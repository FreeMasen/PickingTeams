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
        List<string> names;

        public frmPickingTeams()
        {
            InitializeComponent();
            names = new List<string>();
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            //check the txtbox is not empty
            if (txtName.Text.Length > 0 )
            {
                //if not empty add name to list
                names.Add(txtName.Text);
                updateView();

            }
            else
            {
                //otherwise show error
                MessageBox.Show("Please enter a name or make your teams");
            }
            //focus back on txtbox
            txtName.Focus();
            //make the second button clickable
            btnMakeGroups.Enabled = true;
        }

        

        private void updateView()
        {
            //clear the listbox and update it with our new player
            lstNames.Items.Clear();
            foreach (string player in names)
            {
                lstNames.Items.Add(player);
            }
        }

        
        private void btnMakeGroups_Click(object sender, EventArgs e)
        {
            //check the team size is not empty
            if (txtTeamSize.Text.Length > 0)
            {
                //store the team size
                int teamSize = Convert.ToInt16(txtTeamSize.Text);
                //initate the team counter
                int teamNum = 1;
                //start our random
                Random rng = new Random();
                //create a new list for sorted teams
                List<string> teams = new List<string>();
                //store a second counter
                int counter = 0;
                //perform while our list is not empty
                while (names.Count > 0)
                {
                    //check if our counter and our team size are equal
                    if (counter % teamSize == 0)
                    {
                        //add the team name to our list
                        teams.Add("Team" + teamNum.ToString());
                        teamNum++;
                    }
                    //generate random
                    int n = rng.Next(names.Count);
                    //add the player at our random position to our new list
                    teams.Add(names[n]);
                    //remove this player from old list
                    names.RemoveAt(n);
                    //
                    counter++;
                }
                //set our new list to our old list
                names = teams;
                //run update view
                updateView();
                //make the second button no longer clickable
                btnMakeGroups.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter a team size");
                txtTeamSize.Focus();
            }
        }
    }
}
