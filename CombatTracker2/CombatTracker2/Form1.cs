using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatTracker2
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        public Form1()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null && btnSender is Button)
            {
                Button clickedButton = (Button)btnSender;

                if (currentButton != null)
                {
                    if (currentButton != clickedButton)
                    {
                        DisableButton();
                        currentButton = clickedButton;
                        currentButton.BackColor = Color.FromArgb(1, 135, 134);
                        currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    }
                }
                else
                {
                    currentButton = clickedButton;
                    currentButton.BackColor = Color.FromArgb(1, 135, 134);
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control ctrl in pnlMenu.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(36, 23, 115);
                    btn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
                }
            }
        }


        private void btnPlayers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //pnlPlayers.Show();
            //pnlNPC.Hide();
            //pnlCombat.Hide();
            //pnlTools.Hide();
            ShowPanel(pnlPlayers);
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowPanel(pnlNPC);
            //pnlPlayers.Hide();
            //pnlNPC.Show();
            //pnlCombat.Hide();
            //pnlTools.Hide();
        }

        private void btnCombat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowPanel(pnlCombat);
            //pnlNPC.Hide();
            //pnlPlayers.Hide();
            //pnlCombat.Show();
            //pnlTools.Hide();
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ShowPanel(pnlTools);
            //pnlNPC.Hide();
            //pnlPlayers.Hide();
            //pnlCombat.Hide();
            //pnlTools.Show();
        }

        private void ShowPanel(Panel panelToShow)
        {
            pnlPlayers.Visible = (panelToShow == pnlPlayers);
            pnlNPC.Visible = (panelToShow == pnlNPC);
            pnlCombat.Visible = (panelToShow == pnlCombat);
            pnlTools.Visible = (panelToShow == pnlTools);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
