using System.Diagnostics;

namespace WCF_OpenFolder
{
    public class Service : IService
    {
        public string OpenFolder(string path)
        {
            Process.Start("explorer.exe", path);
            return string.Format("You entered: {0}", path);
        }
    }
}
