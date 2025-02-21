// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set defines a set of codes that are used to indicate the profile type of a test system when acting as the origin within a TestScript.
  /// </summary>
  public static class TestscriptProfileOriginTypesCodes
  {
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FHIRClient = new Coding
    {
      Code = "FHIR-Client",
      Display = "FHIR Client",
      System = "http://terminology.hl7.org/CodeSystem/testscript-profile-origin-types"
    };
    /// <summary>
    /// 
    /// </summary>
    public static readonly Coding FHIRSDCFormFiller = new Coding
    {
      Code = "FHIR-SDC-FormFiller",
      Display = "FHIR SDC FormFiller",
      System = "http://terminology.hl7.org/CodeSystem/testscript-profile-origin-types"
    };
  };
}
