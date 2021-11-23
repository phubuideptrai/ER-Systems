using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillInfoDAO();
                return instance;
            }
            private set => instance = value;
        }
        private BillInfoDAO() { }

        public List<BillInfoDTO> GetListMenu()
        {
            List<BillInfoDTO> listMenu = new List<BillInfoDTO>();

            string query = "SELECT  bf.id, f.name,fc.name as category,bf.description,bf.status, bf.count,f.price, f.price* bf.count as totalPrice from BillInfo as bf, Bill as b,FoodCategory as fc , Food as f where b.id = bf.idBill and f.id = bf.idFood and b.status=0 and fc.id=f.idCategory ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfoDTO menu = new BillInfoDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<BillInfoDTO> GetListMenuByTable(int id)
        {
            List<BillInfoDTO> listMenu = new List<BillInfoDTO>();

            string query = "SELECT bf.id, f.name,fc.name as category,bf.description,bf.status, bf.count,f.price, f.price* bf.count as totalPrice from BillInfo as bf, Bill as b,FoodCategory as fc , Food as f where b.id = bf.idBill and f.id = bf.idFood and b.status=0 and fc.id=f.idCategory and b.idTable = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                BillInfoDTO menu = new BillInfoDTO(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }

        public List<BillInfoDTO>GetListRevenue(int month)
        {
            List<BillInfoDTO> list = new List<BillInfoDTO>();
            string query = "SELECT  bf.id, f.name,fc.name as category,bf.description,bf.status, bf.count,f.price, f.price* bf.count as totalPrice from BillInfo as bf, Bill as b,FoodCategory as fc , Food as f where b.id = bf.idBill and f.id = bf.idFood and b.status = 1 and fc.id=f.idCategory and month(b.DateCheckIn) =" + month;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                BillInfoDTO bill = new BillInfoDTO(row);
                list.Add(bill);
            }
            return list;
        }
        public List<BillInfoDTO>GetListRevenue(int month, int year)
        {
            List<BillInfoDTO> list = new List<BillInfoDTO>();
            string query = "SELECT  bf.id, f.name,fc.name as category,bf.description,bf.status, bf.count,f.price, f.price* bf.count as totalPrice from BillInfo as bf, Bill as b,FoodCategory as fc , Food as f where b.id = bf.idBill and f.id = bf.idFood and b.status = 1 and fc.id=f.idCategory and month(b.DateCheckIn) = " + month + " and year(b.DateCheckIn) = " + year;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                BillInfoDTO bill = new BillInfoDTO(row);
                list.Add(bill);
            }
            return list;
        }
        public void InsertBillInfo(int idBill, int idFood, int count, string des)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @idBill , @idFood , @count , @des", new object[] { idBill, idFood, count, des });
        }

        public int GetBillInfo(int idBill, int idFood)
        {

            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT id FROM BillInfo where idBill=" + idBill + "and idFood= " + idFood);
            }
            catch
            {
                return -1;
            }
        }
        public void UpdateStatus(int id, int status)
        {
         
            string query = string.Format("Update dbo.BillInfo set status = {0}  where id = {1}", status, id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
