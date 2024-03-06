using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public class Character
    {
        public int AC { get; set; }
        public string Name { get; set; }
        public string Player { get; set; }
        public string Type { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int TempHP { get; set; }
        public bool Reaction { get; set; }
        public bool Concentrating { get; set; }
        public string Condition { get; set; }
        public string Size { get; set; }
        public int Initiative { get; set; }
        public int DeathSave { get; set; }
        public int DeathFail { get; set; }
        public string ImagePath { get; set; }


        public Character(int ac, string name, int maxHP, int currentHP)
        {
            AC = ac;
            Name = name;
            MaxHP = maxHP;
            CurrentHP = currentHP;
            Reaction = false;
            Concentrating = false;
            Condition = "";
            Player = "";
            Type = "";
            Initiative = 0;
            Size = "";
            TempHP = 0;
            DeathSave = 0;
            DeathFail = 0;
        }

        //Override ToString method to provide necessary information to the listbox
        public override string ToString()
        {
            string concentrationStatus = Concentrating ? "[Concentrating]," : "";
            string reactionStatus = Reaction ? "[Used Reaction]," : "";

            return $"{Initiative} - {Name} HP: {CurrentHP}/{MaxHP}, AC: {AC}, {concentrationStatus} {reactionStatus} {Condition}";
        }

        //Set the character's initiative
        public void SetInitiative(int init)
        {
            Initiative = init;
        }

        public void Heal(int healHP)
        {
            // Function Comment Header
            /* Name: Heal
             * Sent: int (healHP)
             * Returned: none
             * This function adds HP to the character by the amount sent in*/
            CurrentHP += healHP;
            int max = MaxHP;

            if (CurrentHP > max)
            {
                CurrentHP = max;
            }
        }

        public void Damage(int damageHP)
        {
            // Function Comment Header
            /* Name: Damage
             * Sent: int (damageHP)
             * Returned: none
             * This function removes HP from the character by the amount sent in*/

            //If the character has any temporary HP, remove them first and remove the remainder from current HP
            if (TempHP > 0)
            {
                int remainder = TempHP - damageHP;

                if (remainder < 0)
                {
                    CurrentHP += remainder;
                }

                TempHP = 0;
            }
            else
            {
                CurrentHP -= damageHP;
            }
            //If the character HP is reduced to 0, they are given the Unconscious condition and can no longer concentrate
            if (CurrentHP <= 0)
            {
                CurrentHP = 0;
                Condition = "Unconscious";
                Concentrating = false;
            }
        }

        public void DeathSavingThrow(int roll)
        {
            // Function Comment Header
            /* Name: DeathSavingThrow
             * Sent: int (roll)
             * Returned: none
             * This function handles death saving throws by sending in the death saving throw roll result*/

            if (CurrentHP <= 0)
            {
                if (roll == 20)
                {
                    //If a natural 20 is rolled, ask if they want to stabilize the character
                    string message = "Natural 20? (Bring to Stable?)";
                    DialogResult result = MessageBox.Show(message, "20 Death Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        CurrentHP = 1;
                        Condition = "Stable";
                    }
                    else
                    {
                        DeathSave++;
                    }
                }
                else if (roll == 1)
                {
                    //If a natural 1 is rolled, count as two failed death saves
                    DeathFail += 2;
                }
                else if (roll >= 10)
                {
                    //If the roll is 10 or higher, count as a successful death save
                    DeathSave++;
                }
                else
                {
                    // If the roll is less than 10, count as a failed death save
                    DeathFail++;
                }

                //Check for condition leading to stabilization
                if (DeathSave >= 3)
                {
                    CurrentHP = 1;
                    Condition = "Stable";
                }
                //Check for condition leading to death
                if (DeathFail >= 3)
                {
                    Condition = "Dead";
                }
            }
        }
    }
}
