using System.Text;

namespace GrpcServer
{
    public static class JwtAuthenticationManager
    {
        public const string JWT_TOKEN_KEY = "CodingDrop@2022";
        public const int JWT_TOKEN_VALIDITY = 30;
        public static AuthenticationReply Authenticate(AuthenticationRequest authenticationRequest)
        {
            //database connectivity here
            if(authenticationRequest.UserName != "Mynul"||authenticationRequest.Password!="12345")
                return null;
            //-------------------
            var jwtSecurityHandler = new JwtSecurityHandler();
            var tokenKey = Encoding.ASCII.GetBytes(JWT_TOKEN_KEY);
            var tokenExpiraryDateTime=DateTime.Now.AddMinutes(JWT_TOKEN_VALIDITY);
        }
    }
}

