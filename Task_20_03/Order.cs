using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal class Order
    {
        public OrderStatus Status { get; set; }
        public void ChangeStatus(OrderStatus newStatus)
        {
            if (Status == newStatus
                || Status == OrderStatus.Cancelled
                || Status == OrderStatus.Delivered)
                return;

            Status = newStatus;
            Console.WriteLine($"Заказ переведён в статус: {Status.GetDescription()}");
        }

    }
}
