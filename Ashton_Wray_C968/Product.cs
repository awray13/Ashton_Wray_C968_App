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
        public bool RemoveAssociatedPart(int partId)
        {
            bool partRemoved = false;

            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    AssociatedParts.Remove(part);
                    partRemoved = true;
                }
                else
                {
                    partRemoved = false;
                }
            }
            return partRemoved;
        }

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
    }
}
