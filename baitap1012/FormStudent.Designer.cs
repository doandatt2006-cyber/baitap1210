namespace baitap1012
{
    partial class FormStudent
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
            progressBar1 = new ProgressBar();
            lblPercent = new Label();
            btnLoadData = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(45, 28);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(154, 29);
            progressBar1.TabIndex = 0;
            // 
            // lblPercent
            // 
            lblPercent.AutoSize = true;
            lblPercent.Location = new Point(61, 88);
            lblPercent.Name = "lblPercent";
            lblPercent.Size = new Size(29, 20);
            lblPercent.TabIndex = 1;
            lblPercent.Text = "0%";
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(45, 139);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(168, 29);
            btnLoadData.TabIndex = 2;
            btnLoadData.Text = "Nạp dữ liệu (Async)";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(45, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(662, 202);
            dataGridView1.TabIndex = 3;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnLoadData);
            Controls.Add(lblPercent);
            Controls.Add(progressBar1);
            Name = "FormStudent";
            Text = "FormStudent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblPercent;
        private Button btnLoadData;
        private DataGridView dataGridView1;
    }
}