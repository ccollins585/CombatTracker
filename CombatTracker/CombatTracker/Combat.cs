using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker
{
    public class Combat
    {
        private List<Character> combatOrder = new List<Character>();
        private int roundCounter;
        private int turnCounter;

        public void AddParticipant(Character participant)
        {
            // Function Comment Header
            /* Name: AddParticipant
             * Sent: Character (participant)
             * Returned: none
             * This function adds the character being sent in to the CombatOrder list, based on their initiative*/

            //Check if a participant with the same name already exists
            if (!combatOrder.Any(c => c.Name == participant.Name))
            {
                //Find characters with the same initiative
                List<Character> sameInitiative = combatOrder
                    .Where(c => c.Initiative == participant.Initiative)
                    .ToList();

                if (sameInitiative.Count == 0)
                {
                    //If no characters have the same initiative, add the participant to the list
                    combatOrder.Add(participant);
                    combatOrder = combatOrder.OrderByDescending(c => c.Initiative).ToList();
                }
                else
                {
                    //If there are characters with the same initiative, ask the user for tie-breaking
                    string promptMessage = $"Do you want to place '{participant.Name}' before the existing participant in the combat order?";

                    DialogResult result = MessageBox.Show(promptMessage, "Tie-Breaking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        //Insert the participant before the first character with the same initiative
                        combatOrder.InsertRange(combatOrder.IndexOf(sameInitiative.First()), new[] { participant });
                    }
                    else
                    {
                        //Insert the participant after the last character with the same initiative
                        combatOrder.InsertRange(combatOrder.IndexOf(sameInitiative.Last()) + 1, new[] { participant });
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("A participant with the same name already exists in the combat order.");
            }
        }

        //Get the current combat order
        public List<Character> GetCombatOrder()
        {
            return combatOrder;
        }

        //Get the current turn count
        public int GetTurnCounter()
        {
            return turnCounter;
        }

        //Get the current round count
        public int GetRoundCounter()
        {
            return roundCounter;
        }

        //Start a new combat session
        public void StartCombat()
        {
            roundCounter = 1;
            turnCounter = 1;
        }

        //End the current combat session
        public void EndCombat()
        {
            combatOrder.Clear();
            roundCounter = 0;
            turnCounter = 0;
        }

        //Get the character currently taking their turn
        public Character GetCurrentCharacter()
        {
            if (combatOrder.Count > 0)
            {
                int currentIndex = (turnCounter - 1) % combatOrder.Count;
                return combatOrder[currentIndex];
            }
            else
            {
                return null;
            }
        }

        //Get the character who will take the next turn
        public Character GetNextCharacter()
        {
            if (combatOrder.Count > 0)
            {
                int nextIndex = (turnCounter % combatOrder.Count);
                return combatOrder[nextIndex];
            }
            else
            {
                return null;
            }
        }

        public void NextTurn()
        {
            // Function Comment Header
            /* Name: NextTurn
             * Sent: none
             * Returned: none
             * This function moves to the next characters turn in the combat order and handles the turn and round counters*/

            Character nextCharacter = GetNextCharacter();

            if (nextCharacter != null)
            {
                //Reset the reaction status for the next character
                nextCharacter.Reaction = false;
            }

            //Increment the turn counter and handle round transitions
            turnCounter++;

            if (turnCounter > combatOrder.Count)
            {
                turnCounter = 1;
                roundCounter++;
            }
        }
    }
}
