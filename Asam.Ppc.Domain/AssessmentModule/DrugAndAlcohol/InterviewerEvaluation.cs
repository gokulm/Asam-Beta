using Pillar.Domain;

namespace Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol
{
    public class InterviewerEvaluation : RevisionBase
    {
        #region Constructors and Destructors

        protected internal InterviewerEvaluation()
        {
        }

        #endregion

        #region public  Properties

        public virtual bool? HasMaintainedBarbituatesDoseAtTherapeuticLevels { get; protected set; }

        public virtual bool? HasMaintainedMethadoneDoseAtTherapeuticLevels { get; protected set; }

        public virtual bool? HasMaintainedNicotineDoseAtTherapeuticLevels { get; protected set; }

        public virtual bool? HasMaintainedOtherDrugDoseAtTherapeuticLevels { get; protected set; }

        public virtual bool? HasMaintainedOtherOpiatesDoseAtTherapeuticLevels { get; protected set; }

        public virtual bool? HasMaintainedSedativeDoseAtTherapeuticLevels { get; protected set; }

        public virtual bool? HasMaintainedStimulantDoseAtTherapeuticLevels { get; protected set; }

        #endregion
    }
}