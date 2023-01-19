namespace ADONETLesson4_ClassicAsynchronous
{
    partial class ClassicAsynchronous
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
            this.txt_Request = new System.Windows.Forms.TextBox();
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Transaction = new System.Windows.Forms.Button();
            this.Btn_Async1 = new System.Windows.Forms.Button();
            this.Btn_Async2 = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Request
            // 
            this.txt_Request.Location = new System.Drawing.Point(12, 12);
            this.txt_Request.Name = "txt_Request";
            this.txt_Request.Size = new System.Drawing.Size(1043, 39);
            this.txt_Request.TabIndex = 0;
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.AutoSize = true;
            this.Btn_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fill.Location = new System.Drawing.Point(12, 57);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(105, 41);
            this.Btn_Fill.TabIndex = 1;
            this.Btn_Fill.Text = "Fill";
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.AutoSize = true;
            this.Btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Update.Location = new System.Drawing.Point(123, 57);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(105, 41);
            this.Btn_Update.TabIndex = 1;
            this.Btn_Update.Text = "Update";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Transaction
            // 
            this.Btn_Transaction.AutoSize = true;
            this.Btn_Transaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Transaction.Location = new System.Drawing.Point(464, 57);
            this.Btn_Transaction.Name = "Btn_Transaction";
            this.Btn_Transaction.Size = new System.Drawing.Size(147, 41);
            this.Btn_Transaction.TabIndex = 1;
            this.Btn_Transaction.Text = "Transaction";
            this.Btn_Transaction.UseVisualStyleBackColor = true;
            this.Btn_Transaction.Click += new System.EventHandler(this.Btn_Transaction_Click);
            // 
            // Btn_Async1
            // 
            this.Btn_Async1.AutoSize = true;
            this.Btn_Async1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Async1.Location = new System.Drawing.Point(835, 57);
            this.Btn_Async1.Name = "Btn_Async1";
            this.Btn_Async1.Size = new System.Drawing.Size(107, 41);
            this.Btn_Async1.TabIndex = 1;
            this.Btn_Async1.Text = "Async 1";
            this.Btn_Async1.UseVisualStyleBackColor = true;
            this.Btn_Async1.Click += new System.EventHandler(this.Btn_Async1_Click);
            // 
            // Btn_Async2
            // 
            this.Btn_Async2.AutoSize = true;
            this.Btn_Async2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Async2.Location = new System.Drawing.Point(948, 57);
            this.Btn_Async2.Name = "Btn_Async2";
            this.Btn_Async2.Size = new System.Drawing.Size(107, 41);
            this.Btn_Async2.TabIndex = 1;
            this.Btn_Async2.Text = "Async 2";
            this.Btn_Async2.UseVisualStyleBackColor = true;
            this.Btn_Async2.Click += new System.EventHandler(this.Btn_Async2_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 104);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.Size = new System.Drawing.Size(1043, 438);
            this.dataGridView.TabIndex = 2;
            // 
            // ClassicAsynchronous
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.Btn_Async2);
            this.Controls.Add(this.Btn_Async1);
            this.Controls.Add(this.Btn_Transaction);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_Fill);
            this.Controls.Add(this.txt_Request);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ClassicAsynchronous";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClassicAsynchronous";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Request;
        private Button Btn_Fill;
        private Button Btn_Update;
        private Button Btn_Transaction;
        private Button Btn_Async1;
        private Button Btn_Async2;
        private DataGridView dataGridView;
    }
}