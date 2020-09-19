using System.Threading.Tasks;
using ProtoBuf.Grpc.Configuration;

namespace Interfaces
{
    [Service]
    public interface IFileSync
    {
        [Operation]
        Task<byte[]> GetFile(string filePath);
    }
}