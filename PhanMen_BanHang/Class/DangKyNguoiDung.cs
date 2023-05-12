using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMen_BanHang.Class
{
    internal class DangKyNguoiDung
    {
        private string hoten, email, phone, taikhoan, matkhau;

        public DangKyNguoiDung()
        {
            hoten = email = phone = taikhoan = matkhau = "";
        }
        
        public DangKyNguoiDung(string ten, string em, string ph, string tk, string mk)
        {
            hoten = ten;
            email = em; 
            phone = ph; 
            taikhoan = tk;
            matkhau = mk;
        }
        // true => hợp lệ               false => không hợp lệ
        public bool KiemTraDinhDangHopLe()
        {
            if(matkhau.Length <7)
            {
                return false;  
            }    
            //Kiểm tra số và chữ
            bool KiemTraChu = false;        //Coi như chưa có chữ
            bool KiemTraSo  = false;        //Coi như chưa có số

            for (int i = 0; i < matkhau.Length; i++)
            {
                if (KiemTraChu == true && KiemTraSo == true)
                {
                    break; // Dừng vòng lặp
                }
                //A -> Z bắt đầu 65
                //a -> z bắt đầu 97
                if ((matkhau[i] >= 'A' && matkhau[i] <= 'Z') || (matkhau[i] >= 'a' && matkhau[i] <= 'z'))
                {
                    KiemTraChu = true;
                }
                if (matkhau[i] >= '0' && matkhau[i] <= '9')
                {
                    KiemTraSo = true;
                }
            }
            if(KiemTraSo == false || KiemTraChu == false)
            {
                return false; //Không hợp lệ
            }
            return true; //hoàn toàn hợp lệ
        }
        public bool KiemTraNguoiDungDungDinhDang()
        {
            //liệt kê trường hợp sai
            if (!email.Contains("@"))
            {
                return false;
            }
            if (!email.Contains(".com"))
            {
                return false;
            }
            int index1 = email.IndexOf("@");
            int index2 = email.IndexOf(".com");
            string s = email.Substring(index1 + 1, index2 - index1-1);
            if (s != "gmail" && s != "yahoo" && s != "hotmail")
            {
                return false;
            }
            if (s == "yahoo")
            {
                if (email.Contains(".vn"))
                {
                    return true;
                }
            }
            return true;
        }
    }
}
