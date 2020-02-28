using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EigthPuzzleWithAStarAlgorithm
{
    public partial class Form1 : Form
    {
        Button nextButton;
        List<int[]> states;
        int tickCount;
        int statesIndex;
        int plusX;
        int plusY;
        int[] goalState;
        int[] initialState;
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<Button> SetIndexOfButtonsByLocation(Panel panel)
        {
            List<Button> buttons = new List<Button>();
            foreach (Button item in panel.Controls)
            {
                if (item.Location.Y == 0)
                    item.Tag = item.Location.X / 35;
                else if (item.Location.Y == 35)
                    item.Tag = item.Location.X / 35 + 3;
                else
                    item.Tag = item.Location.X / 35 + 6;
                buttons.Add(item);
            }
            return buttons;
        }
        void SetLocationToInitialState()
        {
            var firstState = states.FirstOrDefault();
            foreach (Button item in panel1.Controls)
                item.Location = GetLocationByIndex(firstState.ToList().FindIndex(num => num == int.Parse(item.Text)));
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
            label.Text += "______";
        }

        private void btnCoz_Click(object sender, EventArgs e)
        {
            goalState = new int[9];
            initialState = new int[9];
            flowLayoutPanel1.Controls.Clear();

            SetIndexOfButtonsByLocation(panel1).OrderBy(btn =>
            (int)btn.Tag).ToList().ForEach(btn =>
            initialState[(int)btn.Tag] = int.Parse(btn.Text));

            SetIndexOfButtonsByLocation(panel2).OrderBy(btn =>
            (int)btn.Tag).ToList().ForEach(btn =>
            goalState[(int)btn.Tag] = int.Parse(btn.Text));

            Label lbl;
            var stepManager = new StepManager(initialState, goalState);
            states = stepManager.SolveProblem();

            foreach (var item in states)
            {
                lbl = new Label() { AutoSize = true };
                flowLayoutPanel1.Controls.Add(lbl);
                ShowStep(item, lbl);
            }
            if (stepManager.IsSucceed)
            {
                MessageBox.Show("Bulmaca cozuldu! Adimlar teker teker uygulanacak.");
                statesIndex = 1;
                tmrAnimation.Start();
            }
            else
            {
                MessageBox.Show("Yol bulunamadi.");
            }
            btnCoz.Enabled = false;

        }
        Button GetButtonByLocation(Point location, Panel pnl)
        {
            foreach (Button item in pnl.Controls)
                if (item.Location == location) return item;
            return null;
        }
        Point GetLocationByIndex(int index)
        {
            if (index < 3) return new Point(index * 35, 0);
            else if (index < 6) return new Point(index % 3 * 35, 35);
            else return new Point(index % 3 * 35, 70);
        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            if (tickCount > 0)
                ChangeLocationWithAutomation();
            else if (statesIndex == states.Count())
            {
                tmrAnimation.Stop();
                btnCoz.Enabled = true;
            }
            else ChangeNextState();
        }
        void ChangeNextState()
        {
            var firstState = states[statesIndex - 1];
            var currentState = states[statesIndex];
            var blankIndex = firstState.ToList().FindIndex(num => num == 0);
            int nextIndex = 0;
            for (int j = 0; j < firstState.Length; j++)
                if (firstState[j] != currentState[j] && j != blankIndex) nextIndex = j;

            nextButton = GetButtonByLocation(GetLocationByIndex(nextIndex), (Panel)panel1);

            if (nextIndex > blankIndex)
                if (nextIndex == blankIndex + 1)
                {
                    plusX = -1;
                    plusY = 0;
                }
                else
                {
                    plusX = 0;
                    plusY = -1;
                }

            else
                if (nextIndex == blankIndex - 1)
            {
                plusX = 1;
                plusY = 0;
            }
            else
            {
                plusX = 0;
                plusY = 1;
            }
            tickCount = 35;
            statesIndex++;
        }
        void ChangeLocationWithAutomation()
        {
            tickCount--;
            nextButton.Location = new Point(nextButton.Location.X + plusX, nextButton.Location.Y + plusY);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (!btnCoz.Enabled) return;
            var btn = (Button)sender;
            if (GetButtonByLocation(new Point(btn.Location.X + 35, btn.Location.Y), (Panel)btn.Parent) == null && btn.Location.X != 70)
                btn.Location = new Point(btn.Location.X + 35, btn.Location.Y);
            else if (GetButtonByLocation(new Point(btn.Location.X - 35, btn.Location.Y), (Panel)btn.Parent) == null && btn.Location.X != 0)
                btn.Location = new Point(btn.Location.X - 35, btn.Location.Y);
            else if (GetButtonByLocation(new Point(btn.Location.X, btn.Location.Y + 35), (Panel)btn.Parent) == null && btn.Location.Y != 70)
                btn.Location = new Point(btn.Location.X, btn.Location.Y + 35);
            else if (GetButtonByLocation(new Point(btn.Location.X, btn.Location.Y - 35), (Panel)btn.Parent) == null && btn.Location.Y != 0)
                btn.Location = new Point(btn.Location.X, btn.Location.Y - 35);
            btnCoz.Enabled = true;

        }
    }
}
