using MasterControlEnterprise.Model;
using MasterControlEnterprise.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MasterControlEnterprise.View_Model
{
    public class Session
    {
        public static DataContext DB = new DataContext();
        public DateTime TimeSesion { get;private set; }
        public User user { get; private set; }
        private static Session? _instance;

        private Session (User us)
        {
            _instance = this;
            _instance.TimeSesion = DateTime.UtcNow;
            _instance.user = us;
        }

        public static Session InitSesion(string UserName, string Password)
        {
            if (_instance == null)
            {
                User? us = DB.Users.Where(u => u.UserName == UserName.ToLower() && u.Password == Password).FirstOrDefault();
                
                if (us != null)
                {
                    return new Session(us);
                }  
            }
            return null;

        }
        public void closeSesion()
        {
            _instance = null;
        }
    }
}
