using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Crystal
{
    public partial class MainWindow : Window
    {
        Executor executor = new Executor();
        ScriptHub scriptHub = new ScriptHub();

        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation fadeInAnimation = new DoubleAnimation()
            {
                From = 0,
                To = 1,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                BeginTime = TimeSpan.Zero
            };
        }

        #region Ect
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Mini_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        #endregion

        #region Menus
        private void Executor_Click(object sender, RoutedEventArgs e)
        {
            executor.Left = this.Left;
            executor.Top = this.Top;
            executor.Show();
            this.Close();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void ScriptHub_Click(object sender, RoutedEventArgs e)
        {
            scriptHub.Left = this.Left;
            scriptHub.Top = this.Top;
            scriptHub.Show();
            this.Close();
        }
        #endregion
    }
}
