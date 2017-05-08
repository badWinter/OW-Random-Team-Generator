namespace OverwatchRandomGenerator
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
            this.groupContainer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupSizeBox = new System.Windows.Forms.NumericUpDown();
            this.sizeButton = new System.Windows.Forms.Button();
            this.playersContainer = new System.Windows.Forms.GroupBox();
            this.p3Name = new System.Windows.Forms.TextBox();
            this.p2Name = new System.Windows.Forms.TextBox();
            this.p1Name = new System.Windows.Forms.TextBox();
            this.p4Name = new System.Windows.Forms.TextBox();
            this.p5Name = new System.Windows.Forms.TextBox();
            this.p6Name = new System.Windows.Forms.TextBox();
            this.p1Hero = new System.Windows.Forms.Label();
            this.p2Hero = new System.Windows.Forms.Label();
            this.p3Hero = new System.Windows.Forms.Label();
            this.p4Hero = new System.Windows.Forms.Label();
            this.p5Hero = new System.Windows.Forms.Label();
            this.p6Hero = new System.Windows.Forms.Label();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.groupContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSizeBox)).BeginInit();
            this.playersContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupContainer
            // 
            this.groupContainer.Controls.Add(this.sizeButton);
            this.groupContainer.Controls.Add(this.groupSizeBox);
            this.groupContainer.Controls.Add(this.label1);
            this.groupContainer.Location = new System.Drawing.Point(13, 13);
            this.groupContainer.Name = "groupContainer";
            this.groupContainer.Size = new System.Drawing.Size(237, 49);
            this.groupContainer.TabIndex = 0;
            this.groupContainer.TabStop = false;
            this.groupContainer.Text = "Select a group size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Group Size";
            // 
            // groupSizeBox
            // 
            this.groupSizeBox.Location = new System.Drawing.Point(82, 18);
            this.groupSizeBox.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.groupSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.groupSizeBox.Name = "groupSizeBox";
            this.groupSizeBox.Size = new System.Drawing.Size(39, 20);
            this.groupSizeBox.TabIndex = 1;
            this.groupSizeBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sizeButton
            // 
            this.sizeButton.Location = new System.Drawing.Point(156, 15);
            this.sizeButton.Name = "sizeButton";
            this.sizeButton.Size = new System.Drawing.Size(75, 23);
            this.sizeButton.TabIndex = 2;
            this.sizeButton.Text = "Set";
            this.sizeButton.UseVisualStyleBackColor = true;
            this.sizeButton.Click += new System.EventHandler(this.sizeButton_Click);
            // 
            // playersContainer
            // 
            this.playersContainer.Controls.Add(this.p6Hero);
            this.playersContainer.Controls.Add(this.p5Hero);
            this.playersContainer.Controls.Add(this.p4Hero);
            this.playersContainer.Controls.Add(this.p3Hero);
            this.playersContainer.Controls.Add(this.p2Hero);
            this.playersContainer.Controls.Add(this.p1Hero);
            this.playersContainer.Controls.Add(this.p6Name);
            this.playersContainer.Controls.Add(this.p5Name);
            this.playersContainer.Controls.Add(this.p4Name);
            this.playersContainer.Controls.Add(this.p1Name);
            this.playersContainer.Controls.Add(this.p2Name);
            this.playersContainer.Controls.Add(this.p3Name);
            this.playersContainer.Location = new System.Drawing.Point(13, 69);
            this.playersContainer.Name = "playersContainer";
            this.playersContainer.Size = new System.Drawing.Size(559, 280);
            this.playersContainer.TabIndex = 1;
            this.playersContainer.TabStop = false;
            this.playersContainer.Text = "Players";
            // 
            // p3Name
            // 
            this.p3Name.Location = new System.Drawing.Point(440, 109);
            this.p3Name.Name = "p3Name";
            this.p3Name.Size = new System.Drawing.Size(100, 20);
            this.p3Name.TabIndex = 0;
            this.p3Name.Text = "Player 3";
            this.p3Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p3Name.TextChanged += new System.EventHandler(this.p3Name_TextChanged);
            // 
            // p2Name
            // 
            this.p2Name.Location = new System.Drawing.Point(230, 109);
            this.p2Name.Name = "p2Name";
            this.p2Name.Size = new System.Drawing.Size(100, 20);
            this.p2Name.TabIndex = 1;
            this.p2Name.Text = "Player 2";
            this.p2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p2Name.TextChanged += new System.EventHandler(this.p2Name_TextChanged);
            // 
            // p1Name
            // 
            this.p1Name.Location = new System.Drawing.Point(21, 109);
            this.p1Name.Name = "p1Name";
            this.p1Name.Size = new System.Drawing.Size(100, 20);
            this.p1Name.TabIndex = 2;
            this.p1Name.Text = "Player 1";
            this.p1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p1Name.TextChanged += new System.EventHandler(this.p1Name_TextChanged);
            // 
            // p4Name
            // 
            this.p4Name.Location = new System.Drawing.Point(21, 236);
            this.p4Name.Name = "p4Name";
            this.p4Name.Size = new System.Drawing.Size(100, 20);
            this.p4Name.TabIndex = 3;
            this.p4Name.Text = "Player 4";
            this.p4Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p4Name.TextChanged += new System.EventHandler(this.p4Name_TextChanged);
            // 
            // p5Name
            // 
            this.p5Name.Location = new System.Drawing.Point(230, 236);
            this.p5Name.Name = "p5Name";
            this.p5Name.Size = new System.Drawing.Size(100, 20);
            this.p5Name.TabIndex = 4;
            this.p5Name.Text = "Player 5";
            this.p5Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p5Name.TextChanged += new System.EventHandler(this.p5Name_TextChanged);
            // 
            // p6Name
            // 
            this.p6Name.Location = new System.Drawing.Point(440, 236);
            this.p6Name.Name = "p6Name";
            this.p6Name.Size = new System.Drawing.Size(100, 20);
            this.p6Name.TabIndex = 5;
            this.p6Name.Text = "Player 6";
            this.p6Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p6Name.TextChanged += new System.EventHandler(this.p6Name_TextChanged);
            // 
            // p1Hero
            // 
            this.p1Hero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p1Hero.Location = new System.Drawing.Point(21, 86);
            this.p1Hero.Name = "p1Hero";
            this.p1Hero.Size = new System.Drawing.Size(100, 20);
            this.p1Hero.TabIndex = 6;
            this.p1Hero.Text = "?";
            this.p1Hero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Hero
            // 
            this.p2Hero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p2Hero.Location = new System.Drawing.Point(230, 86);
            this.p2Hero.Name = "p2Hero";
            this.p2Hero.Size = new System.Drawing.Size(100, 20);
            this.p2Hero.TabIndex = 7;
            this.p2Hero.Text = "?";
            this.p2Hero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p3Hero
            // 
            this.p3Hero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p3Hero.Location = new System.Drawing.Point(440, 86);
            this.p3Hero.Name = "p3Hero";
            this.p3Hero.Size = new System.Drawing.Size(100, 20);
            this.p3Hero.TabIndex = 8;
            this.p3Hero.Text = "?";
            this.p3Hero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p4Hero
            // 
            this.p4Hero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p4Hero.Location = new System.Drawing.Point(21, 213);
            this.p4Hero.Name = "p4Hero";
            this.p4Hero.Size = new System.Drawing.Size(100, 20);
            this.p4Hero.TabIndex = 9;
            this.p4Hero.Text = "?";
            this.p4Hero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p5Hero
            // 
            this.p5Hero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p5Hero.Location = new System.Drawing.Point(230, 213);
            this.p5Hero.Name = "p5Hero";
            this.p5Hero.Size = new System.Drawing.Size(100, 20);
            this.p5Hero.TabIndex = 10;
            this.p5Hero.Text = "?";
            this.p5Hero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p6Hero
            // 
            this.p6Hero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.p6Hero.Location = new System.Drawing.Point(440, 213);
            this.p6Hero.Name = "p6Hero";
            this.p6Hero.Size = new System.Drawing.Size(100, 20);
            this.p6Hero.TabIndex = 11;
            this.p6Hero.Text = "?";
            this.p6Hero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // randomizeButton
            // 
            this.randomizeButton.Location = new System.Drawing.Point(368, 14);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(204, 50);
            this.randomizeButton.TabIndex = 2;
            this.randomizeButton.Text = "Randomize";
            this.randomizeButton.UseVisualStyleBackColor = true;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.randomizeButton);
            this.Controls.Add(this.playersContainer);
            this.Controls.Add(this.groupContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Overwatch Random Hero Generator";
            this.groupContainer.ResumeLayout(false);
            this.groupContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupSizeBox)).EndInit();
            this.playersContainer.ResumeLayout(false);
            this.playersContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupContainer;
        private System.Windows.Forms.NumericUpDown groupSizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sizeButton;
        private System.Windows.Forms.GroupBox playersContainer;
        private System.Windows.Forms.TextBox p6Name;
        private System.Windows.Forms.TextBox p5Name;
        private System.Windows.Forms.TextBox p4Name;
        private System.Windows.Forms.TextBox p1Name;
        private System.Windows.Forms.TextBox p2Name;
        private System.Windows.Forms.TextBox p3Name;
        private System.Windows.Forms.Label p1Hero;
        private System.Windows.Forms.Label p6Hero;
        private System.Windows.Forms.Label p5Hero;
        private System.Windows.Forms.Label p4Hero;
        private System.Windows.Forms.Label p3Hero;
        private System.Windows.Forms.Label p2Hero;
        private System.Windows.Forms.Button randomizeButton;
    }
}

