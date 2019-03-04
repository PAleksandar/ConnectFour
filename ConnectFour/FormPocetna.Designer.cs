namespace ConnectFour
{
    partial class FormPocetna
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
            this.btnNovaIgra = new System.Windows.Forms.Button();
            this.btnUputstvo = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaIgra
            // 
            this.btnNovaIgra.BackColor = System.Drawing.Color.Transparent;
            this.btnNovaIgra.BackgroundImage = global::ConnectFour.Properties.Resources.Nova_igra1;
            this.btnNovaIgra.FlatAppearance.BorderSize = 0;
            this.btnNovaIgra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNovaIgra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNovaIgra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaIgra.Location = new System.Drawing.Point(119, 336);
            this.btnNovaIgra.Name = "btnNovaIgra";
            this.btnNovaIgra.Size = new System.Drawing.Size(120, 42);
            this.btnNovaIgra.TabIndex = 3;
            this.btnNovaIgra.TabStop = false;
            this.btnNovaIgra.Tag = "dugmeNovaIgra";
            this.btnNovaIgra.UseVisualStyleBackColor = false;
            this.btnNovaIgra.Click += new System.EventHandler(this.btnNovaIgra_Click);
            // 
            // btnUputstvo
            // 
            this.btnUputstvo.BackColor = System.Drawing.Color.Transparent;
            this.btnUputstvo.BackgroundImage = global::ConnectFour.Properties.Resources.Uputstvo;
            this.btnUputstvo.FlatAppearance.BorderSize = 0;
            this.btnUputstvo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUputstvo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUputstvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUputstvo.Location = new System.Drawing.Point(261, 336);
            this.btnUputstvo.Name = "btnUputstvo";
            this.btnUputstvo.Size = new System.Drawing.Size(120, 42);
            this.btnUputstvo.TabIndex = 4;
            this.btnUputstvo.TabStop = false;
            this.btnUputstvo.Tag = "dugmeNovaIgra";
            this.btnUputstvo.UseVisualStyleBackColor = false;
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.BackgroundImage = global::ConnectFour.Properties.Resources.Izlaz;
            this.btnIzlaz.FlatAppearance.BorderSize = 0;
            this.btnIzlaz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnIzlaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzlaz.Location = new System.Drawing.Point(409, 336);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(120, 42);
            this.btnIzlaz.TabIndex = 5;
            this.btnIzlaz.TabStop = false;
            this.btnIzlaz.Tag = "dugmeNovaIgra";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConnectFour.Properties.Resources.st1_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(668, 434);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnUputstvo);
            this.Controls.Add(this.btnNovaIgra);
            this.DoubleBuffered = true;
            this.Name = "FormPocetna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect four";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaIgra;
        private System.Windows.Forms.Button btnUputstvo;
        private System.Windows.Forms.Button btnIzlaz;
    }
}

