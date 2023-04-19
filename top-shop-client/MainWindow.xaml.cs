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
using top_shop_client.UserControls;
using top_shop_dbconnector;

namespace top_shop_client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TopShopContext db = new();
        public MainWindow()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            ItemList.Children.Clear();
            foreach (var itemCard in from item in  db.Items.ToArray() select new ItemCard() { Item = item})
            {
                itemCard.AddClick += ItemCard_AddClick;
                itemCard.BuyClick += ItemCard_BuyClick;
                ItemList.Children.Add(itemCard);
            }
        }

        private void ItemCard_BuyClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void ItemCard_AddClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
