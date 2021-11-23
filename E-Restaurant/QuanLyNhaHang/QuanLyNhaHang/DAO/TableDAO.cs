using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaHang.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        private TableDAO() { }

        public static TableDAO Instance
        {
            get
            {
                if (instance == null) instance = new TableDAO();
                return TableDAO.instance;
            }
            private set => instance = value;
        }

        public List<TableDTO> GetTableList()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            string query = "SELECT * FROM dbo.TableFood";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<TableDTO> GetTableListAscending()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            string query = "SELECT * FROM TableFood tf order by tf.status asc ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public List<TableDTO>GetTableListDescending()
        {
            List<TableDTO> tableList = new List<TableDTO>();
            string query = "SELECT * FROM TableFood tf order by tf.status desc ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                TableDTO table = new TableDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
        public void SwitchTable(int id1, int id2)
        {
            string query = "EXEC USP_SwitchTable @idTable1 , @idTable2";
            DataProvider.Instance.ExecuteQuery(query, new object[] { id1, id2 });
        }

        public void SetTableStatus()
        {
            string query = "UPDATE TableFood SET TableFood.status = 'Using' where EXISTS (SELECT * from Bill where TableFood.id = Bill.idTable and Bill.status = 0)";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool AddTable(string name)
        {
            string query = string.Format("INSERT TableFood (name) VALUES ('{0}')", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool EditTable(string oldname, string newname)
        {
            string query = string.Format("UPDATE dbo.TableFood Set name = N'{0}' where name = N'{1}'", newname,oldname);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteTable(string name)
        {
            string query = string.Format("Delete dbo.TableFood where name = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string GetTableStatus(int id)
        {
            string query = string.Format("select status from TableFood where id = {0}", id);
            string status = Convert.ToString(DataProvider.Instance.ExecuteScalar(query));
            return status;
        }
        public void UpdateTableStatus(int id)
        {
            string tableStatus = GetTableStatus(id);
            string query;
            if(tableStatus=="Empty")
            {
                query = string.Format("UPDATE TableFood  SET status = 'Using' where id = {0}", id);
            }
            else
            {
                query = string.Format("UPDATE TableFood  SET status = 'Empty' where id = {0}", id);
            }
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        
    }
}
