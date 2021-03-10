using System;
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

namespace wpfSample
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        childwnd childWindow = null;
        static private readonly string TAG = "Wnd1";
        static private Window1 mInstance;

        public static Window1 Instance
        {
            get
            {
                lock (TAG)
                {
                    if (mInstance == null)
                    {
                        mInstance = new Window1();
                    }
                }
                return mInstance;
            }
        }

        public Window1()
        {
            InitializeComponent();
            this.Deactivated += new EventHandler(Win_Deactivate);

            Left = SystemParameters.WorkArea.Width - Width - 26;
            Top = SystemParameters.WorkArea.Height - Height - 47;
            Topmost = true;
        }

        private void Win_Deactivate(object sender, EventArgs e)
        {
            if (childWindow != null && childWindow.IsVisible)
            {
                return;
            }
            this.Hide();
        }

        private void ShowDialog(Window window)
        {
            window.Owner = this;
            window.Show();
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            childWindow = childwnd.Instance;
            ShowDialog(childWindow);
        }
    }
}
