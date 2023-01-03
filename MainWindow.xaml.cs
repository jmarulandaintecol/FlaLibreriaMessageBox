using CIiente.IVIS360.View;
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

namespace MessageBoxPersonal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageAlert a = new MessageAlert("cdñ","sdfsd",true,true, "infoDialog.png");
            a.ShowDialog();
            MessageAlert b = new MessageAlert("cañ", "sdfhsd", true, false, "CloseDialog.png");
            b.ShowDialog();
            MessageAlert c = new MessageAlert("cñ", "sdfd", false, false, "notDiagnostico.png");
            c.ShowDialog();
            MessageAlert d = new MessageAlert("ck", "sdsdnfd", false, true, "okdiag.png");
            MessageAlert ee = new MessageAlert("ckñ", "sdsfd", true, false, "questionDialog.png");
            MessageAlert f = new MessageAlert("Esta es la decicsión mas dificil del mundo, pero para mi es demasiado sencillo de contis", "rffrdrfsefsefse", true, false, "warningDialog.png");
            d.ShowDialog();
            ee.ShowDialog();
            f.ShowDialog();
        }
    }
}
