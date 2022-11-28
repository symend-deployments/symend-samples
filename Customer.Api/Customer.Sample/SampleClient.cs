using Newtonsoft.Json;
using Serilog;
using Symend.Client.Customer.Api;
using Symend.Client.Customer.Client;
using Symend.Client.Customer.Model;

namespace Customer.Sample;

public interface ISampleClient
{
    public Task Run(string organizationId);
}

public class SampleClient : ISampleClient
{
    private readonly IAuthenticationService _authenticationService;

    public SampleClient(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }
    
    public async Task Run(string organizationId)
    {
        var dataTargetDefinitions = await GetDtds(organizationId);
        
        var newAccountForm = CreateNewAccountForm("AccountIdTestOrgDtd",organizationId, dataTargetDefinitions);
        
        // Creates a new Account, we expect an SMS message to be delivered for this user
        var createEvent = await CreateUpdateAccount(organizationId, newAccountForm);

        //Load the created account
        var newAccount = await GetAccount(organizationId, createEvent.Data.Id);
        
        Log.Logger.Information("Created Account: {0}", newAccount.Data.ToJson());
        
        //// To exit all accounts for the current Client uncomment
        //await ExitAllAccounts(organizationId, dataTargetDefinitions);
    }

    private async Task ExitAllAccounts(string organizationId, Dictionary<string, DataTargetDefinitionDictionaryModel> dataTargetDefinitions)
    {
        var accounts = await GetAccounts(organizationId);
        foreach (var account in accounts) 
        {
            var exitAccountForm = ExitAccountForm(account.AccountKey,organizationId, dataTargetDefinitions);
            var result = await CreateUpdateAccount(organizationId, exitAccountForm);
            Log.Logger.Information("Exited Account Id: {0}", result.Data.Id);    
        }
    }

    private AccountForm ExitAccountForm(string accountKey, string organizationId, Dictionary<string, DataTargetDefinitionDictionaryModel> dataTypeDefinitions)
    {
        var properties = new List<AccountFormAttributesInner>();
        properties.Add(new(AccountFormAssembler.AddProperty("AccountKey", accountKey, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Exit_Reason", "PAID", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("OrganizationIdCheck", organizationId, dataTypeDefinitions)));
        return new AccountForm { Attributes = properties }; 
    }

    private AccountForm CreateNewAccountForm(string accountKey,string organizationId,Dictionary<string,DataTargetDefinitionDictionaryModel> dataTypeDefinitions)
    {
        var properties = new List<AccountFormAttributesInner>();
        
        properties.Add(new(AccountFormAssembler.AddProperty("AccountKey", accountKey, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Strategy", "Engaged Recovery", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Email", "rmacdonald@2106design.com", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Phone", "4039730455", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("CC_Number", "4321", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("First_Name", "Ryan", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Last_Name", "MacDonald", dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Placement_Date", DateTime.Now, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("Episode_Date", DateTime.Now, dataTypeDefinitions)));
        properties.Add(new(AccountFormAssembler.AddProperty("OrganizationIdCheck", organizationId, dataTypeDefinitions)));
        return new AccountForm { Attributes = properties }; 
    }
    private async Task<AccountExtendedModelResultModel> GetAccount(string organizationId, Guid id)
    {
        var accountsApi = new AccountsApi
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        return await accountsApi.GetAccountAsync(id, organizationId);
    }
    private async Task<AccountResponseResultModel> CreateUpdateAccount(string organizationId, AccountForm accountForm)
    {
        var accountsApi = new AccountsApi
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        return await accountsApi.CreateUpdateAccountAsync(organizationId, accountForm);
    }
    private async Task<List<AccountSearchResult>> GetAccounts(string organizationId)
    {
        var accountsApi = new AccountsApi
        {
            Configuration = Configuration.MergeConfigurations(GlobalConfiguration.Instance, 
                new Configuration { AccessToken = _authenticationService.GetToken() }
            )
        };
        
        return (await accountsApi.ListAccountsAsync(organizationId)).Data;
    }
    private async Task<Dictionary<string, DataTargetDefinitionDictionaryModel>> GetDtds(string organizationId)
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