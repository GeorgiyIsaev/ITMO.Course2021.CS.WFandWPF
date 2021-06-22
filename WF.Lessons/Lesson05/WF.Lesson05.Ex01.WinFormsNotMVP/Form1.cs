using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsNotMVP
{
    public partial class ClientsForm : Form
    {
        private readonly ClientRepository clientsRepository;

        public ClientsForm()
        {
            this.clientsRepository = new ClientRepository();

            InitializeComponent();
            BindComponent();
        }

        private void BindComponent()
        {
            this.closeButton.Click += OnCloseButtonClick;
            this.clientsListBox.SelectedIndexChanged += OnClientsListBoxSelectedIndexChanged;

            this.clientsListBox.DisplayMember = "Name";
            this.clientsListBox.ValueMember = "Id";
            this.clientsListBox.DataSource = this.clientsRepository.FindAll();
        }

        private void OnClientsListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedClientId = (int)this.clientsListBox.SelectedValue;
            var selectedClient = this.clientsRepository.GetbyId(selectedClientId);

            this.clientNameTextBox.Text = selectedClient.Name;
            this.clientEmailTextBox.Text = selectedClient.Email;
            this.clientGenderTextBox.Text = selectedClient.Gender;
            this.clientAgeTextBox.Text = selectedClient.Age.ToString();
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
