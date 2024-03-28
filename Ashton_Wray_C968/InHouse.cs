namespace Ashton_Wray_C968
{
    // InHouse class inherits from Part
    public class InHouse : Part
    {
        // Fields
        private int _machineId;

        // Getters and setters
        public int MachineId
        {
            get { return _machineId; }
            set { _machineId = value; }
        }

        // Empty constructor
        public InHouse()
        {

        }

        // Constructor with parameters for all fields
        public InHouse(int partId, string partName, decimal partPrice, int partInStock, int partMin, int partMax,
            int machineId)
        {
            PartId = partId;
            PartName = partName;
            PartPrice = partPrice;
            PartInStock = partInStock;
            PartMin = partMin;
            PartMax = partMax;
            MachineId = machineId;
        }

        // Constructor with parameters for all fields except machineId
        public InHouse(int partId, string partName, decimal partPrice, int partInStock, int partMin, int partMax)
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
