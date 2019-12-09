using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL_LanChat;
using DTO_LanChat;
namespace BUS_LanChat
{
    public class BUS_users
    {
        DAL_users DAL_USER = new DAL_users();
        public DataTable GetAllUsers()
        {
            return DAL_USER.GetAllUsers();
        }
        public DataTable GetUsersWith(string Attribute, object value)
        {
            return DAL_USER.GetUsersWith(Attribute, value);
        }
        public void InsertUsers(DTO_users user)
        {
            DAL_USER.InsertUsers(user);
        }
        public void UpdateUsers(DTO_users user)
        {
            DAL_USER.UpdateUsers(user);
        }
        public void DeleteUser(int id)
        {
            DAL_USER.DeleteUsers(id);
        }
        public DTO_users GetUsers(int id)
        {
            return DAL_USER.GetUsers(id);
        }
        public bool isUsersHave(string Attribute, object value)
        {
            return DAL_USER.isUsersHave(Attribute, value);
        }
        public int[] GetUsersID(string Attribute, object value)
        {
            return DAL_USER.GetUsersID(Attribute, value);
        }
        public int GetUsersLength()
        {
            DataTable table = DAL_USER.GetAllUsers();
            return table.Rows.Count;
        }
        public int GetUsersLength(string Attribute,object value)
        {
            DataTable table = DAL_USER.GetUsersWith(Attribute,value);
            return table.Rows.Count;
        }
        public void UpdateUsers(int id, string Attribute, object value)
        {
            DAL_USER.UpdateUsers(id, Attribute, value);
        }
    }
}
