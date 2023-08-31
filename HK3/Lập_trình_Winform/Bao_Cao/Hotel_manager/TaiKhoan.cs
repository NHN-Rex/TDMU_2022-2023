using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_manager
{
    public class TaiKhoan
    {
        public string user;
        public string password;
        public string TenTaiKhoan
        {
            get => user;
            set => user = value;
        }

        public string MatKhau
        {
            get => password;
            set => password = value;
        }
        private string loaitaikhoan;
        public string Loaitaikhoan { get => loaitaikhoan; set => loaitaikhoan = value; }

        

        public void PQTaiKhoan(string user, string password, string Loaitaikhoan)
        {
            this.user = user;
            this.password = password;
            this.loaitaikhoan= Loaitaikhoan;
        }
    }
}
