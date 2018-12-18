namespace WindowsFormsApplication40
{
    partial class objectFollow
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
            this.sourceBox = new System.Windows.Forms.PictureBox();
            this.processedBox = new System.Windows.Forms.PictureBox();
            this.cameraBox = new System.Windows.Forms.ComboBox();
            this.btnstart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.arduinoportBox = new System.Windows.Forms.ComboBox();
            this.btnconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.redButton = new System.Windows.Forms.RadioButton();
            this.greenButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.redButton1 = new System.Windows.Forms.RadioButton();
            this.greenButton1 = new System.Windows.Forms.RadioButton();
            this.blueButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceBox
            // 
            this.sourceBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sourceBox.Location = new System.Drawing.Point(12, 115);
            this.sourceBox.Name = "sourceBox";
            this.sourceBox.Size = new System.Drawing.Size(640, 360);
            this.sourceBox.TabIndex = 0;
            this.sourceBox.TabStop = false;
            // 
            // processedBox
            // 
            this.processedBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.processedBox.Location = new System.Drawing.Point(702, 115);
            this.processedBox.Name = "processedBox";
            this.processedBox.Size = new System.Drawing.Size(640, 360);
            this.processedBox.TabIndex = 1;
            this.processedBox.TabStop = false;
            // 
            // cameraBox
            // 
            this.cameraBox.FormattingEnabled = true;
            this.cameraBox.Location = new System.Drawing.Point(12, 58);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(225, 24);
            this.cameraBox.TabIndex = 2;
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(253, 45);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(88, 50);
            this.btnstart.TabIndex = 3;
            this.btnstart.Text = "START";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 50);
            this.button2.TabIndex = 4;
            this.button2.Text = "STOP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // arduinoportBox
            // 
            this.arduinoportBox.FormattingEnabled = true;
            this.arduinoportBox.Location = new System.Drawing.Point(591, 59);
            this.arduinoportBox.Name = "arduinoportBox";
            this.arduinoportBox.Size = new System.Drawing.Size(225, 24);
            this.arduinoportBox.TabIndex = 5;
            // 
            // btnconnect
            // 
            this.btnconnect.Location = new System.Drawing.Point(949, 46);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(92, 49);
            this.btnconnect.TabIndex = 6;
            this.btnconnect.Text = "CONNECT";
            this.btnconnect.UseVisualStyleBackColor = true;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(300, 654);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(58, 21);
            this.redButton.TabIndex = 7;
            this.redButton.TabStop = true;
            this.redButton.Text = "RED";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // greenButton
            // 
            this.greenButton.AutoSize = true;
            this.greenButton.Location = new System.Drawing.Point(358, 654);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(78, 21);
            this.greenButton.TabIndex = 8;
            this.greenButton.TabStop = true;
            this.greenButton.Text = "GREEN";
            this.greenButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(671, 654);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(65, 21);
            this.blueButton.TabIndex = 9;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "BLUE";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // redButton1
            // 
            this.redButton1.AutoSize = true;
            this.redButton1.Location = new System.Drawing.Point(53, 509);
            this.redButton1.Name = "redButton1";
            this.redButton1.Size = new System.Drawing.Size(58, 21);
            this.redButton1.TabIndex = 10;
            this.redButton1.TabStop = true;
            this.redButton1.Text = "RED";
            this.redButton1.UseVisualStyleBackColor = true;
            // 
            // greenButton1
            // 
            this.greenButton1.AutoSize = true;
            this.greenButton1.Location = new System.Drawing.Point(318, 509);
            this.greenButton1.Name = "greenButton1";
            this.greenButton1.Size = new System.Drawing.Size(78, 21);
            this.greenButton1.TabIndex = 11;
            this.greenButton1.TabStop = true;
            this.greenButton1.Text = "GREEN";
            this.greenButton1.UseVisualStyleBackColor = true;
            // 
            // blueButton1
            // 
            this.blueButton1.AutoSize = true;
            this.blueButton1.Location = new System.Drawing.Point(632, 509);
            this.blueButton1.Name = "blueButton1";
            this.blueButton1.Size = new System.Drawing.Size(65, 21);
            this.blueButton1.TabIndex = 12;
            this.blueButton1.TabStop = true;
            this.blueButton1.Text = "BLUE";
            this.blueButton1.UseVisualStyleBackColor = true;
            // 
            // objectFollow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1473, 655);
            this.Controls.Add(this.blueButton1);
            this.Controls.Add(this.greenButton1);
            this.Controls.Add(this.redButton1);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.greenButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.arduinoportBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.processedBox);
            this.Controls.Add(this.sourceBox);
            this.Name = "objectFollow";
            this.Text = "objectFollow";
            this.Load += new System.EventHandler(this.objectFollow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sourceBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processedBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceBox;
        private System.Windows.Forms.PictureBox processedBox;
        private System.Windows.Forms.ComboBox cameraBox;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox arduinoportBox;
        private System.Windows.Forms.Button btnconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton greenButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton redButton1;
        private System.Windows.Forms.RadioButton greenButton1;
        private System.Windows.Forms.RadioButton blueButton1;
    }
}

