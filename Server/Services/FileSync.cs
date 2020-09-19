using System.IO;
using System.Threading.Tasks;
using Interfaces;

namespace Server.Services
{
    public class FileSync : IFileSync
    {
        public Task<byte[]> GetFile(string filePath)
        {
            return File.ReadAllBytesAsync(filePath);
        }
    }
}
