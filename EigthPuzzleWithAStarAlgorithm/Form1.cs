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
            int[] initialState = new int[] { 1, 2, 3, 4, 5, 6, 0, 7, 8 };

            var rootStep = new Step(state: initialState, goalState: goalState, 0);
            var closedSteps = new List<Step> { rootStep };
            var openedSteps = new List<Step>();
            //TODO A* algoritmasina gore donguye koy. Acik ve kapali liste kavramlarini iyice anlamaya calis. 

            var lbl = new Label() { AutoSize = true };
            flowLayoutPanel1.Controls.Add(lbl);
            ShowStep(initialState, lbl);

            while (!rootStep.IsFinished || !rootStep.IsSucceed)
            {

                openedSteps.AddRange(rootStep.NextSteps);
                var currentStep = openedSteps.Find()
                ClosedSteps.Add(currentStep);
                lbl = new Label() { AutoSize = true };
                flowLayoutPanel1.Controls.Add(lbl);
                ShowStep(rootStep.State, lbl);
            }
            if (rootStep.IsSucceed) MessageBox.Show("Bulmaca cozuldu!!");
            else MessageBox.Show("Yol bulunamadi.");

            ShowStep(goalState, label1);
        }

        Step FindNextStepByLessFScore()
        {
            
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
