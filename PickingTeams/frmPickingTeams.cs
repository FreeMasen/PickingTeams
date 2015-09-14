using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickingTeams
{
    public partial class frmPickingTeams : Form
    {
        //list to store enteries
        List<Player> players = new List<Player>();
        List<String> sorted = new List<string>();

        public frmPickingTeams()
        {
            InitializeComponent();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            //check the txtbox is not empty
            if (txtName.Text.Length > 0 )
            {
                //if not empty add name to list
                players.Add(new Player(txtName.Text));

            }
            else
            {
                //otherwise show error
                MessageBox.Show("Please enter a name or make your teams");
            }
            //focus back on txtbox and clear the field
            txtName.Focus();
            txtName.Text = "";

            //clear the datasource and reload the updated list
            lstNames.DataSource = null;
            lstNames.DataSource = players;

            //make the second button clickable
            btnMakeGroups.Enabled = true;
        }

        


        
        private void btnMakeGroups_Click(object sender, EventArgs e)
        {
            //sort the players list by the index
            players.Sort((p1, p2) => p1.index.CompareTo(p2.index));
            //make sure the sorted list is empty
            sorted.Clear();

            //store a counter that will pull the player by index
            int counter = 0;
            //determine the number of teams
            decimal numOfTeams = (players.Count/numTeamSize.Value);

            for (int i = 1; i <= numOfTeams; i++)
            {
                //first add a team name to the list
                sorted.Add("Team " + (i ).ToString());
                for (int x = 0; x < numTeamSize.Value; x++)
                {
                    //then add the number of players determined by the user entry
                    if (counter < players.Count())
                    {
                        sorted.Add(players[counter].name);
                        counter++;
                    }
                }
            }

            //set the listbox source to the new list
            lstNames.DataSource = sorted;

            

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all lists and the listbox
            players.Clear();
            sorted.Clear();
            lstNames.DataSource = null;
        }
        

    }

    //class to define the elementsa that a player would have 
    //as well as a tostring override
    public class Player
    {
        
        public string name { get; set; }
        public int index { get; set; }
        static Random rng = new Random();

        public Player(string name)
        {
            this.name = name;
            this.index = rng.Next();
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
