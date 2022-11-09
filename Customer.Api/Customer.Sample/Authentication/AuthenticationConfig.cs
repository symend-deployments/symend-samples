namespace Customer.Sample;

public class AuthenticationConfig
{
    /// <summary>
    /// Seconds from Expiry to pre-emptively renew the token
    /// </summary>
    public double TokenExpiryGracePeriodSeconds { get; set; }
    public string Authority { get; set; }
    public string ClientId { get; set; }
    public string RefreshToken { get; set; }
}