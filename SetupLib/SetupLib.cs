using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
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
            MessageBox.Show("Custom action happens");
            base.Install(stateSaver);
        }
    }
}
