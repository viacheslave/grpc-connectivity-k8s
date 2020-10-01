using System;
using System.Threading;
using Grpc.Net.Client;
using GrpcConsumer;

namespace GrpcClient
{
	class Program
	{
		static void Main(string[] args)
		{
			AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

			Console.WriteLine("Greeting test");
			Console.WriteLine($"Will be calling {args[0]}");

			using var channel = GrpcChannel.ForAddress(args[0]);

			var client  = new Greeter.GreeterClient(channel);

			for (int i = 0; i < 5; i++)
			{
				var response = client.SayHello(
					new HelloRequest { Name = Guid.NewGuid().ToString() });

				Console.WriteLine("Greeting: " + response.Message);

				Thread.Sleep(1000);
			}
		}
	}
}
