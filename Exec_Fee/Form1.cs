using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_Fee
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			int young = 3;
			int oldmanfee = 2;
			int oldwomanfee = 3;
			int fullticket = 15;
			int oldman = 70;
			int oldwoman = 60;
			int free = 0;

			string yearinput= yearTextBox.Text;
			if (string.IsNullOrEmpty(yearinput))
			{
				MessageBox.Show("請輸入數字");
				return;

			}
			int years=Convert.ToInt32(yearinput);

			if (manButton.Checked==false&&womanButton.Checked==false)
			{
				MessageBox.Show("請選擇性別");
				return;
			}
			if (years<= young)
			{
				carFeeLabel.Text = $"{free}元";
				whyLabel.Text = $"小於{young}歲";
			}
			if (manButton.Checked == true && years >= oldman)
			{

				carFeeLabel.Text = $"{oldmanfee}元";
				whyLabel.Text = "這男的超過70歲了";
				return;
			}
			if (womanButton.Checked == true && years >= oldwoman)
			{
				carFeeLabel.Text = $"{oldwomanfee}元";
				whyLabel.Text = "這女的超過60歲了";
			}
			else
			{
				carFeeLabel.Text = $"{fullticket}元";
				whyLabel.Text = $"年紀未到優惠票";
			}

		}

		private void manButton_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
