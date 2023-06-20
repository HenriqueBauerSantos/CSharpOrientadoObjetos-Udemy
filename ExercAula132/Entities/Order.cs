using ExercAula132.Entities.Enums;
using System.Text;

namespace ExercAula132.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() 
        {
            Moment = DateTime.Now;
        }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) 
        {
            Orders.Add(item);
        }

        public void RemoveItem(OrderItem item) 
        {  
            Orders.Remove(item); 
        }

        public double Total()
        {
            double total=0;
            foreach (var subT in Orders)
            {
                total += subT.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client ");
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items: ");
            foreach (var item in Orders)
            {
                sb.AppendLine(item.ToString());
            }
            sb.Append("Total price: ");
            sb.AppendLine(Total().ToString());
            return sb.ToString();
        }
    }
}
