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
    /// Логика взаимодействия для Ris.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();

            table.ItemsSource = App.Context.MenuRis.ToList();
        }

        private void Zak_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
