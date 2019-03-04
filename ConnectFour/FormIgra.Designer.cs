namespace ConnectFour
{
    partial class FormIgra
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
            this.btnIgrajOpet = new System.Windows.Forms.Button();
            this.btnGlavniMeni = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIgrajOpet
            // 
            this.btnIgrajOpet.BackColor = System.Drawing.Color.Transparent;
            this.btnIgrajOpet.BackgroundImage = global::ConnectFour.Properties.Resources.Igraj_opet;
            this.btnIgrajOpet.FlatAppearance.BorderSize = 0;
            this.btnIgrajOpet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIgrajOpet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIgrajOpet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgrajOpet.Location = new System.Drawing.Point(596, 294);
            this.btnIgrajOpet.Name = "btnIgrajOpet";
            this.btnIgrajOpet.Size = new System.Drawing.Size(120, 42);
            this.btnIgrajOpet.TabIndex = 4;
            this.btnIgrajOpet.TabStop = false;
            this.btnIgrajOpet.Tag = "dugmeNovaIgra";
            this.btnIgrajOpet.UseVisualStyleBackColor = false;
            this.btnIgrajOpet.Click += new System.EventHandler(this.btnIgrajOpet_Click);
            // 
            // btnGlavniMeni
            // 
            this.btnGlavniMeni.BackColor = System.Drawing.Color.Transparent;
            this.btnGlavniMeni.BackgroundImage = global::ConnectFour.Properties.Resources.Glavni_meni;
            this.btnGlavniMeni.FlatAppearance.BorderSize = 0;
            this.btnGlavniMeni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGlavniMeni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGlavniMeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGlavniMeni.Location = new System.Drawing.Point(596, 357);
            this.btnGlavniMeni.Name = "btnGlavniMeni";
            this.btnGlavniMeni.Size = new System.Drawing.Size(120, 42);
            this.btnGlavniMeni.TabIndex = 5;
            this.btnGlavniMeni.TabStop = false;
            this.btnGlavniMeni.Tag = "dugmeNovaIgra";
            this.btnGlavniMeni.UseVisualStyleBackColor = false;
            this.btnGlavniMeni.Click += new System.EventHandler(this.btnGlavniMeni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(635, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 51);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(635, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 51);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // FormIgra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConnectFour.Properties.Resources.st3_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(757, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGlavniMeni);
            this.Controls.Add(this.btnIgrajOpet);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(773, 550);
            this.MinimumSize = new System.Drawing.Size(773, 550);
            this.Name = "FormIgra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect four";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIgra_FormClosed);
            this.Load += new System.EventHandler(this.FormIgra_Load);
            this.Click += new System.EventHandler(this.FormIgra_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIgrajOpet;
        private System.Windows.Forms.Button btnGlavniMeni;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}