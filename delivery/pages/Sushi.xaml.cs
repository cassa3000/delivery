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

namespace delivery.pages
{
    /// <summary>
    /// Логика взаимодействия для Sushi.xaml
    /// </summary>
    public partial class Sushi : Page
    {
        public Sushi()
        {
            InitializeComponent();
            tableSushi.ItemsSource = App.Context.MenuSushi.ToList();
        }
        private void Zak_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
