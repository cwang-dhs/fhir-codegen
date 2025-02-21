// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Adjudication Value codes which includes codes to indicate the amounts eligible under the plan, the amount of benefit, copays etc.
  /// </summary>
  public static class AdjudicationCodes
  {
    /// <summary>
    /// Amount payable under the coverage
    /// </summary>
    public static readonly Coding BenefitAmount = new Coding
    {
      Code = "benefit",
      Display = "Benefit Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Patient Co-Payment
    /// </summary>
    public static readonly Coding CoPay = new Coding
    {
      Code = "copay",
      Display = "CoPay",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Amount deducted from the eligible amount prior to adjudication.
    /// </summary>
    public static readonly Coding Deductible = new Coding
    {
      Code = "deductible",
      Display = "Deductible",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Amount of the change which is considered for adjudication.
    /// </summary>
    public static readonly Coding EligibleAmount = new Coding
    {
      Code = "eligible",
      Display = "Eligible Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// Eligible Percentage.
    /// </summary>
    public static readonly Coding EligiblePercent = new Coding
    {
      Code = "eligpercent",
      Display = "Eligible %",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// The total submitted amount for the claim or group or line item.
    /// </summary>
    public static readonly Coding SubmittedAmount = new Coding
    {
      Code = "submitted",
      Display = "Submitted Amount",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// The amount of tax.
    /// </summary>
    public static readonly Coding Tax = new Coding
    {
      Code = "tax",
      Display = "Tax",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
    /// <summary>
    /// The amount of deductible which could not allocated to other line items.
    /// </summary>
    public static readonly Coding UnallocatedDeductible = new Coding
    {
      Code = "unallocdeduct",
      Display = "Unallocated Deductible",
      System = "http://terminology.hl7.org/CodeSystem/adjudication"
    };
  };
}
