// See https://aka.ms/new-console-template for more information

using Grpc.Net.Client;
using GrpcConsoleClient;

var channel = GrpcChannel.ForAddress("http://localhost:5000");
var client = new Greeter.GreeterClient(channel);

var response = await client.SayHelloAsync(
     new HelloRequest { Name = "World" });

Console.WriteLine(response.Message);