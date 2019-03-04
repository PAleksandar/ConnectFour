namespace ConnectFour
{
    partial class FormDialog
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
            this.btnPrihvati = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.rbPrvi = new System.Windows.Forms.RadioButton();
            this.rdbDrugi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnPrihvati
            // 
            this.btnPrihvati.BackColor = System.Drawing.Color.Transparent;
            this.btnPrihvati.BackgroundImage = global::ConnectFour.Properties.Resources.Prihvati;
            this.btnPrihvati.FlatAppearance.BorderSize = 0;
            this.btnPrihvati.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrihvati.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrihvati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrihvati.Location = new System.Drawing.Point(97, 240);
            this.btnPrihvati.Name = "btnPrihvati";
            this.btnPrihvati.Size = new System.Drawing.Size(120, 42);
            this.btnPrihvati.TabIndex = 4;
            this.btnPrihvati.TabStop = false;
            this.btnPrihvati.Tag = "dugmeNovaIgra";
            this.btnPrihvati.UseVisualStyleBackColor = false;
            this.btnPrihvati.Click += new System.EventHandler(this.btnPrihvati_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Transparent;
            this.btnOdustani.BackgroundImage = global::ConnectFour.Properties.Resources.Odustani;
            this.btnOdustani.FlatAppearance.BorderSize = 0;
            this.btnOdustani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOdustani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(235, 240);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(120, 42);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.TabStop = false;
            this.btnOdustani.Tag = "dugmeNovaIgra";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // rbPrvi
            // 
            this.rbPrvi.BackColor = System.Drawing.Color.Transparent;
            this.rbPrvi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rbPrvi.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPrvi.Checked = true;
            this.rbPrvi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rbPrvi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rbPrvi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rbPrvi.Location = new System.Drawing.Point(140, 105);
            this.rbPrvi.Name = "rbPrvi";
            this.rbPrvi.Size = new System.Drawing.Size(30, 30);
            this.rbPrvi.TabIndex = 6;
            this.rbPrvi.TabStop = true;
            this.rbPrvi.UseVisualStyleBackColor = false;
            // 
            // rdbDrugi
            // 
            this.rdbDrugi.BackColor = System.Drawing.Color.Transparent;
            this.rdbDrugi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rdbDrugi.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbDrugi.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.rdbDrugi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rdbDrugi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rdbDrugi.Location = new System.Drawing.Point(140, 141);
            this.rdbDrugi.Name = "rdbDrugi";
            this.rdbDrugi.Size = new System.Drawing.Size(30, 30);
            this.rdbDrugi.TabIndex = 7;
            this.rdbDrugi.UseVisualStyleBackColor = false;
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConnectFour.Properties.Resources.st2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 324);
            this.Controls.Add(this.rdbDrugi);
            this.Controls.Add(this.rbPrvi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPrihvati);
            this.DoubleBuffered = true;
            this.Name = "FormDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect four";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrihvati;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RadioButton rbPrvi;
        private System.Windows.Forms.RadioButton rdbDrugi;
    }
}