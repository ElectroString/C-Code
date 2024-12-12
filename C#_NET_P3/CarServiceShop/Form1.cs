/*
 * Cam Davies
 * 28/10/2024
 * A simple program to track Car services
 */





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceShop
{
    public partial class Form1 : Form
    {
        List<Service> services = new List<Service>();
        // Phone Number constants
        long MAX_PHONE_NUMBER = 9999999999;
        int MIN_PHONE_NUMBER = 1000000000;

        // Service States
        bool engineService = false;
        bool transmissionService = false;
        bool filterService = false;

        // Declare Price Constants
        decimal ENGINE_SERVICE_PRICE = 60m;
        decimal TRANSMISSION_SERVCICE_PRICE = 120m;
        decimal AIR_FILTER_SERVICE_PRICE = 40.5m;
        decimal TAX = 1.13m; // Feel Free to change the Tax Amount (Currently at 13%)


        // Initializes The Form
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
            SetDefaults();
        }


        private void Check_box_Engine_SelectedIndexChanged(object sender, EventArgs e)
        {
 

        }




        // Recalculates price and updates engine service state when checked/unchecked
        private void Check_Box_Engine_CheckedChanged(object sender, EventArgs e)
        {
            if (engineService)
            {
                engineService = false;
                CalculatePrice(-(ENGINE_SERVICE_PRICE*TAX));
            }
            else
            {
                engineService = true;
                CalculatePrice(ENGINE_SERVICE_PRICE * TAX);
            }
        }

        // Recalculates price and updates Transmission service state when checked/unchecked
        private void checkBoxTransmission_CheckedChanged(object sender, EventArgs e)
        {
            if (transmissionService)
            {
                transmissionService = false;
                CalculatePrice(-(TRANSMISSION_SERVCICE_PRICE*TAX));
            }
            else
            {
                transmissionService = true;
                CalculatePrice(TRANSMISSION_SERVCICE_PRICE * TAX);
            }
        }

        // Recalculates price and updates Air Filter service state when checked/unchecked
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (filterService)
            {
                filterService = false;
                CalculatePrice(-(AIR_FILTER_SERVICE_PRICE*TAX));
            }
            else
            {
                filterService = true;
                CalculatePrice(AIR_FILTER_SERVICE_PRICE * TAX);
            }
        }


        // Adds a new service to the list when the "Add" Button is Clicked
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (isValid())
            {
                Service service = new Service(txtBoxFirstName.Text, txtBoxLastName.Text, Convert.ToInt64(txtBoxPhone.Text), comboBoxMake.SelectedItem.ToString(), txtBoxModel.Text, txtBoxColour.Text, Convert.ToInt32(comboBoxYear.SelectedItem.ToString()), engineService, transmissionService, filterService, Convert.ToDecimal(txtBoxCost.Text));
                          
                services.Add(service);

                RefreshList();
                SetDefaults();
             }
        }

        // Removed the selected item from the list when "Remove" button is pressed
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                services.RemoveAt(listView1.SelectedIndices[0]);
                RefreshList();
                SetDefaults();
            }
            else
            {
                MessageBox.Show("No Item Selected");
            }
        }

        // Updates the selected item with specified updates when "Update" button is pressed
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                if (isValid())
                {
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].FirstName = txtBoxFirstName.Text;
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].LastName = txtBoxLastName.Text;
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].model = txtBoxModel.Text;
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].colour = txtBoxColour.Text;

                    services[Convert.ToInt32(listView1.SelectedIndices[0])].PhoneNumber = txtBoxPhone.Text;
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].price = txtBoxCost.Text;

                    services[Convert.ToInt32(listView1.SelectedIndices[0])].make = comboBoxMake.Text;
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].year = comboBoxYear.Text;

                    services[Convert.ToInt32(listView1.SelectedIndices[0])].engOilChange = engineService.ToString();
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].transOilChange = transmissionService.ToString();
                    services[Convert.ToInt32(listView1.SelectedIndices[0])].airFilterChange = filterService.ToString();
                    RefreshList();
                    SetDefaults();
                }
            }
            else
            {
                MessageBox.Show("No Items Selected");
            }
        }

        // Resets Input Fields when "New" Button is pressed
        private void btnNew_Click(object sender, EventArgs e)
        {
            SetDefaults();
            listView1.SelectedIndices.Clear();
        }

        // Removes all items in the list when "Remove All" button is pressed
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            services.Clear();
            SetDefaults();
        }

        // Exits the program when the "Exit" button is pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            SetDefaults();
            this.Close();
        }

        // Checked if each of the input fields are valid
        private bool isValid()
        {

            if (String.IsNullOrWhiteSpace(txtBoxFirstName.Text)){
                MessageBox.Show("Error: First Name Cannot Be Blank");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtBoxLastName.Text))
            {
                MessageBox.Show("Error: Last Name Cannot Be Blank");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtBoxModel.Text))
            {
                MessageBox.Show("Error: Model Cannot Be Blank");
                return false;
            }
            if (String.IsNullOrWhiteSpace(txtBoxColour.Text))
            {
                MessageBox.Show("Error: Colour Cannot Be Blank");
                return false;
            }
            try
            {
                long phone = System.Convert.ToInt64(txtBoxPhone.Text);
                if (phone > MAX_PHONE_NUMBER || phone < MIN_PHONE_NUMBER)
                {
                    MessageBox.Show("Error: PhoneNumber must be 10 digits");
                    return false;
                }
            }
            catch 
            {
                MessageBox.Show("Error: Phone Number must be numeric");
                return false;
            }
            return true;
        }


        // Populates the Combo Boxes with data
        private void PopulateComboBoxes()
        {
            comboBoxMake.Items.Add("Kia");
            comboBoxMake.Items.Add("Honda");
            comboBoxMake.Items.Add("GMC");
            comboBoxMake.Items.Add("Ford");

            for (int i = 2024; i > 2003; i--)
            {
                comboBoxYear.Items.Add(i.ToString());
            }

        }


        //Adds the specified price to the current price and displays result
        private void CalculatePrice(decimal price)
        {
            decimal newprice = Math.Round((Convert.ToDecimal(txtBoxCost.Text) + price),2);
            txtBoxCost.Text = newprice.ToString();
        }

        // Sets all input fields to their default States
        private void SetDefaults()
        {
            txtBoxFirstName.Text = string.Empty;
            txtBoxLastName.Text = string.Empty;
            txtBoxModel.Text = string.Empty;
            txtBoxPhone.Text = string.Empty;
            txtBoxColour.Text = string.Empty;

            comboBoxMake.SelectedIndex = 0;
            comboBoxYear.SelectedIndex = 0;

            Check_Box_Engine.Checked = false;
            engineService = false;
            checkBoxTransmission.Checked = false;
            transmissionService = false;
            checkBoxFilter.Checked = false;
            filterService = false;

            txtBoxCost.Text = "0";
        }
        // Refreshes the listView, adding all items in the list of Services
        private void RefreshList()
        {
            listView1.Items.Clear();
            foreach (Service service in services)
            {
                ListViewItem item = new ListViewItem(service.identificationNumber);
                item.SubItems.Add(service.FirstName);
                item.SubItems.Add(service.LastName);
                item.SubItems.Add(service.PhoneNumber);
                item.SubItems.Add(service.make);
                item.SubItems.Add(service.model);
                item.SubItems.Add(service.year);
                item.SubItems.Add(service.colour);
                item.SubItems.Add(service.engOilChange);
                item.SubItems.Add(service.transOilChange);
                item.SubItems.Add(service.airFilterChange);
                item.SubItems.Add(service.price);
                listView1.Items.Add(item);
            }
        }

        // Fills in the input fields with the selected Item when it is clicked
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0) {
                txtBoxFirstName.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].FirstName;
                txtBoxLastName.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].LastName;
                txtBoxPhone.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].PhoneNumber;
                txtBoxModel.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].model;
                txtBoxColour.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].colour;

                if (Convert.ToBoolean(services[Convert.ToInt32(listView1.SelectedIndices[0])].engOilChange) == true)
                {
                    Check_Box_Engine.Checked = true;

                }
                else
                {
                    Check_Box_Engine.Checked = false;
                }

                if (Convert.ToBoolean(services[Convert.ToInt32(listView1.SelectedIndices[0])].transOilChange) == true)
                {
                    checkBoxTransmission.Checked = true;
                }
                else
                {
                    checkBoxTransmission.Checked = false;
                }

                if (Convert.ToBoolean(services[Convert.ToInt32(listView1.SelectedIndices[0])].airFilterChange) == true)
                {
                    checkBoxFilter.Checked = true;
                }
                else
                {
                    checkBoxFilter.Checked = false;
                }

                comboBoxMake.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].make;
                comboBoxYear.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].year;

                txtBoxCost.Text = services[Convert.ToInt32(listView1.SelectedIndices[0])].price;
            }
        }


    }
}
