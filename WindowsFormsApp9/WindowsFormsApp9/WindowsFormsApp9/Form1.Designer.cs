
namespace WindowsFormsApp9
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.allyear = new System.Windows.Forms.RadioButton();
			this.ChooseTime = new System.Windows.Forms.RadioButton();
			this.usefor = new System.Windows.Forms.ComboBox();
			this.ccstyle = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.timeline = new System.Windows.Forms.Panel();
			this.Dtpend = new System.Windows.Forms.DateTimePicker();
			this.Dtpstart = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.renew = new System.Windows.Forms.Button();
			this.Please = new System.Windows.Forms.Label();
			this.result = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timeline.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(146, 111);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "使用期間";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.Location = new System.Drawing.Point(186, 221);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "用途";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.Location = new System.Drawing.Point(34, 283);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(202, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "汽缸CC數 / 馬達馬力";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.Location = new System.Drawing.Point(78, 348);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "試算結果";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// allyear
			// 
			this.allyear.AutoSize = true;
			this.allyear.Checked = true;
			this.allyear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.allyear.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.allyear.Location = new System.Drawing.Point(267, 112);
			this.allyear.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.allyear.Name = "allyear";
			this.allyear.Size = new System.Drawing.Size(81, 24);
			this.allyear.TabIndex = 4;
			this.allyear.TabStop = true;
			this.allyear.Text = "全年度";
			this.allyear.UseVisualStyleBackColor = true;
			this.allyear.CheckedChanged += new System.EventHandler(this.allyear_CheckedChanged);
			// 
			// ChooseTime
			// 
			this.ChooseTime.AutoSize = true;
			this.ChooseTime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ChooseTime.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.ChooseTime.Location = new System.Drawing.Point(411, 111);
			this.ChooseTime.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.ChooseTime.Name = "ChooseTime";
			this.ChooseTime.Size = new System.Drawing.Size(81, 24);
			this.ChooseTime.TabIndex = 5;
			this.ChooseTime.Text = "依期間";
			this.ChooseTime.UseVisualStyleBackColor = true;
			this.ChooseTime.CheckedChanged += new System.EventHandler(this.ChooseTime_CheckedChanged);
			// 
			// usefor
			// 
			this.usefor.Cursor = System.Windows.Forms.Cursors.Default;
			this.usefor.FormattingEnabled = true;
			this.usefor.Items.AddRange(new object[] {
            "請選擇",
            "機車",
            "貨車",
            "大客車",
            "自用小客車",
            "營業用小客車"});
			this.usefor.Location = new System.Drawing.Point(256, 221);
			this.usefor.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.usefor.Name = "usefor";
			this.usefor.Size = new System.Drawing.Size(350, 23);
			this.usefor.TabIndex = 6;
			this.usefor.SelectedIndexChanged += new System.EventHandler(this.usefor_SelectedIndexChanged);
			// 
			// ccstyle
			// 
			this.ccstyle.Cursor = System.Windows.Forms.Cursors.Default;
			this.ccstyle.FormattingEnabled = true;
			this.ccstyle.Items.AddRange(new object[] {
            "請選擇"});
			this.ccstyle.Location = new System.Drawing.Point(256, 282);
			this.ccstyle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.ccstyle.Name = "ccstyle";
			this.ccstyle.Size = new System.Drawing.Size(350, 23);
			this.ccstyle.TabIndex = 7;
			this.ccstyle.SelectedIndexChanged += new System.EventHandler(this.ccstyle_SelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label7.Location = new System.Drawing.Point(214, 29);
			this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(462, 50);
			this.label7.TabIndex = 13;
			this.label7.Text = "使用牌照稅應納稅額試算";
			this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// timeline
			// 
			this.timeline.Controls.Add(this.Dtpend);
			this.timeline.Controls.Add(this.Dtpstart);
			this.timeline.Controls.Add(this.label6);
			this.timeline.Controls.Add(this.label5);
			this.timeline.Location = new System.Drawing.Point(202, 151);
			this.timeline.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.timeline.Name = "timeline";
			this.timeline.Size = new System.Drawing.Size(589, 52);
			this.timeline.TabIndex = 15;
			this.timeline.Visible = false;
			// 
			// Dtpend
			// 
			this.Dtpend.Cursor = System.Windows.Forms.Cursors.Default;
			this.Dtpend.CustomFormat = " yyyy年MM月dd日  dddd";
			this.Dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Dtpend.Location = new System.Drawing.Point(339, 16);
			this.Dtpend.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.Dtpend.Name = "Dtpend";
			this.Dtpend.Size = new System.Drawing.Size(246, 25);
			this.Dtpend.TabIndex = 16;
			this.Dtpend.ValueChanged += new System.EventHandler(this.Dtpend_ValueChanged);
			// 
			// Dtpstart
			// 
			this.Dtpstart.Cursor = System.Windows.Forms.Cursors.Default;
			this.Dtpstart.CustomFormat = " yyyy年MM月dd日  dddd";
			this.Dtpstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.Dtpstart.Location = new System.Drawing.Point(44, 16);
			this.Dtpstart.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.Dtpstart.Name = "Dtpstart";
			this.Dtpstart.Size = new System.Drawing.Size(246, 25);
			this.Dtpstart.TabIndex = 15;
			this.Dtpstart.ValueChanged += new System.EventHandler(this.Dtpstart_ValueChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label6.Location = new System.Drawing.Point(300, 19);
			this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 22);
			this.label6.TabIndex = 14;
			this.label6.Text = "至";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label5.Location = new System.Drawing.Point(5, 19);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 22);
			this.label5.TabIndex = 13;
			this.label5.Text = "從";
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(608, 698);
			this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 42);
			this.button1.TabIndex = 16;
			this.button1.Tag = "";
			this.button1.Text = "試算";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Calculate_Click);
			// 
			// renew
			// 
			this.renew.Cursor = System.Windows.Forms.Cursors.Hand;
			this.renew.Location = new System.Drawing.Point(767, 698);
			this.renew.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.renew.Name = "renew";
			this.renew.Size = new System.Drawing.Size(112, 42);
			this.renew.TabIndex = 17;
			this.renew.Text = "重填";
			this.renew.UseVisualStyleBackColor = true;
			this.renew.Click += new System.EventHandler(this.renew_Click);
			// 
			// Please
			// 
			this.Please.AutoSize = true;
			this.Please.Font = new System.Drawing.Font("新細明體", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Please.Location = new System.Drawing.Point(623, 251);
			this.Please.Name = "Please";
			this.Please.Size = new System.Drawing.Size(0, 33);
			this.Please.TabIndex = 18;
			// 
			// result
			// 
			this.result.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.result.Location = new System.Drawing.Point(173, 348);
			this.result.Multiline = true;
			this.result.Name = "result";
			this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.result.Size = new System.Drawing.Size(631, 330);
			this.result.TabIndex = 19;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-22, 684);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(258, 66);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(905, 752);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.result);
			this.Controls.Add(this.Please);
			this.Controls.Add(this.renew);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.timeline);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.ccstyle);
			this.Controls.Add(this.usefor);
			this.Controls.Add(this.ChooseTime);
			this.Controls.Add(this.allyear);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.Name = "Form1";
			this.Text = "TaxCalculator";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.timeline.ResumeLayout(false);
			this.timeline.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RadioButton allyear;
		private System.Windows.Forms.RadioButton ChooseTime;
		private System.Windows.Forms.ComboBox usefor;
		private System.Windows.Forms.ComboBox ccstyle;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel timeline;
		private System.Windows.Forms.DateTimePicker Dtpend;
		private System.Windows.Forms.DateTimePicker Dtpstart;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button renew;
		private System.Windows.Forms.Label Please;
		private System.Windows.Forms.TextBox result;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

