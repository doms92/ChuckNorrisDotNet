using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisWinForm
{
    public partial class ChuckNorrisJokeFrm : Form
    {
        public ChuckNorrisJokeFrm()
        {
            InitializeComponent();
        }

        private async void randomJokeBtn_Click(object sender, EventArgs e)
        {
            Joke joke = await ChuckNorrisClient.GetRandomJoke();
            randomJokeRtx.Text = joke.JokeText;
        }

        private async void ChuckNorrisJokeFrm_Load(object sender, EventArgs e)
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (string category in categories)
            {
                jokeCategoriesCmb.Items.Add(category);
            }
        }
    }
}
