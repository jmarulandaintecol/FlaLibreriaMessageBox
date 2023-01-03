using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace CIiente.IVIS360.View
{
    /// <summary>
    /// Lógica de interacción para MessageAlert.xaml
    /// </summary>
    public partial class MessageAlert : Window
    {
        private string Message { get; set; }
        private string  IconImage {get; set; }
        private string MessageTitle { get; set; }
        private bool ButtonAceptCancel { get; set; }
        private bool ButtonAcept { get; set; }

        public string[] listImages = { "infoDialog.png", "questionDialog.png","warningDialog.png", "notDiagnostico.png", "closeDialog.png", "okdiag.png" };
        

        public MessageAlert(string message, string messageTitle = "", bool buttonAceptCancel=false, bool buttonAcept = false, string iconImage="" )
        {
            try {
                this.Message = message;
                this.IconImage = iconImage;
                this.ButtonAceptCancel = buttonAceptCancel;
                this.MessageTitle = messageTitle;
                this.ButtonAcept = buttonAcept;


                InitializeComponent();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          




        }
        private void MessageAlert_Loaded(object sender, RoutedEventArgs e)
        {
            messageLabel.Text = this.Message;
            title.Content = MessageTitle;
            Uri resourceUri = new Uri($"/Image/{this.IconImage}", UriKind.Relative);
            imgDynamic.Source = new BitmapImage(resourceUri);
            if (this.ButtonAceptCancel)
            { 
                
                Acept.Visibility = Visibility.Visible;
                Cancel.Visibility = Visibility.Visible;
                this.ButtonAcept = false;
              }
            else
            {
              
                //title.Content = MessageTitle;
            }
            if (ButtonAcept)
            {
                AceptOptionTwo.Visibility = Visibility.Visible;
            }

            if (IconImage == "")
            {
                imgDynamic.Visibility = Visibility.Hidden;
            }
            else
            {
                GetImagenIcon();
                imgDynamic.Visibility = Visibility.Visible;
                
            }
            
            
        }
        private void Acept_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

    

        private void GetImagenIcon()
        {
            int cont = 0;
            for (int i =0;i< listImages.Length;i++)
            {
                if (listImages[i] == this.IconImage)
                {
                    break;
                }
                cont++;
            }
            if (cont == listImages.Length - 1)
            {
                this.IconImage = "infoDialog.png";
            }

            
        }


        private void AceptOptionTwo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }
    }
}
