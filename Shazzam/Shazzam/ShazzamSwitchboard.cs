using Shazzam.Views;
using System.Windows;

namespace Shazzam
{
    internal static class ShazzamSwitchboard
    {
        public static Window MainWindow { get; set; }

        public static CodeTabView CodeTabView { get; set; }

        public static FileLoaderPlugin FileLoaderPlugin { get; set; }
    }
}
