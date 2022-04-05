using Grpc.Net.Client;
using GrpcService;

namespace Grpc_Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var channel=GrpcChannel.ForAddress("http://localhost:5251");
            var client=new Sample.SampleClient(channel);
            var reponse = await client.GetFullNameAsync(new SampleRequest { FirstName = "Mynul", LastName = "Islam" });
            Console.WriteLine(reponse.FullName);
            Console.ReadKey();
        }
    }
}
