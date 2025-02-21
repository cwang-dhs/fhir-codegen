// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// Specific parameters for the ordered item.  For example, the size of the indicated item.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SupplyRequestParameter>))]
  public class SupplyRequestParameter : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A code or string that identifies the device detail being asserted.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Range means device should have a value that falls somewhere within the specified range.
    /// </summary>
    public CodeableConcept ValueCodeableConcept { get; set; }
    /// <summary>
    /// Range means device should have a value that falls somewhere within the specified range.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// Range means device should have a value that falls somewhere within the specified range.
    /// </summary>
    public Range ValueRange { get; set; }
    /// <summary>
    /// Range means device should have a value that falls somewhere within the specified range.
    /// </summary>
    public bool? ValueBoolean { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (ValueCodeableConcept != null)
      {
        writer.WritePropertyName("valueCodeableConcept");
        ValueCodeableConcept.SerializeJson(writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(writer, options);
      }

      if (ValueRange != null)
      {
        writer.WritePropertyName("valueRange");
        ValueRange.SerializeJson(writer, options);
      }

      if (ValueBoolean != null)
      {
        writer.WriteBoolean("valueBoolean", (bool)ValueBoolean!);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new fhirCsR5.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          ValueCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          ValueCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new fhirCsR5.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueRange":
          ValueRange = new fhirCsR5.Models.Range();
          ValueRange.DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        default:
          ((fhirCsR5.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// A record of a request for a medication, substance or device used in the healthcare setting.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<SupplyRequest>))]
  public class SupplyRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "SupplyRequest";
    /// <summary>
    /// When the request was made.
    /// </summary>
    public string AuthoredOn { get; set; }
    /// <summary>
    /// Extension container element for AuthoredOn
    /// </summary>
    public Element _AuthoredOn { get; set; }
    /// <summary>
    /// Category of supply, e.g.  central, non-stock, etc. This is used to support work flows associated with the supply process.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// Where the supply is expected to come from.
    /// </summary>
    public Reference DeliverFrom { get; set; }
    /// <summary>
    /// Where the supply is destined to go.
    /// </summary>
    public Reference DeliverTo { get; set; }
    /// <summary>
    /// The identifier.type element is used to distinguish between the identifiers assigned by the requester/placer and the performer/filler.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Note that there's a difference between a prescription - an instruction to take a medication, along with a (sometimes) implicit supply, and an explicit request to supply, with no explicit instructions.
    /// </summary>
    public CodeableReference Item { get; set; }
    /// <summary>
    /// When the request should be fulfilled.
    /// </summary>
    public string OccurrenceDateTime { get; set; }
    /// <summary>
    /// Extension container element for OccurrenceDateTime
    /// </summary>
    public Element _OccurrenceDateTime { get; set; }
    /// <summary>
    /// When the request should be fulfilled.
    /// </summary>
    public Period OccurrencePeriod { get; set; }
    /// <summary>
    /// When the request should be fulfilled.
    /// </summary>
    public Timing OccurrenceTiming { get; set; }
    /// <summary>
    /// Specific parameters for the ordered item.  For example, the size of the indicated item.
    /// </summary>
    public List<SupplyRequestParameter> Parameter { get; set; }
    /// <summary>
    /// Indicates how quickly this SupplyRequest should be addressed with respect to other requests.
    /// </summary>
    public string Priority { get; set; }
    /// <summary>
    /// Extension container element for Priority
    /// </summary>
    public Element _Priority { get; set; }
    /// <summary>
    /// The amount that is being ordered of the indicated item.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// The reason why the supply item was requested.
    /// </summary>
    public List<CodeableReference> Reason { get; set; }
    /// <summary>
    /// The device, practitioner, etc. who initiated the request.
    /// </summary>
    public Reference Requester { get; set; }
    /// <summary>
    /// Status of the supply request.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Who is intended to fulfill the request.
    /// </summary>
    public List<Reference> Supplier { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR5.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Priority))
      {
        writer.WriteString("priority", (string)Priority!);
      }

      if (_Priority != null)
      {
        writer.WritePropertyName("_priority");
        _Priority.SerializeJson(writer, options);
      }

      if (Item != null)
      {
        writer.WritePropertyName("item");
        Item.SerializeJson(writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

      if ((Parameter != null) && (Parameter.Count != 0))
      {
        writer.WritePropertyName("parameter");
        writer.WriteStartArray();

        foreach (SupplyRequestParameter valParameter in Parameter)
        {
          valParameter.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(OccurrenceDateTime))
      {
        writer.WriteString("occurrenceDateTime", (string)OccurrenceDateTime!);
      }

      if (_OccurrenceDateTime != null)
      {
        writer.WritePropertyName("_occurrenceDateTime");
        _OccurrenceDateTime.SerializeJson(writer, options);
      }

      if (OccurrencePeriod != null)
      {
        writer.WritePropertyName("occurrencePeriod");
        OccurrencePeriod.SerializeJson(writer, options);
      }

      if (OccurrenceTiming != null)
      {
        writer.WritePropertyName("occurrenceTiming");
        OccurrenceTiming.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(AuthoredOn))
      {
        writer.WriteString("authoredOn", (string)AuthoredOn!);
      }

      if (_AuthoredOn != null)
      {
        writer.WritePropertyName("_authoredOn");
        _AuthoredOn.SerializeJson(writer, options);
      }

      if (Requester != null)
      {
        writer.WritePropertyName("requester");
        Requester.SerializeJson(writer, options);
      }

      if ((Supplier != null) && (Supplier.Count != 0))
      {
        writer.WritePropertyName("supplier");
        writer.WriteStartArray();

        foreach (Reference valSupplier in Supplier)
        {
          valSupplier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Reason != null) && (Reason.Count != 0))
      {
        writer.WritePropertyName("reason");
        writer.WriteStartArray();

        foreach (CodeableReference valReason in Reason)
        {
          valReason.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (DeliverFrom != null)
      {
        writer.WritePropertyName("deliverFrom");
        DeliverFrom.SerializeJson(writer, options);
      }

      if (DeliverTo != null)
      {
        writer.WritePropertyName("deliverTo");
        DeliverTo.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "authoredOn":
          AuthoredOn = reader.GetString();
          break;

        case "_authoredOn":
          _AuthoredOn = new fhirCsR5.Models.Element();
          _AuthoredOn.DeserializeJson(ref reader, options);
          break;

        case "category":
          Category = new fhirCsR5.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "deliverFrom":
          DeliverFrom = new fhirCsR5.Models.Reference();
          DeliverFrom.DeserializeJson(ref reader, options);
          break;

        case "deliverTo":
          DeliverTo = new fhirCsR5.Models.Reference();
          DeliverTo.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Identifier objIdentifier = new fhirCsR5.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "item":
          Item = new fhirCsR5.Models.CodeableReference();
          Item.DeserializeJson(ref reader, options);
          break;

        case "occurrenceDateTime":
          OccurrenceDateTime = reader.GetString();
          break;

        case "_occurrenceDateTime":
          _OccurrenceDateTime = new fhirCsR5.Models.Element();
          _OccurrenceDateTime.DeserializeJson(ref reader, options);
          break;

        case "occurrencePeriod":
          OccurrencePeriod = new fhirCsR5.Models.Period();
          OccurrencePeriod.DeserializeJson(ref reader, options);
          break;

        case "occurrenceTiming":
          OccurrenceTiming = new fhirCsR5.Models.Timing();
          OccurrenceTiming.DeserializeJson(ref reader, options);
          break;

        case "parameter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Parameter = new List<SupplyRequestParameter>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.SupplyRequestParameter objParameter = new fhirCsR5.Models.SupplyRequestParameter();
            objParameter.DeserializeJson(ref reader, options);
            Parameter.Add(objParameter);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Parameter.Count == 0)
          {
            Parameter = null;
          }

          break;

        case "priority":
          Priority = reader.GetString();
          break;

        case "_priority":
          _Priority = new fhirCsR5.Models.Element();
          _Priority.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR5.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "reason":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reason = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objReason = new fhirCsR5.Models.CodeableReference();
            objReason.DeserializeJson(ref reader, options);
            Reason.Add(objReason);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reason.Count == 0)
          {
            Reason = null;
          }

          break;

        case "requester":
          Requester = new fhirCsR5.Models.Reference();
          Requester.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "supplier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Supplier = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objSupplier = new fhirCsR5.Models.Reference();
            objSupplier.DeserializeJson(ref reader, options);
            Supplier.Add(objSupplier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Supplier.Count == 0)
          {
            Supplier = null;
          }

          break;

        default:
          ((fhirCsR5.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the SupplyRequest.priority field
  /// </summary>
  public static class SupplyRequestPriorityCodes {
    public const string ROUTINE = "routine";
    public const string URGENT = "urgent";
    public const string ASAP = "asap";
    public const string STAT = "stat";
  }
  /// <summary>
  /// Code Values for the SupplyRequest.status field
  /// </summary>
  public static class SupplyRequestStatusCodes {
    public const string DRAFT = "draft";
    public const string ACTIVE = "active";
    public const string SUSPENDED = "suspended";
    public const string CANCELLED = "cancelled";
    public const string COMPLETED = "completed";
    public const string ENTERED_IN_ERROR = "entered-in-error";
    public const string UNKNOWN = "unknown";
  }
}
