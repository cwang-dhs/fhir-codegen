// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Distinguishes groups from questions and display text and indicates data type for questions.
  /// </summary>
  public static class ItemTypeCodes
  {
    /// <summary>
    /// Question with binary content such as an image, PDF, etc. as an answer (valueAttachment).
    /// </summary>
    public static readonly Coding Attachment = new Coding
    {
      Code = "attachment",
      Display = "Attachment",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a yes/no answer (valueBoolean).
    /// </summary>
    public static readonly Coding Boolean = new Coding
    {
      Code = "boolean",
      Display = "Boolean",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a Coding - generally drawn from a list of possible answers (valueCoding)
    /// </summary>
    public static readonly Coding Coding = new Coding
    {
      Code = "coding",
      Display = "Coding",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a date answer (valueDate).
    /// </summary>
    public static readonly Coding Date = new Coding
    {
      Code = "date",
      Display = "Date",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a date and time answer (valueDateTime).
    /// </summary>
    public static readonly Coding DateTime = new Coding
    {
      Code = "dateTime",
      Display = "Date Time",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with is a real number answer (valueDecimal).
    /// </summary>
    public static readonly Coding Decimal = new Coding
    {
      Code = "decimal",
      Display = "Decimal",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Text for display that will not capture an answer or have child items.
    /// </summary>
    public static readonly Coding Display = new Coding
    {
      Code = "display",
      Display = "Display",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// An item with no direct answer but should have at least one child item.
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      Display = "Group",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with an integer answer (valueInteger).
    /// </summary>
    public static readonly Coding Integer = new Coding
    {
      Code = "integer",
      Display = "Integer",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a combination of a numeric value and unit, potentially with a comparator (&lt;, &gt;, etc.) as an answer. (valueQuantity) There is an extension 'http://hl7.org/fhir/StructureDefinition/questionnaire-unit' that can be used to define what unit should be captured (or the unit that has a ucum conversion from the provided unit).
    /// </summary>
    public static readonly Coding Quantity = new Coding
    {
      Code = "quantity",
      Display = "Quantity",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// An item that defines a specific answer to be captured, and which may have child items. (the answer provided in the QuestionnaireResponse should be of the defined datatype).
    /// </summary>
    public static readonly Coding Question = new Coding
    {
      Code = "question",
      Display = "Question",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a reference to another resource (practitioner, organization, etc.) as an answer (valueReference).
    /// </summary>
    public static readonly Coding Reference = new Coding
    {
      Code = "reference",
      Display = "Reference",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a short (few words to short sentence) free-text entry answer (valueString).
    /// </summary>
    public static readonly Coding String = new Coding
    {
      Code = "string",
      Display = "String",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a long (potentially multi-paragraph) free-text entry answer (valueString).
    /// </summary>
    public static readonly Coding Text = new Coding
    {
      Code = "text",
      Display = "Text",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a time (hour:minute:second) answer independent of date. (valueTime).
    /// </summary>
    public static readonly Coding Time = new Coding
    {
      Code = "time",
      Display = "Time",
      System = "http://hl7.org/fhir/item-type"
    };
    /// <summary>
    /// Question with a URL (website, FTP site, etc.) answer (valueUri).
    /// </summary>
    public static readonly Coding Url = new Coding
    {
      Code = "url",
      Display = "Url",
      System = "http://hl7.org/fhir/item-type"
    };
  };
}
