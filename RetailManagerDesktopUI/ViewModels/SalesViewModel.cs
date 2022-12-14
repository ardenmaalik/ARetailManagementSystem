using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailManagerDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        private BindingList<string> _products;
        public BindingList<string> Products
        {
            get { return _products; }
            set 
            { 
                _products = value;
                NotifyOfPropertyChange(() => Products);
            }
        }

        private string _itemQuantity;
        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            {
                _itemQuantity = value; 
                    NotifyOfPropertyChange(() => Products);
            }
        }

        public string SubTotal
        {
            // TODO: Replace with calculation 
            get {
                return "$0.00"; 
            }
        } 
        public string Tax
        {
            // TODO: Replace with calculation 
            get {
                return "$0.00"; 
            }
        } 
        
        public string Total
        {
            // TODO: Replace with calculation 
            get {
                return "$0.00"; 
            }
        }


        private BindingList<string> _cart;
        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected
                // Make sure there is an item quantity
                return output;

            }
        }

        public void AddToCart()
        {

        }
        public bool CanRemoveFromCart
        {
            get
            {
                bool output = false;

                // Make sure something is selected

                return output;

            }
        }
        public void RemoveFromCart()
        {

        }

       public bool CanCheckout
        {
            get
            {
                bool output = false;

                // Make sure there is something in the cart

                return output;
            }
        }

        public void Checkout()
        {

        }

    }
}
