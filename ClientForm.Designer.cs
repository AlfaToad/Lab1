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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addClientButton = new System.Windows.Forms.Button();
            this.removeClientButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.Text = "Имя";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(170, 10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(150, 20);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Email";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(330, 10);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 2;
            this.phoneTextBox.Text = "Телефон";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(10, 40);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(450, 20);
            this.addressTextBox.TabIndex = 3;
            this.addressTextBox.Text = "Адрес";
            // 
            // addClientButton
            // 
            this.addClientButton.Location = new System.Drawing.Point(10, 80);
            this.addClientButton.Name = "addClientButton";
            this.addClientButton.Size = new System.Drawing.Size(100, 23);
            this.addClientButton.TabIndex = 4;
            this.addClientButton.Text = "Добавить";
            // 
            // removeClientButton
            // 
            this.removeClientButton.Location = new System.Drawing.Point(120, 80);
            this.removeClientButton.Name = "removeClientButton";
            this.removeClientButton.Size = new System.Drawing.Size(100, 23);
            this.removeClientButton.TabIndex = 5;
            this.removeClientButton.Text = "Удалить";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 110);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(200, 20);
            this.searchTextBox.TabIndex = 6;
            this.searchTextBox.Text = "Поиск";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(220, 110);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 23);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Искать";
            // 
            // clientsListBox
            // 
            this.clientsListBox.Location = new System.Drawing.Point(10, 140);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(450, 199);
            this.clientsListBox.TabIndex = 8;
            // 
            // ClientForm
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addClientButton);
            this.Controls.Add(this.removeClientButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.clientsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientForm";
            this.Tag = "111";
            this.Text = "Управление клиентами";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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

