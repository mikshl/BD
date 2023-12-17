
namespace Приложение
{
    partial class AdministratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientsOrdersLabel = new System.Windows.Forms.Label();
            this.DelClientButton = new System.Windows.Forms.Button();
            this.IdClientForDelTextBox = new System.Windows.Forms.TextBox();
            this.UpdateClientLabel = new System.Windows.Forms.Label();
            this.ClientFIOlabel = new System.Windows.Forms.Label();
            this.ClientBirthDatelabel = new System.Windows.Forms.Label();
            this.ClientPhoneLabel = new System.Windows.Forms.Label();
            this.AddClientFIO = new System.Windows.Forms.TextBox();
            this.AddClientPhone = new System.Windows.Forms.TextBox();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.AddOrderDurationTime = new System.Windows.Forms.TextBox();
            this.AddOrderRoomID = new System.Windows.Forms.TextBox();
            this.AddOrderClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddOrderHookahPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IdOrderForDelTextBox = new System.Windows.Forms.TextBox();
            this.DelOrderButton = new System.Windows.Forms.Button();
            this.AddClientBirthDate = new System.Windows.Forms.DateTimePicker();
            this.UptadeNewRoomPriceButton = new System.Windows.Forms.Button();
            this.UpdateRoomIDTextbox = new System.Windows.Forms.TextBox();
            this.UpdateNewPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 59);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(451, 362);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClientsOrdersLabel
            // 
            this.ClientsOrdersLabel.AutoSize = true;
            this.ClientsOrdersLabel.Location = new System.Drawing.Point(16, 16);
            this.ClientsOrdersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientsOrdersLabel.Name = "ClientsOrdersLabel";
            this.ClientsOrdersLabel.Size = new System.Drawing.Size(290, 16);
            this.ClientsOrdersLabel.TabIndex = 1;
            this.ClientsOrdersLabel.Text = "Информация о пользователях и их заказах";
            // 
            // DelClientButton
            // 
            this.DelClientButton.Location = new System.Drawing.Point(857, 209);
            this.DelClientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelClientButton.Name = "DelClientButton";
            this.DelClientButton.Size = new System.Drawing.Size(176, 37);
            this.DelClientButton.TabIndex = 3;
            this.DelClientButton.Text = "Удалить клиента";
            this.DelClientButton.UseVisualStyleBackColor = true;
            this.DelClientButton.Click += new System.EventHandler(this.DelClientButton_Click);
            // 
            // IdClientForDelTextBox
            // 
            this.IdClientForDelTextBox.Location = new System.Drawing.Point(659, 217);
            this.IdClientForDelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdClientForDelTextBox.Name = "IdClientForDelTextBox";
            this.IdClientForDelTextBox.Size = new System.Drawing.Size(175, 22);
            this.IdClientForDelTextBox.TabIndex = 4;
            this.IdClientForDelTextBox.Enter += new System.EventHandler(this.IdClientForDelTextBox_Enter);
            this.IdClientForDelTextBox.Leave += new System.EventHandler(this.IdClientForDelTextBox_Leave);
            // 
            // UpdateClientLabel
            // 
            this.UpdateClientLabel.AutoSize = true;
            this.UpdateClientLabel.Location = new System.Drawing.Point(525, 16);
            this.UpdateClientLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpdateClientLabel.Name = "UpdateClientLabel";
            this.UpdateClientLabel.Size = new System.Drawing.Size(128, 16);
            this.UpdateClientLabel.TabIndex = 5;
            this.UpdateClientLabel.Text = "Добавить клиента";
            // 
            // ClientFIOlabel
            // 
            this.ClientFIOlabel.AutoSize = true;
            this.ClientFIOlabel.Location = new System.Drawing.Point(529, 63);
            this.ClientFIOlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientFIOlabel.Name = "ClientFIOlabel";
            this.ClientFIOlabel.Size = new System.Drawing.Size(92, 16);
            this.ClientFIOlabel.TabIndex = 6;
            this.ClientFIOlabel.Text = "FIOClientlabel";
            // 
            // ClientBirthDatelabel
            // 
            this.ClientBirthDatelabel.AutoSize = true;
            this.ClientBirthDatelabel.Location = new System.Drawing.Point(529, 101);
            this.ClientBirthDatelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientBirthDatelabel.Name = "ClientBirthDatelabel";
            this.ClientBirthDatelabel.Size = new System.Drawing.Size(107, 16);
            this.ClientBirthDatelabel.TabIndex = 7;
            this.ClientBirthDatelabel.Text = "Дата рождения";
            // 
            // ClientPhoneLabel
            // 
            this.ClientPhoneLabel.AutoSize = true;
            this.ClientPhoneLabel.Location = new System.Drawing.Point(529, 138);
            this.ClientPhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ClientPhoneLabel.Name = "ClientPhoneLabel";
            this.ClientPhoneLabel.Size = new System.Drawing.Size(120, 16);
            this.ClientPhoneLabel.TabIndex = 8;
            this.ClientPhoneLabel.Text = "Номер телефона";
            // 
            // AddClientFIO
            // 
            this.AddClientFIO.Location = new System.Drawing.Point(659, 59);
            this.AddClientFIO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddClientFIO.Name = "AddClientFIO";
            this.AddClientFIO.Size = new System.Drawing.Size(287, 22);
            this.AddClientFIO.TabIndex = 9;
            // 
            // AddClientPhone
            // 
            this.AddClientPhone.Location = new System.Drawing.Point(659, 134);
            this.AddClientPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddClientPhone.Name = "AddClientPhone";
            this.AddClientPhone.Size = new System.Drawing.Size(287, 22);
            this.AddClientPhone.TabIndex = 11;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(791, 166);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(156, 28);
            this.AddClientButton.TabIndex = 12;
            this.AddClientButton.Text = "Добавить";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Location = new System.Drawing.Point(791, 457);
            this.AddOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(156, 28);
            this.AddOrderButton.TabIndex = 19;
            this.AddOrderButton.Text = "Добавить";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // AddOrderDurationTime
            // 
            this.AddOrderDurationTime.Location = new System.Drawing.Point(659, 389);
            this.AddOrderDurationTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddOrderDurationTime.Name = "AddOrderDurationTime";
            this.AddOrderDurationTime.Size = new System.Drawing.Size(287, 22);
            this.AddOrderDurationTime.TabIndex = 18;
            // 
            // AddOrderRoomID
            // 
            this.AddOrderRoomID.Location = new System.Drawing.Point(659, 352);
            this.AddOrderRoomID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddOrderRoomID.Name = "AddOrderRoomID";
            this.AddOrderRoomID.Size = new System.Drawing.Size(287, 22);
            this.AddOrderRoomID.TabIndex = 17;
            // 
            // AddOrderClientID
            // 
            this.AddOrderClientID.Location = new System.Drawing.Point(659, 314);
            this.AddOrderClientID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddOrderClientID.Name = "AddOrderClientID";
            this.AddOrderClientID.Size = new System.Drawing.Size(287, 22);
            this.AddOrderClientID.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 393);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Время аренды (ч)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Номер комнаты";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(529, 318);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 16);
            this.label.TabIndex = 13;
            this.label.Text = "Id клиента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Добавить заказ";
            // 
            // AddOrderHookahPrice
            // 
            this.AddOrderHookahPrice.Location = new System.Drawing.Point(659, 425);
            this.AddOrderHookahPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddOrderHookahPrice.Name = "AddOrderHookahPrice";
            this.AddOrderHookahPrice.Size = new System.Drawing.Size(287, 22);
            this.AddOrderHookahPrice.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(529, 428);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Доп. кальян (руб)";
            // 
            // IdOrderForDelTextBox
            // 
            this.IdOrderForDelTextBox.Location = new System.Drawing.Point(659, 514);
            this.IdOrderForDelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IdOrderForDelTextBox.Name = "IdOrderForDelTextBox";
            this.IdOrderForDelTextBox.Size = new System.Drawing.Size(175, 22);
            this.IdOrderForDelTextBox.TabIndex = 24;
            this.IdOrderForDelTextBox.Enter += new System.EventHandler(this.IdOrderForDelTextBox_Enter);
            this.IdOrderForDelTextBox.Leave += new System.EventHandler(this.IdOrderForDelTextBox_Leave);
            // 
            // DelOrderButton
            // 
            this.DelOrderButton.Location = new System.Drawing.Point(857, 507);
            this.DelOrderButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DelOrderButton.Name = "DelOrderButton";
            this.DelOrderButton.Size = new System.Drawing.Size(176, 37);
            this.DelOrderButton.TabIndex = 23;
            this.DelOrderButton.Text = "Удалить заказ";
            this.DelOrderButton.UseVisualStyleBackColor = true;
            this.DelOrderButton.Click += new System.EventHandler(this.DelOrderButton_Click);
            // 
            // AddClientBirthDate
            // 
            this.AddClientBirthDate.Location = new System.Drawing.Point(659, 101);
            this.AddClientBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddClientBirthDate.Name = "AddClientBirthDate";
            this.AddClientBirthDate.Size = new System.Drawing.Size(288, 22);
            this.AddClientBirthDate.TabIndex = 26;
            // 
            // UptadeNewRoomPriceButton
            // 
            this.UptadeNewRoomPriceButton.Location = new System.Drawing.Point(132, 507);
            this.UptadeNewRoomPriceButton.Name = "UptadeNewRoomPriceButton";
            this.UptadeNewRoomPriceButton.Size = new System.Drawing.Size(81, 23);
            this.UptadeNewRoomPriceButton.TabIndex = 27;
            this.UptadeNewRoomPriceButton.Text = "Обновить";
            this.UptadeNewRoomPriceButton.UseVisualStyleBackColor = true;
            this.UptadeNewRoomPriceButton.Click += new System.EventHandler(this.UptadeNewRoomPriceButton_Click);
            // 
            // UpdateRoomIDTextbox
            // 
            this.UpdateRoomIDTextbox.Location = new System.Drawing.Point(19, 463);
            this.UpdateRoomIDTextbox.Name = "UpdateRoomIDTextbox";
            this.UpdateRoomIDTextbox.Size = new System.Drawing.Size(107, 22);
            this.UpdateRoomIDTextbox.TabIndex = 28;
            // 
            // UpdateNewPriceTextBox
            // 
            this.UpdateNewPriceTextBox.Location = new System.Drawing.Point(132, 463);
            this.UpdateNewPriceTextBox.Name = "UpdateNewPriceTextBox";
            this.UpdateNewPriceTextBox.Size = new System.Drawing.Size(126, 22);
            this.UpdateNewPriceTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Id комнаты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Новая цена за час";
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdateNewPriceTextBox);
            this.Controls.Add(this.UpdateRoomIDTextbox);
            this.Controls.Add(this.UptadeNewRoomPriceButton);
            this.Controls.Add(this.AddClientBirthDate);
            this.Controls.Add(this.IdOrderForDelTextBox);
            this.Controls.Add(this.DelOrderButton);
            this.Controls.Add(this.AddOrderHookahPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.AddOrderDurationTime);
            this.Controls.Add(this.AddOrderRoomID);
            this.Controls.Add(this.AddOrderClientID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.AddClientPhone);
            this.Controls.Add(this.AddClientFIO);
            this.Controls.Add(this.ClientPhoneLabel);
            this.Controls.Add(this.ClientBirthDatelabel);
            this.Controls.Add(this.ClientFIOlabel);
            this.Controls.Add(this.UpdateClientLabel);
            this.Controls.Add(this.IdClientForDelTextBox);
            this.Controls.Add(this.DelClientButton);
            this.Controls.Add(this.ClientsOrdersLabel);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AdministratorForm";
            this.Text = "Администратор";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ClientsOrdersLabel;
        private System.Windows.Forms.Button DelClientButton;
        private System.Windows.Forms.TextBox IdClientForDelTextBox;
        private System.Windows.Forms.Label UpdateClientLabel;
        private System.Windows.Forms.Label ClientFIOlabel;
        private System.Windows.Forms.Label ClientBirthDatelabel;
        private System.Windows.Forms.Label ClientPhoneLabel;
        private System.Windows.Forms.TextBox AddClientFIO;
        private System.Windows.Forms.TextBox AddClientPhone;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.TextBox AddOrderDurationTime;
        private System.Windows.Forms.TextBox AddOrderRoomID;
        private System.Windows.Forms.TextBox AddOrderClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddOrderHookahPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IdOrderForDelTextBox;
        private System.Windows.Forms.Button DelOrderButton;
        private System.Windows.Forms.DateTimePicker AddClientBirthDate;
        private System.Windows.Forms.Button UptadeNewRoomPriceButton;
        private System.Windows.Forms.TextBox UpdateRoomIDTextbox;
        private System.Windows.Forms.TextBox UpdateNewPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}