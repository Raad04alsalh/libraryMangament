namespace MidTerm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			student_info_list.Items.Clear();
			textBox1.Focus();
		}
		
		private void button2_Click(object sender, EventArgs e)
		{
			student_info_list.Items.Add(textBox1.Text);
			student_info_list.Items.Add(textBox2.Text);
			if (_se.Checked == true) { student_info_list.Items.Add("SE"); }
			if (_ai.Checked == true) { student_info_list.Items.Add("AI"); }
			if (_cs.Checked == true) { student_info_list.Items.Add("CS"); }
			if (_cyber.Checked == true) { student_info_list.Items.Add("Cyber"); }
			if(_c.Checked == true) { student_info_list.Items.Add("C++"); }
			if (_java.Checked == true) { student_info_list.Items.Add("Java"); }
			if (_cSharp.Checked == true) { student_info_list.Items.Add("C#"); }
		}

		private void student_info_list_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void _lang_Enter(object sender, EventArgs e)
		{

		}
	}
}
