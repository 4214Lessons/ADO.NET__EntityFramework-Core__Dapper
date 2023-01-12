namespace ADONETLesson2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.Btn_Exec = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCommand.Location = new System.Drawing.Point(12, 12);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(1099, 43);
            this.txtCommand.TabIndex = 0;
            // 
            // Btn_Exec
            // 
            this.Btn_Exec.AutoSize = true;
            this.Btn_Exec.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Exec.Location = new System.Drawing.Point(12, 61);
            this.Btn_Exec.Name = "Btn_Exec";
            this.Btn_Exec.Size = new System.Drawing.Size(124, 48);
            this.Btn_Exec.TabIndex = 1;
            this.Btn_Exec.Text = "EXEC";
            this.Btn_Exec.UseVisualStyleBackColor = true;
            this.Btn_Exec.Click += new System.EventHandler(this.Btn_Exec_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1099, 508);
            this.dataGridView1.TabIndex = 2;
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.AutoSize = true;
            this.Btn_Fill.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Fill.Location = new System.Drawing.Point(857, 61);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(124, 48);
            this.Btn_Fill.TabIndex = 1;
            this.Btn_Fill.Text = "Fill";
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.AutoSize = true;
            this.Btn_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Btn_Update.Location = new System.Drawing.Point(987, 61);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(124, 48);
            this.Btn_Update.TabIndex = 1;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Fill);
            this.Controls.Add(this.Btn_Exec);
            this.Controls.Add(this.txtCommand);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCommand;
        private Button Btn_Exec;
        private DataGridView dataGridView1;
        private Button Btn_Fill;
        private Button Btn_Update;
    }
}