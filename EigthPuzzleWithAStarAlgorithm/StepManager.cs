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
        Step currentStep;

        public StepManager(int[] _initialState, int[] _goalState)
        {
            initialState = _initialState;
            goalState = _goalState;
        }
        public List<int[]> SolveProblem()
        {
            var rootStep = new Step(state: initialState, goalState: goalState, 0);
            openedSteps.Add(rootStep);
            currentStep = rootStep;
            while (openedSteps.Any() && (!currentStep.IsFinished || !currentStep.IsSucceed))
            {
                DeleteStepFromOpenedListAddToClosedList(currentStep);
                currentStep = FindBestNextStep()??currentStep;//Null donerse artik acik listede step kalmamistir dolayisiyla bir daha donguye giremeyecek. Dolayisiyla currentStep yine kullanilacagindan null a esitleme
            }
            if (currentStep.IsSucceed)
            {
                var tempStep = currentStep;
                while (tempStep!=null)
                {
                    AllStates.Add(tempStep.State);
                    tempStep = tempStep.ParentStep;
                }
            }     
            IsSucceed = currentStep.IsSucceed;
            return AllStates;
        }
        Step FindBestNextStep()
        {
            currentStep.LoadPossibleNextSteps();
            var validNextSteps = currentStep.NextSteps.Where(nextStep =>
            !closedSteps.Where(closedStep=>closedStep.CompareState(nextStep.State)).Any()); //Sonraki adimlar kapali listede olabilir onlari filtreleyerek openListe sonraki adimlari ekle

            openedSteps.AddRange(validNextSteps.Where(step=>!openedSteps.Where(stp=>step.CompareState(stp.State)).Any()));
            return openedSteps.OrderBy(step => step.FX).FirstOrDefault(); //FX=HX+GX degeri en az olani gonder
        }

        void DeleteStepFromOpenedListAddToClosedList(Step step)
        {
            var willBeDeletedStep = openedSteps.Where(stp =>
            stp.GX == step.GX &&
            stp.StepId == step.StepId)
                .FirstOrDefault();
            closedSteps.Add(willBeDeletedStep);
            openedSteps.Remove(willBeDeletedStep);
        }
    }
}
