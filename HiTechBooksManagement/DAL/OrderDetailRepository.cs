using HiTechBooksManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.DAL
{
    public class OrderDetailRepository
    {
        private readonly HiTechBooksDBModel dbContext;

        public OrderDetailRepository()
        {
            dbContext = new HiTechBooksDBModel();
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails() => dbContext.OrderDetails.ToList();

        public IEnumerable<OrderDetail> GetOrderDetailsByOrderID(int orderID)
        {
            return dbContext.OrderDetails
                .Where(od => od.OrderID == orderID)
                .ToList();
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            dbContext.OrderDetails.Add(orderDetail);
            dbContext.SaveChanges();
        }

        public bool IsUnique(int id)
        {
            var orderDetail = dbContext.OrderDetails.Find(id);
            if(orderDetail != null)
            {
                return false;
            }
            return true;
        }

        public OrderDetail SearchById(int id)
        {
            var orderDetail = dbContext.OrderDetails.Find(id);
            return orderDetail;
        }

        public OrderDetail SearchOrderDetail(int id) => dbContext.OrderDetails.Find(id);

        public void DeleteOrderDetail(int id)
        {
            OrderDetail orderDetail = dbContext.OrderDetails.Find(id);
            if (orderDetail != null) 
            {
                dbContext.OrderDetails.Remove(orderDetail);
                dbContext.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Order details not found");
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            OrderDetail orderDetailToUpdate = dbContext.OrderDetails.FirstOrDefault(o => o.OrderDetailsID == orderDetail.OrderDetailsID);
            if (orderDetailToUpdate != null)
            {
                orderDetailToUpdate.OrderID = orderDetail.OrderID;
                orderDetailToUpdate.BookID = orderDetail.BookID;
                orderDetailToUpdate.Quantity = orderDetail.Quantity;
                orderDetailToUpdate.UnitPrice = orderDetail.UnitPrice;
                dbContext.SaveChanges();

            }

        }
    }
}
