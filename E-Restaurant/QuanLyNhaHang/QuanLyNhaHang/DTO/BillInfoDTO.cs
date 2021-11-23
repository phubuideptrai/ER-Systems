using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DTO
{
    public class BillInfoDTO
    {
        public BillInfoDTO(int id, string foodName, string category, int count, float price, float totalPrice = 0, string description = null, int status = 0)
        {
            this.Id = id;
            this.FoodName = foodName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
            this.Description = description;
            this.Status = status;
            this.Category = category;
        }
        public BillInfoDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.FoodName = row["name"].ToString();
            this.Category = row["category"].ToString();
            this.Count = (int)row["count"];
            this.Price = (float)Convert.ToDouble(row["price"]);
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"]);
            this.Description = row["description"].ToString();
            this.Status = (int)row["status"];
        }


        private int id;
        private float totalPrice;
        private float price;
        private string foodName;
        private int count;
        private string category;
        private string description;
        private int status;

        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public float Price { get => price; set => price = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public string Description { get => description; set => description = value; }
        public int Status { get => status; set => status = value; }
        public string Category { get => category; set => category = value; }
        public int Id { get => id; set => id = value; }
    }
}
