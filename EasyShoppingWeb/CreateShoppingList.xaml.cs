using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace EasyShoppingWeb
{
    /// <summary>
    /// Interaction logic for CreateShoppingList.xaml
    /// </summary>
    public partial class CreateShoppingList : Window
    {
        public CreateShoppingList()
        {
            InitializeComponent();
        }

        private void SaveList_Click(object sender, RoutedEventArgs e)
        {
            SavedList sL = new SavedList();
            sL.Show();
            this.Close();
        }

        private void AddToList_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }
    }
}
