// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Evidence focus characteristic code.
  /// </summary>
  public static class FocusCharacteristicCodeCodes
  {
    /// <summary>
    /// Used to reference a specific article.
    /// </summary>
    public static readonly Coding Citation = new Coding
    {
      Code = "citation",
      Display = "Citation",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// Used to denote a focus on clinical outcomes, ie evidence variable in role of outcome (measured variable) as observed is considered a "clinical outcome" (patient-important outcome such as mortality, symptoms, function or quality of life).
    /// </summary>
    public static readonly Coding ObservedOutcomesAreClinicalOutcomes = new Coding
    {
      Code = "clinical-outcomes-observed",
      Display = "Observed outcomes are clinical outcomes",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// The comparator (intervention or control state) of interest.
    /// </summary>
    public static readonly Coding Comparator = new Coding
    {
      Code = "comparator",
      Display = "Comparator",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// The exposure of interest, such as an intervention.
    /// </summary>
    public static readonly Coding Exposure = new Coding
    {
      Code = "exposure",
      Display = "Exposure",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// Any medication exposures. A subset of exposures or interventions that are medications.
    /// </summary>
    public static readonly Coding MedicationExposures = new Coding
    {
      Code = "medication-exposures",
      Display = "Medication exposures",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// the outcome of interest.
    /// </summary>
    public static readonly Coding Outcome = new Coding
    {
      Code = "outcome",
      Display = "Outcome",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// The population of interest.
    /// </summary>
    public static readonly Coding Population = new Coding
    {
      Code = "population",
      Display = "Population",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
    /// <summary>
    /// Type of research study, such as randomized trial or case-control study.
    /// </summary>
    public static readonly Coding StudyType = new Coding
    {
      Code = "study-type",
      Display = "Study type",
      System = "http://terminology.hl7.org/CodeSystem/focus-characteristic-code"
    };
  };
}
