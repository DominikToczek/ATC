using System.IO;

namespace ATC
{
    public static class ConstantPaths
    {
        public static readonly string rootDirPath = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()));
        public static readonly string configsPath = Path.Combine(rootDirPath, "Configs");
        public static readonly string test = "asdasd";
    }
}