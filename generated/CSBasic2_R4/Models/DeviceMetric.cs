// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// Describes the calibrations that have been performed or that are required to be performed.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<DeviceMetricCalibration>))]
  public class DeviceMetricCalibration : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Describes the state of the calibration.
    /// </summary>
    public string State { get; set; }
    /// <summary>
    /// Extension container element for State
    /// </summary>
    public Element _State { get; set; }
    /// <summary>
    /// Describes the time last calibration has been performed.
    /// </summary>
    public string Time { get; set; }
    /// <summary>
    /// Extension container element for Time
    /// </summary>
    public Element _Time { get; set; }
    /// <summary>
    /// Describes the type of the calibration method.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(State))
      {
        writer.WriteString("state", (string)State!);
      }

      if (_State != null)
      {
        writer.WritePropertyName("_state");
        _State.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Time))
      {
        writer.WriteString("time", (string)Time!);
      }

      if (_Time != null)
      {
        writer.WritePropertyName("_time");
        _Time.SerializeJson(writer, options);
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
        case "state":
          State = reader.GetString();
          break;

        case "_state":
          _State = new fhirCsR4.Models.Element();
          _State.DeserializeJson(ref reader, options);
          break;

        case "time":
          Time = reader.GetString();
          break;

        case "_time":
          _Time = new fhirCsR4.Models.Element();
          _Time.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the DeviceMetric.calibration.state field
  /// </summary>
  public static class DeviceMetricCalibrationStateCodes {
    public const string NOT_CALIBRATED = "not-calibrated";
    public const string CALIBRATION_REQUIRED = "calibration-required";
    public const string CALIBRATED = "calibrated";
    public const string UNSPECIFIED = "unspecified";
  }
  /// <summary>
  /// Code Values for the DeviceMetric.calibration.type field
  /// </summary>
  public static class DeviceMetricCalibrationTypeCodes {
    public const string UNSPECIFIED = "unspecified";
    public const string OFFSET = "offset";
    public const string GAIN = "gain";
    public const string TWO_POINT = "two-point";
  }
  /// <summary>
  /// Describes a measurement, calculation or setting capability of a medical device.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<DeviceMetric>))]
  public class DeviceMetric : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "DeviceMetric";
    /// <summary>
    /// Describes the calibrations that have been performed or that are required to be performed.
    /// </summary>
    public List<DeviceMetricCalibration> Calibration { get; set; }
    /// <summary>
    /// Indicates the category of the observation generation process. A DeviceMetric can be for example a setting, measurement, or calculation.
    /// </summary>
    public string Category { get; set; }
    /// <summary>
    /// Extension container element for Category
    /// </summary>
    public Element _Category { get; set; }
    /// <summary>
    /// Describes the color representation for the metric. This is often used to aid clinicians to track and identify parameter types by color. In practice, consider a Patient Monitor that has ECG/HR and Pleth for example; the parameters are displayed in different characteristic colors, such as HR-blue, BP-green, and PR and SpO2- magenta.
    /// </summary>
    public string Color { get; set; }
    /// <summary>
    /// Extension container element for Color
    /// </summary>
    public Element _Color { get; set; }
    /// <summary>
    /// For identifiers assigned to a device by the device or gateway software, the `system` element of the identifier should be set to the unique identifier of the device.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Describes the measurement repetition time. This is not necessarily the same as the update period. The measurement repetition time can range from milliseconds up to hours. An example for a measurement repetition time in the range of milliseconds is the sampling rate of an ECG. An example for a measurement repetition time in the range of hours is a NIBP that is triggered automatically every hour. The update period may be different than the measurement repetition time, if the device does not update the published observed value with the same frequency as it was measured.
    /// </summary>
    public Timing MeasurementPeriod { get; set; }
    /// <summary>
    /// Indicates current operational state of the device. For example: On, Off, Standby, etc.
    /// </summary>
    public string OperationalStatus { get; set; }
    /// <summary>
    /// Extension container element for OperationalStatus
    /// </summary>
    public Element _OperationalStatus { get; set; }
    /// <summary>
    /// Describes the link to the  Device that this DeviceMetric belongs to and that provide information about the location of this DeviceMetric in the containment structure of the parent Device. An example would be a Device that represents a Channel. This reference can be used by a client application to distinguish DeviceMetrics that have the same type, but should be interpreted based on their containment location.
    /// </summary>
    public Reference Parent { get; set; }
    /// <summary>
    /// Describes the link to the  Device that this DeviceMetric belongs to and that contains administrative device information such as manufacturer, serial number, etc.
    /// </summary>
    public Reference Source { get; set; }
    /// <summary>
    /// DeviceMetric.type can be referred to either IEEE 11073-10101 or LOINC.
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// DeviceMetric.unit can refer to either UCUM or preferable a RTMMS coding system.
    /// </summary>
    public CodeableConcept Unit { get; set; }
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


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Unit != null)
      {
        writer.WritePropertyName("unit");
        Unit.SerializeJson(writer, options);
      }

      if (Source != null)
      {
        writer.WritePropertyName("source");
        Source.SerializeJson(writer, options);
      }

      if (Parent != null)
      {
        writer.WritePropertyName("parent");
        Parent.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OperationalStatus))
      {
        writer.WriteString("operationalStatus", (string)OperationalStatus!);
      }

      if (_OperationalStatus != null)
      {
        writer.WritePropertyName("_operationalStatus");
        _OperationalStatus.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Color))
      {
        writer.WriteString("color", (string)Color!);
      }

      if (_Color != null)
      {
        writer.WritePropertyName("_color");
        _Color.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Category))
      {
        writer.WriteString("category", (string)Category!);
      }

      if (_Category != null)
      {
        writer.WritePropertyName("_category");
        _Category.SerializeJson(writer, options);
      }

      if (MeasurementPeriod != null)
      {
        writer.WritePropertyName("measurementPeriod");
        MeasurementPeriod.SerializeJson(writer, options);
      }

      if ((Calibration != null) && (Calibration.Count != 0))
      {
        writer.WritePropertyName("calibration");
        writer.WriteStartArray();

        foreach (DeviceMetricCalibration valCalibration in Calibration)
        {
          valCalibration.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "calibration":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Calibration = new List<DeviceMetricCalibration>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.DeviceMetricCalibration objCalibration = new fhirCsR4.Models.DeviceMetricCalibration();
            objCalibration.DeserializeJson(ref reader, options);
            Calibration.Add(objCalibration);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Calibration.Count == 0)
          {
            Calibration = null;
          }

          break;

        case "category":
          Category = reader.GetString();
          break;

        case "_category":
          _Category = new fhirCsR4.Models.Element();
          _Category.DeserializeJson(ref reader, options);
          break;

        case "color":
          Color = reader.GetString();
          break;

        case "_color":
          _Color = new fhirCsR4.Models.Element();
          _Color.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Identifier objIdentifier = new fhirCsR4.Models.Identifier();
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

        case "measurementPeriod":
          MeasurementPeriod = new fhirCsR4.Models.Timing();
          MeasurementPeriod.DeserializeJson(ref reader, options);
          break;

        case "operationalStatus":
          OperationalStatus = reader.GetString();
          break;

        case "_operationalStatus":
          _OperationalStatus = new fhirCsR4.Models.Element();
          _OperationalStatus.DeserializeJson(ref reader, options);
          break;

        case "parent":
          Parent = new fhirCsR4.Models.Reference();
          Parent.DeserializeJson(ref reader, options);
          break;

        case "source":
          Source = new fhirCsR4.Models.Reference();
          Source.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "unit":
          Unit = new fhirCsR4.Models.CodeableConcept();
          Unit.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the DeviceMetric.category field
  /// </summary>
  public static class DeviceMetricCategoryCodes {
    public const string MEASUREMENT = "measurement";
    public const string SETTING = "setting";
    public const string CALCULATION = "calculation";
    public const string UNSPECIFIED = "unspecified";
  }
  /// <summary>
  /// Code Values for the DeviceMetric.color field
  /// </summary>
  public static class DeviceMetricColorCodes {
    public const string BLACK = "black";
    public const string RED = "red";
    public const string GREEN = "green";
    public const string YELLOW = "yellow";
    public const string BLUE = "blue";
    public const string MAGENTA = "magenta";
    public const string CYAN = "cyan";
    public const string WHITE = "white";
  }
  /// <summary>
  /// Code Values for the DeviceMetric.operationalStatus field
  /// </summary>
  public static class DeviceMetricOperationalStatusCodes {
    public const string ON = "on";
    public const string OFF = "off";
    public const string STANDBY = "standby";
    public const string ENTERED_IN_ERROR = "entered-in-error";
  }
}
