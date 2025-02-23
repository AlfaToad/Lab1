using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab1
{
    public partial class ClientForm : Form
    {
        private ClientManager clientManager;
        public ClientForm()
        {

            clientManager = new ClientManager();
            InitializeComponent();

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateClientsList();
        }
        private void UpdateClientsList()
        {
            clientsListBox.Items.Clear();
            foreach (var client in clientManager.Clients)
            {
                clientsListBox.Items.Add($"{client.Name} - {client.Email} ({client.Phone})");
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text)
            || string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            Client newClient = new Client(nameTextBox.Text, emailTextBox.Text,
            phoneTextBox.Text, addressTextBox.Text);
            try
            {
                clientManager.AddClient(newClient);
                nameTextBox.Clear();
                emailTextBox.Clear();
                phoneTextBox.Clear();
                addressTextBox.Clear();
                UpdateClientsList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void RemoveClientButton_Click(object sender, EventArgs e)
        {
            if (clientsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите клиента для удаления!");
                return;
            }
            string selectedItem = clientsListBox.SelectedItem.ToString();
            string[] parts = selectedItem.Split(new[] { '-' }, StringSplitOptions.None);
            if (parts.Length >= 2)
            {
                string name = parts[0].Trim();
                string email = parts[1].Trim();
                /*               email = email.Remove(email.IndexOf(" "));*/
                var clientToRemove = clientManager.Clients.Find(c => c.Name == name && c.Email + " (" + c.Phone + ")"
                == email);
                if (clientToRemove != null)
                {
                    try
                    {
                        clientManager.RemoveClient(clientToRemove);
                        UpdateClientsList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                UpdateClientsList();
                return;
            }
            var searchResults = clientManager.SearchClients(searchTextBox.Text);
            clientsListBox.Items.Clear();
            foreach (var client in searchResults)
            {
                clientsListBox.Items.Add($"{client.Name} - {client.Email} ({client.Phone})");
            }
        }
    }
}
