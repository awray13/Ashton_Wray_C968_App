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
        public InHouse(int partId, string name, decimal price, int inventory, int min, int max,
            int machineId)
        {
            PartId = partId;
            Name = name;
            Price = price;
            Inventory = inventory;
            Min = min;
            Max = max;
            MachineId = machineId;
        }

        // Constructor with parameters for all fields except machineId
        public InHouse(int partId, string name, decimal price, int inventory, int min, int max)
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
