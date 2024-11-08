namespace VerkeerspleinProject
{
    partial class Verkeersplein
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
            this.picCar = new System.Windows.Forms.PictureBox();
            this.picCar2 = new System.Windows.Forms.PictureBox();
            this.picAmbulance = new System.Windows.Forms.PictureBox();
            this.picJohnnyWalker = new System.Windows.Forms.PictureBox();
            this.picStopLicht1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picStopLicht2 = new System.Windows.Forms.PictureBox();
            this.picStopLicht3 = new System.Windows.Forms.PictureBox();
            this.picStopLicht4 = new System.Windows.Forms.PictureBox();
            this.picMiniStopLicht2 = new System.Windows.Forms.PictureBox();
            this.picMiniStopLicht3 = new System.Windows.Forms.PictureBox();
            this.picMiniStopLicht1 = new System.Windows.Forms.PictureBox();
            this.picMiniStopLicht4 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.picJohnnyWalker2 = new System.Windows.Forms.PictureBox();
            this.btnVoetgangers = new System.Windows.Forms.Button();
            this.btnAmbulance = new System.Windows.Forms.Button();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.btnKnipperen = new System.Windows.Forms.Button();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmbulance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJohnnyWalker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJohnnyWalker2)).BeginInit();
            this.SuspendLayout();
            // 
            // picCar
            // 
            this.picCar.Image = global::VerkeerspleinProject.Properties.Resources.Game_Car_Racing_2030056;
            this.picCar.Location = new System.Drawing.Point(125, 258);
            this.picCar.Name = "picCar";
            this.picCar.Size = new System.Drawing.Size(75, 40);
            this.picCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar.TabIndex = 0;
            this.picCar.TabStop = false;
            // 
            // picCar2
            // 
            this.picCar2.Image = global::VerkeerspleinProject.Properties.Resources.left_sidepng;
            this.picCar2.Location = new System.Drawing.Point(506, 217);
            this.picCar2.Name = "picCar2";
            this.picCar2.Size = new System.Drawing.Size(83, 41);
            this.picCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCar2.TabIndex = 1;
            this.picCar2.TabStop = false;
            // 
            // picAmbulance
            // 
            this.picAmbulance.Image = global::VerkeerspleinProject.Properties.Resources.Ambulance_down;
            this.picAmbulance.Location = new System.Drawing.Point(329, 76);
            this.picAmbulance.Name = "picAmbulance";
            this.picAmbulance.Size = new System.Drawing.Size(56, 99);
            this.picAmbulance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmbulance.TabIndex = 2;
            this.picAmbulance.TabStop = false;
            // 
            // picJohnnyWalker
            // 
            this.picJohnnyWalker.Image = global::VerkeerspleinProject.Properties.Resources.Johnnie_Walker;
            this.picJohnnyWalker.Location = new System.Drawing.Point(57, 139);
            this.picJohnnyWalker.Name = "picJohnnyWalker";
            this.picJohnnyWalker.Size = new System.Drawing.Size(40, 57);
            this.picJohnnyWalker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJohnnyWalker.TabIndex = 3;
            this.picJohnnyWalker.TabStop = false;
            // 
            // picStopLicht1
            // 
            this.picStopLicht1.BackColor = System.Drawing.Color.Black;
            this.picStopLicht1.Location = new System.Drawing.Point(255, 316);
            this.picStopLicht1.Name = "picStopLicht1";
            this.picStopLicht1.Size = new System.Drawing.Size(38, 108);
            this.picStopLicht1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStopLicht1.TabIndex = 4;
            this.picStopLicht1.TabStop = false;
            this.picStopLicht1.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picStopLicht2
            // 
            this.picStopLicht2.BackColor = System.Drawing.Color.Black;
            this.picStopLicht2.Location = new System.Drawing.Point(475, 88);
            this.picStopLicht2.Name = "picStopLicht2";
            this.picStopLicht2.Size = new System.Drawing.Size(39, 108);
            this.picStopLicht2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStopLicht2.TabIndex = 5;
            this.picStopLicht2.TabStop = false;
            this.picStopLicht2.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas_Paint);
            // 
            // picStopLicht3
            // 
            this.picStopLicht3.BackColor = System.Drawing.Color.Black;
            this.picStopLicht3.Location = new System.Drawing.Point(254, 88);
            this.picStopLicht3.Name = "picStopLicht3";
            this.picStopLicht3.Size = new System.Drawing.Size(39, 108);
            this.picStopLicht3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStopLicht3.TabIndex = 6;
            this.picStopLicht3.TabStop = false;
            this.picStopLicht3.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas_Paint);
            // 
            // picStopLicht4
            // 
            this.picStopLicht4.BackColor = System.Drawing.Color.Black;
            this.picStopLicht4.Location = new System.Drawing.Point(475, 316);
            this.picStopLicht4.Name = "picStopLicht4";
            this.picStopLicht4.Size = new System.Drawing.Size(39, 108);
            this.picStopLicht4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStopLicht4.TabIndex = 7;
            this.picStopLicht4.TabStop = false;
            this.picStopLicht4.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas_Paint);
            // 
            // picMiniStopLicht2
            // 
            this.picMiniStopLicht2.BackColor = System.Drawing.Color.Black;
            this.picMiniStopLicht2.Location = new System.Drawing.Point(729, 124);
            this.picMiniStopLicht2.Name = "picMiniStopLicht2";
            this.picMiniStopLicht2.Size = new System.Drawing.Size(39, 72);
            this.picMiniStopLicht2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiniStopLicht2.TabIndex = 8;
            this.picMiniStopLicht2.TabStop = false;
            this.picMiniStopLicht2.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas2_Paint);
            // 
            // picMiniStopLicht3
            // 
            this.picMiniStopLicht3.BackColor = System.Drawing.Color.Black;
            this.picMiniStopLicht3.Location = new System.Drawing.Point(2, 124);
            this.picMiniStopLicht3.Name = "picMiniStopLicht3";
            this.picMiniStopLicht3.Size = new System.Drawing.Size(39, 72);
            this.picMiniStopLicht3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiniStopLicht3.TabIndex = 9;
            this.picMiniStopLicht3.TabStop = false;
            this.picMiniStopLicht3.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas2_Paint);
            // 
            // picMiniStopLicht1
            // 
            this.picMiniStopLicht1.BackColor = System.Drawing.Color.Black;
            this.picMiniStopLicht1.Location = new System.Drawing.Point(2, 316);
            this.picMiniStopLicht1.Name = "picMiniStopLicht1";
            this.picMiniStopLicht1.Size = new System.Drawing.Size(39, 72);
            this.picMiniStopLicht1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiniStopLicht1.TabIndex = 10;
            this.picMiniStopLicht1.TabStop = false;
            this.picMiniStopLicht1.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas2_Paint);
            // 
            // picMiniStopLicht4
            // 
            this.picMiniStopLicht4.BackColor = System.Drawing.Color.Black;
            this.picMiniStopLicht4.Location = new System.Drawing.Point(729, 316);
            this.picMiniStopLicht4.Name = "picMiniStopLicht4";
            this.picMiniStopLicht4.Size = new System.Drawing.Size(39, 72);
            this.picMiniStopLicht4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiniStopLicht4.TabIndex = 11;
            this.picMiniStopLicht4.TabStop = false;
            this.picMiniStopLicht4.Paint += new System.Windows.Forms.PaintEventHandler(this.jpiccanvas2_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(125, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // picJohnnyWalker2
            // 
            this.picJohnnyWalker2.Image = global::VerkeerspleinProject.Properties.Resources.Johnnie_Walker;
            this.picJohnnyWalker2.Location = new System.Drawing.Point(683, 316);
            this.picJohnnyWalker2.Name = "picJohnnyWalker2";
            this.picJohnnyWalker2.Size = new System.Drawing.Size(40, 57);
            this.picJohnnyWalker2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJohnnyWalker2.TabIndex = 13;
            this.picJohnnyWalker2.TabStop = false;
            // 
            // btnVoetgangers
            // 
            this.btnVoetgangers.Location = new System.Drawing.Point(616, 379);
            this.btnVoetgangers.Name = "btnVoetgangers";
            this.btnVoetgangers.Size = new System.Drawing.Size(107, 23);
            this.btnVoetgangers.TabIndex = 14;
            this.btnVoetgangers.Text = "Voetgangers";
            this.btnVoetgangers.UseVisualStyleBackColor = true;
            this.btnVoetgangers.Click += new System.EventHandler(this.btnVoetgangers_Click);
            // 
            // btnAmbulance
            // 
            this.btnAmbulance.Location = new System.Drawing.Point(300, 47);
            this.btnAmbulance.Name = "btnAmbulance";
            this.btnAmbulance.Size = new System.Drawing.Size(94, 23);
            this.btnAmbulance.TabIndex = 15;
            this.btnAmbulance.Text = "Ambulance";
            this.btnAmbulance.UseVisualStyleBackColor = true;
            this.btnAmbulance.Click += new System.EventHandler(this.btnAmbulance_Click);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 500;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // btnKnipperen
            // 
            this.btnKnipperen.Location = new System.Drawing.Point(2, 501);
            this.btnKnipperen.Name = "btnKnipperen";
            this.btnKnipperen.Size = new System.Drawing.Size(175, 23);
            this.btnKnipperen.TabIndex = 16;
            this.btnKnipperen.Text = "22.00 - 06.00";
            this.btnKnipperen.UseVisualStyleBackColor = true;
            this.btnKnipperen.Click += new System.EventHandler(this.btnKnipperen_Click);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // Verkeersplein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VerkeerspleinProject.Properties.Resources.achtergrond_voor_de_weg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 526);
            this.Controls.Add(this.btnKnipperen);
            this.Controls.Add(this.btnAmbulance);
            this.Controls.Add(this.btnVoetgangers);
            this.Controls.Add(this.picJohnnyWalker2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picMiniStopLicht4);
            this.Controls.Add(this.picMiniStopLicht1);
            this.Controls.Add(this.picMiniStopLicht3);
            this.Controls.Add(this.picMiniStopLicht2);
            this.Controls.Add(this.picStopLicht4);
            this.Controls.Add(this.picStopLicht3);
            this.Controls.Add(this.picStopLicht2);
            this.Controls.Add(this.picStopLicht1);
            this.Controls.Add(this.picJohnnyWalker);
            this.Controls.Add(this.picAmbulance);
            this.Controls.Add(this.picCar2);
            this.Controls.Add(this.picCar);
            this.DoubleBuffered = true;
            this.Name = "Verkeersplein";
            this.Text = "Verkeersplein";
            ((System.ComponentModel.ISupportInitialize)(this.picCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmbulance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJohnnyWalker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStopLicht4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMiniStopLicht4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJohnnyWalker2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCar;
        private System.Windows.Forms.PictureBox picCar2;
        private System.Windows.Forms.PictureBox picAmbulance;
        private System.Windows.Forms.PictureBox picJohnnyWalker;
        private System.Windows.Forms.PictureBox picStopLicht1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picStopLicht2;
        private System.Windows.Forms.PictureBox picStopLicht3;
        private System.Windows.Forms.PictureBox picStopLicht4;
        private System.Windows.Forms.PictureBox picMiniStopLicht2;
        private System.Windows.Forms.PictureBox picMiniStopLicht3;
        private System.Windows.Forms.PictureBox picMiniStopLicht1;
        private System.Windows.Forms.PictureBox picMiniStopLicht4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picJohnnyWalker2;
        private System.Windows.Forms.Button btnVoetgangers;
        private System.Windows.Forms.Button btnAmbulance;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Button btnKnipperen;
        private System.Windows.Forms.Timer timer6;
    }
}

