/*
 * Created by SharpDevelop.
 * User: User
 * Date: 08/03/2022
 * Time: 11:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace program2
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);
			listBox1.Items.Add(textBox2.Text);
			listBox1.Items.Add(textBox3.Text);

			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
		}
		void Button2Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
		}
	}
}
