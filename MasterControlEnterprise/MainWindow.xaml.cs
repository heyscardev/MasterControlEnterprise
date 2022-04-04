using MasterControlEnterprise.Model;
using MasterControlEnterprise.Model.Data;
using MasterControlEnterprise.Seeders;
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

namespace MasterControlEnterprise
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
        private void clickRefresh(Object o,RoutedEventArgs r)
        {
            UsersList.Items.Clear();
            DataContext DB = new DataContext();
            DB.Users.ToList().ForEach((u) => {
                ListViewItem r = new ListViewItem();
                r.Content = u.FirstName;
                UsersList.Items.Add(r);
            });
            
           
        }
    }
}
