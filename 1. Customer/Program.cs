using System;
namespace Customer
{
    interface ICustomerManager
    {
        void addCustomer(int id);
        void deleteCustomer(int id);
        void findCustomer(string title);
        void updateCustomer(int id);
    }
    class Customer
    {
        public Customer(int id, string name, string address, int salary)
        {
            ID = id;
            Name = name;
            Address = address;
            Salary = salary;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }
    }
    class CustomerManager : ICustomerManager
    {
        private Customer[] myCustomer;
        private int flag;
        public void addCustomer(int id)
        {
            flag = 0;
            Console.WriteLine("33");
            foreach (Customer item in myCustomer)
            {
                Console.WriteLine("36");
                if (item.ID == id)
                {
                    flag = 1;
                    Console.WriteLine("Customer ID Exists..!");
                    break;
                }
            }
            if (flag == 0)
            {
                Customer temp = new Customer(16, "Sohel", "Mysore", 10000);
                myCustomer[0].ID = temp.ID;
                myCustomer[0].Name = temp.Name;
                myCustomer[0].Address = temp.Address;
                myCustomer[0].Salary = temp.Salary;
            }
        }
        public void deleteCustomer(int id)
        {

        }
        public void findCustomer(string name)
        {
            foreach (Customer item in myCustomer)
            {
                if (name == item.Name)
                {
                    Console.WriteLine("{0}  {1}  {2}  {4}", item.ID, item.Name, item.Address, item.Salary);
                }
            }
        }
        public void updateCustomer(int id)
        {

        }
    }
    class ICustomerManagerMain
    {
        static void Main(string[] args)
        {
            CustomerManager mngr = new CustomerManager();
            mngr.addCustomer(10);
            mngr.findCustomer("C#");
        }
    }
}