﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private ObjectSource _source = new ObjectSource();
        private BindingSource _categoriesBindingSource = new BindingSource();
        private BindingSource _productsBindingSource = new BindingSource();

        private void DataForm_Load(object sender, EventArgs e)
        {
            _categoriesBindingSource.DataSource = _source.GetCategories();

            CategoryToolStripComboBox.DisplayMember = "CategoryName";
            CategoryToolStripComboBox.ValueMember = "CategoryID";
            CategoryToolStripComboBox.DataSource = _categoriesBindingSource;

            ProductsDataGridView.DataSource = _productsBindingSource;
            ProductsListBox.DataSource = _productsBindingSource;
            ProductsListBox.DisplayMember = "ProductName";

            NameTextBox.DataBindings.Add("Text", _productsBindingSource, "ProductName");
            //QuantityTextBox.DataBindings.Add("Text", _productsBindingSource, "QuantityPerUnit");
            PriceTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitPrice");
            StockTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsInStock");
            //OrderTextBox.DataBindings.Add("Text", _productsBindingSource, "UnitsOnOrder");
            //DiscontinuedCheckBox.DataBindings.Add("Checked", _productsBindingSource, "Discontinued");
        }

        private void CategoryToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var catId = Convert.ToInt32(CategoryToolStripComboBox.SelectedValue);
            _productsBindingSource.DataSource = _source.GetProducts(catId);
        }
    }
}
