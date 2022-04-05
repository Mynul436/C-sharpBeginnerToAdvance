using Grpc.Core;

namespace GrpcServer.Services
{
    public class CustomerService :Customer.CustomerBase
    {
        private readonly ILogger<CustomerService> _logger;
        public  CustomerService(ILogger<CustomerService> logger)
        {
            _logger= logger;
        }
        public override Task<CustomerModel> GetCustomerInfo(CustomerLookUpModel request, ServerCallContext context)
        {
            CustomerModel output = new CustomerModel();
            if (request.UserId == 1)
            {
                output.FirstName = "Mynul";
                output.LastName = "Islam";
            }
            else if(request.UserId == 2)
            {
                output.FirstName = "Sephaire";
                output.LastName = "Rahman";
            }
            else
            {
                output.FirstName = "Sadnan";
                output.LastName = "Tahmid";
            }
            return Task.FromResult(output);
        }
    }
}
