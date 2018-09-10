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

namespace CartSystem
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string name = addText.Text;
            listList.Items.Add(name);
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (listList.SelectedIndex != -1)
            {
                listList.Items.RemoveAt(listList.SelectedIndex);
            }
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            string name = addText.Text;
            if (listList.SelectedIndex != -1 && addText.Text != "")
            {
                listList.Items[listList.SelectedIndex] = name;
            }
        }
    }
}
