using MasterControlEnterprise.Model;
using MasterControlEnterprise.Model.Data;
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
            var db = new DataContext();
            var u = new User()
            {
                FirstName = "loco",
                LastName = "pepe",
                IdentificationType = IdentificationType.V,
                IdentityDocument = "28493312",
                Email = "papo@gmail.com",
                Password = "28493312h",
                UserType = UserType.ADMIN,
                UserName = "pepito123",
                DeleteState = false,
                
            };
            db.Users.Add(u);
            db.SaveChanges();
        }
    }
}
