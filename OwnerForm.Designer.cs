
namespace Приложение
{
    partial class OwnerForm
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.DescriptionForDelete = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSwitchFormAd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.Size = new System.Drawing.Size(684, 276);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(472, 284);
            this.btnSaveChanges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(212, 44);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Сохранить изменения";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(472, 381);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(212, 47);
            this.btnDeleteEmployee.TabIndex = 2;
            this.btnDeleteEmployee.Text = "Удалить";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // DescriptionForDelete
            // 
            this.DescriptionForDelete.Location = new System.Drawing.Point(12, 396);
            this.DescriptionForDelete.Name = "DescriptionForDelete";
            this.DescriptionForDelete.Size = new System.Drawing.Size(313, 73);
            this.DescriptionForDelete.TabIndex = 3;
            this.DescriptionForDelete.Text = "Чтобы удалить администратора, выделите всю строку и нажмите кнопку \"Удалить\"";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(313, 72);
            this.label7.TabIndex = 11;
            this.label7.Text = "Чтобы изменить/добавить администратора, достаточно изменить интересующие Вас ячей" +
    "ки, после чего нажать на кнопку \"Сохранить изменения\"";
            // 
            // btnSwitchFormAd
            // 
            this.btnSwitchFormAd.Location = new System.Drawing.Point(691, 0);
            this.btnSwitchFormAd.Name = "btnSwitchFormAd";
            this.btnSwitchFormAd.Size = new System.Drawing.Size(183, 50);
            this.btnSwitchFormAd.TabIndex = 13;
            this.btnSwitchFormAd.Text = "Войти администратором";
            this.btnSwitchFormAd.UseVisualStyleBackColor = true;
            this.btnSwitchFormAd.Click += new System.EventHandler(this.btnSwitchFormAd_Click);
            // 
            // OwnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 554);
            this.Controls.Add(this.btnSwitchFormAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescriptionForDelete);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OwnerForm";
            this.Text = "OwnerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Label DescriptionForDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSwitchFormAd;
    }
}