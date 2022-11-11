using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Inventory
{
    public partial class frmAddProduct : Form
    {
        //Custom Exceptions
        class NumberFormatException : Exception 
        {
            public NumberFormatException(string quantity) : base(quantity) { }
        }

        class StringFormatException : Exception 
        {
            public StringFormatException(string name) : base(name) { }
        }

        class CurrencyFormatException : Exception 
        {
            public CurrencyFormatException(string price) : base(price) { }
        }

        //Inintialized Variable
        private int _Quantity;
        private double _SellPrice;
        private string _ProductName, _Category, _MfgDate, _ExpDate, _Description;
        
        // Initialized BindingSource
        BindingSource showProductList;

        public frmAddProduct()
        {
            InitializeComponent();

            showProductList = new BindingSource();
        }

        private void frmAddProduct_Load(object sender, EventArgs e)         
        {
            //Declaring Array Values
            string[] ListOfProductCategory = new string[]
            {
                "Beverages", "Bread / Bakery",
                "Canned / Jarred Goods",
                "Dairy",
                "Frozen Goods",
                "Personal Care",
                "Öther"
            };

            //foreach loop that will iterate the value inside an array and add it to combo box option
            foreach (string variableName in ListOfProductCategory)
            {
                cbCategory.Items.Add(variableName);
            }
        }
        
        //Try Catch
        public string Product_Name(string name)
        {
            try
            {
                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new StringFormatException(name);
                }
            }
            catch (StringFormatException sfe) 
            {
                MessageBox.Show("String Format input in product name. " + sfe.Message);
            }
            finally 
            {
                Console.WriteLine("Input string only in product name");
            }
            return name;
        }
        public int Quantity(string qty)
        {

            try
            {
                if (!Regex.IsMatch(qty, @"^[0-9]"))
                {
                    throw new NumberFormatException(qty);
                }
            }
            catch (NumberFormatException nfe)
            {
                MessageBox.Show("String Format input in product name. " + nfe.Message);
            }
            return Convert.ToInt32(qty);
        }
        public double SellingPrice(string price)
        {
            try
            {
                if (!Regex.IsMatch(price.ToString(), @"^(\d*\.)?\d+$"))
                {
                    throw new CurrencyFormatException(price);
                }
            }
            catch (CurrencyFormatException cfe)
            {
                MessageBox.Show("String Format input in product name. " + cfe.Message);
            }
            return Convert.ToDouble(price);
        }

        //When the user clicked the add product button it will call this method
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //Calling methods and assigning values
            _ProductName = Product_Name(txtProductName.Text);
            _Category = cbCategory.Text;
            _MfgDate = dtPickerMfgDate.Value.ToString("yyyy-mm-dd");
            _ExpDate = dtPickerExpDate.Value.ToString("yyyy-mm-dd");
            _Description = richTextDescription.Text;
            _Quantity = Quantity(txtQuantity.Text);
            _SellPrice = SellingPrice(txtSellPrice.Text);

            //Adding Values to product list binding source
            showProductList.Add(new ProductClass(_ProductName, _Category, _MfgDate, _ExpDate, _SellPrice, _Quantity, _Description)); 
            
            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.DataSource = showProductList;


        }


    }
}
