using System;
using System.ComponentModel;
using System.Reflection;

namespace Task_20_03
{
//    создайте программу для управления статусом заказа в интернет-магазине.используйте перечислениеorderstatus со значениями:
//• new(новый)
//• processing(в обработке)
//• shipped(отправлен)
//• delivered(доставлен)
//• cancelled(отменён)
//напишите метод, который меняет статус заказа.
//если заказ уже доставлен или отменён, запретите изменение статуса.
//выводите сообщение при каждом изменении статуса (например,
//"заказ переведён в статус: отправлен").
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order1 = new();
            order1.ChangeStatus(OrderStatus.Processing);


        }
         
    }
}
