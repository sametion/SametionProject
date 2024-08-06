using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "product added";
        public static string ProductNameInvalid = "product name invalid";
        public static string MaintenanceTime="system is under maintenance";
        public static string ProductListed="products listed";

        public static string ProductCountOfCategoryError = "categoride 10 üründen fazla olamaz";
        public static string ProductNameAlreadyExist="this product Name Already exist";
        public static string CategoryLimitExceeded="Category limit has exceeded";
    }
}
