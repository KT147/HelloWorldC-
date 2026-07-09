namespace OOP
{
    internal class Customer

    {
        private static int nextId = 1;

        private readonly int _id;

        private string _password;

        public string Password { set
            {
                _password = value;
        } }

        public int Id
        {
            get
            { return _id; }
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        //ctor

        public Customer()
        {
            _id = nextId++;
            Name = "New Customer";
            Address = "No Address";
            ContactNumber = "No number";
        }

        public Customer(string name, string address = "NA", string contactNumber = "NA")
        {
            _id = nextId++;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public void SetDetails(string name, string address, string contactNumber = "NA")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        public static void DoSomeStuff()
        {
            System.Console.WriteLine("Im doing some stuff");
        }

        public void GetDetails()
        {
            Console.WriteLine("Customer name " + Name + " and id: " + _id);
        }
    }
}