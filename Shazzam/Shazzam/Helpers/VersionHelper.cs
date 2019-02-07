using System;
using System.Deployment.Application;

namespace Shazzam.Helpers
{
    internal static class VersionHelper
    {

        internal static string GetVersionNumber()
        {
            System.Reflection.Assembly _assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();

            string ourVersion = string.Empty;

            if (_assemblyInfo != null)
            {
                ourVersion = _assemblyInfo.GetName().Version.ToString();
            }
            return ourVersion;

        }
        internal static string GetShortVersionNumber()
        {
            System.Reflection.Assembly _assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();

            string ourVersion = string.Empty;

            if (_assemblyInfo != null)
            {
                ourVersion = String.Format("{0}.{1}",
                                            _assemblyInfo.GetName().Version.Major.ToString(),
                                            _assemblyInfo.GetName().Version.Minor.ToString());
            }
            return ourVersion;

        }
    }
}
