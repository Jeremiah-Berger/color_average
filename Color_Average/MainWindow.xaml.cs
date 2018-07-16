using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Drawing;

namespace Color_Average
{    /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
    public partial class MainWindow : Window
    {
        
       
        public MainWindow()
        {
            InitializeComponent();
            
        }
        


        private void ImportButton_Click(object sender, RoutedEventArgs e)
        {

            int TotalRed = 0;
            int TotalGreen = 0;
            int TotalBlue = 0;
            int pixelcount = 0;
           

            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png;*.gif|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                string path = new Uri(op.FileName).LocalPath.ToString();
                Bitmap UserImage = new Bitmap(path);
                BitmapImage ImgSrc = new BitmapImage(new Uri(op.FileName));
                Image.Source = ImgSrc;
                int TotalPixels = (UserImage.Height) * (UserImage.Width);
                int RectangleWidth = ((400 * ((UserImage.Width) / (UserImage.Height)) * (UserImage.Width)) / UserImage.Height);

               

                for (int i = 0; i < UserImage.Width; i++)
                {
                    for (int j = 0; j < UserImage.Height; j++)
                    {
                        System.Drawing.Color pixel = UserImage.GetPixel(i, j);
                        byte red = pixel.R;
                        byte green = pixel.G;
                        byte blue = pixel.B;

                        TotalRed = TotalRed + red;
                        TotalGreen = TotalGreen + green;
                        TotalBlue = TotalBlue + blue;
                        pixelcount++;
                       
                    }
                }

                double RAvg = TotalRed / pixelcount;
                double GAvg = TotalGreen / pixelcount;
                double BAvg = TotalBlue / pixelcount;


                ColorDisplay.Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)RAvg, (byte)GAvg, (byte)BAvg));
                ColorDisplay.Width = RectangleWidth;
                

                RGBText.Text = "rgb(" + (byte)RAvg + ", " + (byte)GAvg + ", " + (byte)BAvg + ")";
                int RInt = Convert.ToInt16(RAvg);
                int GInt = Convert.ToInt16(GAvg);
                int BInt = Convert.ToInt16(BAvg);
               
                string hex = RInt.ToString("X2") + GInt.ToString("X2") + BInt.ToString("X2");
                HexText.Text = "#" + hex;
            }
        }

        public bool AllowCursor;
        public int ImageWidthHalf;
        public int PixelateIntensity;
        public Bitmap UserImage;

        private void PixelatorButton_Click(object sender, RoutedEventArgs e)
        {

            int TotalRed = 0;
            int TotalGreen = 0;
            int TotalBlue = 0;
            int pixelcount = 0;


            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png;*.gif|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                string path = new Uri(op.FileName).LocalPath.ToString();
                UserImage = new Bitmap(path);
                BitmapImage ImgSrc = new BitmapImage(new Uri(op.FileName));
                ToBePixelated.Source = ImgSrc;
                ImageWidthHalf = (((UserImage.Height) / (600)) * (UserImage.Width)) / 2 ;

                AllowCursor = true;





            }
        }

               
            
        

        private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
          if (AllowCursor == true)
         {
                PixelateIntensity = 20;


               var pos = e.GetPosition(this.ToPixelImage);
              XLabel.Content = pos.X;
               YLabel.Content = pos.Y;

              



                System.Drawing.Color PhotoColor = UserImage.GetPixel(Convert.ToInt16(pos.X), Convert.ToInt16(pos.Y));
                byte red = PhotoColor.R;
                byte green = PhotoColor.G;
                byte blue = PhotoColor.B;


            }

           else;
          {
        }



        }
    }
}