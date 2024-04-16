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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/cursos.xaml", UriKind.Relative);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/escolas.xaml", UriKind.Relative);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/turmas.xaml", UriKind.Relative);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/alunos.xaml", UriKind.Relative);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("/relatorios.xaml", UriKind.Relative);
        }
    }
}
