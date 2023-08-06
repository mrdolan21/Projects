namespace KerbelProjectTest1
{
    partial class Launch
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launch));
            this.btnReturn = new System.Windows.Forms.Button();
            this.spaceshipname = new System.Windows.Forms.Label();
            this.lbl_selected_spaceship = new System.Windows.Forms.Label();
            this.zoomout_timer = new System.Windows.Forms.Timer(this.components);
            this.btnLaunch = new System.Windows.Forms.Button();
            this.launch_rocket_timer = new System.Windows.Forms.Timer(this.components);
            this.star_close = new System.Windows.Forms.PictureBox();
            this.insert_Gas = new System.Windows.Forms.Label();
            this.insert_Angle = new System.Windows.Forms.Label();
            this.up_gas = new System.Windows.Forms.Button();
            this.down_angle = new System.Windows.Forms.Button();
            this.up_angle = new System.Windows.Forms.Button();
            this.down_gas = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comet = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.WIN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.star_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WIN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Location = new System.Drawing.Point(707, 569);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Tag = "btnReturn";
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // spaceshipname
            // 
            this.spaceshipname.AutoSize = true;
            this.spaceshipname.BackColor = System.Drawing.Color.Black;
            this.spaceshipname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceshipname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.spaceshipname.Location = new System.Drawing.Point(448, 565);
            this.spaceshipname.Name = "spaceshipname";
            this.spaceshipname.Size = new System.Drawing.Size(20, 27);
            this.spaceshipname.TabIndex = 17;
            this.spaceshipname.Text = " ";
            // 
            // lbl_selected_spaceship
            // 
            this.lbl_selected_spaceship.AutoSize = true;
            this.lbl_selected_spaceship.BackColor = System.Drawing.Color.Black;
            this.lbl_selected_spaceship.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selected_spaceship.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_selected_spaceship.Location = new System.Drawing.Point(240, 565);
            this.lbl_selected_spaceship.Name = "lbl_selected_spaceship";
            this.lbl_selected_spaceship.Size = new System.Drawing.Size(199, 27);
            this.lbl_selected_spaceship.TabIndex = 18;
            this.lbl_selected_spaceship.Text = "Selected Spaceship:";
            // 
            // btnLaunch
            // 
            this.btnLaunch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLaunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLaunch.Location = new System.Drawing.Point(25, 569);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 25;
            this.btnLaunch.Tag = "btnLaunch";
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = false;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // star_close
            // 
            this.star_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_close.Image = ((System.Drawing.Image)(resources.GetObject("star_close.Image")));
            this.star_close.Location = new System.Drawing.Point(800, 600);
            this.star_close.Name = "star_close";
            this.star_close.Size = new System.Drawing.Size(20, 20);
            this.star_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.star_close.TabIndex = 26;
            this.star_close.TabStop = false;
            this.star_close.Click += new System.EventHandler(this.pictureBox35_Click);
            // 
            // insert_Gas
            // 
            this.insert_Gas.AutoSize = true;
            this.insert_Gas.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_Gas.Location = new System.Drawing.Point(372, 232);
            this.insert_Gas.Name = "insert_Gas";
            this.insert_Gas.Size = new System.Drawing.Size(77, 33);
            this.insert_Gas.TabIndex = 28;
            this.insert_Gas.Text = "Gas 0";
            this.insert_Gas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insert_Angle
            // 
            this.insert_Angle.AutoSize = true;
            this.insert_Angle.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_Angle.Location = new System.Drawing.Point(359, 265);
            this.insert_Angle.Name = "insert_Angle";
            this.insert_Angle.Size = new System.Drawing.Size(100, 33);
            this.insert_Angle.TabIndex = 29;
            this.insert_Angle.Text = "Angle 0";
            this.insert_Angle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // up_gas
            // 
            this.up_gas.BackColor = System.Drawing.Color.Black;
            this.up_gas.Location = new System.Drawing.Point(309, 242);
            this.up_gas.Name = "up_gas";
            this.up_gas.Size = new System.Drawing.Size(22, 23);
            this.up_gas.TabIndex = 30;
            this.up_gas.Text = "🔼";
            this.up_gas.UseVisualStyleBackColor = false;
            // 
            // down_angle
            // 
            this.down_angle.BackColor = System.Drawing.Color.Black;
            this.down_angle.Location = new System.Drawing.Point(493, 275);
            this.down_angle.Name = "down_angle";
            this.down_angle.Size = new System.Drawing.Size(22, 23);
            this.down_angle.TabIndex = 31;
            this.down_angle.Text = "🔽";
            this.down_angle.UseVisualStyleBackColor = false;
            // 
            // up_angle
            // 
            this.up_angle.BackColor = System.Drawing.Color.Black;
            this.up_angle.Location = new System.Drawing.Point(309, 275);
            this.up_angle.Name = "up_angle";
            this.up_angle.Size = new System.Drawing.Size(22, 23);
            this.up_angle.TabIndex = 30;
            this.up_angle.Text = "🔼";
            this.up_angle.UseVisualStyleBackColor = false;
            // 
            // down_gas
            // 
            this.down_gas.BackColor = System.Drawing.Color.Black;
            this.down_gas.Location = new System.Drawing.Point(493, 242);
            this.down_gas.Name = "down_gas";
            this.down_gas.Size = new System.Drawing.Size(22, 23);
            this.down_gas.TabIndex = 31;
            this.down_gas.Text = "🔽";
            this.down_gas.UseVisualStyleBackColor = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 600);
            this.splitter1.TabIndex = 33;
            this.splitter1.TabStop = false;
            // 
            // comet
            // 
            this.comet.Image = global::KerbelProjectTest1.Properties.Resources.COMETGOD;
            this.comet.Location = new System.Drawing.Point(782, 584);
            this.comet.Name = "comet";
            this.comet.Size = new System.Drawing.Size(203, 100);
            this.comet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.comet.TabIndex = 32;
            this.comet.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::KerbelProjectTest1.Properties.Resources.explosion_8bit;
            this.explosion.Location = new System.Drawing.Point(782, 584);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(140, 126);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.explosion.TabIndex = 35;
            this.explosion.TabStop = false;
            // 
            // WIN
            // 
            this.WIN.Image = global::KerbelProjectTest1.Properties.Resources.you_win;
            this.WIN.Location = new System.Drawing.Point(788, 589);
            this.WIN.Name = "WIN";
            this.WIN.Size = new System.Drawing.Size(205, 56);
            this.WIN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WIN.TabIndex = 36;
            this.WIN.TabStop = false;
            // 
            // Launch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.WIN);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.down_gas);
            this.Controls.Add(this.down_angle);
            this.Controls.Add(this.up_angle);
            this.Controls.Add(this.up_gas);
            this.Controls.Add(this.insert_Angle);
            this.Controls.Add(this.insert_Gas);
            this.Controls.Add(this.star_close);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.spaceshipname);
            this.Controls.Add(this.lbl_selected_spaceship);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.comet);
            this.Controls.Add(this.explosion);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Launch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch";
            ((System.ComponentModel.ISupportInitialize)(this.star_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WIN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label spaceshipname;
        private System.Windows.Forms.Label lbl_selected_spaceship;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.Timer zoomout_timer;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Timer launch_rocket_timer;
        private System.Windows.Forms.PictureBox star_close;
        private System.Windows.Forms.Label insert_Gas;
        private System.Windows.Forms.Label insert_Angle;
        private System.Windows.Forms.Button up_gas;
        private System.Windows.Forms.Button down_angle;
        private System.Windows.Forms.Button up_angle;
        private System.Windows.Forms.Button down_gas;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox comet;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox WIN;
    }
}