using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SMS.Data;
using SMS.Framework;
using Data;

namespace SMS.BusinessLogic
{
    public class UserBL
    {
        private PlayerDBEntities context = new PlayerDBEntities();

        public Result<List<Admin>> GetAllAdmins(string name="")
        { 
            var result = new Result<List<Admin>>();

            var query = from d in context.Admins
                select d;

            if (ValidationHelper.IsStringValid(name))
            {
                query = from d in query
                    where d.Name.Contains(name)
                    select d;
            }

            result.Data = query.ToList();

            return result;
        }

      

        public Result<Admin> Login(string userName, string password)
        {
            var result = new Result<Admin>();

            try
            {
                var userInfo = context.Admins.FirstOrDefault(u => u.ID== userName && u.Password== password);
                result.Data = userInfo;
                if (userInfo != null)
                {
                   
                    context.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }

            return result;
        }

        public Result<Admin> LogOut()
        {
            var result = new Result<Admin>();

            try
            {
                var userInfo = context.Admins.FirstOrDefault(u => u.ID == LoginHelper.LoginUserInfo.ID);
                if (userInfo != null)
                {
                    
                    context.SaveChanges();
                }
                return result;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }

            return result;
        }

        public Result<Admin> Delete(int id)
        {
            var result = new Result<Admin>();

            try
            {
                var Admin = context.Admins.FirstOrDefault(d => d.ID ==LoginHelper.LoginUserInfo.ID);
                if (Admin == null)
                {
                    result.HasError = true;
                    result.Messages.Add("Invalid ID");
                    return result;
                }

                context.Admins.Remove(Admin);
                context.SaveChanges();

                result.Data = Admin;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }
            return result;
        }


        public Result<Admin> SaveAdmin(Admin userInfo)
        {
            var result = new Result<Admin>();

            if (!ValidationHelper.IsStringValid(userInfo.Name))
            {
                result.HasError = true;
                result.Messages.Add("Invalid Name");
                return result;
            }


            try
            {
                if (context.Admins.Any(d => d.Name == userInfo.Name && d.ID != userInfo.ID))
                {
                    result.HasError = true;
                    result.Messages.Add("Username Exist");
                    return result;
                }

                var Admin = context.Admins.FirstOrDefault(d => d.ID == userInfo.ID);
                if (Admin == null)
                {
                    Admin = new Admin();
                    context.Admins.Add(Admin);
                }

                Admin.Name = userInfo.Name;
                Admin.Password = userInfo.Password;
                Admin.ID = "1";

                context.SaveChanges();

                result.Data = Admin;
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.Messages.Add(ex.Message);
            }


            return result;
        }
    }
}
