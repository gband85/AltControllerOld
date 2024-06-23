using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AltController.Core;
using System;

namespace AltController
{
    public partial class HelpAboutWindow : Window
    {
        public HelpAboutWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Window loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.VersionText.Text = string.Format("{0} {1}", Properties.Resources.String_Version, Constants.AppVersion);
            this.CopyrightText.Text = string.Format("{0} 2013-{1} {2}", Properties.Resources.String_Copyright,
                DateTime.Now.Year, Constants.AuthorName);
            this.TranslatorNamesText.Text = Constants.TranslatorNames;
        }

        // /// <summary>
        // /// Can Close command execute
        // /// </summary>
        // /// <param name="sender"></param>
        // /// <param name="e"></param>
        // private void CloseCanExecute(object sender, CanExecuteRoutedEventArgs e)
        // {
        //     e.CanExecute = true;
        //     e.Handled = true;
        // }

        /// <summary>
        /// Close window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
            e.Handled = true;
        }
        //
        // /// <summary>
        // /// Hyperlink clicked
        // /// </summary>
        // /// <param name="sender"></param>
        // /// <param name="e"></param>
        // private void Hyperlink_RequestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        // {
        //     try
        //     {
        //         System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
        //     }
        //     catch (Exception)
        //     {
        //     }
        //
        //     e.Handled = true;
        // }
    }
}