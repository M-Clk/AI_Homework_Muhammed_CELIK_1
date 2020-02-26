using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EigthPuzzleWithAStarAlgorithm
{
    public class StepManager
    {
        List<Step> closedSteps = new List<Step>();
        List<Step> openedSteps = new List<Step>();
        int[] goalState;
        int[] initialState;
        List<int[]> AllStates = new List<int[]>();
        public bool IsSucceed { get; private set; }

        public StepManager(int[] _initialState, int[] _goalState)
        {
            initialState = _initialState;
            goalState = _goalState;
        }
        public List<int[]> SolveProblem()
        {
            var rootStep = new Step(state: initialState, goalState: goalState, 0);
            openedSteps.Add(rootStep);
            var currentStep = FindBestNextStep();
            while (!currentStep.IsFinished || !currentStep.IsSucceed)
            {
                DeleteStepFromOpenedListAddToClosedList(currentStep);
                AllStates.Add(currentStep.State);
                openedSteps.AddRange(currentStep.NextSteps);
                currentStep = FindBestNextStep();
            }
            IsSucceed = currentStep.IsSucceed;
            return AllStates;
        }
        Step FindBestNextStep()=>
            openedSteps.OrderBy(step => step.FX).FirstOrDefault();
        void DeleteStepFromOpenedListAddToClosedList(Step step)
        {
            var willBeDeletedStep = openedSteps.Where(stp =>
            stp.GX == step.GX &&
            stp.StepId == step.StepId)
                .FirstOrDefault();
            closedSteps.Add(willBeDeletedStep);
            openedSteps.Remove(willBeDeletedStep);
        }
        void AddStepsToOpenedList(List<Step> steps)
        {
            
        }
    }
}
