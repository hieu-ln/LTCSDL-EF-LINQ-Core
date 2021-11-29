using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTCSDL.DAL;
using LTCSDL.DTO;

namespace LTCSDL.BLL
{
    public class CategoryBLL
    {
        private CategoryDAL dal;

        public CategoryBLL()
        {
            dal = new CategoryDAL();
        }

        public IList<CategoryDTO> GetAll()
        {
            return dal.GetAll();
        }
    }
}
