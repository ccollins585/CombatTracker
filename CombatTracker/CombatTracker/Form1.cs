using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public partial class Form1 : Form
    {
        /* Name: Chris Collins
         * Description: This program serves as a Dungeons & Dragons 5th Edition combat tracker, aiding Dungeon Masters in managing various combat components.*/

        private List<Character> playerList = new List<Character>();
        private List<Character> NPCList = new List<Character>();
        private Combat combatTracker = new Combat();

        public Form1()
        {
            InitializeComponent();
            ResetForm();
        }

        private void ResetForm()
        {
            //Function Comment Header
            /* Name: ResetForm
             * Sent: none
             * Returned: none
             * This function performs a reset of the form*/
            grpCombat.Enabled = false;
            //Set default type to 'Humanoid'
            cboPlayerType.SelectedIndex = 9;
            cboNPCType.SelectedIndex = 9;
            //Set default size to 'Medium'
            cboPlayerSize.SelectedIndex = 3;
            cboNPCSize.SelectedIndex = 3;
            btnEnd.Enabled = false;
            ClearLabels();
            ClearText();
            lstPlayers.Items.Clear();
            lstNPC.Items.Clear();
            lstCombat.Items.Clear();

        }

        private void ClearLabels()
        {
            //Function Comment Header
            /* Name: ClearLabels
             * Sent: none
             * Returned: none
             * This function clears all labels on the form*/
            lblAC.Text = "";
            lblConcentrating.Text = "";
            lblConcentrationCheck.Text = "";
            lblConditions.Text = "";
            lblHP.Text = "";
            lblName.Text = "";
            lblPlayer.Text = "";
            lblReaction.Text = "";
            lblType.Text = "";
            lblTurn.Text = "";
            lblRound.Text = "";
            lblSize.Text = "";
            lblTempHP.Text = "";
            lblDeathFail.Text = "";
            lblDeathSuccess.Text = "";
        }

        private void ClearText()
        {
            //Function Comment Header
            /* Name: ClearText
             * Sent: none
             * Returned: none
             * This function clears all textboxes on the form*/
            txtConstitution.Text = "";
            txtCurrentHP.Text = "";
            txtDamage.Text = "";
            txtHPChange.Text = "";
            txtNPCAC.Text = "";
            txtNPCHP.Text = "";
            txtNPCInitiative.Text = "";
            txtNPCName.Text = "";
            txtPlayer.Text = "";
            txtPlayerAC.Text = "";
            txtPlayerInitiative.Text = "";
            txtPlayerMaxHP.Text = "";
            txtPlayerName.Text = "";
        }

        private void btnCheckConcentration_Click(object sender, EventArgs e)
        {
            //Must use valid integer inputs for damage and constitution saving throw to perform a concentration check
            if (!int.TryParse(txtDamage.Text, out int damage) || !int.TryParse(txtConstitution.Text, out int check))
            {
                MessageBox.Show("Please enter valid numerical values for damage and concentration check.");
                return;
            }
            //The difficulty of a concentration check is either half the damage taken or 10, whichever is greater
            int DC = Math.Max(damage / 2, 10);
            //The concentration check is successful if the saving throw is equal to or greater than the difficulty
            string result = (check >= DC) ? "Success" : "Fail";
            //Display the result
            lblConcentrationCheck.Text = result;
            //Change the color of the text to green on a success or red on a failure
            lblConcentrationCheck.ForeColor = (check >= DC) ? Color.Green : Color.Red;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtPlayerName.Text;
                string player = txtPlayer.Text;
                int ac = int.Parse(txtPlayerAC.Text);
                int currentHP = int.Parse(txtCurrentHP.Text);
                int maxHP = int.Parse(txtPlayerMaxHP.Text);
                string type = cboPlayerType.Text;
                string size = cboPlayerSize.Text;
                //Players must have a Name, Player, and Type
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(player) || string.IsNullOrWhiteSpace(type))
                {
                    MessageBox.Show("Name, Player, and Type cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Validate inputs for AC, Current HP, and Max HP
                if (!int.TryParse(txtPlayerAC.Text, out ac) || !int.TryParse(txtCurrentHP.Text, out currentHP) || !int.TryParse(txtPlayerMaxHP.Text, out maxHP))
                {
                    MessageBox.Show("Invalid numeric input for AC, Current HP, or Max HP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Current HP cannot be greater than Max HP
                currentHP = Math.Min(currentHP, maxHP);
                //Create a new player character with inputs
                Character newPlayer = new Character(ac, name, maxHP, currentHP);
                newPlayer.Player = player;
                newPlayer.Type = type;
                newPlayer.Size = size;
                //Add new player to player list
                playerList.Add(newPlayer);
                lstPlayers.Items.Add(newPlayer.Name);
                ClearText();
                txtPlayer.Text = "";
                //Update the 'Current' section with the new players info
                lblName.Text = newPlayer.Name;
                lblPlayer.Text = newPlayer.Player;
                lblType.Text = newPlayer.Type;
                lblAC.Text = newPlayer.AC.ToString();
                lblHP.Text = $"{newPlayer.CurrentHP} / {newPlayer.MaxHP}";
                if (newPlayer.TempHP != 0)
                {
                    lblTempHP.Text = newPlayer.TempHP.ToString();
                } else
                {
                    lblTempHP.Text = "";
                }
                lblSize.Text = newPlayer.Size.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            //If a player is selected in the list, remove that player
            if (lstPlayers.SelectedIndex != -1)
            {
                Character selectedPlayer = playerList[lstPlayers.SelectedIndex];
                playerList.Remove(selectedPlayer);
                lstPlayers.Items.RemoveAt(lstPlayers.SelectedIndex);
            }
        }

        private void btnPlayerCombat_Click(object sender, EventArgs e)
        {
            try
            {
                //If a player is selected, add that character to the combat order with the entered initiative
                if (lstPlayers.SelectedIndex != -1)
                {
                    int initiative = int.Parse(txtPlayerInitiative.Text);
                    Character selectedPlayer = playerList[lstPlayers.SelectedIndex];
                    selectedPlayer.SetInitiative(initiative);
                    combatTracker.AddParticipant(selectedPlayer);
                    lstCombat.Items.Add(selectedPlayer.ToString());
                    //Reset the combat order based on every initiative in combat
                    UpdateCombatList();
                    //Clear list selection
                    lstPlayers.SelectedIndex = -1;
                    txtPlayerInitiative.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNPC_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtNPCName.Text;
                int ac = int.Parse(txtNPCAC.Text);
                int maxHP = int.Parse(txtNPCHP.Text);
                string type = cboNPCType.Text;
                string size = cboNPCSize.Text;
                //NPC must have a name and type
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(type))
                {
                    MessageBox.Show("Name and Type cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Must use valid inputs for AC and HP
                if (!int.TryParse(txtNPCAC.Text, out ac)  || !int.TryParse(txtNPCHP.Text, out maxHP))
                {
                    MessageBox.Show("Invalid numeric input for AC, Current HP, or Max HP.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Create a new NPC character with entered info
                Character newNPC = new Character(ac, name, maxHP, maxHP);
                newNPC.Player = "DM";
                newNPC.Type = type;
                newNPC.Size = size;
                //Add new NPC to the npc list
                NPCList.Add(newNPC);
                lstNPC.Items.Add(newNPC.Name);
                //Update the 'Current' section with the new NPC
                lblName.Text = newNPC.Name;
                lblPlayer.Text = newNPC.Player;
                lblType.Text = newNPC.Type;
                lblAC.Text = newNPC.AC.ToString();
                lblHP.Text = $"{newNPC.CurrentHP} / {newNPC.MaxHP}";
                if (newNPC.TempHP != 0)
                {
                    lblTempHP.Text = newNPC.TempHP.ToString();
                }
                else
                {
                    lblTempHP.Text = "";
                }
                lblSize.Text = newNPC.Size.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveNPC_Click(object sender, EventArgs e)
        {
            //If an NPC is selected from the list, remove that NPC
            if (lstNPC.SelectedIndex != -1)
            {
                Character selectedNPC = NPCList[lstNPC.SelectedIndex];
                NPCList.Remove(selectedNPC);
                lstNPC.Items.RemoveAt(lstNPC.SelectedIndex);
            }
        }

        private void btnRemoveAllNPC_Click(object sender, EventArgs e)
        {
            //Make sure NPC list is not empty
            if (NPCList.Count > 0)
            {
                //Confirm the user wants to clear the NPC list
                DialogResult result = MessageBox.Show("Are you sure you want to remove all NPCs?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Clear list on 'yes'
                if (result == DialogResult.Yes)
                {
                    NPCList.Clear();
                    lstNPC.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("There are no NPCs to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNPCCombat_Click(object sender, EventArgs e)
        {
            try
            {
                //If an NPC is selected, add that NPC to the combat order with the entered initiative
                if (lstNPC.SelectedIndex != -1)
                {
                    int initiative = int.Parse(txtNPCInitiative.Text);
                    Character selectedNPC = NPCList[lstNPC.SelectedIndex];
                    selectedNPC.SetInitiative(initiative);
                    combatTracker.AddParticipant(selectedNPC);
                    lstCombat.Items.Add(selectedNPC.ToString());
                    //Update the combat list based on initiative
                    UpdateCombatList();
                    //Clear list selection
                    lstNPC.SelectedIndex = -1;
                    txtNPCInitiative.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCombatList()
        {
            //Function Comment Header
            /* Name: UpdateCombatList
             * Sent: none
             * Returned: none
             * This function clears the combat list and rebuilds the list based on initiative order*/
            lstCombat.Items.Clear();
            foreach (Character participant in combatTracker.GetCombatOrder())
            {
                lstCombat.Items.Add(participant.ToString());
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Begin combat, enable the combat section
            combatTracker.StartCombat();
            btnEnd.Enabled = true;
            grpCombat.Enabled = true;
            btnStart.Enabled = false;
            //Update 'Current' section for the first character in the initiative order
            UpdateCurrentCharacterLabel();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            //End combat and disable the combat section
            combatTracker.EndCombat();
            btnStart.Enabled = true;
            btnEnd.Enabled = false;
            grpCombat.Enabled = false;
            //Clear combat list and labels
            ClearLabels();
            lstCombat.Items.Clear();
        }

        private void btnReaction_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character in the combat list is selected, set that character's reaction to 'true'. This indicates that
                // character has used their reaction this round. Update labels and list to reflect changes.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];
                        selected.Reaction = true;
                        UpdateCombatList();
                        UpdateCurrentCharacterLabel();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConcentrate_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character in the combat list is selected, flip that characters concentration property. True indicates that
                //a character is currently concentrating. Update labels and list to reflect changes.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];
                        if (selected.Concentrating == true)
                        {
                            selected.Concentrating = false;
                        } else
                        {
                            selected.Concentrating = true;
                        }
                        UpdateCombatList();
                        UpdateCurrentCharacterLabel();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCondition_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character in the combat list is selected, add the selected condition to that character.
                //Update labels and list to reflect changes.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];
                        selected.Condition += cboConditions.Text+", ";
                        UpdateCombatList();
                        UpdateCurrentCharacterLabel();

                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveConditions_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character in the combat list is selected, remove all conditions for that character.
                //Update labels and list to reflect changes.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];
                        selected.Condition = "";
                        UpdateCombatList();
                        UpdateCurrentCharacterLabel();

                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character in the combat list is selected, increase the current HP of that character by the amount
                // in the input textbox. Update labels and list to reflect changes.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];

                        if (int.TryParse(txtHPChange.Text, out int hp))
                        {
                            selected.Heal(hp);
                            UpdateCombatList();
                            UpdateCurrentCharacterLabel();
                            txtHPChange.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character in the combat list is selected, decrease the current HP of that character by the amount
                // in the input textbox. Update labels and list to reflect changes.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];

                        if (int.TryParse(txtHPChange.Text, out int hp))
                        {
                            selected.Damage(hp);
                            UpdateCombatList();
                            UpdateCurrentCharacterLabel();
                            txtHPChange.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            try
            {
                //End the turn of the current character and move to the next character in the combat order
                //Update 'Current' section for the next character in the combat order
                combatTracker.NextTurn();
                UpdateCurrentCharacterLabel();
                UpdateCombatList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateCurrentCharacterLabel()
        {
            //Function Comment Header
            /* Name: UpdateCurrentCharacterLabel
             * Sent: none
             * Returned: none
             * This function will set all the labels in the Current section with the information of the selected character*/

            try
            {
                //Update 'Current' section for the character in the combat order
                Character currentCharacter = combatTracker.GetCurrentCharacter();

                if (currentCharacter != null)
                {
                    lblTurn.Text = $"{combatTracker.GetTurnCounter()}";
                    lblRound.Text = $"{combatTracker.GetRoundCounter()}";
                    LoadCharacterImage(currentCharacter);
                    lblName.Text = currentCharacter.Name;
                    lblPlayer.Text = currentCharacter.Player;
                    lblType.Text = currentCharacter.Type;
                    lblAC.Text = currentCharacter.AC.ToString();
                    lblHP.Text = $"{currentCharacter.CurrentHP} / {currentCharacter.MaxHP}";
                    lblConditions.Text = currentCharacter.Condition;
                    if (currentCharacter.TempHP != 0)
                    {
                        lblTempHP.Text = "+"+currentCharacter.TempHP.ToString();
                    }
                    else
                    {
                        lblTempHP.Text = "";
                    }
                    lblSize.Text = currentCharacter.Size.ToString();

                    if (currentCharacter.Concentrating)
                    {
                        lblConcentrating.Text = "Concentrating";
                    } else
                    {
                        lblConcentrating.Text = "";
                    }
                    if (currentCharacter.Reaction)
                    {
                        lblReaction.Text = "Used Reaction";
                    } else
                    {
                        lblReaction.Text = "";
                    }

                    if (currentCharacter.DeathFail > 0)
                    {
                        lblDeathFail.Text = currentCharacter.DeathFail.ToString() + " Failed Death Saves";
                    } else
                    {
                        lblDeathFail.Text = "";
                    }

                    if (currentCharacter.DeathSave > 0)
                    {
                        lblDeathSuccess.Text = currentCharacter.DeathSave.ToString() + " Passed Death Saves";
                    }
                    else
                    {
                        lblDeathSuccess.Text = "";
                    }
                }
                else
                {
                    lblTurn.Text = "No participants in combat";
                    lblRound.Text = "";
                    ClearLabels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveCombat_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character from the combat order is selected, remove them from combat
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        combatOrder.RemoveAt(lstCombat.SelectedIndex);
                        lstCombat.Items.RemoveAt(lstCombat.SelectedIndex);
                        UpdateCurrentCharacterLabel();
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTempHP_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character is selected, increase the TEMPORARY HP by the amount in the textbox
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];

                        if (int.TryParse(txtHPChange.Text, out int hp))
                        {
                            selected.TempHP += hp;
                            UpdateCombatList();
                            UpdateCurrentCharacterLabel();
                            txtHPChange.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeathSave_Click(object sender, EventArgs e)
        {
            try
            {
                //If a character from combat is selected, perform a death saving throw by entertering the result of the death save roll into the textbox.
                if (lstCombat.SelectedIndex != -1)
                {
                    List<Character> combatOrder = combatTracker.GetCombatOrder();

                    if (lstCombat.SelectedIndex < combatOrder.Count)
                    {
                        Character selected = combatOrder[lstCombat.SelectedIndex];
                        //Roll a d20 and enter the result in the textbox
                        if (int.TryParse(txtHPChange.Text, out int deathSave))
                        {
                            selected.DeathSavingThrow(deathSave);
                            UpdateCombatList();
                            UpdateCurrentCharacterLabel();
                            txtHPChange.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Invalid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid selection. Please select a valid character from the combat order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCharacterImage(Character character)
        {
            //Function Comment Header
            /* Name: LoadCharacterImage
             * Sent: Character (character)
             * Returned: none
             * This function loads an image into the Current section if the Character sent in has an image*/

            if (!string.IsNullOrEmpty(character.ImagePath))
            {
                try
                {
                    //Load the image from the file path
                    picCurrent.Image = Image.FromFile(character.ImagePath);
                }
                catch (Exception ex)
                {
                    picCurrent.Image = null;
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }
            else
            {
                picCurrent.Image = null;
            }
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the selected file path
                    string selectedFilePath = openFileDialog.FileName;

                    //Check if selected player is in list
                    if (lstPlayers.SelectedIndex != -1)
                    {
                        //Get the selected player
                        Character selectedPlayer = playerList[lstPlayers.SelectedIndex];

                        //Set the image path for the selected player
                        selectedPlayer.ImagePath = selectedFilePath;

                        LoadCharacterImage(selectedPlayer);

                        lstPlayers.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("Please select a player from the list before adding an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPicNPC_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif, *.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the selected file path
                    string selectedFilePath = openFileDialog.FileName;

                    //If selected character is in list
                    if (lstNPC.SelectedIndex != -1)
                    {
                        //Get the selected character
                        Character selectedNPC = NPCList[lstNPC.SelectedIndex];

                        //Set the image path for the selected character
                        selectedNPC.ImagePath = selectedFilePath;

                        LoadCharacterImage(selectedNPC);

                        lstNPC.SelectedIndex = -1;

                    }
                    else
                    {
                        MessageBox.Show("Please select a player from the list before adding an image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
