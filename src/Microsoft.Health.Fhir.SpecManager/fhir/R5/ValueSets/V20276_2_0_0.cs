// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Value Set of codes that describe the kind of appointment or the reason why an appointment has been scheduled.
  /// </summary>
  public static class V20276Codes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ARoutineCheckUpSuchAsAnAnnualPhysical = new Coding
    {
      Code = "CHECKUP",
      Display = "A routine check-up, such as an annual physical",
      System = "http://terminology.hl7.org/CodeSystem/v2-0276"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding EmergencyAppointment = new Coding
    {
      Code = "EMERGENCY",
      Display = "Emergency appointment",
      System = "http://terminology.hl7.org/CodeSystem/v2-0276"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding AFollowUpVisitFromAPreviousAppointment = new Coding
    {
      Code = "FOLLOWUP",
      Display = "A follow up visit from a previous appointment",
      System = "http://terminology.hl7.org/CodeSystem/v2-0276"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding RoutineAppointmentDefaultIfNotValued = new Coding
    {
      Code = "ROUTINE",
      Display = "Routine appointment - default if not valued",
      System = "http://terminology.hl7.org/CodeSystem/v2-0276"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding APreviouslyUnscheduledWalkInVisit = new Coding
    {
      Code = "WALKIN",
      Display = "A previously unscheduled walk-in visit",
      System = "http://terminology.hl7.org/CodeSystem/v2-0276"
    };
  };
}
