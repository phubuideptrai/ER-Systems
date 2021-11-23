using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class StaffDTO
    {
        private int id;
        private String name;
        private int sex;
        private String email;
        private String phone;
        private int salary;
        private int position;

        public StaffDTO() { }

        public StaffDTO(int id, string name, int sex, string email, string phone, int salary, int position)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.email = email;
            this.phone = phone;
            this.salary = salary;
            this.position = position;
        }

        public StaffDTO(DataRow row)
        {
            this.id = (int)row["id"]; ;
            this.name = row["name"].ToString();
            this.sex = (int)row["sex"];
            this.email = row["email"].ToString();
            this.phone = row["phone"].ToString();
            this.salary = (int)row["salary"];
            this.position = (int)row["position"];
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Sex { get => sex; set => sex = value; }
        public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Salary { get => salary; set => salary = value; }
        public int Position { get => position; set => position = value; }
    }
}
