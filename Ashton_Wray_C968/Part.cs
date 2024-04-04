namespace Ashton_Wray_C968
{
    // Part class
    public abstract class Part
    {
        // Fields
        private int _partId;
        private string _partName;
        private decimal _partPrice;
        private int _partInStock;
        private int _partMin;
        private int _partMax;

        // Getters and setters
        public int PartId
        {
            get { return _partId; }
            set { _partId = value; }
        }

        public string Name
        {
            get { return _partName; }
            set { _partName = value; }
        }

        public decimal Price
        {
            get { return _partPrice; }
            set { _partPrice = value; }
        }

        public int Inventory
        {
            get { return _partInStock; }
            set { _partInStock = value; }
        }

        public int Min
        {
            get { return _partMin; }
            set { _partMin = value; }
        }

        public int Max
        {
            get { return _partMax; }
            set { _partMax = value; }
        }
    }
}
