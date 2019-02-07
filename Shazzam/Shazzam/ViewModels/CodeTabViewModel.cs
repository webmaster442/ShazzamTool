namespace Shazzam.ViewModels
{
    internal class CodeTabViewModel : ViewModelBase
    {

        public bool AreGeneratedCodeTabsEnabled
        {
            get
            {
                return Shazzam.Properties.Settings.Default.AreGeneratedCodeTabsEnabled;
            }
        }

    }
}
