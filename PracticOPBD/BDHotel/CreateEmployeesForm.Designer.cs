
namespace BDHotel
{
    partial class CreateEmployeesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Grid_EmployeesCreate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LName = new System.Windows.Forms.TextBox();
            this.txt_FName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_EmployeesCreate)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid_EmployeesCreate
            // 
            this.Grid_EmployeesCreate.AllowUserToAddRows = false;
            this.Grid_EmployeesCreate.AllowUserToDeleteRows = false;
            this.Grid_EmployeesCreate.AllowUserToResizeColumns = false;
            this.Grid_EmployeesCreate.AllowUserToResizeRows = false;
            this.Grid_EmployeesCreate.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.Grid_EmployeesCreate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_EmployeesCreate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Grid_EmployeesCreate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_EmployeesCreate.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid_EmployeesCreate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_EmployeesCreate.DefaultCellStyle = dataGridViewCellStyle10;
            this.Grid_EmployeesCreate.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid_EmployeesCreate.EnableHeadersVisualStyles = false;
            this.Grid_EmployeesCreate.Location = new System.Drawing.Point(12, 12);
            this.Grid_EmployeesCreate.Name = "Grid_EmployeesCreate";
            this.Grid_EmployeesCreate.RowHeadersVisible = false;
            this.Grid_EmployeesCreate.Size = new System.Drawing.Size(673, 202);
            this.Grid_EmployeesCreate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите ID для поиска";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(210, 6);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(213, 20);
            this.txt_ID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(150, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Данные, для изменения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(113, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(150, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя";
            // 
            // txt_LName
            // 
            this.txt_LName.Location = new System.Drawing.Point(193, 66);
            this.txt_LName.Name = "txt_LName";
            this.txt_LName.Size = new System.Drawing.Size(230, 20);
            this.txt_LName.TabIndex = 10;
            // 
            // txt_FName
            // 
            this.txt_FName.Location = new System.Drawing.Point(193, 92);
            this.txt_FName.Name = "txt_FName";
            this.txt_FName.Size = new System.Drawing.Size(230, 20);
            this.txt_FName.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(123, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(193, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_ID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_FName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_LName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 227);
            this.panel1.TabIndex = 15;
            // 
            // CreateEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(441, 223);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Grid_EmployeesCreate);
            this.Name = "CreateEmployeesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateEmployeesForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_EmployeesCreate)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_EmployeesCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_LName;
        private System.Windows.Forms.TextBox txt_FName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}