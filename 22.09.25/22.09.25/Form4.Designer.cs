namespace _22._09._25
{
    partial class Form4
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
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ceramics = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plastic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Metal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.Budget,
            this.Cotton,
            this.Wood,
            this.Leather,
            this.Ceramics,
            this.Plastic,
            this.Glass,
            this.Metal});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            // 
            // Budget
            // 
            this.Budget.HeaderText = "Budget";
            this.Budget.Name = "Budget";
            // 
            // Cotton
            // 
            this.Cotton.HeaderText = "Cotton";
            this.Cotton.Name = "Cotton";
            // 
            // Wood
            // 
            this.Wood.HeaderText = "Wood";
            this.Wood.Name = "Wood";
            // 
            // Leather
            // 
            this.Leather.HeaderText = "Leather";
            this.Leather.Name = "Leather";
            // 
            // Ceramics
            // 
            this.Ceramics.HeaderText = "Ceramics";
            this.Ceramics.Name = "Ceramics";
            // 
            // Plastic
            // 
            this.Plastic.HeaderText = "Plastic";
            this.Plastic.Name = "Plastic";
            // 
            // Glass
            // 
            this.Glass.HeaderText = "Glass";
            this.Glass.Name = "Glass";
            // 
            // Metal
            // 
            this.Metal.HeaderText = "Metal";
            this.Metal.Name = "Metal";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wood;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leather;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ceramics;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plastic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Glass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Metal;
    }
}