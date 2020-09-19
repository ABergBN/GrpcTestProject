using System;
using System.IO;
using System.Threading.Tasks;
using Grpc.Net.Client;
using Interfaces;
using ProtoBuf.Grpc.Client;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            GrpcClientFactory.AllowUnencryptedHttp2 = true;
            using var http = GrpcChannel.ForAddress("http://localhost:10042", new GrpcChannelOptions
            {
                MaxReceiveMessageSize = 100 * 1024 * 1024,
                MaxSendMessageSize = 100 * 1024 * 1024
            });

            var fileSync = http.CreateGrpcService<IFileSync>();
            var files = Directory.GetFiles(@"C:\Users\Alex\Desktop\LivingColours", "*.*", SearchOption.AllDirectories);

            for (var index = 0; index < files.Length; index++)
            {
                var file = files[index];
                Console.WriteLine(index);
                var result = await fileSync.GetFile(file);
            }
        }
    }
}
