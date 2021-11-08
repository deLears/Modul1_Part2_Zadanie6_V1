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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }

    public class WeatherControl : DependencyObject
    {
        public static readonly DependencyProperty TemperatureProperty;
        
  

        static WeatherControl()
        {
            TemperatureProperty = DependencyProperty.Register("Temperature", typeof(int), typeof(WeatherControl));   //моделирующий погодную сводку – температуру (целое число в диапазоне от -50 до +50)
            
        }

       
        public int Temperature
        {
            get { return (int)GetValue(TemperatureProperty); }
            set
                {
                if (value > -50 && value < 50)
                {
                    Temperature = value;
                }
                else { Temperature = 0; }
                }
        }
        public string WindDirection                                            //направление ветра (строка)
        { get; set; }

        public int WindSpeed                                                   //скорость ветра (целое число)
        { get; set; }

        public enum RainFalls                                                  // наличие осадков (возможные значения: 0 – солнечно, 1 – облачно, 2 – дождь, 3 – снег. Можно использовать целочисленное значение, либо создать перечисление enum)
        {
            Sunny = 0,
            Cloudy = 1,
            Raining = 2,
            Snowing = 3
        }


    }
}
}
