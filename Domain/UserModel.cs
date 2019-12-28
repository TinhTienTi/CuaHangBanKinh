using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDAO userDao = new UserDAO();

        // Attributes
        private string manv;
        private string fristName;
        private string lastName;
        private string soNha;
        private string tenDuong;
        private string xaPhuong;
        private string quanHuyen;
        private string tinhTP;
        private string viettel;
        private string mobifone;
        private string vinaphone;
        private string vietnammobile;
        private float luong;
        private DateTime ngayVaoLam;
        private string cmnd;
        private DateTime ngaySinh;
        private string email;
        private string gioiTinh;
        private string TenChucVu;

        public UserModel()
        {

        }

        public UserModel(string manv, string fristName, string lastName, string soNha, string tenDuong, string xaPhuong, string quanHuyen, string tinhTP, string viettel, string mobifone, string vinaphone, string vietnammobile, float luong, DateTime ngayVaoLam, string cmnd, DateTime ngaySinh, string email, string gioiTinh, string tenChucVu)
        {
            this.manv = manv;
            this.fristName = fristName;
            this.lastName = lastName;
            this.soNha = soNha;
            this.tenDuong = tenDuong;
            this.xaPhuong = xaPhuong;
            this.quanHuyen = quanHuyen;
            this.tinhTP = tinhTP;
            this.viettel = viettel;
            this.mobifone = mobifone;
            this.vinaphone = vinaphone;
            this.vietnammobile = vietnammobile;
            this.luong = luong;
            this.ngayVaoLam = ngayVaoLam;
            this.cmnd = cmnd;
            this.ngaySinh = ngaySinh;
            this.email = email;
            this.gioiTinh = gioiTinh;
            TenChucVu = tenChucVu;
        }


        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
    }
}
