using MasterControlEnterprise.Model;
using MasterControlEnterprise.Model.Data;
using MasterControlEnterprise.Seeders;
using MasterControlEnterprise.View_Model;
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
            btn_iniciar_sesion.Click += new RoutedEventHandler(event_init_sesion);
        }
        private void event_init_sesion(Object sender, RoutedEventArgs e) 
        {
            Session ss = Session.InitSesion(tb_user_name.Text, tb_password.Password);
            if(ss == null)
            {
                MessageBox.Show("usuario o contraseña invalida");
            }
            else
            {
                MessageBox.Show("usuario: " + ss.user.FirstName + "tipo: " + ss.user.UserType);
               
            }
        }
    }
}
