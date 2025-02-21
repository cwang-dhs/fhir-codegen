// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The possible sort directions, ascending or descending.
  /// </summary>
  public static class SortDirectionCodes
  {
    /// <summary>
    /// Sort by the value ascending, so that lower values appear first.
    /// </summary>
    public static readonly Coding Ascending = new Coding
    {
      Code = "ascending",
      Display = "Ascending",
      System = "http://hl7.org/fhir/sort-direction"
    };
    /// <summary>
    /// Sort by the value descending, so that lower values appear last.
    /// </summary>
    public static readonly Coding Descending = new Coding
    {
      Code = "descending",
      Display = "Descending",
      System = "http://hl7.org/fhir/sort-direction"
    };
  };
}
