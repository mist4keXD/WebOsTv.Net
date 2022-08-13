using System.Diagnostics;
using System.IO;

namespace WebOsTv.Net.FileSystem
{
    internal class FileService : IFileService
    {
        private string _rootPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        public bool Exists(string path)
        {
            return File.Exists(Path.Combine(_rootPath, path));
        }

        public string ReadAllText(string path)
        {
            return File.ReadAllText(Path.Combine(_rootPath, path));
        }

        public void WriteAllText(string path, string content)
        {
            File.WriteAllText(Path.Combine(_rootPath, path), content);
        }
    }
}
