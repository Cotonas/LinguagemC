using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ControlOrders.Entities.Enums;
using ControlOrders.Entities;

namespace ControlOrders.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.00;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMARY: ");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name + " " + Client.BirthDate.ToString("dd/MM/yyy") + " " + Client.Email);
            sb.AppendLine("Order items: ");
            foreach (OrderItem c in Items)
            {
                sb.AppendLine(c.ToString());
            }
            sb.Append("Total price: $" + Total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
