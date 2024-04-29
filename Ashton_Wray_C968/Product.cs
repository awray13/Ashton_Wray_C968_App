using System.ComponentModel;

namespace Ashton_Wray_C968
{
    // Product class
    public class Product
    {
        // Attributes for Product class
        private int _productId;
        private string _productName;
        private decimal _productPrice;
        private int _productInStock;
        private int _productMin;
        private int _productMax;

        // BindingList of Parts for AssociatedParts attribute
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        // Getters and setters
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        public decimal ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }

        public int ProductInStock
        {
            get { return _productInStock; }
            set { _productInStock = value; }
        }

        public int ProductMin
        {
            get { return _productMin; }
            set { _productMin = value; }
        }

        public int ProductMax
        {
            get { return _productMax; }
            set { _productMax = value; }
        }

        // Change the product price to a string and display as currency
        public string ProductPriceString
        {
            get { return _productPrice.ToString("C"); }
        }

        // Empty constructor
        public Product()
        {

        }

        // Constructor with parameters for all fields
        public Product(int productId, string productName, decimal productPrice, int productInStock, int productMin,
            int productMax)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductInStock = productInStock;
            ProductMin = productMin;
            ProductMax = productMax;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        // Removes a part from the AssociatedParts list
        // Only removes the part if the partId matches the partId of the part to be removed and isn't associated with any Products


        public Part LookupAssociatedPart(int partId)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }
        // Removes a part from the AssociatedParts list
        public bool RemoveAssociatedPart(int partId)
        {
            bool partRemoved = false;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId && !IsPartAssociatedWithProduct(part))
                {
                    AssociatedParts.Remove(part);
                    partRemoved = true;
                    break;
                }
            }

            return partRemoved;
        }

        // Checks if a part is associated with any Product
        private bool IsPartAssociatedWithProduct(Part part)
        {
            foreach (Product product in Inventory.Products)
            {
                if (product.AssociatedParts.Contains(part))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
