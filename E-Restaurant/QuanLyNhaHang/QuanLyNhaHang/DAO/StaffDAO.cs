using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class StaffDAO
    {
        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StaffDAO();
                return instance;
            }
            private set => instance = value;
        }
        private StaffDAO() { }

        public List<StaffDTO> GetListStaff()
        {
            List<StaffDTO> listStaff = new List<StaffDTO>();

            string query = "select * from Staff";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                StaffDTO staff = new StaffDTO(item);
                listStaff.Add(staff);
            }

            return listStaff;
        }

        public List<StaffDTO> GetListStaffByName(string name)
        {
            List<StaffDTO> listStaff = new List<StaffDTO>();
            string query = string.Format("select * from Staff where name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                StaffDTO staff = new StaffDTO(item);
                listStaff.Add(staff);
            }
            return listStaff;
        }

        public StaffDTO GetStaffById(int id)
        {

            string query = "select * from Staff where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                StaffDTO staff = new StaffDTO(data.Rows[0]);
                return staff;
            }
            return null;
        }

        public bool DeleteStaff(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("Delete FROM Staff where id = "+id);

            return result > 0;
        }

        public int CheckPhoneExist(string phone)
        {

            string query = string.Format("select * from Staff where phone = '{0}'",phone);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                StaffDTO staff = new StaffDTO(data.Rows[0]);
                return staff.Id;
            }
            return 0;
        }

        public int CheckEmailExist(string email)
        {

            string query = string.Format("select * from Staff where email = '{0}'", email);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                StaffDTO staff = new StaffDTO(data.Rows[0]);
                return staff.Id;
            }
            return 0;
        }

        public void EditStaff(string name, int sex, string email, string phone, int salary, int position,int id)
        {
            string query = string.Format("UPDATE dbo.Staff SET name = '{0}', sex = {1} , email = '{2}' , phone = '{3}' , salary = {4} , position = {5} where id = {6}", name, sex,email,phone,salary,position,id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InsertStaff(string  name,int sex, string email,string phone,int salary,int position)
        {
            DataProvider.Instance.ExecuteQuery("exec USP_InsertStaff @name , @sex , @email , @phone , @salary , @position ", new object[] { name, sex, email, phone, salary,position });
        }
        public List<StaffDTO> GetListStaffByNameAscending(string name)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Staff order by name asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }
            }
            else
            {
                string query = string.Format("select * from Staff where name like N'%{0}%' order by name asc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }

            }
            return staffs;
        }

        public List<StaffDTO> GetListStaffByNameDescending(string name)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Staff order by name desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }
            }
            else
            {
                string query = string.Format("select * from Staff where name like N'%{0}%' order by name desc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }

            }
            return staffs;
        }

        public List<StaffDTO> GetListStaffBySalaryAscending(string name)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Staff order by salary asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }
            }
            else
            {
                string query = string.Format("select * from Staff where name like N'%{0}%' order by salary asc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }

            }
            return staffs;
        }

        public List<StaffDTO> GetListStaffBySalaryDescending(string name)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Staff order by salary desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }
            }
            else
            {
                string query = string.Format("select * from Staff where name like N'%{0}%' order by salary desc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }

            }
            return staffs;
        }

        public List<StaffDTO> GetListStaffByPositionAscending(string name)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Staff order by position desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }
            }
            else
            {
                string query = string.Format("select * from Staff where name like N'%{0}%' order by position desc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }

            }
            return staffs;
        }

        public List<StaffDTO> GetListStaffByPositionDescending(string name)
        {
            List<StaffDTO> staffs = new List<StaffDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Staff order by position asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }
            }
            else
            {
                string query = string.Format("select * from Staff where name like N'%{0}%' order by position asc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    StaffDTO staff = new StaffDTO(item);
                    staffs.Add(staff);
                }

            }
            return staffs;
        }

        public int GetMaxIdStaff()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.Staff");
            }
            catch
            {
                return 1;
            }
        }

        public string GetNameById(int id)
        {
            string query = "SELECT name FROM Staff WHERE id = "+id;
            string name = DataProvider.Instance.ExecuteScalar(query).ToString();
            return name;
        }
        public string GetUserNameById(int id)
        {
            string query = "select username from Account, Staff where Account.idStaff = Staff.id and Staff.id = " + id;
            string name = DataProvider.Instance.ExecuteScalar(query).ToString();
            return name;
        }
    }
}
