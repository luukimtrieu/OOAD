using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class FormHome : Form
    {
        private Guna2Button currentButton;
        public FormHome()
        {
            InitializeComponent();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Guna2Button)btnSender)
                {
                DisableButton();
                currentButton = (Guna2Button)btnSender;
                currentButton.BackColor = Color.SteelBlue;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panel1.Controls)
            {
                if (previousButton.GetType() == typeof(Guna2Button))
                {
                    previousButton.BackColor = System.Drawing.Color.Transparent;
                    previousButton.ForeColor = Color.Black;
                    previousButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void EntertainButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
