namespace Ashton_Wray_C968
{
    // Outsourced class inherits from Part
    public class Outsourced : Part
    {
        // Fields
        private string _companyName;

        // Getters and setters
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        // Empty constructor
        public Outsourced()
        {

        }

        // Constructor with parameters for all fields
        public Outsourced(int partId, string name, decimal price, int inventory, int min, int max,
            string companyName)
        {
            PartId = partId;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }

        // Constructor with parameters for all fields except companyName
        public Outsourced(int partId, string name, decimal price, int inventory, int min, int max)
        {
            PartId = partId;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
        }
    }
}
