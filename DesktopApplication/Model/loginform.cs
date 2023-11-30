using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopApplication.Model;
using DevExpress.Data.Browsing;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.Graph.SecurityNamespace;

namespace DesktopApplication.Model
{
    public class loginform /*: ILogin*/
    {
        private DataContext _context;
        public loginform (DataContext Context)
        {
            _context = Context;
        }
        //public Message Login(LoginModel login)
        //{
        //    using (var conn = new SqlConnection(@"Server=DESKTOP-DMB5OIT;Database=Noble;Trusted_Connection=True;MultipleActiveResultSets=true"))
        //   {
        //        SqlCommand cmd = new SqlCommand("select * from AspNetUsers", conn);
        //        conn.Open();
        //      cmd.ExecuteNonQuery();
        //       // DataSet ds = new DataSet();

        //     conn.Close();
        //    }

        //}
    }
}
