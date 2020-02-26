using System;
using System.Collections.Generic;
using System.Linq;

namespace EigthPuzzleWithAStarAlgorithm
{
    public class Step
    {
        public int StepId { get; private set; } = 1;
        public Step(int[] state, int[] goalState, int gX)
        {
            State = state;
            GoalState = goalState;
            GX = gX;
            CalculateHX();
        }
        void CalculateHX()
        {
            for (int i = 0; i < State.Length; i++)
                if (State[i] != 0 && State[i] != GoalState[i]) HX++;
        }
        int BlankIndex() => Array.FindIndex(State, value => value == 0);
        private int[] GoalState { get; set; }
        public int[] State { get; set; }
        public int GX { get; private set; }
        public int HX { get; private set; }
        public int FX { get => GX + HX; }
        public List<Step> NextSteps { get; private set; } = new List<Step>();
        public Step ParentStep { get; set; }
        public void LoadPossibleNextSteps()
        {
            if (NextSteps.Any()) return;
            var StepId = 0;
            if (CanMoveUp())
                NextSteps.Add(new Step(state: Move(BlankIndex(), BlankIndex() - 3), GoalState, GX + 1) { ParentStep = this, StepId = ++StepId });
            if (CanMoveDown())
                NextSteps.Add(new Step(state: Move(BlankIndex(), BlankIndex() + 3), GoalState, GX + 1) { ParentStep = this, StepId = ++StepId });
            if (CanMoveLeft())
                NextSteps.Add(new Step(state: Move(BlankIndex(), BlankIndex() - 1), GoalState, GX + 1) { ParentStep = this, StepId = ++StepId });
            if (CanMoveRight())
                NextSteps.Add(new Step(state: Move(BlankIndex(), BlankIndex() + 1), GoalState, GX + 1) { ParentStep = this, StepId = ++StepId });
        }
        public Step FindNextStep() => NextSteps.OrderBy(step => step.FX).FirstOrDefault();
        private int[] Move(int selectedIndex, int newIndex)
        {
            int[] newState = (int[])State.Clone();
            newState[selectedIndex] = State[newIndex];
            newState[newIndex] = State[selectedIndex];
            return newState;
        }
        private bool CanMoveUp() => BlankIndex() > 2;
        private bool CanMoveDown() => BlankIndex() < 6;
        private bool CanMoveLeft() => BlankIndex() % 3 != 0;
        private bool CanMoveRight() => BlankIndex() % 3 != 2;
        public bool IsFinished { get => !NextSteps.Any(); }
        public bool IsSucceed { get => HX == 0; }
        public bool CompareState(int[] state)
        {
            for (int i = 0; i < State.Length; i++)
                if (state[i] != State[i]) return false;
            return true;
        }
    }
}
