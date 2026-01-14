using HiTechBooksManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public class OrderRepository
    {
        private readonly HiTechBooksDBModel dbContext;

        public OrderRepository()
        {
            dbContext = new HiTechBooksDBModel();
        }

        public IEnumerable<Order> GetAllOrders()=> dbContext.Orders.ToList();

        public void AddOrder(Order order)
        {
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }



        public bool IsUnique(int id)
        {
            var order = dbContext.Orders.Find(id);
            if(order != null)
            {
                return false;
            }
            return true;
        }

        public Order SearchById(int id)
        {
            var order = dbContext.Orders.Find(id);
            return order;
        }

        public Order SearchOrder(int id) => dbContext.Orders.Find(id);

        public void DeleteOrder(int id)
        {
            Order order = dbContext.Orders.Find(id);
            if(order != null)
            {
                dbContext.Orders.Remove(order);
                dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Order was not found");
            }
        }

        public void UpdateOrder(Order order)
        {
            Order orderToUpdate = dbContext.Orders.FirstOrDefault(o=>o.OrderID == order.OrderID);
            if(orderToUpdate != null )
            {
                orderToUpdate.OrderDate = order.OrderDate;
                orderToUpdate.OrderDetails = order.OrderDetails;
                orderToUpdate.UserID = order.UserID;
                orderToUpdate.CustomerID = order.CustomerID;
                orderToUpdate.TotalAmount = order.TotalAmount;
                dbContext.SaveChanges();

            }
        }


    }
}
