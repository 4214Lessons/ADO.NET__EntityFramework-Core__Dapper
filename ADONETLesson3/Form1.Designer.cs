namespace ADONETLesson3
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
            this.cmBoxProviders = new System.Windows.Forms.ComboBox();
            this.txtConStr = new System.Windows.Forms.TextBox();
            this.txtRequest = new System.Windows.Forms.TextBox();
            this.btnGetAllProviders = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmBoxProviders
            // 
            this.cmBoxProviders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmBoxProviders.FormattingEnabled = true;
            this.cmBoxProviders.Location = new System.Drawing.Point(12, 12);
            this.cmBoxProviders.Name = "cmBoxProviders";
            this.cmBoxProviders.Size = new System.Drawing.Size(491, 34);
            this.cmBoxProviders.TabIndex = 0;
            this.cmBoxProviders.SelectedIndexChanged += new System.EventHandler(this.cmBoxProviders_SelectedIndexChanged);
            // 
            // txtConStr
            // 
            this.txtConStr.Location = new System.Drawing.Point(12, 90);
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.ReadOnly = true;
            this.txtConStr.Size = new System.Drawing.Size(1001, 33);
            this.txtConStr.TabIndex = 1;
            // 
            // txtRequest
            // 
            this.txtRequest.Location = new System.Drawing.Point(12, 171);
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.Size = new System.Drawing.Size(663, 33);
            this.txtRequest.TabIndex = 1;
            // 
            // btnGetAllProviders
            // 
            this.btnGetAllProviders.Location = new System.Drawing.Point(693, 12);
            this.btnGetAllProviders.Name = "btnGetAllProviders";
            this.btnGetAllProviders.Size = new System.Drawing.Size(320, 33);
            this.btnGetAllProviders.TabIndex = 2;
            this.btnGetAllProviders.Text = "Get All Providers";
            this.btnGetAllProviders.UseVisualStyleBackColor = true;
            this.btnGetAllProviders.Click += new System.EventHandler(this.btnGetAllProviders_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(695, 171);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(318, 33);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1001, 443);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "ConnectionString:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "SQL Request:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 665);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.btnGetAllProviders);
            this.Controls.Add(this.txtRequest);
            this.Controls.Add(this.txtConStr);
            this.Controls.Add(this.cmBoxProviders);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmBoxProviders;
        private TextBox txtConStr;
        private TextBox txtRequest;
        private Button btnGetAllProviders;
        private Button btnExecute;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
    }
}