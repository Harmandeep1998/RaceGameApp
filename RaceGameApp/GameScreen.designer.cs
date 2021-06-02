namespace RaceGameApp
{
    partial class GameScreen
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
            this.panelControls = new System.Windows.Forms.Panel();
            this.numericDogNumber = new System.Windows.Forms.NumericUpDown();
            this.labelBetDog = new System.Windows.Forms.Label();
            this.numericBetAmount = new System.Windows.Forms.NumericUpDown();
            this.labelBet = new System.Windows.Forms.Label();
            this.labelMaxBet = new System.Windows.Forms.Label();
            this.textPunter3 = new System.Windows.Forms.TextBox();
            this.textPunter2 = new System.Windows.Forms.TextBox();
            this.textPunter1 = new System.Windows.Forms.TextBox();
            this.radioPunter3 = new System.Windows.Forms.RadioButton();
            this.radioPunter2 = new System.Windows.Forms.RadioButton();
            this.radioPunter1 = new System.Windows.Forms.RadioButton();
            this.btnAction = new System.Windows.Forms.Button();
            this.picZeep4 = new System.Windows.Forms.PictureBox();
            this.picZeep3 = new System.Windows.Forms.PictureBox();
            this.picZeep2 = new System.Windows.Forms.PictureBox();
            this.picZeep1 = new System.Windows.Forms.PictureBox();
            this.pictureTrack = new System.Windows.Forms.PictureBox();
            this.panelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDogNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelControls.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelControls.Controls.Add(this.numericDogNumber);
            this.panelControls.Controls.Add(this.labelBetDog);
            this.panelControls.Controls.Add(this.numericBetAmount);
            this.panelControls.Controls.Add(this.labelBet);
            this.panelControls.Controls.Add(this.labelMaxBet);
            this.panelControls.Controls.Add(this.textPunter3);
            this.panelControls.Controls.Add(this.textPunter2);
            this.panelControls.Controls.Add(this.textPunter1);
            this.panelControls.Controls.Add(this.radioPunter3);
            this.panelControls.Controls.Add(this.radioPunter2);
            this.panelControls.Controls.Add(this.radioPunter1);
            this.panelControls.Location = new System.Drawing.Point(12, 370);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(1189, 251);
            this.panelControls.TabIndex = 0;
            // 
            // numericDogNumber
            // 
            this.numericDogNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericDogNumber.Location = new System.Drawing.Point(1079, 174);
            this.numericDogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericDogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericDogNumber.Name = "numericDogNumber";
            this.numericDogNumber.Size = new System.Drawing.Size(67, 34);
            this.numericDogNumber.TabIndex = 10;
            this.numericDogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelBetDog
            // 
            this.labelBetDog.AutoSize = true;
            this.labelBetDog.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBetDog.Location = new System.Drawing.Point(747, 176);
            this.labelBetDog.Name = "labelBetDog";
            this.labelBetDog.Size = new System.Drawing.Size(272, 28);
            this.labelBetDog.TabIndex = 9;
            this.labelBetDog.Text = "Punter Bet On Dog No";
            // 
            // numericBetAmount
            // 
            this.numericBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBetAmount.Location = new System.Drawing.Point(1079, 95);
            this.numericBetAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericBetAmount.Name = "numericBetAmount";
            this.numericBetAmount.Size = new System.Drawing.Size(67, 34);
            this.numericBetAmount.TabIndex = 8;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.Location = new System.Drawing.Point(747, 97);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(285, 28);
            this.labelBet.TabIndex = 7;
            this.labelBet.Text = "Punter Bet Amount is ";
            // 
            // labelMaxBet
            // 
            this.labelMaxBet.AutoSize = true;
            this.labelMaxBet.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaxBet.Location = new System.Drawing.Point(747, 22);
            this.labelMaxBet.Name = "labelMaxBet";
            this.labelMaxBet.Size = new System.Drawing.Size(376, 28);
            this.labelMaxBet.TabIndex = 6;
            this.labelMaxBet.Text = "Punter Max Bet Amount is $50";
            // 
            // textPunter3
            // 
            this.textPunter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPunter3.Location = new System.Drawing.Point(183, 176);
            this.textPunter3.Name = "textPunter3";
            this.textPunter3.Size = new System.Drawing.Size(493, 30);
            this.textPunter3.TabIndex = 5;
            // 
            // textPunter2
            // 
            this.textPunter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPunter2.Location = new System.Drawing.Point(183, 99);
            this.textPunter2.Name = "textPunter2";
            this.textPunter2.Size = new System.Drawing.Size(493, 30);
            this.textPunter2.TabIndex = 4;
            // 
            // textPunter1
            // 
            this.textPunter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPunter1.Location = new System.Drawing.Point(183, 22);
            this.textPunter1.Name = "textPunter1";
            this.textPunter1.Size = new System.Drawing.Size(493, 30);
            this.textPunter1.TabIndex = 3;
            // 
            // radioPunter3
            // 
            this.radioPunter3.AutoSize = true;
            this.radioPunter3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPunter3.Location = new System.Drawing.Point(19, 174);
            this.radioPunter3.Name = "radioPunter3";
            this.radioPunter3.Size = new System.Drawing.Size(137, 32);
            this.radioPunter3.TabIndex = 2;
            this.radioPunter3.TabStop = true;
            this.radioPunter3.Text = "Punter 3";
            this.radioPunter3.UseVisualStyleBackColor = true;
            this.radioPunter3.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioPunter2
            // 
            this.radioPunter2.AutoSize = true;
            this.radioPunter2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPunter2.Location = new System.Drawing.Point(19, 97);
            this.radioPunter2.Name = "radioPunter2";
            this.radioPunter2.Size = new System.Drawing.Size(137, 32);
            this.radioPunter2.TabIndex = 1;
            this.radioPunter2.TabStop = true;
            this.radioPunter2.Text = "Punter 2";
            this.radioPunter2.UseVisualStyleBackColor = true;
            this.radioPunter2.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioPunter1
            // 
            this.radioPunter1.AutoSize = true;
            this.radioPunter1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPunter1.Location = new System.Drawing.Point(19, 20);
            this.radioPunter1.Name = "radioPunter1";
            this.radioPunter1.Size = new System.Drawing.Size(137, 32);
            this.radioPunter1.TabIndex = 0;
            this.radioPunter1.TabStop = true;
            this.radioPunter1.Text = "Punter 1";
            this.radioPunter1.UseVisualStyleBackColor = true;
            this.radioPunter1.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // btnAction
            // 
            this.btnAction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.Location = new System.Drawing.Point(150, 627);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(872, 111);
            this.btnAction.TabIndex = 5;
            this.btnAction.Text = "Place Bet";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // picZeep4
            // 
            this.picZeep4.Image = global::RaceGameApp.Properties.Resources.zeep4;
            this.picZeep4.Location = new System.Drawing.Point(1076, 294);
            this.picZeep4.Name = "picZeep4";
            this.picZeep4.Size = new System.Drawing.Size(123, 70);
            this.picZeep4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZeep4.TabIndex = 4;
            this.picZeep4.TabStop = false;
            // 
            // picZeep3
            // 
            this.picZeep3.Image = global::RaceGameApp.Properties.Resources.zeep3;
            this.picZeep3.Location = new System.Drawing.Point(1076, 200);
            this.picZeep3.Name = "picZeep3";
            this.picZeep3.Size = new System.Drawing.Size(123, 70);
            this.picZeep3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZeep3.TabIndex = 3;
            this.picZeep3.TabStop = false;
            // 
            // picZeep2
            // 
            this.picZeep2.Image = global::RaceGameApp.Properties.Resources.zeep2;
            this.picZeep2.Location = new System.Drawing.Point(1076, 106);
            this.picZeep2.Name = "picZeep2";
            this.picZeep2.Size = new System.Drawing.Size(123, 70);
            this.picZeep2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZeep2.TabIndex = 2;
            this.picZeep2.TabStop = false;
            // 
            // picZeep1
            // 
            this.picZeep1.Image = global::RaceGameApp.Properties.Resources.zeep4;
            this.picZeep1.Location = new System.Drawing.Point(1076, 12);
            this.picZeep1.Name = "picZeep1";
            this.picZeep1.Size = new System.Drawing.Size(123, 70);
            this.picZeep1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picZeep1.TabIndex = 1;
            this.picZeep1.TabStop = false;
            // 
            // pictureTrack
            // 
            this.pictureTrack.Image = global::RaceGameApp.Properties.Resources.tracks;
            this.pictureTrack.Location = new System.Drawing.Point(12, 10);
            this.pictureTrack.Name = "pictureTrack";
            this.pictureTrack.Size = new System.Drawing.Size(1058, 354);
            this.pictureTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTrack.TabIndex = 6;
            this.pictureTrack.TabStop = false;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 750);
            this.Controls.Add(this.picZeep4);
            this.Controls.Add(this.picZeep3);
            this.Controls.Add(this.picZeep2);
            this.Controls.Add(this.picZeep1);
            this.Controls.Add(this.pictureTrack);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.panelControls);
            this.MaximizeBox = false;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Race Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameScreen_FormClosing);
            this.panelControls.ResumeLayout(false);
            this.panelControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDogNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picZeep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.PictureBox picZeep1;
        private System.Windows.Forms.PictureBox picZeep2;
        private System.Windows.Forms.PictureBox picZeep3;
        private System.Windows.Forms.PictureBox picZeep4;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.PictureBox pictureTrack;
        private System.Windows.Forms.TextBox textPunter3;
        private System.Windows.Forms.TextBox textPunter2;
        private System.Windows.Forms.TextBox textPunter1;
        private System.Windows.Forms.RadioButton radioPunter3;
        private System.Windows.Forms.RadioButton radioPunter2;
        private System.Windows.Forms.RadioButton radioPunter1;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Label labelMaxBet;
        private System.Windows.Forms.NumericUpDown numericDogNumber;
        private System.Windows.Forms.Label labelBetDog;
        private System.Windows.Forms.NumericUpDown numericBetAmount;
    }
}

