using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace Crystal
{
    public partial class Executor : Window
    {
        public Executor()
        {
            InitializeComponent();
            InitializeEditor();
        }

        #region Ect
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Mini_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        #endregion

        private async void InitializeEditor()
        {
            await Editor.EnsureCoreWebView2Async(null);
            Editor.Source = new Uri(System.IO.Path.GetFullPath(@".\Editor\index.html"), UriKind.Absolute);
        }

        #region Menus
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow win1 = new MainWindow();
            win1.Left = this.Left;
            win1.Top = this.Top;
            win1.Show();
            this.Close();
            this.Close();
        }

        private void Executor_Click(object sender, RoutedEventArgs e)
        {
            //Nothing
        }

        private void ScriptHub_Click(object sender, RoutedEventArgs e)
        {
            ScriptHub scriptHub = new ScriptHub();
            scriptHub.Left = this.Left;
            scriptHub.Top = this.Top;
            scriptHub.Show();
            this.Close();
            this.Close();
        }
        #endregion

        #region Execute, Clear, Attach
        private async void Execute_Click(object sender, RoutedEventArgs e)
        {
            //Not Helping With This
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Editor.ExecuteScriptAsync("editor.setValue('')");
        }

        private void Attach_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //What Ever You Using For Attaching
                MessageBox.Show("Attached");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        #endregion

        bool topmost = false;
        private void TopMost_Click(object sender, RoutedEventArgs e)
        {
            if (topmost == false)
            {
                topmost = true;
                this.Topmost = true;
            }
            else
            {
                topmost = false;
                this.Topmost = false;
            }
        }

        private void Kill_Roblox_Click(object sender, RoutedEventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("RobloxPlayerBeta");
            foreach (Process process in processes)
            {
                process.Kill();
                MessageBox.Show("Successfuly killed RobloxPlayerBeta");
            }
        }
    }
}
