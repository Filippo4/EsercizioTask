using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace EsercizioTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEsegui_Click(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(txt_Numero.Text);
            Task<int> t1 =Task.Factory.StartNew(() => TrovaMultipli(n));
            lbl_output.Content = t1.Result;
        }

        public int TrovaMultipli(int n)
        {
            int nMultipli = 0;
            for(int i=0;i<200000000;i++)
            {
                if(i%n==0)
                {
                    nMultipli++;
                }
            }

          return nMultipli;
        }

        private void txt_Numero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
