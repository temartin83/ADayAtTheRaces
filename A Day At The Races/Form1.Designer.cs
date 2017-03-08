namespace A_Day_At_The_Races
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
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.racetrackPicture = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.bettingParlor = new System.Windows.Forms.GroupBox();
            this.alBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.raceButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dogChoice = new System.Windows.Forms.NumericUpDown();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.whosBetting = new System.Windows.Forms.Label();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            this.bettingParlor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dog4
            // 
            this.dog4.Image = global::A_Day_At_The_Races.Properties.Resources.dog;
            this.dog4.Location = new System.Drawing.Point(1, 163);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(76, 21);
            this.dog4.TabIndex = 1;
            this.dog4.TabStop = false;
            // 
            // racetrackPicture
            // 
            this.racetrackPicture.Image = global::A_Day_At_The_Races.Properties.Resources.racetrack;
            this.racetrackPicture.Location = new System.Drawing.Point(1, 2);
            this.racetrackPicture.Name = "racetrackPicture";
            this.racetrackPicture.Size = new System.Drawing.Size(792, 198);
            this.racetrackPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPicture.TabIndex = 0;
            this.racetrackPicture.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = global::A_Day_At_The_Races.Properties.Resources.dog;
            this.dog3.Location = new System.Drawing.Point(1, 115);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(76, 21);
            this.dog3.TabIndex = 2;
            this.dog3.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = global::A_Day_At_The_Races.Properties.Resources.dog;
            this.dog2.Location = new System.Drawing.Point(1, 59);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(76, 21);
            this.dog2.TabIndex = 3;
            this.dog2.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = global::A_Day_At_The_Races.Properties.Resources.dog;
            this.dog1.Location = new System.Drawing.Point(1, 12);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(76, 21);
            this.dog1.TabIndex = 4;
            this.dog1.TabStop = false;
            // 
            // bettingParlor
            // 
            this.bettingParlor.Controls.Add(this.alBetLabel);
            this.bettingParlor.Controls.Add(this.bobBetLabel);
            this.bettingParlor.Controls.Add(this.joeBetLabel);
            this.bettingParlor.Controls.Add(this.label3);
            this.bettingParlor.Controls.Add(this.raceButton);
            this.bettingParlor.Controls.Add(this.label2);
            this.bettingParlor.Controls.Add(this.dogChoice);
            this.bettingParlor.Controls.Add(this.betAmount);
            this.bettingParlor.Controls.Add(this.betButton);
            this.bettingParlor.Controls.Add(this.whosBetting);
            this.bettingParlor.Controls.Add(this.alRadioButton);
            this.bettingParlor.Controls.Add(this.bobRadioButton);
            this.bettingParlor.Controls.Add(this.label1);
            this.bettingParlor.Controls.Add(this.joeRadioButton);
            this.bettingParlor.Location = new System.Drawing.Point(12, 207);
            this.bettingParlor.Name = "bettingParlor";
            this.bettingParlor.Size = new System.Drawing.Size(770, 199);
            this.bettingParlor.TabIndex = 5;
            this.bettingParlor.TabStop = false;
            this.bettingParlor.Text = "Betting Parlor";
            // 
            // alBetLabel
            // 
            this.alBetLabel.AutoSize = true;
            this.alBetLabel.Location = new System.Drawing.Point(294, 134);
            this.alBetLabel.Name = "alBetLabel";
            this.alBetLabel.Size = new System.Drawing.Size(75, 17);
            this.alBetLabel.TabIndex = 19;
            this.alBetLabel.Text = "alBetLabel";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(294, 105);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(88, 17);
            this.bobBetLabel.TabIndex = 18;
            this.bobBetLabel.Text = "bobBetLabel";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(294, 80);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(83, 17);
            this.joeBetLabel.TabIndex = 17;
            this.joeBetLabel.Text = "joeBetLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bets";
            // 
            // raceButton
            // 
            this.raceButton.Location = new System.Drawing.Point(595, 62);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(144, 75);
            this.raceButton.TabIndex = 15;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "bucks on dog number";
            // 
            // dogChoice
            // 
            this.dogChoice.Location = new System.Drawing.Point(311, 173);
            this.dogChoice.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogChoice.Name = "dogChoice";
            this.dogChoice.Size = new System.Drawing.Size(42, 22);
            this.dogChoice.TabIndex = 13;
            this.dogChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(108, 171);
            this.betAmount.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(46, 22);
            this.betAmount.TabIndex = 12;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(55, 170);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(47, 23);
            this.betButton.TabIndex = 11;
            this.betButton.Text = "bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // whosBetting
            // 
            this.whosBetting.AutoSize = true;
            this.whosBetting.Location = new System.Drawing.Point(6, 173);
            this.whosBetting.Name = "whosBetting";
            this.whosBetting.Size = new System.Drawing.Size(43, 17);
            this.whosBetting.TabIndex = 10;
            this.whosBetting.Text = "name";
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(6, 128);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(96, 21);
            this.alRadioButton.TabIndex = 9;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al has $45";
            this.alRadioButton.UseVisualStyleBackColor = true;
            this.alRadioButton.CheckedChanged += new System.EventHandler(this.alRadioButton_CheckedChanged);
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(6, 101);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(109, 21);
            this.bobRadioButton.TabIndex = 8;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob has $75";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            this.bobRadioButton.CheckedChanged += new System.EventHandler(this.bobRadioButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 7;
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(6, 74);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(107, 21);
            this.joeRadioButton.TabIndex = 6;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe has $50";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            this.joeRadioButton.CheckedChanged += new System.EventHandler(this.joeRadioButton_CheckedChanged);
            // 
            // raceTimer
            // 
            this.raceTimer.Interval = 5;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 410);
            this.Controls.Add(this.bettingParlor);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.racetrackPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            this.bettingParlor.ResumeLayout(false);
            this.bettingParlor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPicture;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.GroupBox bettingParlor;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Label whosBetting;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown dogChoice;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.Label alBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer raceTimer;
    }
}

