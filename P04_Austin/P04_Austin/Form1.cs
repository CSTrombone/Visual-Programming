using static System.Windows.Forms.LinkLabel;
using System.IO;

namespace P04_Austin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (StreamReader streamReader = new StreamReader("PlayerNamed.txt"))
            {
                string line = "\n";
                while ((line = streamReader.ReadLine()) != null)
                {
                    playersList.Items.Add(line);
                }
            }
        }
        //Save new names form closes
        protected override void OnFormClosing(FormClosingEventArgs e) 
        {
            using (StreamWriter saveNames = File.AppendText("PlayerNamed.txt"))
            {                   
                for (int i = 0; i < appendLstBox.Items.Count; i++)
                {                   
                    saveNames.WriteLine(appendLstBox.Items[i]);
                }
            }
            base.OnFormClosing(e);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && playersList.Text != "")
            {
                playersList.Items.Add(playersList.Text);
                appendLstBox.Items.Add(playersList.Text);
                playersList.Text = "";
            }
        }

        private void team1AddBtn_Click(object sender, EventArgs e)
        {
            if (playersList.SelectedIndex != -1)
            {
                team1LstBox.Items.Add(playersList.Text);
                playersList.Items.Remove(playersList.Text);
                playersList.Text = "";
            }
        }

        private void team2AddBtn_Click(object sender, EventArgs e)
        {
            if (playersList.SelectedIndex != -1)
            {
                team2LstBox.Items.Add(playersList.Text);
                playersList.Items.Remove(playersList.Text);
                playersList.Text = "";
            }
        }

        private void team1RemoveBtn_Click(object sender, EventArgs e)
        {
            if(team1LstBox.SelectedIndex != -1)
            {
                playersList.Items.Add(team1LstBox.Items[team1LstBox.SelectedIndex]);
                team1LstBox.Items.RemoveAt(team1LstBox.SelectedIndex);
            }
        }

        private void team2RemoveBtn_Click(object sender, EventArgs e)
        {
            if (team2LstBox.SelectedIndex != -1)
            {
                playersList.Items.Add(team2LstBox.Items[team2LstBox.SelectedIndex]);
                team2LstBox.Items.RemoveAt(team2LstBox.SelectedIndex);
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < team1LstBox.Items.Count; i++)
            {
                playersList.Items.Add(team1LstBox.Items[i]);
            }
            for (int i = 0; i < team2LstBox.Items.Count; i++)
            {
                playersList.Items.Add(team2LstBox.Items[i]);
            }
            team1LstBox.Items.Clear();
            team2LstBox.Items.Clear();
        }
    }
}
