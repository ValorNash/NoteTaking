using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace NoteTaking

{
	public partial class Form1 : Form
	{
		DataTable table;

		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			table = new DataTable();
			table.Columns.Add("Title", typeof(String));
			table.Columns.Add("Messages", typeof(String));

			dataGridView1.DataSource = table;
		}

		private void bttNew_Click(object sender, EventArgs e)
		{
			TxtTitle.Clear();
			txtMessage.Clear();
		}

		private void bttSave_Click(object sender, EventArgs e)
		{
			table.Rows.Add(TxtTitle.Text, txtMessage.Text);

			TxtTitle.Clear();
			txtMessage.Clear();
		}
	}
}