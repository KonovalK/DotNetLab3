namespace ProccessManager
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
            this.ProcessesDataGridView = new System.Windows.Forms.DataGridView();
            this.NameProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartCalcBtn = new System.Windows.Forms.Button();
            this.StartProcLabel = new System.Windows.Forms.Label();
            this.StartWordBtn = new System.Windows.Forms.Button();
            this.StartExcelBtn = new System.Windows.Forms.Button();
            this.StartPowerPointBtn = new System.Windows.Forms.Button();
            this.StartAccessBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessesDataGridView
            // 
            this.ProcessesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProcessesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProcess,
            this.Memory,
            this.timeStar,
            this.Priority,
            this.StreamCount});
            this.ProcessesDataGridView.Location = new System.Drawing.Point(-3, 1);
            this.ProcessesDataGridView.Name = "ProcessesDataGridView";
            this.ProcessesDataGridView.RowHeadersWidth = 51;
            this.ProcessesDataGridView.RowTemplate.Height = 29;
            this.ProcessesDataGridView.Size = new System.Drawing.Size(805, 431);
            this.ProcessesDataGridView.TabIndex = 0;
            this.ProcessesDataGridView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProcessesDataGridView_MouseClick);
            // 
            // NameProcess
            // 
            this.NameProcess.HeaderText = "Назва";
            this.NameProcess.MinimumWidth = 6;
            this.NameProcess.Name = "NameProcess";
            this.NameProcess.Width = 125;
            // 
            // Memory
            // 
            this.Memory.HeaderText = "Пам\'ять";
            this.Memory.MinimumWidth = 6;
            this.Memory.Name = "Memory";
            this.Memory.Width = 125;
            // 
            // timeStar
            // 
            this.timeStar.HeaderText = "Час початку";
            this.timeStar.MinimumWidth = 6;
            this.timeStar.Name = "timeStar";
            this.timeStar.Width = 125;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Пріоритет";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.Width = 125;
            // 
            // StreamCount
            // 
            this.StreamCount.HeaderText = "Кількість потоків";
            this.StreamCount.MinimumWidth = 6;
            this.StreamCount.Name = "StreamCount";
            this.StreamCount.Width = 175;
            // 
            // StartCalcBtn
            // 
            this.StartCalcBtn.Location = new System.Drawing.Point(27, 478);
            this.StartCalcBtn.Name = "StartCalcBtn";
            this.StartCalcBtn.Size = new System.Drawing.Size(121, 33);
            this.StartCalcBtn.TabIndex = 1;
            this.StartCalcBtn.Text = "Калькулятор";
            this.StartCalcBtn.UseVisualStyleBackColor = true;
            this.StartCalcBtn.Click += new System.EventHandler(this.StartCalcBtn_Click);
            // 
            // StartProcLabel
            // 
            this.StartProcLabel.AutoSize = true;
            this.StartProcLabel.Location = new System.Drawing.Point(12, 446);
            this.StartProcLabel.Name = "StartProcLabel";
            this.StartProcLabel.Size = new System.Drawing.Size(136, 20);
            this.StartProcLabel.TabIndex = 2;
            this.StartProcLabel.Text = "Запустити процес:";
            // 
            // StartWordBtn
            // 
            this.StartWordBtn.Location = new System.Drawing.Point(154, 478);
            this.StartWordBtn.Name = "StartWordBtn";
            this.StartWordBtn.Size = new System.Drawing.Size(121, 33);
            this.StartWordBtn.TabIndex = 3;
            this.StartWordBtn.Text = "MS Word";
            this.StartWordBtn.UseVisualStyleBackColor = true;
            this.StartWordBtn.Click += new System.EventHandler(this.StartWordBtn_Click);
            // 
            // StartExcelBtn
            // 
            this.StartExcelBtn.Location = new System.Drawing.Point(281, 478);
            this.StartExcelBtn.Name = "StartExcelBtn";
            this.StartExcelBtn.Size = new System.Drawing.Size(121, 33);
            this.StartExcelBtn.TabIndex = 4;
            this.StartExcelBtn.Text = "MS Excel";
            this.StartExcelBtn.UseVisualStyleBackColor = true;
            this.StartExcelBtn.Click += new System.EventHandler(this.StartExcelBtn_Click);
            // 
            // StartPowerPointBtn
            // 
            this.StartPowerPointBtn.Location = new System.Drawing.Point(408, 478);
            this.StartPowerPointBtn.Name = "StartPowerPointBtn";
            this.StartPowerPointBtn.Size = new System.Drawing.Size(121, 33);
            this.StartPowerPointBtn.TabIndex = 5;
            this.StartPowerPointBtn.Text = "MS PowerPoint";
            this.StartPowerPointBtn.UseVisualStyleBackColor = true;
            this.StartPowerPointBtn.Click += new System.EventHandler(this.StartPowerPointBtn_Click);
            // 
            // StartAccessBtn
            // 
            this.StartAccessBtn.Location = new System.Drawing.Point(535, 478);
            this.StartAccessBtn.Name = "StartAccessBtn";
            this.StartAccessBtn.Size = new System.Drawing.Size(121, 33);
            this.StartAccessBtn.TabIndex = 6;
            this.StartAccessBtn.Text = "MS Access";
            this.StartAccessBtn.UseVisualStyleBackColor = true;
            this.StartAccessBtn.Click += new System.EventHandler(this.StartAccessBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.StartAccessBtn);
            this.Controls.Add(this.StartPowerPointBtn);
            this.Controls.Add(this.StartExcelBtn);
            this.Controls.Add(this.StartWordBtn);
            this.Controls.Add(this.StartProcLabel);
            this.Controls.Add(this.StartCalcBtn);
            this.Controls.Add(this.ProcessesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProcessesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memory;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamCount;
        private System.Windows.Forms.Button StartCalcBtn;
        private System.Windows.Forms.Label StartProcLabel;
        private System.Windows.Forms.Button StartWordBtn;
        private System.Windows.Forms.Button StartExcelBtn;
        private System.Windows.Forms.Button StartPowerPointBtn;
        private System.Windows.Forms.Button StartAccessBtn;
    }
}
