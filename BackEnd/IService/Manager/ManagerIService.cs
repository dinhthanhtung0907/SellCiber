using BackEnd.DTO;
using BackEnd.Models;
using System.Collections;
using System.Collections.Generic;

namespace BackEnd.IService.Manager
{
    public interface ManagerIService
    {
        public IEnumerable<dynamic> GetAllOrders();
        public IEnumerable<dynamic> GetAllproduct();
        public IEnumerable<dynamic> GetAllpcustomer();
        public Order addOrder(Order db);
        public IEnumerable<dynamic> Search(StringRequest db);

    }
}
