using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace School_Paper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private ContentPresenter GetTask1()
        {
            return task1;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // 获取其他控件的引用并修改其背景颜色
            myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1835"));
            task1.Visibility = Visibility.Visible;


        }

        private void RadioButton_Checked2(object sender, RoutedEventArgs e)
        {
            // 获取其他控件的引用并修改其背景颜色
            myborder2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1835"));
            myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A335E"));
            task1.Visibility = Visibility.Collapsed;
            task2.Visibility = Visibility.Visible;

        }

        private void RadioButton_Checked3(object sender, RoutedEventArgs e)
        {
            // 获取其他控件的引用并修改其背景颜色
            myborder3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1D1835"));
            myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A335E"));
            task1.Visibility = Visibility.Collapsed;

        }
        
        private void RadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            // 获取其他控件的引用并将其背景颜色恢复到原始状态
            myborder.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A335E"));
            task1.Visibility = Visibility.Collapsed;

        }
        private void RadioButton_Unchecked2(object sender, RoutedEventArgs e)
        {
            // 获取其他控件的引用并将其背景颜色恢复到原始状态
            myborder2.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A335E"));
            task2.Visibility = Visibility.Collapsed;

        }
        private void RadioButton_Unchecked3(object sender, RoutedEventArgs e)
        {
            // 获取其他控件的引用并将其背景颜色恢复到原始状态
            myborder3.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3A335E"));
        }






        public MainWindow()
        {
            InitializeComponent();

        }
    }
}