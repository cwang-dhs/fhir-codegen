// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// What the target is validated against
  /// </summary>
  public static class VerificationresultValidationTypeCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding MultipleSources = new Coding
    {
      Code = "multiple",
      Display = "Multiple Sources",
      System = "http://terminology.hl7.org/CodeSystem/validation-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding Nothing = new Coding
    {
      Code = "nothing",
      Display = "Nothing",
      System = "http://terminology.hl7.org/CodeSystem/validation-type"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding PrimarySource = new Coding
    {
      Code = "primary",
      Display = "Primary Source",
      System = "http://terminology.hl7.org/CodeSystem/validation-type"
    };
  };
}
