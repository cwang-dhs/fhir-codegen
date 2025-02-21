// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Value Set of codes that specify additional clinical information about the patient or specimen to report the supporting and/or suspected diagnosis and clinical findings on requests for interpreted diagnostic studies.
  /// </summary>
  public static class V20916Codes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PatientWasFastingPriorToTheProcedure = new Coding
    {
      Code = "F",
      Display = "Patient was fasting prior to the procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FastingNotAskedOfThePatientAtTimeOfProcedure = new Coding
    {
      Code = "FNA",
      Display = "Fasting not asked of the patient at time of procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding ThePatientIndicatedTheyDidNotFastPriorToTheProcedure = new Coding
    {
      Code = "NF",
      Display = "The patient indicated they did not fast prior to the procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding NotGivenPatientWasNotAskedAtTheTimeOfTheProcedure = new Coding
    {
      Code = "NG",
      Display = "Not Given - Patient was not asked at the time of the procedure.",
      System = "http://terminology.hl7.org/CodeSystem/v2-0916"
    };
  };
}
