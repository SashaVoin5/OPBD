
namespace BDHotel
{
    partial class DeleteEmployeesForm
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
            this.txt_Delete = new System.Windows.Forms.TextBox();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Delete
            // 
            this.txt_Delete.Location = new System.Drawing.Point(15, 73);
            this.txt_Delete.Name = "txt_Delete";
            this.txt_Delete.Size = new System.Drawing.Size(235, 20);
            this.txt_Delete.TabIndex = 3;
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(12, 120);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(238, 23);
            this.bt_Delete.TabIndex = 4;
            this.bt_Delete.Text = "Удалить ";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите код сотрудника, которого хотите удалить";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bt_Delete);
            this.panel1.Controls.Add(this.txt_Delete);
            this.panel1.Location = new System.Drawing.Point(-1, -14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 172);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Введите ID человека,который хотите удалить";
            // 
            // DeleteEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(266, 156);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить сотрудника";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Delete;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}