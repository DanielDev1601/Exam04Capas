namespace Presentacion
{
    partial class formRegionEditar
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
            components = new System.ComponentModel.Container();
            btnGrabar = new Button();
            label1 = new Label();
            txtRegionNameEdit = new TextBox();
            label3 = new Label();
            txtIdEdit = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(11, 105);
            btnGrabar.Margin = new Padding(2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(78, 23);
            btnGrabar.TabIndex = 11;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 10;
            label1.Text = "Nombre Region:";
            // 
            // txtRegionNameEdit
            // 
            txtRegionNameEdit.Location = new Point(11, 73);
            txtRegionNameEdit.Margin = new Padding(2);
            txtRegionNameEdit.Name = "txtRegionNameEdit";
            txtRegionNameEdit.Size = new Size(192, 23);
            txtRegionNameEdit.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 14;
            label3.Text = "Id:";
            // 
            // txtIdEdit
            // 
            txtIdEdit.Enabled = false;
            txtIdEdit.Location = new Point(11, 27);
            txtIdEdit.Margin = new Padding(2);
            txtIdEdit.Name = "txtIdEdit";
            txtIdEdit.Size = new Size(94, 23);
            txtIdEdit.TabIndex = 15;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formRegionEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(226, 134);
            Controls.Add(txtIdEdit);
            Controls.Add(label3);
            Controls.Add(btnGrabar);
            Controls.Add(label1);
            Controls.Add(txtRegionNameEdit);
            Name = "formRegionEditar";
            Text = "frmRegionEditar";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnGrabar;
        private Label label1;
        private Label label3;
        public TextBox txtIdEdit;
        public ComboBox cboVisibleEdit;
        public TextBox txtRegionNameEdit;
        private ErrorProvider errorProvider1;
    }
}