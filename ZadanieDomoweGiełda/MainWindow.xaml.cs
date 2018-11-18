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
using System.Windows.Threading;

namespace ZadanieDomoweGiełda
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  MainWindow()
        {
            InitializeComponent();
            Thread thread = new Thread(new ThreadStart(Klik));
            thread.Start();
       
        }

        private void Klik()
        {
            var ColorRed = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 232, 38, 19));
            var ColorGreen = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 92, 236, 11));
            System.Random x = new Random();
            int xx = 10;
            Style styleRed = this.FindResource("BackForeColorStyle2") as Style;
            Style styleGreen = this.FindResource("BackForeColorStyle1") as Style;
            Style borderRed = this.FindResource("Border1") as Style;
            Style borderGreen = this.FindResource("Border2") as Style;
            double x1, x2, x3, x4;
            string Text1 = "KGHM";
            string Text2 = "PKO BP";
            string Text3 = "LOTOS";
            string Text4 = "ORLEN";
            double war1 = 100;
            double war2 = 100;
            double war3 = 100;
            double war4 = 100;

                while(true)
                {
                    x1 = x.Next(1, 200);
                    x1 = (x1 - 100d) / 100d;
                    x2 = x.Next(1, 200);
                x2 = (x2 - 100d) / 100d;
                x3 = x.Next(1, 200);
                x3 = (x3 - 100d) / 100d;
                x4 = x.Next(1, 200);
                x4 = (x4 - 100d) / 100d;

                if (x1 <= 0)
                    {
                        this.Dispatcher.Invoke(() =>
                        {
                            Label1.Style = styleRed;
                            war1 += x1;
                            Label1.Content = Text1 + "\n" + war1 + " PLN\n" + x1 + " PLN";
                            Border1.Style = borderRed;
                         });

                    }
                    else
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label1.Style = styleGreen;
                        war1 += x1;
                        Label1.Content = Text1 + "\n" + war1 + " PLN\n" + x1 + " PLN";
                        Border1.Style = borderGreen;

                    });
                    }


                    if (x2 <= 0)
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label2.Style = styleRed;
                        war2 += x2;
                        Label2.Content = Text2 + "\n" + war2 + " PLN\n" + x2 + " PLN";
                        Border2.Style = borderRed;
                    });
                    }
                    else
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label2.Style = styleGreen;
                        war2 += x2;
                        Label2.Content = Text2 + "\n" + war2 + " PLN\n" + x2 + " PLN";
                        Border2.Style = borderGreen;
                    });
                    }

                    if (x3 <= 0)
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label3.Style = styleRed;
                        war3 += x3;
                        Label3.Content = Text3 + "\n" + war3 + " PLN\n" + x3 + " PLN";
                        Border3.Style = borderRed;
                    });
                    }
                    else
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label3.Style = styleGreen;
                        war3 += x3;
                        Label3.Content = Text3 + "\n" + war3 + " PLN\n" + x3 + " PLN";
                        Border3.Style = borderGreen;
                    });
                    }

                    if (x4 <= 0)
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label4.Style = styleRed;
                        war4 += x4;
                        Label4.Content = Text4 + "\n" + war4 + " PLN\n" + x4 + " PLN";
                        Border4.Style = borderRed;
                    });
                    }
                    else
                    {
                    this.Dispatcher.Invoke(() =>
                    {
                        Label4.Style = styleGreen;
                        war4 += x4;
                        Label4.Content = Text4 + "\n" + war4 + " PLN\n" + x4 + " PLN";
                        Border4.Style = borderGreen;
                    });
                    }

                    Thread.Sleep(3000);
                }
            
         }
       
        

    }


}
