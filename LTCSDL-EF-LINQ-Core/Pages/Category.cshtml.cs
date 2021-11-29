using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using LTCSDL.BLL;
using LTCSDL.DTO;

namespace LTCSDL_EF_LINQ_Core.Pages
{
    public class CategoryModel : PageModel
    {
        private CategoryBLL bus;
        public List<CategoryDTO> lst;
        public CategoryModel()
        {
            bus = new CategoryBLL();
        }
        public void OnGet()
        {
            lst = bus.GetAll().ToList();
        }
    }
}
