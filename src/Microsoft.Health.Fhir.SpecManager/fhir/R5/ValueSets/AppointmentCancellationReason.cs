// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This example value set defines a set of reasons for the cancellation of an appointment.
  /// </summary>
  public static class AppointmentCancellationReasonCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EquipmentMaintenanceRepair = new Coding
    {
      Code = "maint",
      Display = "Equipment Maintenance/Repair",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrepMedIncomplete = new Coding
    {
      Code = "meds-inc",
      Display = "Prep/Med Incomplete",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherCMSTherapyCapServiceNotAuthorized = new Coding
    {
      Code = "oth-cms",
      Display = "Other: CMS Therapy Cap Service Not Authorized",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Other = new Coding
    {
      Code = "other",
      Display = "Other",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherError = new Coding
    {
      Code = "oth-err",
      Display = "Other: Error",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherFinancial = new Coding
    {
      Code = "oth-fin",
      Display = "Other: Financial",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherNoInterpreterAvailable = new Coding
    {
      Code = "oth-int",
      Display = "Other: No Interpreter Available",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherImproperIVAccessInfiltrateIV = new Coding
    {
      Code = "oth-iv",
      Display = "Other: Improper IV Access/Infiltrate IV",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherPrepMedResultsUnavailable = new Coding
    {
      Code = "oth-mu",
      Display = "Other: Prep/Med/Results Unavailable",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherScheduleOrderError = new Coding
    {
      Code = "oth-oerr",
      Display = "Other: Schedule Order Error",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherRoomResourceMaintenance = new Coding
    {
      Code = "oth-room",
      Display = "Other: Room/Resource Maintenance",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherSilentWalkInError = new Coding
    {
      Code = "oth-swie",
      Display = "Other: Silent Walk In Error",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding OtherWeather = new Coding
    {
      Code = "oth-weath",
      Display = "Other: Weather",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "pat",
      Display = "Patient",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientCanceledViaPatientPortal = new Coding
    {
      Code = "pat-cpp",
      Display = "Patient: Canceled via Patient Portal",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientCanceledViaAutomatedReminderSystem = new Coding
    {
      Code = "pat-crs",
      Display = "Patient: Canceled via automated reminder system",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientDeceased = new Coding
    {
      Code = "pat-dec",
      Display = "Patient: Deceased",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientFeelingBetter = new Coding
    {
      Code = "pat-fb",
      Display = "Patient: Feeling Better",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientLackOfTransportation = new Coding
    {
      Code = "pat-lt",
      Display = "Patient: Lack of Transportation",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientMemberTerminated = new Coding
    {
      Code = "pat-mt",
      Display = "Patient: Member Terminated",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientMoved = new Coding
    {
      Code = "pat-mv",
      Display = "Patient: Moved",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientPregnant = new Coding
    {
      Code = "pat-preg",
      Display = "Patient: Pregnant",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientScheduledFromWaitList = new Coding
    {
      Code = "pat-swl",
      Display = "Patient: Scheduled from Wait List",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientUnhappyChangedProvider = new Coding
    {
      Code = "pat-ucp",
      Display = "Patient: Unhappy/Changed Provider",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Provider = new Coding
    {
      Code = "prov",
      Display = "Provider",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderDischarged = new Coding
    {
      Code = "prov-dch",
      Display = "Provider: Discharged",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderEduMeeting = new Coding
    {
      Code = "prov-edu",
      Display = "Provider: Edu/Meeting",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderHospitalized = new Coding
    {
      Code = "prov-hosp",
      Display = "Provider: Hospitalized",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderLabsOutOfAcceptableRange = new Coding
    {
      Code = "prov-labs",
      Display = "Provider: Labs Out of Acceptable Range",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderMRIScreeningFormMarkedDoNotProceed = new Coding
    {
      Code = "prov-mri",
      Display = "Provider: MRI Screening Form Marked Do Not Proceed",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderOncologyTreatmentPlanChanges = new Coding
    {
      Code = "prov-onc",
      Display = "Provider: Oncology Treatment Plan Changes",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ProviderPersonal = new Coding
    {
      Code = "prov-pers",
      Display = "Provider: Personal",
      System = "http://terminology.hl7.org/CodeSystem/appointment-cancellation-reason"
    };
  };
}
