using Newtonsoft.Json;
using Serilog;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Customer.Sample;

public interface ISampleClient
{
    public Task Run(Guid organizationId);
}

public class SampleClient : ISampleClient
{
    private readonly IAuthenticationService _authenticationService;

    public SampleClient(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    public async Task Run(Guid organizationId)
    {
        var dataTargetDefinitions = await GetDtds(organizationId);
        
        var newAccountForm = CreateNewAccountForm("Account-Id-Here",organizationId, dataTargetDefinitions);
        
        // Creates a new Account, we expect an SMS message to be delivered for this user
        var createEvent = await CreateUpdateAccount(organizationId, newAccountForm);
        
        //Load the created account
        var newAccount = await GetAccount(organizationId, createEvent.Data.Id);
        
        Log.Logger.Information("Created Account: {0}", newAccount.Data.ToJson());
        
        // Load Customer Trail
        var accounts = await GetAccounts(organizationId);
        foreach (var account in accounts) 
        {
            Log.Logger.Information("Loading Cuss Trail for AccountId: {0}", account.Id);
            var cussTrail = await GetCussTrailByAccountKey(account.AccountKey, organizationId);
            if (cussTrail.Data.Count>0)
            {
                Log.Logger.Information("Found Customer Trail Events for AccountId/AccountKey {0}/{1}\n{2}", 
                    account.Id,
                    account.AccountKey, 
                    cussTrail.ToJson());
            }
        }
        
        // To exit all accounts for the current Client uncomment
        // await ExitAllAccounts(organizationId, dataTargetDefinitions);
    }
    
    private async Task<CustomerTrailEventPagedModel> GetCussTrailByAccountId(Guid accountId, Guid organizationId)
    {
        var customerTrailApi = new CustomerTrailApi()
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };

        
        return await customerTrailApi.GetCustomerTrailEventsForAccountAsync(accountId.ToString(), organizationId);
    }

      private async Task<CustomerTrailEventPagedModel> GetCussTrailByAccountKey(string accountKey, Guid organizationId)
    {
        var customerTrailApi = new CustomerTrailApi()
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        
        return await customerTrailApi.GetCustomerEventsByAccountKeyAsync(organizationId, accountKey);
    }

    private async Task ExitAllAccounts(Guid organizationId, Dictionary<string, DataTargetDefinitionDictionaryModel> dataTargetDefinitions)
    {
        var accounts = await GetAccounts(organizationId);
        foreach (var account in accounts) 
        {
            var exitAccountForm = ExitAccountForm(account.AccountKey,organizationId, dataTargetDefinitions);
            var result = await CreateUpdateAccount(organizationId, exitAccountForm);
            Log.Logger.Information("Exited Account Id: {0}", result.Data.Id);    
        }
    }

    private AccountForm ExitAccountForm(string accountKey, Guid organizationId, Dictionary<string, DataTargetDefinitionDictionaryModel> dataTypeDefinitions)
    {
        var properties = new List<AccountFormAttributesInner>();
        properties.Add(new(AccountFormAssembler.AddProperty("AccountKey", accountKey, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Exit_Reason", "PAID", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("OrganizationIdCheck", organizationId.ToString(), dataTypeDefinitions)));
        return new AccountForm { Attributes = properties }; 
    }

    private AccountForm CreateNewAccountForm(string accountKey,Guid organizationId,Dictionary<string,DataTargetDefinitionDictionaryModel> dataTypeDefinitions)
    {
        var properties = new List<AccountFormAttributesInner>();
        
        properties.Add(new(AccountFormAssembler.AddProperty("AccountKey", accountKey, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Strategy", "Engaged Recovery", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Email", "user@email.com", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Phone", "5555555555", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("CC_Number", "4321", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("First_Name", "John", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Last_Name", "Doe", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Placement_Date", DateTime.Now, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Episode_Date", DateTime.Now, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("OrganizationIdCheck", organizationId.ToString(), dataTypeDefinitions)));
        return new AccountForm { Attributes = properties }; 
    }
    private async Task<AccountExtendedModelResultModel> GetAccount(Guid organizationId, Guid id)
    {
        var accountsApi = new AccountsApi
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        return await accountsApi.GetAccountAsync(id, organizationId);
    }
    private async Task<AccountResponseResultModel> CreateUpdateAccount(Guid organizationId, AccountForm accountForm)
    {
        var accountsApi = new AccountsApi
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        return await accountsApi.CreateUpdateAccountAsync(organizationId, accountForm);
    }
    private async Task<List<AccountSearchResult>> GetAccounts(Guid organizationId)
    {
        var accountsApi = new AccountsApi
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        
        return (await accountsApi.ListAccountsAsync(organizationId)).Data;
    }
    private async Task<Dictionary<string, DataTargetDefinitionDictionaryModel>> GetDtds(Guid organizationId)
    {
        var dtdApi = new DataTargetDefinitionsApi()
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance,
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };

        var pagedDtds = await dtdApi.GetDataTargetDefinitionsDictionaryAsync(organizationId);

        return pagedDtds.Data;
    }
}