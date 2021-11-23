using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaHang.DTO;
using System.Data;

namespace QuanLyNhaHang.DAO
{
    class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null) instance = new FoodDAO();
                return FoodDAO.instance;

            }
            private set => instance = value;
        }

        private FoodDAO() { }

        public List<FoodDTO> GetFoodByCategoryID(int id)
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "select * from Food where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }

            return list;
        }

        public int GetOrderQuantityByID(int idFood)
        {
            string query = string.Format("select sum(bf.count) from BillInfo bf where bf.idFood = " + idFood);
            int quantity;

            try
            {
                quantity = (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch
            {
                quantity = 0;
            }
            return quantity;
        }
        public List<FoodDTO> GetListFood()
        {
            List<FoodDTO> list = new List<FoodDTO>();

            string query = "SELECT * FROM Food ORDER BY idCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                FoodDTO food = new FoodDTO(item);
                list.Add(food);
            }

            return list;
        }

        public List<FoodDTO> SearchFoodByName(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            string query = string.Format("select * from Food f where f.name like N'%{0}%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                FoodDTO foodies = new FoodDTO(item);
                food.Add(foodies);
            }
            return food;
        }
        public List<FoodDTO> GetListFoodByNameAscending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Food f order by f.name asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = string.Format("select * from Food f where f.name like N'%{0}%' order by f.name asc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }
        public List<FoodDTO> GetListFoodByNameDescending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Food f order by f.name desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = string.Format("select * from Food f where f.name like N'%{0}%' order by f.name desc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }
        public List<FoodDTO> GetListFoodByidCategoryAscending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Food f order by f.idCategory asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = string.Format("select * from Food f where f.name like N'%{0}%' order by f.idCategory asc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }
        public List<FoodDTO> GetListFoodByidCategoryDescending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Food f order by f.idCategory desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = string.Format("select * from Food f where f.name like N'%{0}%' order by f.idCategory desc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }
        public List<FoodDTO> GetListFoodByPriceAscending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Food f order by f.price asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = string.Format("select * from Food f where f.name like N'%{0}%' order by f.price asc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }
        public List<FoodDTO> GetListFoodByPriceDescending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select * from Food f order by f.price desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = string.Format("select * from Food f where f.name like N'%{0}%' order by f.price desc", name);
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }
        public List<FoodDTO> GetListFoodByQuantityDescending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select Food.id,Food.idCategory,Food.name,Food.price "+
                                "FROM Food LEFT JOIN dbo.BillInfo ON BillInfo.idFood = Food.id " +
                                "Group by Food.id,Food.idCategory,Food.name,Food.price " +
                                "order by sum(BillInfo.count) desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = "select Food.id,Food.idCategory,Food.name,Food.price " +
                                "FROM Food LEFT JOIN dbo.BillInfo ON BillInfo.idFood = Food.id " +
                                "where Food.name like N'%" + name + "%'+ " +
                                "Group by Food.id,Food.idCategory,Food.name,Food.price " +
                                "order by sum(BillInfo.count) desc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }

        public List<FoodDTO> GetListFoodByQuantityAscending(string name)
        {
            List<FoodDTO> food = new List<FoodDTO>();
            if (string.IsNullOrWhiteSpace(name))
            {
                string query = "select Food.id,Food.idCategory,Food.name,Food.price " +
                                "FROM Food LEFT JOIN dbo.BillInfo ON BillInfo.idFood = Food.id " +
                                "Group by Food.id,Food.idCategory,Food.name,Food.price "+
                                "order by sum(BillInfo.count) asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }
            }
            else
            {
                string query = "select Food.id,Food.idCategory,Food.name,Food.price " +
                                "FROM Food LEFT JOIN dbo.BillInfo ON BillInfo.idFood = Food.id " +
                                "where Food.name like N'%" + name + "%'+ " +
                                "Group by Food.id,Food.idCategory,Food.name,Food.price " +
                                "order by sum(BillInfo.count) asc";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    FoodDTO foood = new FoodDTO(item);
                    food.Add(foood);
                }

            }
            return food;
        }

        public bool AddMeal(string name,int idCategory, float price)
        {
            string query = string.Format("INSERT dbo.Food ( name,idCategory, price ) VALUES  ( N'{0}', {1},{2})", name,idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool EditMeal(int id, string name, int idCategory, float price)
        {
            string query = string.Format("UPDATE dbo.Food SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, idCategory, price, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteMeal(string name)
        {
            string query = string.Format("Delete FROM Food where Food.name = N'{0}'",name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public int GetIDFoodByName(string name)
        {
            string query = string.Format("Select food.id from Food where food.name = N'{0}'", name);
            int id = (int)DataProvider.Instance.ExecuteScalar(query);
            return id;
        }

        public FoodDTO GetFoodById(int id)
        {

            string query = "select * from Food where id = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                FoodDTO food = new FoodDTO(data.Rows[0]);
                return food;
            }
            return null;
        }
    }
}
