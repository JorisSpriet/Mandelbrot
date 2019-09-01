namespace MandelBrotParallel
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.settingsBox = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.steps = new System.Windows.Forms.TextBox();
			this.toPower = new System.Windows.Forms.TextBox();
			this.fromPower = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.settingsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Location = new System.Drawing.Point(-1, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(882, 623);
			this.panel1.TabIndex = 0;
			// 
			// settingsBox
			// 
			this.settingsBox.Controls.Add(this.button3);
			this.settingsBox.Controls.Add(this.steps);
			this.settingsBox.Controls.Add(this.toPower);
			this.settingsBox.Controls.Add(this.fromPower);
			this.settingsBox.Controls.Add(this.button2);
			this.settingsBox.Controls.Add(this.button1);
			this.settingsBox.Dock = System.Windows.Forms.DockStyle.Right;
			this.settingsBox.Location = new System.Drawing.Point(887, 0);
			this.settingsBox.Name = "settingsBox";
			this.settingsBox.Size = new System.Drawing.Size(229, 624);
			this.settingsBox.TabIndex = 1;
			this.settingsBox.TabStop = false;
			this.settingsBox.Text = "Settings";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(131, 97);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// steps
			// 
			this.steps.Location = new System.Drawing.Point(98, 19);
			this.steps.Name = "steps";
			this.steps.Size = new System.Drawing.Size(100, 20);
			this.steps.TabIndex = 5;
			this.steps.Text = "1000";
			// 
			// toPower
			// 
			this.toPower.Location = new System.Drawing.Point(54, 19);
			this.toPower.Name = "toPower";
			this.toPower.Size = new System.Drawing.Size(38, 20);
			this.toPower.TabIndex = 4;
			this.toPower.Text = "4";
			// 
			// fromPower
			// 
			this.fromPower.Location = new System.Drawing.Point(6, 19);
			this.fromPower.Name = "fromPower";
			this.fromPower.Size = new System.Drawing.Size(42, 20);
			this.fromPower.TabIndex = 2;
			this.fromPower.Text = "2";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(6, 126);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 97);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1116, 624);
			this.Controls.Add(this.settingsBox);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "Form1";
			this.Text = "Form1";
			this.settingsBox.ResumeLayout(false);
			this.settingsBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox settingsBox;
		private System.Windows.Forms.TextBox fromPower;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox steps;
		private System.Windows.Forms.TextBox toPower;
		private System.Windows.Forms.Button button3;
	}
}

