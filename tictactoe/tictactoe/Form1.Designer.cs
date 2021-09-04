namespace tictactoe
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
            this.TopRight = new System.Windows.Forms.Panel();
            this.MiddleRight = new System.Windows.Forms.Panel();
            this.MiddleMiddle = new System.Windows.Forms.Panel();
            this.MiddleLeft = new System.Windows.Forms.Panel();
            this.BottomRight = new System.Windows.Forms.Panel();
            this.BottomMiddle = new System.Windows.Forms.Panel();
            this.BottomLeft = new System.Windows.Forms.Panel();
            this.TopMiddle = new System.Windows.Forms.Panel();
            this.TopLeft = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopRight
            // 
            this.TopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopRight.Location = new System.Drawing.Point(606, 12);
            this.TopRight.Name = "TopRight";
            this.TopRight.Size = new System.Drawing.Size(150, 150);
            this.TopRight.TabIndex = 2;
            this.TopRight.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // MiddleRight
            // 
            this.MiddleRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiddleRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleRight.Location = new System.Drawing.Point(606, 168);
            this.MiddleRight.Name = "MiddleRight";
            this.MiddleRight.Size = new System.Drawing.Size(150, 150);
            this.MiddleRight.TabIndex = 5;
            this.MiddleRight.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // MiddleMiddle
            // 
            this.MiddleMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiddleMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleMiddle.Location = new System.Drawing.Point(450, 169);
            this.MiddleMiddle.Name = "MiddleMiddle";
            this.MiddleMiddle.Size = new System.Drawing.Size(150, 150);
            this.MiddleMiddle.TabIndex = 4;
            this.MiddleMiddle.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // MiddleLeft
            // 
            this.MiddleLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiddleLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MiddleLeft.Location = new System.Drawing.Point(294, 169);
            this.MiddleLeft.Name = "MiddleLeft";
            this.MiddleLeft.Size = new System.Drawing.Size(150, 150);
            this.MiddleLeft.TabIndex = 3;
            this.MiddleLeft.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // BottomRight
            // 
            this.BottomRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomRight.Location = new System.Drawing.Point(606, 324);
            this.BottomRight.Name = "BottomRight";
            this.BottomRight.Size = new System.Drawing.Size(150, 150);
            this.BottomRight.TabIndex = 8;
            this.BottomRight.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // BottomMiddle
            // 
            this.BottomMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomMiddle.Location = new System.Drawing.Point(450, 325);
            this.BottomMiddle.Name = "BottomMiddle";
            this.BottomMiddle.Size = new System.Drawing.Size(150, 150);
            this.BottomMiddle.TabIndex = 7;
            this.BottomMiddle.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // BottomLeft
            // 
            this.BottomLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BottomLeft.Location = new System.Drawing.Point(294, 325);
            this.BottomLeft.Name = "BottomLeft";
            this.BottomLeft.Size = new System.Drawing.Size(150, 150);
            this.BottomLeft.TabIndex = 6;
            this.BottomLeft.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // TopMiddle
            // 
            this.TopMiddle.BackgroundImage = global::tictactoe.Properties.Resources.o__2_;
            this.TopMiddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopMiddle.Location = new System.Drawing.Point(450, 12);
            this.TopMiddle.Name = "TopMiddle";
            this.TopMiddle.Size = new System.Drawing.Size(150, 150);
            this.TopMiddle.TabIndex = 1;
            this.TopMiddle.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // TopLeft
            // 
            this.TopLeft.BackgroundImage = global::tictactoe.Properties.Resources.cross;
            this.TopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopLeft.Location = new System.Drawing.Point(294, 12);
            this.TopLeft.Name = "TopLeft";
            this.TopLeft.Size = new System.Drawing.Size(150, 150);
            this.TopLeft.TabIndex = 0;
            this.TopLeft.Click += new System.EventHandler(this.TopMiddle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "TIC TAC TOE ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "NEW GAME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "By Clarence Yang";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(23, 408);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Play with AI";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Noughts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Crosses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 499);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BottomRight);
            this.Controls.Add(this.BottomMiddle);
            this.Controls.Add(this.BottomLeft);
            this.Controls.Add(this.MiddleRight);
            this.Controls.Add(this.MiddleMiddle);
            this.Controls.Add(this.TopRight);
            this.Controls.Add(this.MiddleLeft);
            this.Controls.Add(this.TopMiddle);
            this.Controls.Add(this.TopLeft);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "TIC TAC TOE ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopLeft;
        private System.Windows.Forms.Panel TopMiddle;
        private System.Windows.Forms.Panel TopRight;
        private System.Windows.Forms.Panel MiddleRight;
        private System.Windows.Forms.Panel MiddleMiddle;
        private System.Windows.Forms.Panel MiddleLeft;
        private System.Windows.Forms.Panel BottomRight;
        private System.Windows.Forms.Panel BottomMiddle;
        private System.Windows.Forms.Panel BottomLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

