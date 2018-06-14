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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2f
{
    /// <summary>
    /// qq.xaml 的互動邏輯
    /// </summary>
    public partial class qq : UserControl
    {
        public string name
        {
            get
            {
                return a.Text;
            }
            set
            {
                a.Text = value;
            }
        }
        public int money
        {
            get
            {
                
                try
                {
                    return int.Parse(b.Text);
                }

                catch
                {
                    MessageBox.Show("輸入數字");
                    return 0;
                }
            }
            set
            {
                b.Text = value.ToString();
            }

        }
        public qq()
        {
            InitializeComponent();
        }
    }
}
