using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Crystal
{
    /// <summary>
    /// Interaction logic for ScriptHub.xaml
    /// </summary>
    public partial class ScriptHub : Window
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        #region Ect
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

        #region Menus
        private void Home_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Left = this.Left;
            mainWindow.Top = this.Top;
            mainWindow.Show();
            this.Close();
            this.Close();
        }

        private void Executor_Click(object sender, RoutedEventArgs e)
        {
            Executor executor = new Executor();
            executor.Left = this.Left;
            executor.Top = this.Top;
            executor.Show();
            this.Close();
            this.Close();
        }

        private void ScriptHub_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion
    }
}
