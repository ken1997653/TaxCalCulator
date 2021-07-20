using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{


	public partial class Form1 : Form
	{
		
		
		string[] motorcc = new string[] { "150cc 以下 / 12HP以下(12.2PS以下)", "151cc~ 250cc/12.1~20HP(12.3~20.3PS)", "251cc~ 500cc/20.1HP以上(20.4PS以上)", "501cc~ 600cc", "601cc~1200cc", "1201cc~1800cc", "1801cc 以上" };
		int[] mortortax = new int[] { 0, 800, 1620, 2160, 4320, 7120, 11230 };
		string[] carcc = new string[] { "500cc 以下 / 38HP以下(38.6PS以下)", "501cc - 600cc / 38.1-56HP(38.7-56.8PS)", "601cc - 1200cc / 56.1-83HP(56.9-84.2PS)", "1201cc - 1800cc / 83.1-182HP(84.3-184.7PS)", "1801cc - 2400cc / 182.1-262HP(184.8-265.9PS)", "2401cc - 3000cc / 262.1-322HP(266-326.8PS", "3001cc - 4200cc / 322.1-414HP(326.9-420.2PS", "4201cc - 5400cc / 414.1-469HP(420.3-476.0PS)", "5401cc - 6600cc/ 469.1-509HP(476.1-516.6PS)", "6601cc - 7800cc / 509.1HP以上(516.7PS以上)", "7801cc 以上" };
		int[] homecartax = new int[] { 1620, 2160, 4320, 7120, 11230, 15210, 28220, 46170, 69690, 117000, 151200 };
		int[] comcartax = new int[] { 1260, 2160, 3060, 6480, 9900, 16380, 24300, 33660, 44460, 56700 };
		string[] bcatcc = new string[] { "500cc 以下", "501cc - 600cc", "601cc - 1200cc", "1201cc - 1800cc", "1801cc - 2400cc", "2401cc - 3000cc / 138HP以下(140.1PS以下)", "3001cc - 3600cc", "3601cc - 4200cc / 138.1-200HP(140.2-203.0PS)", "4201cc - 4800cc", "4801cc -5400cc / 200.1-247HP(203.1-250.7PS)", "5401cc - 6000cc", "6001cc - 6600cc / 247.1-286HP(250.8-290.3PS)", "6601cc-7200cc", "7201cc-7800cc / 286.1-336HP(290.4-341.0PS)", "7801cc~8400cc", "8401cc~9000cc / 336.1-361HP(341.1-366.4PS)", "9001cc~9600cc", "9601cc~10200cc / 361.1HP以上(366.5PS以上)", "10201cc 以上" };
		int[] bigcartax = new int[] { 0,1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };
		int[] trucktax = new int[] { 900, 1080, 1800, 2700, 3600, 4500, 5400, 6300, 7200, 8100, 9000, 9900, 10800, 11700, 12600, 13500, 14400, 15300, 16200 };
		public Form1()
		{
			InitializeComponent();
		}
		
		private void Form1_Load(object sender, EventArgs e)
		{
			usefor.SelectedIndex = 0;
			ccstyle.SelectedIndex = 0;
			this.Dtpstart.Value = DateTime.Now;
			this.Dtpend.MinDate = DateTime.Now;
			
		}

		private void allyear_CheckedChanged(object sender, EventArgs e)
		{
			if(allyear.Checked)
			this.timeline.Visible = false;
		}

		private void ChooseTime_CheckedChanged(object sender, EventArgs e)
		{
			if (ChooseTime.Checked)
				this.timeline.Visible = true;
		}

	
		private void Calculate_Click(object sender, EventArgs e)
		{
			


			if (usefor.SelectedItem.ToString() == "請選擇")
			{

				this.Please.Text = "請先選擇用途!!";
				this.Please.Visible = true;
				result.Visible = false;
			}
			else
			{
				this.Please.Visible = false;
				result.Visible = true;
			}
			string choosetype;
			choosetype = usefor.SelectedItem.ToString();
			int ccstyleindex = ccstyle.SelectedIndex;
			string chooseccstyle;
			chooseccstyle = ccstyle.SelectedItem.ToString();
			int taxprice;
			switch (choosetype)
			{
				case "機車":
					taxprice = mortortax[ccstyleindex];
					break;
				case "貨車":
					taxprice = trucktax[ccstyleindex];
					break;
				case "大客車":
					taxprice = bigcartax[ccstyleindex];
					break;
				case "自用小客車":
					taxprice = homecartax[ccstyleindex];
					break;
				case "營業用小客車":
					taxprice = comcartax[ccstyleindex];
					break;
				default:

					taxprice = 0;
					break;
			}

			string startday;
			string endday;
			DateTime sstartday;
			DateTime eendday;


			if (allyear.Checked)
			{

				startday = new DateTime(DateTime.Now.Year, 1, 1,00,00,00).ToString("yyyy/MM/dd");
				endday = new DateTime(DateTime.Now.Year, 12, 31,23,59,59).ToString("yyyy/MM/dd");
				sstartday = new DateTime(DateTime.Now.Year, 1, 1);
				eendday = new DateTime(DateTime.Now.Year, 12, 31);



			}

			else
			{

				startday = Dtpstart.Value.ToString("yyyy/MM/dd");
				endday = Dtpend.Value.ToString("yyyy/MM/dd");
				sstartday = Dtpstart.Value;
				eendday = Dtpend.Value;



			}
			int countyearsnum;
			countyearsnum = eendday.Year - sstartday.Year + 1;
			int[] yearsrange = new int[countyearsnum];
			int[] daynum = new int[countyearsnum];
			bool fouryearonce;
			int threesixsix;
			int[] daysinyears = new int[countyearsnum];
		
			DateTime[,] choseyearday = new DateTime[countyearsnum, 2];
			TimeSpan countdays;
			int[] taxpricerange = new int[countyearsnum];
			for (int c = 0; c < countyearsnum; c++)       //for(int i =1;i<=X;i++)
			{
				yearsrange[c] = sstartday.Year + c;
				fouryearonce = DateTime.IsLeapYear(sstartday.Year + c);

				if (fouryearonce)
				{
					threesixsix = 366;
				}
				else
				{
					threesixsix = 365;
				}

				daynum[c] = threesixsix;
				if (c == 0)
				{
					
					choseyearday[c, 0] = sstartday.Date;
					
				}
				else
					choseyearday[c, 0] = new DateTime(sstartday.Year + c, 1, 1);
				if (c == countyearsnum - 1)
				{
					choseyearday[c, 1] = eendday;
				}
				else
					choseyearday[c, 1] = new DateTime(sstartday.Year + c, 12, 31);


				countdays = choseyearday[c, 1] - choseyearday[c, 0];
				countdays = countdays.Add(new TimeSpan(1, 0, 0, 1));
				daysinyears[c] = countdays.Days;

				taxpricerange[c] = taxprice * countdays.Days / threesixsix;

			}


			result.Text = "";

			for (int c = 0; c < countyearsnum; c++)
			{


				this.result.Text +=

					$"第{c + 1}筆," + Environment.NewLine + Environment.NewLine +
					$"使用期間:從{choseyearday[c, 0].ToString("yyyy/MM/dd")}至{choseyearday[c, 1].ToString("yyyy/MM/dd")}" + Environment.NewLine + Environment.NewLine +
					$"計算天數: {daysinyears[c]}" + Environment.NewLine + Environment.NewLine +
					$"用途: {choosetype}" + Environment.NewLine + Environment.NewLine +
					$"汽缸CC數: {chooseccstyle}" + Environment.NewLine + Environment.NewLine +
					$"計算公式:{taxprice}*{daysinyears[c]}/{daynum[c]}={taxprice * daysinyears[c] / daynum[c]}" + Environment.NewLine + Environment.NewLine +
					$"應納稅額:{taxprice * daysinyears[c] / daynum[c]}" + Environment.NewLine + Environment.NewLine + Environment.NewLine +
					$"______________________________________________" + Environment.NewLine + Environment.NewLine + Environment.NewLine;
			}

			int totaltax = 0;
			foreach (int total in taxpricerange)
			{ totaltax += total; }

			this.result.Text +=
			$"共計{countyearsnum}筆,總金額{totaltax}元" + Environment.NewLine + Environment.NewLine;
		}

		private void renew_Click(object sender, EventArgs e)
		{
			usefor.SelectedIndex = 0;
			ccstyle.SelectedIndex = 0;
			allyear.Checked = true;
			this.result.Text = "";
			this.Please.Text = "請先選擇用途!!";
			this.Please.Visible = false;
			this.result.Visible = true;
			Dtpstart.Value = DateTime.Now;
			Dtpend.Value = DateTime.Now;

		}

		private void usefor_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			switch (usefor.SelectedItem) 
			{
				case "請選擇":
					ccstyle.Items.Clear();
					ccstyle.Items.Add("請先選擇用途");
					ccstyle.SelectedIndex = 0;
					break;
				case "機車":
					ccstyle.Items.Clear();
					ccstyle.Items.AddRange(motorcc);
					ccstyle.SelectedIndex = 0;

					break;
				case "貨車":
					ccstyle.Items.Clear();
					ccstyle.Items.AddRange(bcatcc);
					ccstyle.SelectedIndex = 0;
					break;
				case "大客車":
					ccstyle.Items.Clear();
					ccstyle.Items.AddRange(bcatcc);
					ccstyle.SelectedIndex = 0;
					break;
				case "自用小客車":
					ccstyle.Items.Clear();
					ccstyle.Items.AddRange(carcc);
					ccstyle.SelectedIndex = 0;
					break;
				case "營業用小客車":
					ccstyle.Items.Clear();
					ccstyle.Items.AddRange(carcc);
					ccstyle.SelectedIndex = 0;
					break;


					

			}
			if (usefor.SelectedItem != "請選擇") 
			{
				this.Please.Visible = false;
			}
		}



		private void ccstyle_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void Dtpstart_ValueChanged(object sender, EventArgs e)
		{
			Dtpend.MinDate = Dtpstart.Value;
		}

		private void Dtpend_ValueChanged(object sender, EventArgs e)
		{

		}

		
	}

}


