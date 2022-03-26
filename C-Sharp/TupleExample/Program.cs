using TupleExample;

Customer[] customers = new Customer[3];
Order[] orders = new Order[3];
Customer customer1 = new Customer { Id=1,Name="Mynul Islam",Address="Madaripur"};
Customer customer2 = new Customer { Id = 2, Name = "Soad", Address = "Rjor" };
Customer customer3 = new Customer { Id = 3, Name = "Saikoth", Address = "Mostofapur" };
Order order1 = new Order { Id = 1, CustomerId = 1, TotalAmount = 800, OrderDate = new DateTime(2022, 03, 11) };
Order order2 = new Order { Id = 2, CustomerId = 2, TotalAmount = 400, OrderDate = new DateTime(2022, 03, 12) };
Order order3 = new Order { Id = 3, CustomerId = 3, TotalAmount = 300, OrderDate = new DateTime(2022, 03, 13) };

customers[0]= customer1;
customers[1]= customer2;   
customers[2]= customer3;

orders[0]= order1;    
orders[1]= order2;
orders[2]= order3;

(string name, double amount)[] data = new (string, double)[3];
int index=0;
for (int i = 0; i < orders.Length; i++)
{
    if (orders[i].TotalAmount > 500)
    {
        for (int j = 0; j < customers.Length; j++)
        {
            if (orders[i].Id == customers[j].Id)
            {
                data[index++] = (customers[j].Name, orders[i].TotalAmount);
            }
        }
    }
}
for (int i = 0; i < index; i++)
{
    Console.WriteLine($"Customer name {data[i].name},and total amount {data[i].amount}");
}