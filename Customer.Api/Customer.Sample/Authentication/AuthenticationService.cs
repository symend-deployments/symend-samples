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
        return "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6IjJlcjg0bVNOWkR0ZGNvVXdIM3R2bCJ9.eyJodHRwOi8vc2NoZW1hcy5zeW1lbmQuY29tL3JvbGUiOlsiZGVhZGJlZWYtZGVhZC1iZWVmLWRlYWQtYmVlZmRlYWRiZWUxOlNFR01FTlQtUFVCTElTSEVSIiwiZGVhZGJlZWYtZGVhZC1iZWVmLWRlYWQtYmVlZmRlYWRiZWUxOkRBVEEtREVTSUdORVIiLCJkZWFkYmVlZi1kZWFkLWJlZWYtZGVhZC1iZWVmZGVhZGJlZTE6U0VHTUVOVC1WSUVXRVIiLCJkZWFkYmVlZi1kZWFkLWJlZWYtZGVhZC1iZWVmZGVhZGJlZTE6U0VHTUVOVC1ERVNJR05FUiJdLCJodHRwOi8vc2NoZW1hcy5zeW1lbmQuY29tL3N1YiI6IjY5NjA2N2FiLWNmNjYtNDZmOC04Y2ZlLTlkNWFhNDc4MTdjYyIsImlzcyI6Imh0dHBzOi8vYXV0aC1kZXYuc3ltZW5kLmlvLyIsInN1YiI6ImF1dGgwfDYxZjFlOGU2NDk1MmY3MDA2OGRkYjUzNCIsImF1ZCI6WyJodHRwczovLyoubG9jYWwuc3ltZW5kaW5jLmNvbTo0NDMiLCJodHRwczovL3N5bWVuZC1kZXYtdXMudXMuYXV0aDAuY29tL3VzZXJpbmZvIl0sImlhdCI6MTY4MDI4NjcyMywiZXhwIjoxNjgwMjg3NjIzLCJhenAiOiIzbHh3Ujk1eHVJVERKS0RCMWtzU2txMkU5a3l3dTJOUCIsInNjb3BlIjoib3BlbmlkIHByb2ZpbGUgZW1haWwgb2ZmbGluZV9hY2Nlc3MifQ.k0QyAbgQmCrPhdKSmEtpezT-tPrRMMpvkFv-0LG7cJp9lLHCspeH9qx_JxuYOzTod17nlwwMPT3LDOpo3xpR5tyYJqDhs_6Tv8l4KpsQkwfeXUYVlID2jSMqjJUQdtlFz7623Mi8hRd-B9vBkaZKv1UOTM5JUyef-e4jCEiaCkZsTH4ANVNNN2DLM2JnToJzGXyd7inm4WIW2QINxw1tW5BKj_jZ2aaUwZOUzTCZ3QGsowkc_0iZJ6vAGJdNZQO1_YZuc82kDbZ4omuznEXHGYHYQBEZ96sb8v26E7VcweZd1xl8l340aFxiDf1Xx8auiEbVKsJhQQrZ_h3HyHn6KQ";
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