using System.Data;

namespace Digital_Golf_Scorecard
{
    public partial class Form1 : Form
    {
        DataTable gameList = new DataTable();
        bool isGameListEditing = false;
        int courseNameIndex = 0;
        int dateIndex = 1;
        int courseNameWidth = 207;
        int dateWidth = 100;
        int holeWidth = 35;
        int[] scores = new int[18];
        public Form1()
        {
            InitializeComponent();
            // Create columns
            gameList.Columns.Add("Course");
            gameList.Columns.Add("Date");
            for(int i = 1; i <= 18; i++)
            {
                gameList.Columns.Add(i.ToString());
            }

            // Point our datagridview to our datasource
            roundList.DataSource = gameList;

            // Set width of column to fit the UI
            roundList.Columns[courseNameIndex].Width = courseNameWidth;
            roundList.Columns[dateIndex].Width = dateWidth;
            for (int i = 2; i <= 19; i++)
            {
                roundList.Columns[i].Width = holeWidth;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                gameList.Rows[roundList.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Again this is terrible DO NOT TRY THIS AT HOME
            if (isGameListEditing)
            {
                gameList.Rows[roundList.CurrentCell.RowIndex]["Course"] = courseNameText.Text;
                gameList.Rows[roundList.CurrentCell.RowIndex]["Date"] = dateText.Text;
            }
            else
            {
                gameList.Rows.Add(courseNameText.Text, dateText.Text);
            } 
            // Clear fields
            courseNameText.Text = "";
            dateText.Text = "";
            isGameListEditing = false;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            courseNameText.Text = "";
            dateText.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isGameListEditing = true;
            courseNameText.Text = gameList.Rows[roundList.CurrentCell.RowIndex].ItemArray[0].ToString();
            dateText.Text = gameList.Rows[roundList.CurrentCell.RowIndex].ItemArray[1].ToString();
        }
    }
}
