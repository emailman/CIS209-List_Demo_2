using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace List_Demo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load an inventory of cars into the list box
            var inventory = new List<Car>
            {
                new Car("Fit", 4, "Red", "LX"),
                new Car("Civic", 4, "Blue", "EX"),
                new Car("Civic", 4, "Blue", "EX")
            };

            lbxNewCars.Items.AddRange(inventory.ToArray());
        }

        private void lbxNewCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Has an item been selected from the list?
            if (lbxNewCars.SelectedIndex != -1)
                // Provide an OK-Cancel dialog to complete the sale
                if (MessageBox.Show($"Selling {lbxNewCars.SelectedItem}?",
                    "Honda Auto Land",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)

                    // If OK selected, remove the item from the inventory
                    lbxNewCars.Items.RemoveAt(lbxNewCars.SelectedIndex);
        }
    }

    class Car
    {
        readonly string model;
        readonly int cylinders;
        readonly string color;
        readonly string trim;

        public Car(string _model, int _cylinders, string _color, string _trim)
        {
            model = _model;
            cylinders = _cylinders;
            color = _color;
            trim = _trim;
        }

        public override string ToString()
        {
            return $"{model} {trim}\t{cylinders} cyl  {color} ";
        }
    }
}
