using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using System.Security.Cryptography;

namespace DataAccess
{
    public class UserDAO:ConnectionToSql
    {
        public bool Login (string user, string pass)    
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT tk.MaNV, nv.HoNV, nv.TenNV, username, password FROM dbo.taiKhoan tk JOIN dbo.NhanVien nv ON nv.MaNV = tk.MaNV WHERE tk.userName = @MATAIKHOAN AND tk.passWord = @MATKHAU";
                    command.Parameters.AddWithValue("@MATAIKHOAN", user);
                    command.Parameters.AddWithValue("@MATKHAU", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while(reader.Read())
                        {
                            UserLoginCache.MaNV = reader.GetString(0);
                            UserLoginCache.FRISTNAME = reader.GetString(1);
                            UserLoginCache.LASTNAME = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        // lấy lại mật khẩu
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT tk.MaNV, nv.HoNV, nv.TenNV, username, password, email FROM dbo.taiKhoan tk JOIN dbo.NhanVien nv ON nv.MaNV = tk.MaNV WHERE Email = @email";
                    command.Parameters.AddWithValue("@email", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1);
                        string userLastname = reader.GetString(2);
                        string userEmail = reader.GetString(5);
                        string accountPassword = reader.GetString(4);

                        // giải mã mật khẩu
                        string hash = "t47@l54";
                        string pass;
                        byte[] data = Convert.FromBase64String(accountPassword);
                        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                        {
                            byte[] key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                            using (TripleDESCryptoServiceProvider tripDES = new TripleDESCryptoServiceProvider() { Key = key, Mode=CipherMode.ECB, Padding= PaddingMode.PKCS7})
                            {
                                ICryptoTransform transform = tripDES.CreateDecryptor();
                                byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                                pass = UTF8Encoding.UTF8.GetString(results);
                            }

                        }

                        var mailService = new EmailServices.SystemSupportMail();
                        mailService.SendEmail(
                            subject: "System: Password recovery request",
                            body: "Hi, " + userName + userLastname + "\n You requested to recover your password. \n" +
                            "Your current password is: " + pass +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.",
                            recipientMail: new List<string> { userEmail }
                            );
                        return "Hi, " + userName + userLastname + "\nYou requested to recover your password." +
                            "Please check your email: " + userEmail +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.";
                    }
                    else
                        return "Xin lỗi, bạn không có tài khoản với email này";
                }
            }
        }
    }
}
