// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Benefit Term codes.
  /// </summary>
  public static class BenefitTermCodes
  {
    /// <summary>
    /// Annual, renewing on the anniversary
    /// </summary>
    public static readonly Coding Annual = new Coding
    {
      Code = "annual",
      Display = "Annual",
      System = "http://terminology.hl7.org/CodeSystem/benefit-term"
    };
    /// <summary>
    /// Per day
    /// </summary>
    public static readonly Coding Day = new Coding
    {
      Code = "day",
      Display = "Day",
      System = "http://terminology.hl7.org/CodeSystem/benefit-term"
    };
    /// <summary>
    /// For the total term, lifetime, of the policy or coverage
    /// </summary>
    public static readonly Coding Lifetime = new Coding
    {
      Code = "lifetime",
      Display = "Lifetime",
      System = "http://terminology.hl7.org/CodeSystem/benefit-term"
    };
  };
}
