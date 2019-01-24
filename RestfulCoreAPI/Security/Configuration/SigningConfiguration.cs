using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography;

namespace RestfulCoreAPI.Security.Configuration
{
    public class SigningConfiguration
    {
        public SecurityKey Key { get; set; }
        public SigningCredentials SigningCredentials { get; }

        public SigningConfiguration()
        {
            using (var provider = new RSACryptoServiceProvider(2048))
            {
                Key = new RsaSecurityKey(provider.ExportParameters(true));
            }

            SigningCredentials = new SigningCredentials(Key, SecurityAlgorithms.RsaSha256Signature);
        }
    }
}
