/*
 * Created by SharpDevelop.
 * User: User
 * Date: 27/02/2022
 * Time: 19:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace programsederhana
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(105, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masukkan Data";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(24, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(248, 20);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(105, 76);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Input";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(24, 115);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(245, 121);
			this.listBox1.TabIndex = 5;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "programsederhana";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
