using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Microsoft.VisualBasic;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace AltController
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var _FileOpen = this.FindControl<MenuItem>("FileOpen");
            _FileOpen.Click += OpenExecuted;
        }
                /// <summary>
        /// File Open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExecuted(object sender,Avalonia.Interactivity.RoutedEventArgs e)
        {
            try
            {
               // ClearMessages();

                // Ask the user whether they wish to save if appropriate
                // MessageBoxResult result = MessageBoxResult.None;
                // if (_profileChanged)
                // {
                 var box =   MessageBoxManager.GetMessageBoxStandard(
                       Properties.Resources.String_Save_profile_description,
                        Properties.Resources.String_Save_profile_title,
                        ButtonEnum.YesNoCancel);
                 box.ShowWindowAsync();
                 //MessageBoxImage.Question);
                 //     if (result == MessageBoxResult.Yes)
                 //     {
                 //         this.SaveExecuted(sender, e);
                 //     }
                 // }

                 // if (result != MessageBoxResult.Cancel)
                 // {
                 //     Avalonia.Controls.Window dialog = new Avalonia.Controls.Window();
                 //     string defaultProfilesFolder = Path.Combine(AppConfig.UserDataDir, Constants.ProfilesFolderName);
                 //     dialog.InitialDirectory = _appConfig.GetStringVal(Constants.ConfigProfilesDir, defaultProfilesFolder);
                 //     dialog.Multiselect = false;
                 //     dialog.Filter = Properties.Resources.String_Profile_files_filter;
                 //     dialog.CheckFileExists = true;
                 //     if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                 //     {
                 //         // Load the selected profile
                 //         LoadProfile(dialog.FileName);
                 //     }
                 // }
            }
            catch (Exception ex)
            {
               // ShowError(Properties.Resources.E_MAIN005, ex);
            }

            //e.Handled = true;
        }
    }
}