/*
 * Created by SharpDevelop.
 * User: User
 * Date: 27/02/2022
 * Time: 19:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace programsederhana
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add(textBox1.Text);
		}
	}
}
