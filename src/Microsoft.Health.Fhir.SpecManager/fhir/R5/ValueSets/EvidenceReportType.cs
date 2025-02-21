// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The kind of report, such as grouping of classifiers, search results, or human-compiled expression.
  /// </summary>
  public static class EvidenceReportTypeCodes
  {
    /// <summary>
    /// The report is primarily a listing of classifiers about the report subject.
    /// </summary>
    public static readonly Coding Classification = new Coding
    {
      Code = "classification",
      Display = "Classification",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
    /// <summary>
    /// The report is a composition containing one or more FHIR resources in the content.
    /// </summary>
    public static readonly Coding ResourceCompilation = new Coding
    {
      Code = "resources-compiled",
      Display = "Resource Compilation",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
    /// <summary>
    /// The report is a composition of results generated in response to a search query.
    /// </summary>
    public static readonly Coding SearchResults = new Coding
    {
      Code = "search-results",
      Display = "Search Results",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
    /// <summary>
    /// The report is a structured representation of text.
    /// </summary>
    public static readonly Coding StructuredText = new Coding
    {
      Code = "text-structured",
      Display = "Structured Text",
      System = "http://terminology.hl7.org/CodeSystem/evidence-report-type"
    };
  };
}
