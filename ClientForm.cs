using System;
using System.Text.RegularExpressions;
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
                clientsListBox.Items.Add($"{client.Name} - {client.Email} ({client.Phone}) {client.Address}");
            }
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(emailTextBox.Text)
            || string.IsNullOrEmpty(phoneTextBox.Text) || string.IsNullOrEmpty(addressTextBox.Text) || nameTextBox.Text == "Имя" || emailTextBox.Text == "Email"
            || phoneTextBox.Text == "Телефон" || addressTextBox.Text == "Адрес")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            if (nameTextBox.Text.LastIndexOfAny(['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '!', '@', '#', '№', '$', ';', '%', '^', ':', '&', '?', '*', '(', ')', '+', '=', '_', '/', '\\', '|', '>', '<', '.', ',', '\'', '"']) != -1)
            {
                MessageBox.Show("Имя не должно содержать цифр!");
                return;
            }
            if (!Regex.IsMatch(phoneTextBox.Text, @"^\+?\d{11}"))
            {
                MessageBox.Show("Введен несуществующий номер телефона!");
                return;
            }
            if (!Regex.IsMatch(phoneTextBox.Text, @"^\+?\d{11}"))
            {
                MessageBox.Show("Введен несуществующий номер телефона!");
                return;
            }
            if (!Regex.IsMatch(emailTextBox.Text, @"(@)(.+)$"))
            {
                MessageBox.Show("Введена несуществующая почта!");
                return;
            }
            if (addressTextBox.Text.IndexOfAny(['!', '@', '#', '$', '%', '^', '&', '?', '+', '=', '_', '/', '\\', '|', '>', '<']) != -1)
            {
                MessageBox.Show("Введен неправильный адрес!");
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
                var clientToRemove = clientManager.Clients.Find(c => c.Name == name && c.Email + " (" + c.Phone + ") " + c.Address
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
            if (searchTextBox.Text == "Поиск") { searchTextBox.Text = ""; }
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                UpdateClientsList();
                return;
            }
            var searchResults = clientManager.SearchClients(searchTextBox.Text);
            clientsListBox.Items.Clear();
            foreach (var client in searchResults)
            {
                clientsListBox.Items.Add($"{client.Name} - {client.Email} ({client.Phone}) {client.Address}");
            }
        }

        private void nameTextBox_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Имя") { nameTextBox.Text = ""; }
        }

        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email") { emailTextBox.Text = ""; }
        }

        private void phoneTextBox_Click(object sender, EventArgs e)
        {
            if (phoneTextBox.Text == "Телефон") { phoneTextBox.Text = ""; }
        }

        private void addressTextBox_Click(object sender, EventArgs e)
        {
            if (addressTextBox.Text == "Адрес") { addressTextBox.Text = ""; }
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            if (searchTextBox.Text == "Поиск") { searchTextBox.Text = ""; }
        }
    }
}
