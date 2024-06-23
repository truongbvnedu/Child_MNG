using Child_mg.Models;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Child_mg.Controllers
{

    internal class userController
    {
        ChildDbContext db = new ChildDbContext();
        private static userController instance;
        public static userController Instance
        {
            get { if (instance == null) instance = new userController(); return instance; }
            private set { instance = value; }
        }
        public  User storageUser;
        public List<User> loadteaherlist() 
        {
            var user = from c in db.Users
                       where c.Role == 2
                       select c;
            return user.ToList();
        }
        
        public int decentralization_login(string username, string password)
        {
            User user = db.Users.Where(p => p.Account.Equals(username) && p.Password.Equals(password)).FirstOrDefault();
            if (user == null)
            {
                return -1;
            }
            switch (user.Role)
            {
                case 0:
                    storageUser = user;
                    return 0;
                case 1:
                    storageUser = user;
                    return 1;
                case 2:
                    storageUser = user;
                    return 2;
                default:
                    return -1;
            }
        }
        public bool checkphone(string phone) 
        {
            var checkphone = from User in db.Users
                        where User.Phone == phone
                        select User;
            int i = checkphone.Count();
            if (i >0)
            {
                return false;
            }
            else {return true; }
        }
        public void addaccount(string name ,  string phone , string username ,string password , string address ,string gender ,int role , string email , string identityid)
        {
            User user = new User();
            user.Name = name;
            user.Phone = phone;
            user.Address = address;
            user.Gender = gender;
            user.Email = email;
            user.IdentityId = identityid;
            user.Account = username;
            user.Role = role;
            user.Password = password;
            db.Users.Add(user);
            db.SaveChanges();
        }
        public int sendcode(string username)
        {
            User user = db.Users.Where(p=>p.Account == username).FirstOrDefault();
            string from, pass, messagebody,to;
            int RandomCode;
            Random random = new Random();
            MailMessage mail = new MailMessage();
            RandomCode = random.Next(100000, 999999);
           
            to = user.Email;
            from = "truongtruongbvn@gmail.com";
            pass = "mxey hyoj hngv twuo";  
            messagebody = "Mã OTP của bạn là: " + RandomCode;
            mail.To.Add(to);
            mail.From = new MailAddress(from);
            mail.Body = messagebody;
            mail.Subject = "Mã OTP đặt lại mật khẩu";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(from, pass),
                EnableSsl = true
            };

            smtp.Send(mail);
            MessageBox.Show("Mã OTP đã được gửi tới email của bạn.");
            return RandomCode;
        }
        public void changepassword(string username, string password,string confimpass,int code) 
        {
            int recodecheck = sendcode(username);
            if (recodecheck == code)
            {
                if (password == confimpass)
                {
                    User user = db.Users.Where(p=>  p.Account == username).FirstOrDefault();
                    user.Password = password;
                    db.SaveChanges();
                    MessageBox.Show("Cập nhật mật khẩu mới thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng vui lòng kiểm tra lại !");
                }

            }
            else
            {
                MessageBox.Show("Sai mã OPT vui lòng kiểm tra lại ");
            }

        }
        public User loaddata(string usernmae, string password)
        {
            User loaduser = db.Users.Where(p => p.Account == usernmae && p.Password == password).FirstOrDefault();
            return loaduser;
        }

    }

}

