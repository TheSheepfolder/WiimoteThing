using Microsoft.Shell;
using System;
using System.Collections.Generic;
using System.Windows;

namespace WiimoteThing
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, ISingleInstanceApp
    {
        internal const string PROFILE_FILTER = "WiimoteThing Profile|*.wsp";

        public bool SignalExternalCommandLineArgs(IList<string> args)
        {
            // show the original instance
            if (this.MainWindow.WindowState == WindowState.Minimized)
            {
                ((MainWindow)this.MainWindow).ShowWindow();
            }

            this.MainWindow.Activate();

            MessageBox.Show("WiimoteThing was already Running so the previous instance was brought into focus.",
                "WiimoteThing Already Running", MessageBoxButton.OK, MessageBoxImage.Information);

            return true;
        }
    }
}
