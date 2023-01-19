namespace ADONETLesson4_AsyncAndAwait
{
    partial class AsyncAndAwait
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txt_Request = new System.Windows.Forms.TextBox();
            this.Btn_Async = new System.Windows.Forms.Button();
            this.Btn_Test1 = new System.Windows.Forms.Button();
            this.Btn_Test2 = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView.Size = new System.Drawing.Size(1025, 391);
            this.dataGridView.TabIndex = 0;
            // 
            // txt_Request
            // 
            this.txt_Request.Location = new System.Drawing.Point(12, 12);
            this.txt_Request.Name = "txt_Request";
            this.txt_Request.Size = new System.Drawing.Size(1025, 39);
            this.txt_Request.TabIndex = 1;
            // 
            // Btn_Async
            // 
            this.Btn_Async.AutoSize = true;
            this.Btn_Async.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Async.Location = new System.Drawing.Point(932, 57);
            this.Btn_Async.Name = "Btn_Async";
            this.Btn_Async.Size = new System.Drawing.Size(105, 41);
            this.Btn_Async.TabIndex = 2;
            this.Btn_Async.Text = "Async";
            this.Btn_Async.UseVisualStyleBackColor = true;
            this.Btn_Async.Click += new System.EventHandler(this.Btn_Async_Click);
            // 
            // Btn_Test1
            // 
            this.Btn_Test1.AutoSize = true;
            this.Btn_Test1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Test1.Location = new System.Drawing.Point(12, 57);
            this.Btn_Test1.Name = "Btn_Test1";
            this.Btn_Test1.Size = new System.Drawing.Size(105, 41);
            this.Btn_Test1.TabIndex = 2;
            this.Btn_Test1.Text = "Test 1";
            this.Btn_Test1.UseVisualStyleBackColor = true;
            this.Btn_Test1.Click += new System.EventHandler(this.Btn_Test1_Click);
            // 
            // Btn_Test2
            // 
            this.Btn_Test2.AutoSize = true;
            this.Btn_Test2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Test2.Location = new System.Drawing.Point(399, 57);
            this.Btn_Test2.Name = "Btn_Test2";
            this.Btn_Test2.Size = new System.Drawing.Size(105, 41);
            this.Btn_Test2.TabIndex = 2;
            this.Btn_Test2.Text = "Test 2";
            this.Btn_Test2.UseVisualStyleBackColor = true;
            this.Btn_Test2.Click += new System.EventHandler(this.Btn_Test2_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.AutoSize = true;
            this.Btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cancel.Location = new System.Drawing.Point(510, 57);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(105, 41);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "Cancel";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // AsyncAndAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 507);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Test2);
            this.Controls.Add(this.Btn_Test1);
            this.Controls.Add(this.Btn_Async);
            this.Controls.Add(this.txt_Request);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AsyncAndAwait";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsyncAndAwait";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView;
        private TextBox txt_Request;
        private Button Btn_Async;
        private Button Btn_Test1;
        private Button Btn_Test2;
        private Button Btn_Cancel;
    }
}