using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL.DTO;
using LTCSDL.DAL.Models;

namespace LTCSDL.DAL
{
    public class CategoryDAL
    {
        private NorthwindContext db;

        public CategoryDAL()
        {
            db = new NorthwindContext();
            //db.Database.Connection.ConnectionString = "Server = localhost; Database = Northwind; User id = sa; password = Password123;";
        }

        public IList<CategoryDTO> GetAll()
        {
            List<CategoryDTO> res = new List<CategoryDTO>();
            try
            {
                var ls = db.Categories.ToList();
                foreach (var c in ls)
                {
                    CategoryDTO cDto = new CategoryDTO();
                    cDto.CategoryID = c.CategoryId;
                    cDto.CategoryName = c.CategoryName;
                    cDto.Description = c.Description;
                    res.Add(cDto);
                }
            }
            catch (Exception e)
            {
                res = null;
            }

            return res;
        }
    }
}
