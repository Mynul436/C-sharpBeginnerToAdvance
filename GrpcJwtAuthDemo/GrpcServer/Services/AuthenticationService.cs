using Grpc.Core;

namespace GrpcServer.Services
{
    public class AuthenticationService:Authentication.AuthenticationBase
    {
        public override Task<AuthenticationReply> Authenticate(AuthenticationRequest request, ServerCallContext context)
        {
            
        }
    }
}
