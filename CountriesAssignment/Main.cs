using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountriesAssignment
{
    public partial class Main : Form
    {
        //Class members
        private CountryTree CTree;
        private Country SpecificCountry;

        //Class constructor
        public Main()
        {
            InitializeComponent();
        }

        //Code in this method is executed when the form is first loaded
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //Displays the number of countries & the height of the tree
        //in the General Information section
        private void LoadGeneralInformation()
        {
            if (CTree != null) //Check there's actually a CountryTree
            {
                //Convert ints to strings so they can be displayed in textboxes
                NoOfCountriesText.Text = CTree.Count().ToString();
                TreeHeightText.Text = CTree.Height().ToString();
            }
        }

        //Identifies which country has been selected from the list
        //and then loads all of that country's information
        private void LoadSpecificCountry(Country selectedCountry)
        {
            CountriesList.SelectedItem = selectedCountry;
            SpecificCountry = selectedCountry;
            LoadCountryInformation();
        }

        //Displays all the fields for a selected country
        //in the 'View/Edit Country Information' section
        private void LoadCountryInformation()
        {
            if (CTree != null && SpecificCountry != null) //Check there's actually a CountryTree and also Country selected
            {
                //Fields converted to string where necessary
                CountryNameText.Text = SpecificCountry.Name;
                GDPText.Text = SpecificCountry.GDPGrowth.ToString();
                InflationText.Text = SpecificCountry.Inflation.ToString();
                TradeBalanceText.Text = SpecificCountry.TradeBalance.ToString();
                HDIText.Text = SpecificCountry.HDIRanking.ToString();
                TradePartnersList.DataSource = SpecificCountry.MainTradePartners;
                //TODO: trade potential
            } else
            {
                //Clear textboxes
                CountryNameText.Clear();
                GDPText.Clear();
                InflationText.Clear();
                TradeBalanceText.Clear();
                HDIText.Clear();
                TradePartnersList.DataSource = null;
            }

        }

        //Updates all information displayed on screen
        private void UpdateAllInfo()
        {
            if (CTree == null)
                return;
            CountriesList.DataSource = CTree.CreateCountryArray(); //Refresh the list of countries in case country is added/deleted
            LoadGeneralInformation();
            LoadCountryInformation();
        }

        //Loads the CSV database
        //Puts the countries into a CountryTree (AVLTree) with each node being of type Country  
        //Makes use of dictionary and lamda expressions
        private void LoadCSVDatabase(string FilePath)
        {
            try
            {
                //File path for the CSV database
                /*string FilePath = @"C:\Users\Faran\Desktop\countries.csv";

                if (File.Exists(FilePath))
                {
                    Console.WriteLine("Database file found.");
                }
                else
                {
                    Console.WriteLine("The database file could not be found!");
                    throw new FileNotFoundException();
                }*/

                //All lines from the CSV file get stored in an array of type string
                string[] CSVLines = File.ReadAllLines(FilePath);

                //Create the CountryTree with the column headers
                CTree = new CountryTree(CSVLines[0].Split(','));

                var Data = CSVLines.Skip(1).ToArray();

                //Wrong format - was causing errors
                /*var CountriesQuery = (from CSVLine in CSVLines let Data = CSVLines.Skip(1).ToArray() select CSVLine.Split(',')).ToDictionary(keys => keys[0], keys => new Country(keys[0],
                             double.Parse(keys[1]),
                             double.Parse(keys[2]),
                             double.Parse(keys[3]),
                             double.Parse(keys[4])
                             ));*/

                var CountriesQuery = (from CSVLine in Data where CSVLine.Trim().Length != 0 select CSVLine.Split(',')).ToDictionary(
                    keys => keys[0], keys => new Country(keys[0], double.Parse(keys[1]), double.Parse(keys[2]), double.Parse(keys[3]), double.Parse(keys[4]))
                );

                int counter = 0;
                foreach (var Country in CountriesQuery)
                {
                    string tradingPartners = CSVLines.Skip(1).ToArray()[counter].Split(',')[5];
                    tradingPartners = tradingPartners.Substring(1, tradingPartners.Length - 2);
                    string[] tradingPartnersArray = tradingPartners.Split(';');
                    Country.Value.MainTradePartners = tradingPartnersArray.Select(tradingPartner => CountriesQuery[tradingPartner]).ToArray();
                    CTree.InsertItem(Country.Value); //Gets the value in the key/value pair and inserts into the CountryTree
                    counter++;
                }

                //Tree has been set up so display all data
                UpdateAllInfo();
            }
            catch (Exception)
            {
                MessageBox.Show(@"There was an error loading the database!");
                CTree = null; //Delete the tree created
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Are you sure you want to close this window?", "International Trading Data", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void OpenDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Dialog = new OpenFileDialog
            {
                Filter = @"CSV files (*.csv)|*.csv", //Show CSV files in the dialogue
                CheckFileExists = true, //Check the file actually exists
                Multiselect = false //Only one file is required

            };
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                LoadCSVDatabase(Dialog.FileName);
            }
            if (Dialog.FileName == string.Empty) //Prompt the user if they haven't selected a CSV file
            {
                MessageBox.Show(
                    @"A database hasn't been selected.",
                    @"Warning",
                    MessageBoxButtons.OK);
            }
        }

        private void CountriesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the currently selected item in the ListBox.
            string curItem = CountriesList.SelectedItem.ToString();

            //MessageBox.Show(curItem);
            Console.WriteLine(curItem);

            //Get reference from where event was fired from using object sender
            //Load the specific country that was selected from the ListBox
            //This part can be quite buggy for some reason
            LoadSpecificCountry((Country)((ListBox)sender).SelectedItem);
        }

        //When the user types something in the search textbox, update the search results in the list
        private void SearchCountryText_TextChanged(object sender, EventArgs e)
        {
            CountriesList.DataSource = CTree.SearchCountry(SearchCountryText.Text);
        }

        private void DeleteCountryButton_Click(object sender, EventArgs e)
        {
            DialogResult DialogResult = MessageBox.Show("Are you sure you want to delete this country?", "Caution", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes && SpecificCountry != null) //Have to select a country to be able to delete one
            {
                CTree.RemoveItem(SpecificCountry);
                UpdateAllInfo();
            }
            else if (DialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void SaveNewCountryButton_Click(object sender, EventArgs e)
        {
            //Check the user has filled the textboxes in - basic/naive validation implementation but better than nothing
            if (CTree.ContainsCountry(CountryNameText.Text))
            {
                MessageBox.Show("This country is already in the database. Use the search function to find and edit details.");
                return;
            }
            else if (string.IsNullOrEmpty(CountryNameText.Text))
            {
                CountryNameText.Focus();
                MessageBox.Show("Please enter a country name.");
            }
            else if (string.IsNullOrEmpty(GDPText.Text))
            {
                GDPText.Focus();
                MessageBox.Show("Please enter GDP growth.");
            }
            else if (string.IsNullOrEmpty(InflationText.Text))
            {
                InflationText.Focus();
                MessageBox.Show("Please enter inflation.");
            }
            else if (string.IsNullOrEmpty(TradeBalanceText.Text))
            {
                TradeBalanceText.Focus();
                MessageBox.Show("Please enter trade balance.");
            }
            else if (string.IsNullOrEmpty(GDPText.Text))
            {
                GDPText.Focus();
                MessageBox.Show("Please enter a country name.");
            }
            else if (string.IsNullOrEmpty(HDIText.Text))
            {
                HDIText.Focus();
                MessageBox.Show("Please enter HDI ranking.");
            }
            else
            {
                //Passed validation checks
                //Convert textbox strings to appropiate data type before passing as parameters to InsertItem
                CTree.InsertItem(new Country(CountryNameText.Text, double.Parse(GDPText.Text), double.Parse(InflationText.Text), double.Parse(TradeBalanceText.Text), double.Parse(HDIText.Text)));
                MessageBox.Show("Added to the tree/database.", CountryNameText.Text);
                UpdateAllInfo();
            }  
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            //Check to see if a country has been selected, can't ammend the details of a country not selected
            if (SpecificCountry != null)
            {
                SpecificCountry.GDPGrowth = double.Parse(GDPText.Text);
                SpecificCountry.Inflation = double.Parse(InflationText.Text);
                SpecificCountry.TradeBalance = double.Parse(TradeBalanceText.Text);
                SpecificCountry.HDIRanking = double.Parse(HDIText.Text);
                SpecificCountry.MainTradePartners = (Country[]) TradePartnersList.DataSource; //Grab the trading partners from the listbox & cast to a Country array
                MessageBox.Show("Details have been ammended.");
            }
            else
            {
                MessageBox.Show("Please use the search function to find the country you wish to ammend.");
            }
        }

        private void AddPartnerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not working :(");
        }

        private void DelPartnerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not working :(");
        }
    }
}
