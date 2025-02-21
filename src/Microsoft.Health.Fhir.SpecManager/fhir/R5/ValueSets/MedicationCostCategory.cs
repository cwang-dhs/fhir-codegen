// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Medication Cost Category Codes
  /// </summary>
  public static class MedicationCostCategoryCodes
  {
    /// <summary>
    /// Tier A cost for this medication
    /// </summary>
    public static readonly Coding BandA = new Coding
    {
      Code = "banda",
      Display = "Band A",
      System = "http://terminology.hl7.org/CodeSystem/medication-cost-category"
    };
    /// <summary>
    /// Tier B cost for this medication
    /// </summary>
    public static readonly Coding BandB = new Coding
    {
      Code = "bandb",
      Display = "Band B",
      System = "http://terminology.hl7.org/CodeSystem/medication-cost-category"
    };
  };
}
