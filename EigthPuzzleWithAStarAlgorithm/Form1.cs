using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigthPuzzleWithAStarAlgorithm
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] goalState = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            int[] initialState = new int[] { 1, 4, 3, 2, 5, 6, 0, 7, 8 };

            //TODO A* algoritmasina gore donguye koy. Acik ve kapali liste kavramlarini iyice anlamaya calis. 

            Label lbl;
            var stepManager = new StepManager(initialState, goalState);
            List<int[]> states = stepManager.SolveProblem();

            foreach (var item in states)
            {
                lbl = new Label() { AutoSize = true };
                flowLayoutPanel1.Controls.Add(lbl);
                ShowStep(item, lbl);
            }
            if (stepManager.IsSucceed) MessageBox.Show("Bulmaca cozuldu!!");
            else MessageBox.Show("Yol bulunamadi.");

            ShowStep(goalState, label1);
        }

        void ShowStep(int[] state, Label label)
        {
            label.Text = "";
            for (int i = 0; i < state.Length; i++)
            {
                if (state[i] == 0) label.Text += "□";
                else label.Text += state[i] + " ";
                if ((i + 1) % 3 == 0) label.Text += "\n";
            }
        }
    }
}
