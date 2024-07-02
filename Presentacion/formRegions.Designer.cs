namespace Presentacion
{
    partial class formRegions
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
            btnListar = new Button();
            dgvRegions = new DataGridView();
            RegionId = new DataGridViewTextBoxColumn();
            RegionName = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRegions).BeginInit();
            SuspendLayout();
            // 
            // btnListar
            // 
            btnListar.Location = new Point(37, 352);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 0;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // dgvRegions
            // 
            dgvRegions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRegions.Columns.AddRange(new DataGridViewColumn[] { RegionId, RegionName });
            dgvRegions.Location = new Point(10, 5);
            dgvRegions.Name = "dgvRegions";
            dgvRegions.RowHeadersWidth = 62;
            dgvRegions.RowTemplate.Height = 25;
            dgvRegions.Size = new Size(266, 341);
            dgvRegions.TabIndex = 1;
            dgvRegions.DoubleClick += dgvRegions_DoubleClick;
            // 
            // RegionId
            // 
            RegionId.DataPropertyName = "RegionId";
            RegionId.HeaderText = "Id";
            RegionId.Name = "RegionId";
            // 
            // RegionName
            // 
            RegionName.DataPropertyName = "RegionName";
            RegionName.HeaderText = "Region";
            RegionName.Name = "RegionName";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(123, 352);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(78, 24);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // frmRegions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 380);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvRegions);
            Controls.Add(btnListar);
            Name = "frmRegions";
            Text = "Regions";
            ((System.ComponentModel.ISupportInitialize)dgvRegions).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnRegistrar;
        public Button btnListar;
        public DataGridView dgvRegions;
        private DataGridViewTextBoxColumn RegionId;
        private DataGridViewTextBoxColumn RegionName;
    }
}
