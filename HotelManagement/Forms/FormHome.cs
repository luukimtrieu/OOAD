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
        private Form currentchildForm;
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
                    currentButton.BackColor = Color.LightSkyBlue;
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

        private void OpenchildForm(Form childForm, object btnSender)
        {
            if (currentchildForm != null)
            {
                currentchildForm.Close();
            }
            ActivateButton(btnSender);
            currentchildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.guna2Panel1.Controls.Add(childForm);
            this.guna2Panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RoomButton_Click(object sender, EventArgs e)
        {
            if (currentButton != (Guna2Button)sender)
            {
                OpenchildForm(new Forms.FormRoom(), sender);
            }
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            if (currentButton != (Guna2Button)sender)
            {
               OpenchildForm(new Forms.FormFood(), sender);
            }
        }

        private void EntertainButton_Click(object sender, EventArgs e)
        {
            if (currentButton != (Guna2Button)sender)
            {
                OpenchildForm(new Forms.FormEntertain(), sender);
            }
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            if (currentButton != (Guna2Button)sender)
            {
                OpenchildForm(new Forms.FormManage(), sender);
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if(currentchildForm != null)
            {
                ActivateButton(sender);
                currentchildForm.Close();
            }
            DisableButton();
        }
    }
}
