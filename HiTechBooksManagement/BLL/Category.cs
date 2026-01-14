using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiTechBooksManagement.DAL;

namespace HiTechBooksManagement.BLL
{
    public class Category
    {


        
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public List<Category > GetAllCategories() =>CategoryDB.GetAllRecords();
        public Category SearchCategory(int categoryID) => CategoryDB.SearchRecord(categoryID);
        public void SaveCategory(Category category) => CategoryDB.SaveRecord(category);
        public bool UpdateCategory(Category category) => CategoryDB.UpdateRecord(category);
        public bool DeleteCategory(int categoryID) => CategoryDB.DeleteRecord(categoryID);

        public bool ExistingCategory(string name) => CategoryDB.CategoryTitleExists(name);

        public bool ExistingCategoryID(string category) => CategoryDB.CategoryIDExists(category);

    }
}
