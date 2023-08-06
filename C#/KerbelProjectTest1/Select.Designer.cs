namespace KerbelProjectTest1
{
    partial class Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select));
            this.lbl_select_spaceship = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.acceleration = new System.Windows.Forms.Label();
            this.top_speed = new System.Windows.Forms.Label();
            this.gas_tank_size = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayout_stats = new System.Windows.Forms.FlowLayoutPanel();
            this.weight = new System.Windows.Forms.Label();
            this.status_weight = new System.Windows.Forms.PictureBox();
            this.status_acceleration = new System.Windows.Forms.PictureBox();
            this.status_tank_size = new System.Windows.Forms.PictureBox();
            this.status_top_speed = new System.Windows.Forms.PictureBox();
            this.label_select_spaceship = new System.Windows.Forms.Label();
            this.lbl_spaceship_name = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.floating_spaceships_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.spaceship2 = new System.Windows.Forms.PictureBox();
            this.spaceship5 = new System.Windows.Forms.PictureBox();
            this.spaceship1 = new System.Windows.Forms.PictureBox();
            this.spaceship4 = new System.Windows.Forms.PictureBox();
            this.spaceship3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayout_stats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_acceleration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_tank_size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_top_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_select_spaceship
            // 
            this.lbl_select_spaceship.AutoSize = true;
            this.lbl_select_spaceship.BackColor = System.Drawing.Color.Black;
            this.lbl_select_spaceship.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_select_spaceship.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_select_spaceship.Location = new System.Drawing.Point(198, 29);
            this.lbl_select_spaceship.Name = "lbl_select_spaceship";
            this.lbl_select_spaceship.Size = new System.Drawing.Size(328, 36);
            this.lbl_select_spaceship.TabIndex = 3;
            this.lbl_select_spaceship.Tag = "labelTitle";
            this.lbl_select_spaceship.Text = "Select Your Rocket";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Location = new System.Drawing.Point(18, 29);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Tag = "btnReturn";
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // acceleration
            // 
            this.acceleration.AutoSize = true;
            this.acceleration.BackColor = System.Drawing.Color.Black;
            this.acceleration.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceleration.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.acceleration.Location = new System.Drawing.Point(3, 71);
            this.acceleration.Name = "acceleration";
            this.acceleration.Size = new System.Drawing.Size(95, 15);
            this.acceleration.TabIndex = 13;
            this.acceleration.Text = "Acceleration";
            // 
            // top_speed
            // 
            this.top_speed.AutoSize = true;
            this.top_speed.BackColor = System.Drawing.Color.Black;
            this.top_speed.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_speed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.top_speed.Location = new System.Drawing.Point(3, 213);
            this.top_speed.Name = "top_speed";
            this.top_speed.Size = new System.Drawing.Size(75, 15);
            this.top_speed.TabIndex = 14;
            this.top_speed.Text = "Top Speed";
            // 
            // gas_tank_size
            // 
            this.gas_tank_size.AutoSize = true;
            this.gas_tank_size.BackColor = System.Drawing.Color.Black;
            this.gas_tank_size.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gas_tank_size.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gas_tank_size.Location = new System.Drawing.Point(3, 142);
            this.gas_tank_size.Name = "gas_tank_size";
            this.gas_tank_size.Size = new System.Drawing.Size(99, 15);
            this.gas_tank_size.TabIndex = 15;
            this.gas_tank_size.Text = "Gas Tank Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(355, -48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 42);
            this.label6.TabIndex = 17;
            this.label6.Text = "Statistics";
            // 
            // flowLayout_stats
            // 
            this.flowLayout_stats.Controls.Add(this.weight);
            this.flowLayout_stats.Controls.Add(this.status_weight);
            this.flowLayout_stats.Controls.Add(this.acceleration);
            this.flowLayout_stats.Controls.Add(this.status_acceleration);
            this.flowLayout_stats.Controls.Add(this.gas_tank_size);
            this.flowLayout_stats.Controls.Add(this.status_tank_size);
            this.flowLayout_stats.Controls.Add(this.top_speed);
            this.flowLayout_stats.Controls.Add(this.status_top_speed);
            this.flowLayout_stats.Location = new System.Drawing.Point(320, 94);
            this.flowLayout_stats.Name = "flowLayout_stats";
            this.flowLayout_stats.Size = new System.Drawing.Size(372, 301);
            this.flowLayout_stats.TabIndex = 23;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.BackColor = System.Drawing.Color.Black;
            this.weight.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weight.Location = new System.Drawing.Point(3, 0);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(57, 15);
            this.weight.TabIndex = 16;
            this.weight.Text = "Weight";
            // 
            // status_weight
            // 
            this.status_weight.Image = global::KerbelProjectTest1.Properties.Resources.stats_bar_1;
            this.status_weight.InitialImage = null;
            this.status_weight.Location = new System.Drawing.Point(3, 18);
            this.status_weight.Name = "status_weight";
            this.status_weight.Size = new System.Drawing.Size(356, 50);
            this.status_weight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.status_weight.TabIndex = 25;
            this.status_weight.TabStop = false;
            // 
            // status_acceleration
            // 
            this.status_acceleration.Image = ((System.Drawing.Image)(resources.GetObject("status_acceleration.Image")));
            this.status_acceleration.InitialImage = global::KerbelProjectTest1.Properties.Resources.stats_bar_1;
            this.status_acceleration.Location = new System.Drawing.Point(3, 89);
            this.status_acceleration.Name = "status_acceleration";
            this.status_acceleration.Size = new System.Drawing.Size(356, 50);
            this.status_acceleration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.status_acceleration.TabIndex = 25;
            this.status_acceleration.TabStop = false;
            // 
            // status_tank_size
            // 
            this.status_tank_size.Image = ((System.Drawing.Image)(resources.GetObject("status_tank_size.Image")));
            this.status_tank_size.InitialImage = null;
            this.status_tank_size.Location = new System.Drawing.Point(3, 160);
            this.status_tank_size.Name = "status_tank_size";
            this.status_tank_size.Size = new System.Drawing.Size(356, 50);
            this.status_tank_size.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.status_tank_size.TabIndex = 25;
            this.status_tank_size.TabStop = false;
            // 
            // status_top_speed
            // 
            this.status_top_speed.Image = ((System.Drawing.Image)(resources.GetObject("status_top_speed.Image")));
            this.status_top_speed.InitialImage = null;
            this.status_top_speed.Location = new System.Drawing.Point(3, 231);
            this.status_top_speed.Name = "status_top_speed";
            this.status_top_speed.Size = new System.Drawing.Size(356, 50);
            this.status_top_speed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.status_top_speed.TabIndex = 25;
            this.status_top_speed.TabStop = false;
            // 
            // label_select_spaceship
            // 
            this.label_select_spaceship.AutoSize = true;
            this.label_select_spaceship.BackColor = System.Drawing.Color.Transparent;
            this.label_select_spaceship.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_select_spaceship.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_select_spaceship.Location = new System.Drawing.Point(16, 301);
            this.label_select_spaceship.Name = "label_select_spaceship";
            this.label_select_spaceship.Size = new System.Drawing.Size(138, 15);
            this.label_select_spaceship.TabIndex = 16;
            this.label_select_spaceship.Text = "Selected Spaceship:";
            // 
            // lbl_spaceship_name
            // 
            this.lbl_spaceship_name.AutoSize = true;
            this.lbl_spaceship_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spaceship_name.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spaceship_name.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_spaceship_name.Location = new System.Drawing.Point(15, 319);
            this.lbl_spaceship_name.Name = "lbl_spaceship_name";
            this.lbl_spaceship_name.Size = new System.Drawing.Size(60, 21);
            this.lbl_spaceship_name.TabIndex = 16;
            this.lbl_spaceship_name.Text = "None";
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContinue.Location = new System.Drawing.Point(617, 434);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 24;
            this.btnContinue.Tag = "btnContinue";
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(461, 437);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 16);
            this.lbl_error.TabIndex = 26;
            this.lbl_error.Tag = "lbl_error";
            // 
            // floating_spaceships_timer
            // 
            this.floating_spaceships_timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox35
            // 
            this.pictureBox35.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(659, 32);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(20, 20);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox35.TabIndex = 27;
            this.pictureBox35.TabStop = false;
            this.pictureBox35.Click += new System.EventHandler(this.pictureBox35_Click);
            // 
            // spaceship2
            // 
            this.spaceship2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceship2.Image = ((System.Drawing.Image)(resources.GetObject("spaceship2.Image")));
            this.spaceship2.InitialImage = null;
            this.spaceship2.Location = new System.Drawing.Point(178, 156);
            this.spaceship2.MaximumSize = new System.Drawing.Size(55, 80);
            this.spaceship2.MinimumSize = new System.Drawing.Size(47, 71);
            this.spaceship2.Name = "spaceship2";
            this.spaceship2.Size = new System.Drawing.Size(47, 71);
            this.spaceship2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spaceship2.TabIndex = 11;
            this.spaceship2.TabStop = false;
            this.spaceship2.Tag = "spaceship2";
            this.spaceship2.Click += new System.EventHandler(this.spaceship2_Click);
            // 
            // spaceship5
            // 
            this.spaceship5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceship5.Image = ((System.Drawing.Image)(resources.GetObject("spaceship5.Image")));
            this.spaceship5.InitialImage = null;
            this.spaceship5.Location = new System.Drawing.Point(19, 156);
            this.spaceship5.MaximumSize = new System.Drawing.Size(55, 80);
            this.spaceship5.MinimumSize = new System.Drawing.Size(47, 71);
            this.spaceship5.Name = "spaceship5";
            this.spaceship5.Size = new System.Drawing.Size(47, 71);
            this.spaceship5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spaceship5.TabIndex = 12;
            this.spaceship5.TabStop = false;
            this.spaceship5.Tag = "spaceship5";
            this.spaceship5.Click += new System.EventHandler(this.spaceship5_Click);
            // 
            // spaceship1
            // 
            this.spaceship1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceship1.Image = ((System.Drawing.Image)(resources.GetObject("spaceship1.Image")));
            this.spaceship1.InitialImage = null;
            this.spaceship1.Location = new System.Drawing.Point(231, 156);
            this.spaceship1.MaximumSize = new System.Drawing.Size(55, 80);
            this.spaceship1.MinimumSize = new System.Drawing.Size(47, 71);
            this.spaceship1.Name = "spaceship1";
            this.spaceship1.Size = new System.Drawing.Size(47, 71);
            this.spaceship1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spaceship1.TabIndex = 9;
            this.spaceship1.TabStop = false;
            this.spaceship1.Tag = "spaceship1";
            this.spaceship1.Click += new System.EventHandler(this.spaceship1_Click);
            // 
            // spaceship4
            // 
            this.spaceship4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceship4.Image = ((System.Drawing.Image)(resources.GetObject("spaceship4.Image")));
            this.spaceship4.InitialImage = null;
            this.spaceship4.Location = new System.Drawing.Point(72, 156);
            this.spaceship4.MaximumSize = new System.Drawing.Size(55, 80);
            this.spaceship4.MinimumSize = new System.Drawing.Size(47, 71);
            this.spaceship4.Name = "spaceship4";
            this.spaceship4.Size = new System.Drawing.Size(47, 71);
            this.spaceship4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spaceship4.TabIndex = 5;
            this.spaceship4.TabStop = false;
            this.spaceship4.Tag = "spaceship4";
            this.spaceship4.Click += new System.EventHandler(this.spaceship4_Click);
            // 
            // spaceship3
            // 
            this.spaceship3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spaceship3.Image = ((System.Drawing.Image)(resources.GetObject("spaceship3.Image")));
            this.spaceship3.InitialImage = null;
            this.spaceship3.Location = new System.Drawing.Point(125, 156);
            this.spaceship3.MaximumSize = new System.Drawing.Size(55, 80);
            this.spaceship3.MinimumSize = new System.Drawing.Size(47, 71);
            this.spaceship3.Name = "spaceship3";
            this.spaceship3.Size = new System.Drawing.Size(47, 71);
            this.spaceship3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.spaceship3.TabIndex = 10;
            this.spaceship3.TabStop = false;
            this.spaceship3.Tag = "spaceship3";
            this.spaceship3.Click += new System.EventHandler(this.spaceship3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 378);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Select
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.spaceship2);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.spaceship5);
            this.Controls.Add(this.spaceship1);
            this.Controls.Add(this.spaceship4);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.spaceship3);
            this.Controls.Add(this.lbl_spaceship_name);
            this.Controls.Add(this.label_select_spaceship);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lbl_select_spaceship);
            this.Controls.Add(this.flowLayout_stats);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayout_stats.ResumeLayout(false);
            this.flowLayout_stats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_acceleration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_tank_size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_top_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceship3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_select_spaceship;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox spaceship4;
        private System.Windows.Forms.PictureBox spaceship3;
        private System.Windows.Forms.PictureBox spaceship2;
        private System.Windows.Forms.PictureBox spaceship1;
        private System.Windows.Forms.Label acceleration;
        private System.Windows.Forms.Label top_speed;
        private System.Windows.Forms.Label gas_tank_size;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flowLayout_stats;
        private System.Windows.Forms.Label label_select_spaceship;
        private System.Windows.Forms.Label lbl_spaceship_name;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.PictureBox status_weight;
        private System.Windows.Forms.PictureBox status_acceleration;
        private System.Windows.Forms.PictureBox status_tank_size;
        private System.Windows.Forms.PictureBox status_top_speed;
        private System.Windows.Forms.PictureBox spaceship5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Timer floating_spaceships_timer;
        private System.Windows.Forms.PictureBox pictureBox35;
    }
}

