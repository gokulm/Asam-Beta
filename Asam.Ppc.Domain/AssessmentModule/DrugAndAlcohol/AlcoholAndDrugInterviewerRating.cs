using Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol.Lookups;
using Asam.Ppc.Primitives;

namespace Asam.Ppc.Domain.AssessmentModule.DrugAndAlcohol
{
    using Pillar.Domain.Attributes;

    /// <summary>
    /// Alcohol and Drug Interviewer Rating
    /// </summary>
    public class AlcoholAndDrugInterviewerRating : RevisionBase
    {
        #region Constructors and Destructors

        protected internal AlcoholAndDrugInterviewerRating()
        {
        }

        #endregion

        #region public  Properties

        /// <summary>
        /// Gets the interviewer comments.
        /// </summary>
        /// <value>
        /// The interviewer comments.
        /// </value>
        [ColumnLength(2000)]
        public virtual string InterviewerComments { get; protected set; }

        /// <summary>
        /// Gets the interviewer score of alcohol treatment need.
        /// </summary>
        /// <value>
        /// The interviewer score of alcohol treatment need.
        /// </value>
        public virtual ScaleOf0To9 InterviewerScoreOfAlcoholTreatmentNeed { get; protected set; }

        /// <summary>
        /// Gets the interviewer score of attitude.
        /// </summary>
        /// <value>
        /// The interviewer score of attitude.
        /// </value>
        public virtual ScaleOf0To9 InterviewerScoreOfAttitude { get; protected set; }

        /// <summary>
        /// Gets the interviewer score of drug treatment need.
        /// </summary>
        /// <value>
        /// The interviewer score of drug treatment need.
        /// </value>
        public virtual ScaleOf0To9 InterviewerScoreOfDrugTreatmentNeed { get; protected set; }

        /// <summary>
        /// Gets the interviewer score of readiness.
        /// </summary>
        /// <value>
        /// The interviewer score of readiness.
        /// </value>
        public virtual ScaleOf0To9 InterviewerScoreOfReadiness { get; protected set; }

        /// <summary>
        /// Gets the is patient experiencing withdrawal signs symptoms.
        /// </summary>
        /// <value>
        /// The is patient experiencing withdrawal signs symptoms.
        /// </value>
        public virtual SignsOfWithdrawal IsPatientExperiencingWithdrawalSignsSymptoms { get; protected set; }

        /// <summary>
        /// Gets the is patient misrepresenting information.
        /// </summary>
        /// <value>
        /// The is patient misrepresenting information.
        /// </value>
        public virtual bool? IsPatientMisrepresentingInformation { get; protected set; }

        /// <summary>
        /// Gets the is patient unable to understand.
        /// </summary>
        /// <value>
        /// The is patient unable to understand.
        /// </value>
        public virtual bool? IsPatientUnableToUnderstand { get; protected set; }

        /// <summary>
        /// Gets the majority of information from collateral source.
        /// </summary>
        /// <value>
        /// The majority of information from collateral source.
        /// </value>
        public virtual bool? MajorityOfInformationFromCollateralSource { get; protected set; }

        /// <summary>
        /// Gets the patient manifesting serious relapse behavior description.
        /// </summary>
        /// <value>
        /// The patient manifesting serious relapse behavior description.
        /// </value>
        public virtual string PatientManifestingSeriousRelapseBehaviorDescription { get; protected set; }

        /// <summary>
        /// Gets the patient manifesting serious relapse behaviors.
        /// </summary>
        /// <value>
        /// The patient manifesting serious relapse behaviors.
        /// </value>
        public virtual bool? PatientManifestingSeriousRelapseBehaviors { get; protected set; }

        #endregion
    }
}