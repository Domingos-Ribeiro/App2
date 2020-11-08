namespace SecondApp
{
    partial class App2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_Happy = new System.Windows.Forms.RadioButton();
            this.rdb_Sad = new System.Windows.Forms.RadioButton();
            this.pict_Happy = new System.Windows.Forms.PictureBox();
            this.pic_Sad = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_Happy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sad)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_Sad);
            this.groupBox1.Controls.Add(this.rdb_Happy);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(154, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdb_Happy
            // 
            this.rdb_Happy.AutoSize = true;
            this.rdb_Happy.Location = new System.Drawing.Point(36, 61);
            this.rdb_Happy.Name = "rdb_Happy";
            this.rdb_Happy.Size = new System.Drawing.Size(56, 17);
            this.rdb_Happy.TabIndex = 0;
            this.rdb_Happy.TabStop = true;
            this.rdb_Happy.Text = "Happy";
            this.rdb_Happy.UseVisualStyleBackColor = true;
            this.rdb_Happy.CheckedChanged += new System.EventHandler(this.rdb_Happy_CheckedChanged);
            // 
            // rdb_Sad
            // 
            this.rdb_Sad.AutoSize = true;
            this.rdb_Sad.Location = new System.Drawing.Point(48, 212);
            this.rdb_Sad.Name = "rdb_Sad";
            this.rdb_Sad.Size = new System.Drawing.Size(44, 17);
            this.rdb_Sad.TabIndex = 1;
            this.rdb_Sad.TabStop = true;
            this.rdb_Sad.Text = "Sad";
            this.rdb_Sad.UseVisualStyleBackColor = true;
            this.rdb_Sad.CheckedChanged += new System.EventHandler(this.rdb_Sad_CheckedChanged);
            // 
            // pict_Happy
            // 
            this.pict_Happy.Image = ((System.Drawing.Image)(resources.GetObject("pict_Happy.Image")));
            this.pict_Happy.Location = new System.Drawing.Point(255, 106);
            this.pict_Happy.Name = "pict_Happy";
            this.pict_Happy.Size = new System.Drawing.Size(130, 128);
            this.pict_Happy.TabIndex = 1;
            this.pict_Happy.TabStop = false;
            this.pict_Happy.Visible = false;
            // 
            // pic_Sad
            // 
            this.pic_Sad.Image = ((System.Drawing.Image)(resources.GetObject("pic_Sad.Image")));
            this.pic_Sad.Location = new System.Drawing.Point(255, 106);
            this.pic_Sad.Name = "pic_Sad";
            this.pic_Sad.Size = new System.Drawing.Size(130, 126);
            this.pic_Sad.TabIndex = 1;
            this.pic_Sad.TabStop = false;
            this.pic_Sad.Visible = false;
            // 
            // App2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 333);
            this.Controls.Add(this.pic_Sad);
            this.Controls.Add(this.pict_Happy);
            this.Controls.Add(this.groupBox1);
            this.Name = "App2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_Happy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Sad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_Sad;
        private System.Windows.Forms.RadioButton rdb_Happy;
        private System.Windows.Forms.PictureBox pict_Happy;
        private System.Windows.Forms.PictureBox pic_Sad;
    }
}

