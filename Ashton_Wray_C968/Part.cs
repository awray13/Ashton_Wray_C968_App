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

        public string PartName
        {
            get { return _partName; }
            set { _partName = value; }
        }

        public decimal PartPrice
        {
            get { return _partPrice; }
            set { _partPrice = value; }
        }

        public int PartInStock
        {
            get { return _partInStock; }
            set { _partInStock = value; }
        }

        public int PartMin
        {
            get { return _partMin; }
            set { _partMin = value; }
        }

        public int PartMax
        {
            get { return _partMax; }
            set { _partMax = value; }
        }
    }
}
