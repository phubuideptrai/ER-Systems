using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        private AccountDAO() { }

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set => instance = value;
        }

        public bool Login(string username, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            string query = "EXEC USP_Login @UserName , @PassWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, hasPass });
            return result.Rows.Count > 0;
        }

        public AccountDTO GetAccountByIdUser(int id)
        {
            string query = "SELECT * FROM Account WHERE idStaff = " + id ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
            {
                AccountDTO account = new AccountDTO(data.Rows[0]);
                return account;
            }
            return null;
        }

        public int GetPositionByUserName(string userName)
        {
            string query = "exec USP_GetPositionByUserName @userName";
            int position = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { userName });
            return position;
        }

        public bool ChangePassword(string userName, string password)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            string query = string.Format("Update Account Set password = N'{0}' Where username = N'{1}' ", hasPass,userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            
            return result > 0;
        }

        public List<AccountDTO> GetListAccount()
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            string query = string.Format("SELECT * FROM Account");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accounts.Add(account);
            }
            return accounts;
        }

        public int GetIDStaffByUserName(string username)
        {
            string query = "exec USP_GetIdByUserName @userName";
            int id = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { username });
            return id;
        }

        public bool InsertAccount(string userName, int idStaff)
        {
            string query = string.Format("INSERT dbo.Account( userName, idStaff) VALUES (N'{0}', {1})", userName, idStaff);
            int result = (int)DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccountByIdStaff(int id)
        {
            string query = "Delete dbo.Account where idStaff = " + id;
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("UPDATE dbo.Account SET passWord = '2251022057731868917119086224872421513662' where userName = '{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }


        public List<AccountDTO> GetAccount_PositionListAscending(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = null;
            if (string.IsNullOrWhiteSpace(username))
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                            "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                            "ORDER BY position ASC";
            }
            else
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                        "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                        "WHERE acc.userName like N'%"+username+"%' "+
                        "ORDER BY position ASC";

            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accountList.Add(account);
            }
            return accountList;
        }

        public List<AccountDTO> GetAccount_PositionListDescending(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = null;
            if (string.IsNullOrWhiteSpace(username))
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                            "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                            "ORDER BY position DESC";
            }
            else
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                        "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                        "WHERE acc.userName like N'%" + username + "%' " +
                        "ORDER BY position DESC";

            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accountList.Add(account);
            }
            return accountList;
        }

        public List<AccountDTO> GetAccount_UsernameListAscending(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = null;
            if (string.IsNullOrWhiteSpace(username))
            {
                query = "SELECT * FROM Account ORDER BY userName ASC";
            }
            else
            {
                query = string.Format("SELECT * FROM Account where userName like N'%{0}%' ORDER BY userName ASC", username);
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accountList.Add(account);
            }
            return accountList;
        }

        public List<AccountDTO> GetAccount_UsernameListDescending(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = null;
            if (string.IsNullOrWhiteSpace(username))
            {
                query = "SELECT * FROM Account ORDER BY userName DESC";
            }
            else
            {
                query = string.Format("SELECT * FROM Account where userName like N'%{0}%' ORDER BY userName DESC", username);
            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accountList.Add(account);
            }
            return accountList;
        }

        public List<AccountDTO> GetAccount_OwnerListAscending(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = null;
            if (string.IsNullOrWhiteSpace(username))
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                            "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                            "ORDER BY name ASC";
            }
            else
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                        "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                        "WHERE acc.userName like N'%" + username + "%' " +
                        "ORDER BY name ASC";

            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accountList.Add(account);
            }
            return accountList;
        }

        public List<AccountDTO> GetAccount_OwnerListDescending(string username)
        {
            List<AccountDTO> accountList = new List<AccountDTO>();
            string query = null;
            if (string.IsNullOrWhiteSpace(username))
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                            "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                            "ORDER BY name DESC";
            }
            else
            {
                query = "SELECT acc.id,acc.idStaff,acc.userName,acc.passWord " +
                        "FROM Account acc INNER JOIN Staff ON Staff.id = acc.idStaff " +
                        "WHERE acc.userName like N'%" + username + "%' " +
                        "ORDER BY name DESC";

            }
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accountList.Add(account);
            }
            return accountList;
        }

        public List<AccountDTO> GetListAccountByUserName(string name)
        {
            List<AccountDTO> accounts = new List<AccountDTO>();
            string query = string.Format("SELECT * FROM Account where userName like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO account = new AccountDTO(item);
                accounts.Add(account);
            }
            return accounts;
        }

        public int CheckUsernamelExist(string username)
        {

            string query = string.Format("select * from Account where username = '{0}'", username);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                AccountDTO account = new AccountDTO(data.Rows[0]);
                return account.IDStaff;
            }
            return 0;
        }
    }
}
