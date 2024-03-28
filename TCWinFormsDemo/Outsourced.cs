namespace TCWinFormsDemo
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
        public Outsourced(int partId, string partName, decimal partPrice, int partInStock, int partMin, int partMax,
            string companyName)
        {
            PartId = partId;
            PartName = partName;
            PartPrice = partPrice;
            PartInStock = partInStock;
            PartMin = partMin;
            PartMax = partMax;
            CompanyName = companyName;
        }

        // Constructor with parameters for all fields except companyName
        public Outsourced(int partId, string partName, decimal partPrice, int partInStock, int partMin, int partMax)
        {
            PartId = partId;
            PartName = partName;
            PartPrice = partPrice;
            PartInStock = partInStock;
            PartMin = partMin;
            PartMax = partMax;
        }
    }
}
