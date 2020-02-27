using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigthPuzzleWithAStarAlgorithm
{
    public partial class Form1 : Form
    {
        Button nextButton;
        List<int[]> states;
        enum Move
        {
            Left,
            Right,
            Down,
            Up
        }
        Move moveRotate;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] goalState = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 0 };
            int[] initialState = new int[] { 0, 3, 7, 1, 2, 8, 4, 5, 6 };

            //TODO A* algoritmasina gore donguye koy. Acik ve kapali liste kavramlarini iyice anlamaya calis. 

            Label lbl;
            var stepManager = new StepManager(initialState, goalState);
            states = stepManager.SolveProblem();

            foreach (var item in states)
            {
                lbl = new Label() { AutoSize = true };
                flowLayoutPanel1.Controls.Add(lbl);
                ShowStep(item, lbl);
            }
            if (stepManager.IsSucceed) MessageBox.Show("Bulmaca cozuldu!!");
            else MessageBox.Show("Yol bulunamadi.");

            ShowStep(goalState, label1);

            var firstState = states.FirstOrDefault();
            foreach (Button item in panel1.Controls)
                item.Location = GetLocation(firstState.ToList().FindIndex(num => num == int.Parse(item.Text)));
        }

        void ShowStep(int[] state, Label label)
        {
            label.Text = "";
            for (int i = 0; i < state.Length; i++)
            {
                if (state[i] == 0) label.Text += "█";
                else label.Text += state[i] + " ";
                if ((i + 1) % 3 == 0) label.Text += "\n";
            }
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < states.Count(); i++)
            {
                var firstState = states[i - 1];
                var currentState = states[i];
                var blankIndex = firstState.ToList().FindIndex(num => num == 0);
                int nextIndex = 0;
                for (int j = 0; j < firstState.Length; j++)
                    if (firstState[j] != currentState[j] && j != blankIndex) nextIndex = j;

                nextButton = GetButtonByLocation(GetLocation(nextIndex));

                if (nextIndex > blankIndex)
                    if (nextIndex == blankIndex + 1)
                        moveRotate = Move.Left;
                    else moveRotate = Move.Up;
                else
                    if (nextIndex == blankIndex - 1)
                    moveRotate = Move.Right;
                else moveRotate = Move.Down;
                tickCount = 35;
                tmrAnimation.Start();
                var a = 2;
            }

        }
        Button GetButtonByLocation(Point location)
        {
            foreach (Button item in panel1.Controls)
                if (item.Location == location) return item;
            return btn0;
        }
        Point GetLocation(int index)
        {
            if (index < 3) return new Point(index * 35, 0);
            else if (index < 6) return new Point(index % 3 * 35, 35);
            else return new Point(index % 3 * 35, 70);
        }
        int tickCount;
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            ChangeLocation();
            if (tickCount == 0) tmrAnimation.Stop();
        }
        void ChangeLocation()
        {
            tickCount--;
            switch (moveRotate)
            {
                case Move.Left:
                    nextButton.Location = new Point(nextButton.Location.X - 1, nextButton.Location.Y);
                    break;
                case Move.Right:
                    nextButton.Location = new Point(nextButton.Location.X + 1, nextButton.Location.Y);
                    break;
                case Move.Down:
                    nextButton.Location = new Point(nextButton.Location.X, nextButton.Location.Y + 1);
                    break;
                case Move.Up:
                    nextButton.Location = new Point(nextButton.Location.X, nextButton.Location.Y - 1);
                    break;
                default:
                    break;
            }
        }
    }
}
