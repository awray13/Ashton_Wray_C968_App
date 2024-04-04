using System.ComponentModel;
using System.Windows.Forms;

namespace Ashton_Wray_C968
{
    public class Inventory
    {
        // Attributes for Products and AllParts
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();

        // Populates the inventory with sample data
        public static void PopulateInventory()
        {
            // Add sample parts
            InHouse part1 = new InHouse();
            part1.PartId = 1;
            part1.Name = "Nails";
            part1.Price = 10.00M;
            part1.Inventory = 5;
            part1.Min = 1;
            part1.Max = 10;
            part1.MachineId = 1;
            AllParts.Add(part1);

            Outsourced part2 = new Outsourced();
            part2.PartId = 2;
            part2.Name = "Gravel";
            part2.Price = 20.00M;
            part2.Inventory = 10;
            part2.Min = 1;
            part2.Max = 20;
            part2.CompanyName = "Lowes";
            AllParts.Add(part2);

            InHouse part3 = new InHouse();
            part3.PartId = 3;
            part3.Name = "Hammer";
            part3.Price = 30.00M;
            part3.Inventory = 15;
            part3.Min = 1;
            part3.Max = 30;
            part3.MachineId = 2;
            AllParts.Add(part3);

            Outsourced part4 = new Outsourced();
            part4.PartId = 4;
            part4.Name = "Oil";
            part4.Price = 40.00M;
            part4.Inventory = 20;
            part4.Min = 1;
            part4.Max = 40;
            part4.CompanyName = "Advanced Auto";
            AllParts.Add(part4);

            // Add sample products
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.ProductName = "Yellow Scooter";
            product1.ProductPrice = 1000.00M;
            product1.ProductInStock = 5;
            product1.ProductMin = 1;
            product1.ProductMax = 10;
            product1.AddAssociatedPart(part1);
            product1.AddAssociatedPart(part2);
            Products.Add(product1);

            Product product2 = new Product();
            product2.ProductId = 2;
            product2.ProductName = "Green Scooter";
            product2.ProductPrice = 2000.00M;
            product2.ProductInStock = 10;
            product2.ProductMin = 1;
            product2.ProductMax = 20;
            product2.AddAssociatedPart(part3);
            product2.AddAssociatedPart(part4);
            Products.Add(product2);

            Product product3 = new Product();
            product3.ProductId = 3;
            product3.ProductName = "Red Scooter";
            product3.ProductPrice = 3000.00M;
            product3.ProductInStock = 15;
            product3.ProductMin = 1;
            product3.ProductMax = 30;
            product3.AddAssociatedPart(part1);
            product3.AddAssociatedPart(part2);
            Products.Add(product3);

            Product product4 = new Product();
            product4.ProductId = 4;
            product4.ProductName = "Blue Scooter";
            product4.ProductPrice = 4000.00M;
            product4.ProductInStock = 20;
            product4.ProductMin = 1;
            product4.ProductMax = 40;
            product4.AddAssociatedPart(part3);
            product4.AddAssociatedPart(part4);
            Products.Add(product4);
        }

        // Adds a product to the inventory
        public static void AddProduct(Product product)
        {
            Products.Add(product);
        }

        // Removes a product from the inventory
        public static bool RemoveProduct(int productId)
        {
            foreach (Product product in Products)
            {
                if (product.ProductId == productId)
                {
                    Products.Remove(product);
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal failed!");
                    return false;
                }
            }
            return false;
        }

        // Looks up a product in the inventory
        public static Product LookupProduct(int productId)
        {
            foreach (Product product in Products)
            {
                if (product.ProductId == productId)
                {
                    return product;
                }
            }
            Product voidProduct = new Product();
            return voidProduct;
        }

        // Updates a product in the inventory
        public static void UpdateProduct(int productId, Product product)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductId == productId)
                {
                    Products[i] = product;
                }
            }
        }

        // Adds a part to the inventory
        public static void AddPart(Part part)
        {
            AllParts.Add(part);
        }

        // Removes a part from the inventory
        public static bool DeletePart(int partId)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartId == partId)
                {
                    AllParts.Remove(part);
                    return true;
                }
                else
                {
                    MessageBox.Show("ERROR: Removal failed!");
                    return false;
                }
            }
            return false;
        }

        // Looks up a part in the inventory
        public static Part LookupPart(int partId)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            Part voidPart = new Outsourced();
            return voidPart;
        }

        // Updates a part in the inventory
        public static void UpdatePart(int partId, Part part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartId == partId)
                {
                    AllParts[i] = part;
                }
            }
        }

        // Returns all parts in the inventory
        public static BindingList<Part> AllPartsList()
        {
            return AllParts;
        }

        // Helper method to get the next available part ID
        public static int CalculatePartId()
        {
            int result = Inventory.AllParts.Count + 1;
            bool isUnique = false;

            while (!isUnique)
            {
                isUnique = true;
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (result == Inventory.AllParts[i].PartId)
                    {
                        result++;
                        isUnique = false;
                        break;
                    }
                }
            }

            return result;
        }

        // Helper method to get the next available product ID
        public static int CalculateProductId()
        {
            int result = Inventory.Products.Count + 1;
            bool isUnique = false;

            while (!isUnique)
            {
                isUnique = true;
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (result == Inventory.Products[i].ProductId)
                    {
                        result++;
                        isUnique = false;
                        break;
                    }
                }
            }

            return result;
        }

    }
}
