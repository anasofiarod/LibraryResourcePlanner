using HiTechBooksManagement.DAL;
using HiTechBooksManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.BLL
{
    public class OrderController
    {
        private readonly OrderRepository orderRepository;

        public OrderController()
        {
            orderRepository = new OrderRepository();
        }

        public IEnumerable<Order> GetOrders() => orderRepository.GetAllOrders();

        public void NewOrder(Order order)=> orderRepository.AddOrder(order);

        public void SaveOrder(Order order) => orderRepository.AddOrder(order);

        public void RemoveOrder(int id) => orderRepository.DeleteOrder(id);

        public void UpdateOrder(Order order) => orderRepository.UpdateOrder(order);

        public bool IsUniqueOrderID(int orderID) => orderRepository.IsUnique(orderID);

        public Order SearchOrderByID(int orderID) => orderRepository.SearchById(orderID);
    }
}
