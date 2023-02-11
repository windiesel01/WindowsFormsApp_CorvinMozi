namespace WindowsFormsApp_CorvinMozi
{
    partial class Form1
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
            this.pictureBox_teremKep = new System.Windows.Forms.PictureBox();
            this.panel_jegyek = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_teremKep)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_teremKep
            // 
            this.pictureBox_teremKep.BackgroundImage = global::WindowsFormsApp_CorvinMozi.Properties.Resources.Korda;
            this.pictureBox_teremKep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_teremKep.Location = new System.Drawing.Point(27, 40);
            this.pictureBox_teremKep.Name = "pictureBox_teremKep";
            this.pictureBox_teremKep.Size = new System.Drawing.Size(184, 218);
            this.pictureBox_teremKep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_teremKep.TabIndex = 0;
            this.pictureBox_teremKep.TabStop = false;
            // 
            // panel_jegyek
            // 
            this.panel_jegyek.Location = new System.Drawing.Point(247, 40);
            this.panel_jegyek.Name = "panel_jegyek";
            this.panel_jegyek.Size = new System.Drawing.Size(357, 182);
            this.panel_jegyek.TabIndex = 1;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(247, 273);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(115, 57);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Mentés";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_left
            // 
            this.button_left.BackgroundImage = global::WindowsFormsApp_CorvinMozi.Properties.Resources.balnyil;
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_left.Location = new System.Drawing.Point(247, 336);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(115, 57);
            this.button_left.TabIndex = 3;
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.BackgroundImage = global::WindowsFormsApp_CorvinMozi.Properties.Resources.jobbra;
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_right.Location = new System.Drawing.Point(489, 336);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(115, 57);
            this.button_right.TabIndex = 4;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.panel_jegyek);
            this.Controls.Add(this.pictureBox_teremKep);
            this.Name = "Form1";
            this.Text = "Korda Sándor terem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_teremKep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_teremKep;
        private System.Windows.Forms.Panel panel_jegyek;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
    }
}

