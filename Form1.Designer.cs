namespace Car_Driving
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.distance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AI4 = new System.Windows.Forms.PictureBox();
            this.AI3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.distance);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AI4);
            this.panel1.Controls.Add(this.AI3);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 521);
            this.panel1.TabIndex = 0;
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.ForeColor = System.Drawing.Color.Transparent;
            this.distance.Location = new System.Drawing.Point(419, 0);
            this.distance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(138, 31);
            this.distance.TabIndex = 2;
            this.distance.Text = "Distance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(93, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(409, 212);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AI4
            // 
            this.AI4.BackColor = System.Drawing.Color.Transparent;
            this.AI4.Image = global::Car_Driving.Properties.Resources.supercar;
            this.AI4.Location = new System.Drawing.Point(792, 22);
            this.AI4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AI4.Name = "AI4";
            this.AI4.Size = new System.Drawing.Size(68, 124);
            this.AI4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI4.TabIndex = 7;
            this.AI4.TabStop = false;
            // 
            // AI3
            // 
            this.AI3.BackColor = System.Drawing.Color.Transparent;
            this.AI3.Image = global::Car_Driving.Properties.Resources.carPink;
            this.AI3.Location = new System.Drawing.Point(13, 212);
            this.AI3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AI3.Name = "AI3";
            this.AI3.Size = new System.Drawing.Size(67, 124);
            this.AI3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI3.TabIndex = 3;
            this.AI3.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::Car_Driving.Properties.Resources.carYellow;
            this.player.Location = new System.Drawing.Point(321, 389);
            this.player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(67, 124);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::Car_Driving.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(321, 311);
            this.explosion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(85, 79);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 4;
            this.explosion.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::Car_Driving.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(531, 101);
            this.AI2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(67, 124);
            this.AI2.TabIndex = 3;
            this.AI2.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::Car_Driving.Properties.Resources.carGrey;
            this.AI1.Location = new System.Drawing.Point(189, 49);
            this.AI1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(67, 124);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Driving.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(-4, -273);
            this.roadTrack2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(911, 793);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack2.TabIndex = 1;
            this.roadTrack2.TabStop = false;
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Car_Driving.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(-3, -785);
            this.roadTrack1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(911, 793);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 0;
            this.roadTrack1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(944, 553);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "car driving";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.moveCar);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.stopCar);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AI4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox AI1;
        private System.Windows.Forms.PictureBox roadTrack2;
        private System.Windows.Forms.PictureBox roadTrack1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.PictureBox AI3;
        private System.Windows.Forms.PictureBox AI4;
        private System.Windows.Forms.Label label2;
    }
}

