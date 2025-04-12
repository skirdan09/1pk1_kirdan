using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_03
{
    internal enum OrderStatus
    {
        New,
        Processing,
        Shipped,
        Delivered,
        Cancelled,
    }

    internal static class OrderStatusDescripton
    {
        private static readonly Dictionary<OrderStatus, string> keyValuePairs = new()
        {
            { OrderStatus.New, "новый" },
            { OrderStatus.Processing, "в обработке" },
            { OrderStatus.Shipped, "отправлен" },
            { OrderStatus.Delivered, "доставлен" },
            { OrderStatus.Cancelled, "отменён" }
        };
        internal static string GetDescription(this OrderStatus status)
            => keyValuePairs[status];
    }
}
