using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesAssignment
{
    //Create an AVLTree where the nodes are Country objects
    class CountryTree : AVLTree<Country>
    {
        //Class members
        private string[] CSVColumnHeaders;

        //Constructor - inherit from AVLTree (superclass) using base keyword
        public CountryTree(string[] CSVColumnHeaders) : base()
        {
            this.CSVColumnHeaders = CSVColumnHeaders;
        }

        //The same as InsertItem in AVLTree class
        //But in this case we are inserting a Country object
        public void InsertCountry(Country c)
        {
            base.InsertItem(c);
        }

        //The same as RemoveItem in AVLTree class
        //But in this case we are removing a Country object
        public void RemoveCountry(Country c)
        {
            base.RemoveItem(c);
        }

        //Checks if a country is already in the tree by comparing names
        //Parameter string needs spaces removed and converted to lowercase
        public bool ContainsCountry(string countryName)
        {
            return ContainsCountry(countryName.Trim().ToLower(), root);
        }

        //Check if the root node exists - no point otherwise
        //Check the current node, then left or right using recursion until match is found or every node (country) is checked
        //Covert country name to lowercase and remove spaces so a match can be found with the parameter 
        private bool ContainsCountry(string countryName, Node<Country> root)
        {
            return root != null && (root.Data.Name.Trim().ToLower().Equals(countryName) || ContainsCountry(countryName, root.Left) || ContainsCountry(countryName, root.Right));
        }

        //Convert the list of country objects to an array
        public Country[] CreateCountryArray()
        {
            List<Country> CountryList = new List<Country>();
            AddCountriesToList(root, ref CountryList);
            return CountryList.ToArray();
        }

        //Adds the content of each node/country to list
        private void AddCountriesToList(Node<Country> tree, ref List<Country> countryList)
        {
            //Make sure the Country/Node actually exists before adding the country data to list
            while (tree != null)
            {
                AddCountriesToList(tree.Left, ref countryList);
                countryList.Add(tree.Data);
                tree = tree.Right;
            }
        }

        //Compares search query to current, left or right node
        //If match is found gets added to list
        //List gets converted to an array at the end
        public Country[] SearchCountry(string search)
        {
            List<Country> SearchResults = new List<Country>();
            //Remove all spaces and underscores
            search = search.Trim().Replace(' ', '_');
            SearchCountry(search, root, ref SearchResults);
            return SearchResults.ToArray();
        }

        private void SearchCountry(string search, Node<Country> root, ref List<Country> searchResults)
        {
            while (root != null) //Ignore nodes that don't exist
            {
                SearchCountry(search, root.Left, ref searchResults);
                if (root.Data.Name.ToLower().Contains(search.ToLower()))
                {
                    //Found a match, add to list
                    searchResults.Add(root.Data);
                } 

                //Change node
                root = root.Right;
            }
        }
    }
}
