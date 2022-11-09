using System.Net;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;

namespace Customer.Sample;

public interface IAuthenticationService
{
    string GetToken();
}

public class AuthenticationService : IAuthenticationService
{
    private readonly IOptions<AuthenticationConfig> _config;
    private TokenResponse? _tokenResponse = null;
    
    public AuthenticationService(IOptions<AuthenticationConfig> config)
    {
        _config = config;
    }
    
    public string GetToken()
    {
        if (_tokenResponse == null || 
            (_tokenResponse.ExpiryUtc - DateTime.UtcNow).TotalSeconds < _config.Value.TokenExpiryGracePeriodSeconds)
        {
            var client = new RestClient(_config.Value.Authority);
            var request = new RestRequest("",Method.Post);
            
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "refresh_token");
            request.AddParameter("client_id", _config.Value.ClientId);
            request.AddParameter("refresh_token", _config.Value.RefreshToken);
            
            RestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK && response.Content != null)
            {
                _tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(response.Content);
                _tokenResponse.ExpiryUtc = DateTime.UtcNow.AddSeconds(_tokenResponse.expires_in);
            }
        }
        
        return _tokenResponse.access_token;
    }
}