using BackEnd.Data;
using BackEnd.DTO;
using BackEnd.IService.Manager;
using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEnd.Service.Manager
{
    public class ManagerService : ManagerIService
    {
        private readonly AppDBContext _context;
        public ManagerService(AppDBContext context)
        {
            _context = context;
        }

        public Order addOrder(Order db)
        {
            try
            {
               
                    _context.Orders.Add(db);
                    _context.SaveChanges();
                    return db;
               

            }
            catch (Exception e) {
                return null;
            }
        }

        public IEnumerable<dynamic> GetAllOrders()
        {
            var orders = from order in _context.Orders
                         select new
                         {
                             OrderDate=order.OrderDate,
                             UserId = order.OrderDate,
                             Amount = order.Amount,
                             ApplicationUserId = order.ApplicationUser.Id,
                             ApplicationUserUserName = order.ApplicationUser.UserName,
                             ProductId = order.Product.Id,
                             ProductName = order.Product.Name,
                             CategoryId = order.Product.Category.Id,
                             CategoryName = order.Product.Category.Name,

                         };
            return orders.AsQueryable();
        }

        public IEnumerable<dynamic> GetAllpcustomer()
        {
            return _context.ApplicationUsers.AsQueryable();
        }

        public IEnumerable<dynamic> GetAllproduct()
        {
            return _context.Products.AsQueryable();
        }

        public IEnumerable<dynamic> Search(StringRequest db)
        {
            var orders = from order in _context.Orders
                         select new
                         {
                             OrderDate = order.OrderDate,
                             UserId = order.OrderDate,
                             Amount = order.Amount,
                             ApplicationUserId = order.ApplicationUser.Id,
                             ApplicationUserUserName = order.ApplicationUser.UserName,
                             ProductId = order.Product.Id,
                             ProductName = order.Product.Name,
                             CategoryId = order.Product.Category.Id,
                             CategoryName = order.Product.Category.Name,

                         };
            return orders.Where(x=>x.CategoryName.Contains(db.stringrequest+"")).AsQueryable();
        }
    }
}
