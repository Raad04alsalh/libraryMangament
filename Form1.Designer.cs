namespace MidTerm
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			first_name = new Label();
			textBox2 = new TextBox();
			ID_no = new Label();
			_major = new GroupBox();
			_cyber = new RadioButton();
			_cs = new RadioButton();
			_ai = new RadioButton();
			_se = new RadioButton();
			_lang = new GroupBox();
			_cSharp = new CheckBox();
			_java = new CheckBox();
			_c = new CheckBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			student_info_list = new ListBox();
			_major.SuspendLayout();
			_lang.SuspendLayout();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.BackColor = SystemColors.InactiveCaption;
			textBox1.BorderStyle = BorderStyle.FixedSingle;
			textBox1.Location = new Point(188, 55);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(125, 27);
			textBox1.TabIndex = 0;
			// 
			// first_name
			// 
			first_name.AutoSize = true;
			first_name.BorderStyle = BorderStyle.Fixed3D;
			first_name.Location = new Point(76, 58);
			first_name.Name = "first_name";
			first_name.Size = new Size(84, 22);
			first_name.TabIndex = 1;
			first_name.Text = "first name :";
			// 
			// textBox2
			// 
			textBox2.BackColor = SystemColors.InactiveCaption;
			textBox2.BorderStyle = BorderStyle.FixedSingle;
			textBox2.Location = new Point(188, 115);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(125, 27);
			textBox2.TabIndex = 2;
			// 
			// ID_no
			// 
			ID_no.AutoSize = true;
			ID_no.BorderStyle = BorderStyle.Fixed3D;
			ID_no.Location = new Point(76, 115);
			ID_no.Name = "ID_no";
			ID_no.Size = new Size(88, 22);
			ID_no.TabIndex = 3;
			ID_no.Text = "ID number :";
			// 
			// _major
			// 
			_major.BackColor = Color.Aquamarine;
			_major.Controls.Add(_cyber);
			_major.Controls.Add(_cs);
			_major.Controls.Add(_ai);
			_major.Controls.Add(_se);
			_major.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			_major.Location = new Point(64, 190);
			_major.Name = "_major";
			_major.Size = new Size(354, 223);
			_major.TabIndex = 4;
			_major.TabStop = false;
			_major.Text = "choose a major :";
			// 
			// _cyber
			// 
			_cyber.AutoSize = true;
			_cyber.Location = new Point(45, 178);
			_cyber.Name = "_cyber";
			_cyber.Size = new Size(71, 24);
			_cyber.TabIndex = 3;
			_cyber.TabStop = true;
			_cyber.Text = "Cyber";
			_cyber.UseVisualStyleBackColor = true;
			// 
			// _cs
			// 
			_cs.AutoSize = true;
			_cs.Location = new Point(45, 137);
			_cs.Name = "_cs";
			_cs.Size = new Size(48, 24);
			_cs.TabIndex = 2;
			_cs.TabStop = true;
			_cs.Text = "CS";
			_cs.UseVisualStyleBackColor = true;
			// 
			// _ai
			// 
			_ai.AutoSize = true;
			_ai.Location = new Point(45, 94);
			_ai.Name = "_ai";
			_ai.Size = new Size(46, 24);
			_ai.TabIndex = 1;
			_ai.TabStop = true;
			_ai.Text = "AI";
			_ai.UseVisualStyleBackColor = true;
			// 
			// _se
			// 
			_se.AutoSize = true;
			_se.Location = new Point(45, 52);
			_se.Name = "_se";
			_se.Size = new Size(46, 24);
			_se.TabIndex = 0;
			_se.TabStop = true;
			_se.Text = "SE";
			_se.UseVisualStyleBackColor = true;
			// 
			// _lang
			// 
			_lang.Controls.Add(_cSharp);
			_lang.Controls.Add(_java);
			_lang.Controls.Add(_c);
			_lang.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			_lang.Location = new Point(76, 462);
			_lang.Name = "_lang";
			_lang.Size = new Size(227, 224);
			_lang.TabIndex = 5;
			_lang.TabStop = false;
			_lang.Text = "choose a language";
			_lang.Enter += _lang_Enter;
			// 
			// _cSharp
			// 
			_cSharp.AutoSize = true;
			_cSharp.Location = new Point(45, 143);
			_cSharp.Name = "_cSharp";
			_cSharp.Size = new Size(49, 24);
			_cSharp.TabIndex = 2;
			_cSharp.Text = "C#";
			_cSharp.UseVisualStyleBackColor = true;
			// 
			// _java
			// 
			_java.AutoSize = true;
			_java.Location = new Point(45, 98);
			_java.Name = "_java";
			_java.Size = new Size(68, 24);
			_java.TabIndex = 1;
			_java.Text = "JAVA";
			_java.UseVisualStyleBackColor = true;
			// 
			// _c
			// 
			_c.AutoSize = true;
			_c.Location = new Point(45, 57);
			_c.Name = "_c";
			_c.Size = new Size(62, 24);
			_c.TabIndex = 0;
			_c.Text = "C++";
			_c.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.BackColor = Color.Yellow;
			button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.Location = new Point(654, 491);
			button1.Name = "button1";
			button1.Size = new Size(111, 44);
			button1.TabIndex = 6;
			button1.Text = "Close";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(128, 128, 255);
			button2.Location = new Point(471, 492);
			button2.Name = "button2";
			button2.Size = new Size(102, 36);
			button2.TabIndex = 7;
			button2.Text = "Add";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.Firebrick;
			button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button3.ForeColor = SystemColors.ActiveCaptionText;
			button3.Location = new Point(852, 489);
			button3.Name = "button3";
			button3.Size = new Size(103, 39);
			button3.TabIndex = 8;
			button3.Text = "Clear";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// student_info_list
			// 
			student_info_list.DrawMode = DrawMode.OwnerDrawFixed;
			student_info_list.FormattingEnabled = true;
			student_info_list.Location = new Point(687, 115);
			student_info_list.Name = "student_info_list";
			student_info_list.Size = new Size(282, 204);
			student_info_list.TabIndex = 9;
			student_info_list.SelectedIndexChanged += student_info_list_SelectedIndexChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1152, 744);
			Controls.Add(student_info_list);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(_lang);
			Controls.Add(_major);
			Controls.Add(ID_no);
			Controls.Add(textBox2);
			Controls.Add(first_name);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			_major.ResumeLayout(false);
			_major.PerformLayout();
			_lang.ResumeLayout(false);
			_lang.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label first_name;
		private TextBox textBox2;
		private Label ID_no;
		private GroupBox _major;
		private RadioButton _cs;
		private RadioButton _ai;
		private RadioButton _se;
		private GroupBox _lang;
		private CheckBox _cSharp;
		private CheckBox _java;
		private CheckBox _c;
		private Button button1;
		private Button button2;
		private Button button3;
		private ListBox student_info_list;
		private RadioButton _cyber;
	}
}
