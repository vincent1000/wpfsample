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
    /// childwnd.xaml 的交互逻辑
    /// </summary>
    public partial class childwnd : Window
    {
        static private readonly string TAG = "childwnd";
        static private childwnd mInstance;
        private static int cnt = 0;

        public static childwnd Instance
        {
            get
            {
                lock (TAG)
                {
                    if (mInstance == null)
                    {
                        mInstance = new childwnd();
                    }
                }
                return mInstance;
            }
        }

        public childwnd()
        {
            InitializeComponent();
            this.Deactivated += new EventHandler(Win_Deactivate);
            Left = SystemParameters.WorkArea.Width - Width - 26 - 500;
            Top = SystemParameters.WorkArea.Height - Height - 47 - 100;
            Topmost = true;
        }

        private void Win_Deactivate(object sender, EventArgs e)
        {
            if (!this.Owner.IsMouseOver)
            {
                this.Owner.Hide();
            }
            else
            {
                this.Owner.Activate();
            }
            this.Hide();
        }

        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            cnt++;
            if(cnt%2 == 0)
            {
                btn.Background = Brushes.Red;
            }
            else
            {
                btn.Background = Brushes.Yellow;
            }
        }
    }
}
