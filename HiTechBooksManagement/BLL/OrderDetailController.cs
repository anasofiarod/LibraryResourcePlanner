using HiTechBooksManagement.DAL;
using HiTechBooksManagement.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiTechBooksManagement.BLL
{
    public class OrderDetailController
    {
        private readonly OrderDetailRepository orderDetailRepository;

        public OrderDetailController()
        {
            orderDetailRepository = new OrderDetailRepository();
        }

        public IEnumerable<OrderDetail> GetOrderDetail() => orderDetailRepository.GetAllOrderDetails();

        public IEnumerable<OrderDetail> SearchOrderDetailsByOrderID(int id) => orderDetailRepository.GetOrderDetailsByOrderID( id);


        public void SaveOrderDetail(OrderDetail orderDetail) => orderDetailRepository.AddOrderDetail(orderDetail);

        public void RemoveOrderDetail(int id) => orderDetailRepository.DeleteOrderDetail(id);

        public void UpdateOrderDetail(OrderDetail orderDetail) => orderDetailRepository.UpdateOrderDetail(orderDetail);

        public bool IsUniqueOrderDetailID(int orderDetailID) => orderDetailRepository.IsUnique(orderDetailID);

        public OrderDetail GetOrderDetailByID(int orderDetailID)=> orderDetailRepository.SearchById(orderDetailID);
    }
}
