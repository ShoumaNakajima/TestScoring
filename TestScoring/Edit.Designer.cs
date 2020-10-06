namespace TestScoring
{
    partial class Edit
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
            this.dgvEditTable = new System.Windows.Forms.DataGridView();
            this.bntDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditTable
            // 
            this.dgvEditTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditTable.Location = new System.Drawing.Point(24, 12);
            this.dgvEditTable.Name = "dgvEditTable";
            this.dgvEditTable.RowTemplate.Height = 21;
            this.dgvEditTable.Size = new System.Drawing.Size(448, 426);
            this.dgvEditTable.TabIndex = 1;
            this.dgvEditTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(487, 408);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 30);
            this.bntDelete.TabIndex = 102;
            this.bntDelete.Text = "削除";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 450);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.dgvEditTable);
            this.Name = "Edit";
            this.Text = "編集";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditTable;
        private System.Windows.Forms.Button bntDelete;
    }
}