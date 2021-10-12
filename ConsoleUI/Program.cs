using Business.Concreate;
using System;
using DataAccess.Concreate.InMemory;
using DataAccess.Concreate.EntityFramework;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success==true)
            {

                //GetAllByCategoryId(2) --  GetAll()  --  GetByUnitPrice(50,100) --  GetProductDetails()
                foreach (var product in productManager.GetProductDetails().Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }

            

        }
    }
}
