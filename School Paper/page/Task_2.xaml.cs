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

namespace School_Paper.page
{
    /// <summary>
    /// Task_2.xaml 的交互逻辑
    /// </summary>
    public partial class Task_2 : UserControl
    {


        public void clelck_button(object sender, RoutedEventArgs e)
        {
            country_box.Text = string.Empty;
            city_box.Text = string.Empty;
            city2_box.Text = string.Empty;
        }



        public Task_2()
        {
            InitializeComponent();
        }
    }
}
