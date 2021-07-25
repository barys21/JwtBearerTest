using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JwtBearerTest
{
    public static class Constants1
    {
        public const string Issuer = "http://localhost:54218";
        public const string Audience = Issuer;
        public const string SecretKey = "this_is_secret_key_for_jwt_token_generation";
    }
}
