using Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol.Lookups;
using Asam.Ppc.Domain.CommonModule.Lookups;

namespace Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol
{
    /// <summary>
    /// Addiction Treatment History
    /// </summary>
    public class AddictionTreatmentHistory : RevisionBase
    {
        #region Constructors and Destructors

        protected internal AddictionTreatmentHistory ()
        {
        }
        
        #endregion

        #region public Properties

        /// <summary>
        /// Gets the highest care level failed from in past90 days.
        /// </summary>
        /// <value>
        /// The highest care level failed from in past90 days.
        /// </value>
        public virtual CareLevel HighestCareLevelFailedFromInPast90Days { get; protected set; }

        /// <summary>
        /// Gets the most recent care level completed.
        /// </summary>
        /// <value>
        /// The most recent care level completed.
        /// </value>
        public virtual CareLevel MostRecentCareLevelCompleted { get; protected set; }

        /// <summary>
        /// Gets the number of days outpatient treatment in past30 days.
        /// </summary>
        /// <value>
        /// The number of days outpatient treatment in past30 days.
        /// </value>
        public virtual uint? NumberOfDaysOutpatientTreatmentInPast30Days { get; protected set; }

        /// <summary>
        /// Gets the number of times alcohol treatment detoxification only lifetime.
        /// </summary>
        /// <value>
        /// The number of times alcohol treatment detoxification only lifetime.
        /// </value>
        public virtual uint? NumberOfTimesAlcoholTreatmentDetoxificationOnlyLifetime { get; protected set; }

        /// <summary>
        /// Gets the number of times drug treatment detoxification only lifetime.
        /// </summary>
        /// <value>
        /// The number of times drug treatment detoxification only lifetime.
        /// </value>
        public virtual uint? NumberOfTimesDrugTreatmentDetoxificationOnlyLifetime { get; protected set; }

        /// <summary>
        /// Gets the number of times drug treatment lifetime.
        /// </summary>
        /// <value>
        /// The number of times drug treatment lifetime.
        /// </value>
        public virtual uint? NumberOfTimesDrugTreatmentLifetime { get; protected set; }

        /// <summary>
        /// Gets the number of times treated for alcohol abuse lifetime.
        /// </summary>
        /// <value>
        /// The number of times treated for alcohol abuse lifetime.
        /// </value>
        public virtual uint? NumberOfTimesTreatedForAlcoholAbuseLifetime { get; protected set; }

        /// <summary>
        /// Gets the previous substance use treatment.
        /// </summary>
        /// <value>
        /// The previous substance use treatment.
        /// </value>
        public virtual SubstanceTreatmentType PreviousSubstanceUseTreatment { get; protected set; }

        /// <summary>
        /// Gets the usually entered continued treatment after detoxification.
        /// </summary>
        /// <value>
        /// The usually entered continued treatment after detoxification.
        /// </value>
        public virtual bool? UsuallyEnteredContinuedTreatmentAfterDetoxification { get; protected set; }

        /// <summary>
        /// Gets the usually left detoxification before advised.
        /// </summary>
        /// <value>
        /// The usually left detoxification before advised.
        /// </value>
        public virtual bool? UsuallyLeftDetoxificationBeforeAdvised { get; protected set; }

        #endregion
    }
}