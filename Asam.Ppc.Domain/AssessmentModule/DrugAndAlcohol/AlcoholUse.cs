using Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol.Lookups;
using Asam.Ppc.Domain.CommonModule.Lookups;
using Asam.Ppc.Domain.CommonModule.ValueObjects;
using Asam.Ppc.Primitives;

namespace Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol
{
    /// <summary>
    /// Alcohol Use
    /// </summary>
    public class AlcoholUse : RevisionBase, ISubstanceUse
    {
        #region Constructors and Destructors

        protected internal AlcoholUse()
        {
        }
        
        #endregion

        #region public Properties

        public virtual bool? HasStrongUrges { get; protected set; }

        public virtual AlcoholRouteOfIntake AlcoholRouteOfIntake { get; protected set; }

        public virtual AlcoholRouteOfIntake AlcoholToIntoxicationRouteOfIntake { get; protected set; }

        public virtual bool? AlcoholUsedToIntoxication { get; protected set; }

        public virtual Money AmountOfMoneySpentInLast30Days { get; protected set; }
        public virtual bool? HasHealthCareProviderPrescribedUse { get; protected set; }
        public virtual LikertScale ImportanceOfTreatmentForSubstanceProblems { get; protected set; }
        public virtual TimeMeasure LastUsedToIntoxification { get; protected set; }

        public virtual uint? NumberOfDaysIntoxicatedInPast30Days { get; protected set; }
        public virtual uint? NumberOfDaysWithSubstanceProblemsInLast30Days { get; protected set; }

        public virtual uint? NumberOfMonthsAsAlcoholConsumerToIntoxication { get; protected set; }
        public virtual uint? NumberOfTimesWithdrawalCausedDeliriumTremens { get; protected set; }

        public virtual uint? NumberOfTimesWithdrawalCausedSeizures { get; protected set; }
        public virtual LikertScale TroubledInLast30DaysBySubstanceProblems { get; protected set; }
        public virtual SubstanceTakenAsPrescribed WasSubstanceTakenAsPrescribed { get; protected set; }

        public virtual bool? ExperiencesWithdrawalSickness { get; protected set; }

        public virtual bool? FrequentlyHighAtHome { get; protected set; }

        public virtual bool? FrequentlyHighAtSchool { get; protected set; }

        public virtual bool? FrequentlyHighAtWork { get; protected set; }

        public virtual bool? FrequentlyHighInDangerousSituations { get; protected set; }

        public virtual bool? HasUsedSubstanceKnowingProblemsWorsened { get; protected set; }

        public virtual bool? IncreasedDoseRequiredToGetSameEffect { get; protected set; }

        public virtual TimeMeasure LastUsed { get; protected set; }

        public virtual uint? NumberOfDaysUsedInPast30Days { get; protected set; }

        public virtual uint? NumberOfMonthsUsedInLifetime { get; protected set; }

        public virtual bool? SubstanceUseRecurrentProblemsWithEmotions { get; protected set; }

        public virtual bool? SubstanceUseRecurrentProblemsWithFamilyFriends { get; protected set; }

        public virtual bool? SubstanceUseRecurrentProblemsWithHealth { get; protected set; }

        public virtual bool? SubstanceUseRecurrentProblemsWithJob { get; protected set; }

        public virtual bool? SubstanceUseRecurrentProblemsWithLegalSystem { get; protected set; }

        public virtual bool? SubstanceUseReductionAttempted { get; protected set; }

        public virtual bool? SubstanceUseReductionInOccupationalActivities { get; protected set; }

        public virtual bool? SubstanceUseReductionInRecreationalActivities { get; protected set; }

        public virtual bool? SubstanceUseReductionInSocialActivities { get; protected set; }

        public virtual bool? UnableToStopUsingSubstance { get; protected set; }

        public virtual bool? UseOfSubstanceTakesUpALotOfTime { get; protected set; }

        public virtual bool? UseSubstanceToPreventWithdrawalSickness { get; protected set; }

        #endregion
    }
}