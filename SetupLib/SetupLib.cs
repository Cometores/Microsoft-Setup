using System.Collections;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace SetupLib
{
    [RunInstaller(true)]
    public partial class SetupLib : System.Configuration.Install.Installer
    {
        public SetupLib()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            string language = GetProvidedParameter("Language");
            if (language != null)
            {
                SetCulture(language);
            }
                
            MessageBox.Show(Properties.Resources.MessageBox_Message);

            base.Install(stateSaver);
        }

        private string GetProvidedParameter(string parameterName)
        {
            try
            {
                return this.Context.Parameters[parameterName] as string;
            }
            catch
            {
                return null;
            }
        }

        private void SetCulture(string language)
        {
            Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.GetCultureInfo(language);
            Thread.CurrentThread.CurrentUICulture =
                System.Globalization.CultureInfo.GetCultureInfo(language);
        }
    }
}