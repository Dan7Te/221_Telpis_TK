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

namespace TK {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow :Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e) {
            gridResult.Visibility = Visibility.Visible;
            Calculate(tbModule1.Text, tbModule2.Text, tbModule3.Text);
        }

        public bool Calculate(string m1, string m2, string m3) {
            int im1;
            int im2;
            int im3;
            if(string.IsNullOrEmpty(m1) || string.IsNullOrEmpty(m2) || string.IsNullOrEmpty(m3)) {
                lblWarning.Content = "Баллы не введены";
                gridResult.Visibility = Visibility.Hidden;
                return false;
            }

            if(!(int.TryParse(m1, out im1) && int.TryParse(m2, out im2) && int.TryParse(m3, out im3))){
                lblWarning.Content = "Баллы введены неверно";
                gridResult.Visibility = Visibility.Hidden;
                return false;
            }

            if(im1 > 22 || im1 < 0 || im2>38 || im2<0 || im3>20 || im3<0) {
                lblWarning.Content = "Баллы введены неверно";
                gridResult.Visibility = Visibility.Hidden;
                return false;
            }
            else {
                int s = im1 + im2 + im3;
                if(s >= 0 && s <= 15) lblMark.Content = 2;
                else if(s>15 && s<=31) lblMark.Content = 3;
                else if(s > 31 && s <= 55) lblMark.Content = 4;
                else if(s > 55 && s <= 80) lblMark.Content = 5;

                lblScoreSum.Content = $"Сумма баллов: {int.Parse(tbModule1.Text) + int.Parse(tbModule2.Text) + int.Parse(tbModule3.Text)}";
                return true;
            }

        }
    }
}
