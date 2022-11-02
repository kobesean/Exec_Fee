namespace Exec_Fee
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
			this.yearTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.calcButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.manButton = new System.Windows.Forms.RadioButton();
			this.womanButton = new System.Windows.Forms.RadioButton();
			this.carFeeLabel = new System.Windows.Forms.Label();
			this.whyLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// yearTextBox
			// 
			this.yearTextBox.Location = new System.Drawing.Point(62, 44);
			this.yearTextBox.Name = "yearTextBox";
			this.yearTextBox.Size = new System.Drawing.Size(100, 22);
			this.yearTextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "年齡:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "車資:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 3;
			this.label3.Text = "原因:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.womanButton);
			this.groupBox1.Controls.Add(this.manButton);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.calcButton);
			this.groupBox1.Controls.Add(this.yearTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(31, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 166);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "客戶資訊";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.whyLabel);
			this.groupBox2.Controls.Add(this.carFeeLabel);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Location = new System.Drawing.Point(31, 210);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(385, 115);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "計算結果";
			// 
			// calcButton
			// 
			this.calcButton.Location = new System.Drawing.Point(72, 109);
			this.calcButton.Name = "calcButton";
			this.calcButton.Size = new System.Drawing.Size(75, 23);
			this.calcButton.TabIndex = 2;
			this.calcButton.Text = "計算";
			this.calcButton.UseVisualStyleBackColor = true;
			this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(198, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 3;
			this.label4.Text = "性別:";
			// 
			// manButton
			// 
			this.manButton.AutoSize = true;
			this.manButton.Location = new System.Drawing.Point(246, 52);
			this.manButton.Name = "manButton";
			this.manButton.Size = new System.Drawing.Size(35, 16);
			this.manButton.TabIndex = 4;
			this.manButton.TabStop = true;
			this.manButton.Text = "男";
			this.manButton.UseVisualStyleBackColor = true;
			this.manButton.CheckedChanged += new System.EventHandler(this.manButton_CheckedChanged);
			// 
			// womanButton
			// 
			this.womanButton.AutoSize = true;
			this.womanButton.Location = new System.Drawing.Point(303, 52);
			this.womanButton.Name = "womanButton";
			this.womanButton.Size = new System.Drawing.Size(35, 16);
			this.womanButton.TabIndex = 5;
			this.womanButton.TabStop = true;
			this.womanButton.Text = "女";
			this.womanButton.UseVisualStyleBackColor = true;
			// 
			// carFeeLabel
			// 
			this.carFeeLabel.AutoSize = true;
			this.carFeeLabel.Location = new System.Drawing.Point(72, 35);
			this.carFeeLabel.Name = "carFeeLabel";
			this.carFeeLabel.Size = new System.Drawing.Size(33, 12);
			this.carFeeLabel.TabIndex = 4;
			this.carFeeLabel.Text = "label5";
			// 
			// whyLabel
			// 
			this.whyLabel.AutoSize = true;
			this.whyLabel.Location = new System.Drawing.Point(72, 73);
			this.whyLabel.Name = "whyLabel";
			this.whyLabel.Size = new System.Drawing.Size(33, 12);
			this.whyLabel.TabIndex = 5;
			this.whyLabel.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 424);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox yearTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton womanButton;
		private System.Windows.Forms.RadioButton manButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button calcButton;
		private System.Windows.Forms.Label whyLabel;
		private System.Windows.Forms.Label carFeeLabel;
	}
}

