namespace Presentacion
{
    partial class formRegionRegistrar
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
            label1 = new Label();
            txtRegionName = new TextBox();
            btnRegistrar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre Region:";
            // 
            // txtRegionName
            // 
            txtRegionName.Location = new Point(11, 28);
            txtRegionName.Margin = new Padding(2);
            txtRegionName.Name = "txtRegionName";
            txtRegionName.Size = new Size(192, 23);
            txtRegionName.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(11, 64);
            btnRegistrar.Margin = new Padding(2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(78, 23);
            btnRegistrar.TabIndex = 6;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formRegionRegistrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 98);
            Controls.Add(btnRegistrar);
            Controls.Add(label1);
            Controls.Add(txtRegionName);
            Margin = new Padding(2);
            Name = "formRegionRegistrar";
            Text = "frmRegionRegistrar";
            Load += frmRegionRegistrar_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRegionName;
        private Button btnRegistrar;
        private ErrorProvider errorProvider1;
    }
}