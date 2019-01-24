namespace RestfulCoreAPI.Security.Configuration
{
    public class TokenConfiguration
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }

        // Tempo de duração do token
        public int Seconds { get; set; }
    }
}
