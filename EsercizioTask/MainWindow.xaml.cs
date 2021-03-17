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
            Task<int> t1 = Task.Factory.StartNew(() => TrovaMultipli(n),
                CancellationToken.None,
                TaskCreationOptions.LongRunning,
                TaskScheduler.Default
                );
            lbl_output.Content = $"{t1.Result}";

        }

        public static int TrovaMultipli(int n)
        {
            int multipli = 0;
            for (int i = 0; i < 200000000; i++)
            {
                if ((i / n) % 2 == 0)
                {
                    multipli++;
                }
            }
            return multipli;
        }
    }
}
