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
    /// Логика взаимодействия для Rol.xaml
    /// </summary>
    public partial class Rol : Page
    {
        public Rol()
        {
            InitializeComponent();
            tableRoll.ItemsSource = App.Context.MenuRoll.ToList();
        }
        private void Zak_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
