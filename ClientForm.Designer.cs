using System.Windows.Forms;

namespace Lab1
{
    partial class ClientForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ClientForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ClientForm";
            this.Tag = "111";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.Text = "Управление клиентами";
            this.Width = 500;
            this.Height = 400;
            //
            this.nameTextBox = new TextBox();
            this.nameTextBox.Location = new System.Drawing.Point(10, 10);
            this.nameTextBox.Width = 150;
            this.nameTextBox.Text = "Имя";
            //
            this.emailTextBox = new TextBox();
            this.emailTextBox.Location = new System.Drawing.Point(170, 10);
            this.emailTextBox.Width = 150;
            this.emailTextBox.Text = "Email";
            //
            this.phoneTextBox = new TextBox();
            this.phoneTextBox.Location = new System.Drawing.Point(330, 10);
            this.phoneTextBox.Width = 100;
            this.phoneTextBox.Text = "Телефон";
            //
            this.addressTextBox = new TextBox();
            this.addressTextBox.Location = new System.Drawing.Point(10, 40);
            this.addressTextBox.Width = 450;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Text = "Адрес";
            //
            this.addClientButton = new Button();
            this.addClientButton.Location = new System.Drawing.Point(10, 80);
            this.addClientButton.Text = "Добавить";
            this.addClientButton.Width = 100;
            this.addClientButton.Click += AddClientButton_Click;
            //
            this.removeClientButton = new Button();
            this.removeClientButton.Location = new System.Drawing.Point(120, 80);
            this.removeClientButton.Text = "Удалить";
            this.removeClientButton.Width = 100;
            this.removeClientButton.Click += RemoveClientButton_Click;
            //
            this.searchTextBox = new TextBox();
            this.searchTextBox.Location = new System.Drawing.Point(10, 110);
            this.searchTextBox.Width = 200;
            this.searchTextBox.Text = "Поиск";
            //
            this.searchButton = new Button();
            this.searchButton.Location = new System.Drawing.Point(220, 110);
            this.searchButton.Text = "Искать";
            this.searchButton.Width = 80;
            this.searchButton.Click += SearchButton_Click;
            //
            this.clientsListBox = new ListBox();
            this.clientsListBox.Location = new System.Drawing.Point(10, 140);
            this.clientsListBox.Width = 450;
            this.clientsListBox.Height = 200;
            //
            this.Controls.Add(nameTextBox);
            this.Controls.Add(emailTextBox);
            this.Controls.Add(phoneTextBox);
            this.Controls.Add(addressTextBox);
            this.Controls.Add(addClientButton);
            this.Controls.Add(removeClientButton);
            this.Controls.Add(searchTextBox);
            this.Controls.Add(searchButton);
            this.Controls.Add(clientsListBox);

        }

        #endregion
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private TextBox addressTextBox;
        private Button addClientButton;
        private Button removeClientButton;
        private TextBox searchTextBox;
        private Button searchButton;
        private ListBox clientsListBox;
    }
}

