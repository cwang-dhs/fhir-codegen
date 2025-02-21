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
  /// Clinical stage or grade of a condition. May include formal severity assessments.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<ConditionStage>))]
  public class ConditionStage : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Reference to a formal record of the evidence on which the staging assessment is based.
    /// </summary>
    public List<Reference> Assessment { get; set; }
    /// <summary>
    /// A simple summary of the stage such as "Stage 3". The determination of the stage is disease-specific.
    /// </summary>
    public CodeableConcept Summary { get; set; }
    /// <summary>
    /// The kind of staging, such as pathological or clinical staging.
    /// </summary>
    public CodeableConcept Type { get; set; }
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

      if (Summary != null)
      {
        writer.WritePropertyName("summary");
        Summary.SerializeJson(writer, options);
      }

      if ((Assessment != null) && (Assessment.Count != 0))
      {
        writer.WritePropertyName("assessment");
        writer.WriteStartArray();

        foreach (Reference valAssessment in Assessment)
        {
          valAssessment.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
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
        case "assessment":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Assessment = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objAssessment = new fhirCsR4.Models.Reference();
            objAssessment.DeserializeJson(ref reader, options);
            Assessment.Add(objAssessment);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Assessment.Count == 0)
          {
            Assessment = null;
          }

          break;

        case "summary":
          Summary = new fhirCsR4.Models.CodeableConcept();
          Summary.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new fhirCsR4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
  /// The evidence may be a simple list of coded symptoms/manifestations, or references to observations or formal assessments, or both.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<ConditionEvidence>))]
  public class ConditionEvidence : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A manifestation or symptom that led to the recording of this condition.
    /// </summary>
    public List<CodeableConcept> Code { get; set; }
    /// <summary>
    /// Links to other relevant information, including pathology reports.
    /// </summary>
    public List<Reference> Detail { get; set; }
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

      if ((Code != null) && (Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();

        foreach (CodeableConcept valCode in Code)
        {
          valCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Detail != null) && (Detail.Count != 0))
      {
        writer.WritePropertyName("detail");
        writer.WriteStartArray();

        foreach (Reference valDetail in Detail)
        {
          valDetail.SerializeJson(writer, options, true);
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
        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objCode = new fhirCsR4.Models.CodeableConcept();
            objCode.DeserializeJson(ref reader, options);
            Code.Add(objCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Code.Count == 0)
          {
            Code = null;
          }

          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Detail = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objDetail = new fhirCsR4.Models.Reference();
            objDetail.DeserializeJson(ref reader, options);
            Detail.Add(objDetail);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Detail.Count == 0)
          {
            Detail = null;
          }

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
  /// A clinical condition, problem, diagnosis, or other event, situation, issue, or clinical concept that has risen to a level of concern.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<Condition>))]
  public class Condition : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Condition";
    /// <summary>
    /// There is no explicit distinction between resolution and remission because in many cases the distinction is not clear. Age is generally used when the patient reports an age at which the Condition abated.  If there is no abatement element, it is unknown whether the condition has resolved or entered remission; applications and users should generally assume that the condition is still valid.  When abatementString exists, it implies the condition is abated.
    /// </summary>
    public string AbatementDateTime { get; set; }
    /// <summary>
    /// Extension container element for AbatementDateTime
    /// </summary>
    public Element _AbatementDateTime { get; set; }
    /// <summary>
    /// There is no explicit distinction between resolution and remission because in many cases the distinction is not clear. Age is generally used when the patient reports an age at which the Condition abated.  If there is no abatement element, it is unknown whether the condition has resolved or entered remission; applications and users should generally assume that the condition is still valid.  When abatementString exists, it implies the condition is abated.
    /// </summary>
    public Age AbatementAge { get; set; }
    /// <summary>
    /// There is no explicit distinction between resolution and remission because in many cases the distinction is not clear. Age is generally used when the patient reports an age at which the Condition abated.  If there is no abatement element, it is unknown whether the condition has resolved or entered remission; applications and users should generally assume that the condition is still valid.  When abatementString exists, it implies the condition is abated.
    /// </summary>
    public Period AbatementPeriod { get; set; }
    /// <summary>
    /// There is no explicit distinction between resolution and remission because in many cases the distinction is not clear. Age is generally used when the patient reports an age at which the Condition abated.  If there is no abatement element, it is unknown whether the condition has resolved or entered remission; applications and users should generally assume that the condition is still valid.  When abatementString exists, it implies the condition is abated.
    /// </summary>
    public Range AbatementRange { get; set; }
    /// <summary>
    /// There is no explicit distinction between resolution and remission because in many cases the distinction is not clear. Age is generally used when the patient reports an age at which the Condition abated.  If there is no abatement element, it is unknown whether the condition has resolved or entered remission; applications and users should generally assume that the condition is still valid.  When abatementString exists, it implies the condition is abated.
    /// </summary>
    public string AbatementString { get; set; }
    /// <summary>
    /// Extension container element for AbatementString
    /// </summary>
    public Element _AbatementString { get; set; }
    /// <summary>
    /// Individual who is making the condition statement.
    /// </summary>
    public Reference Asserter { get; set; }
    /// <summary>
    /// Only used if not implicit in code found in Condition.code. If the use case requires attributes from the BodySite resource (e.g. to identify and track separately) then use the standard extension [bodySite](extension-bodysite.html).  May be a summary code, or a reference to a very precise definition of the location, or both.
    /// </summary>
    public List<CodeableConcept> BodySite { get; set; }
    /// <summary>
    /// The categorization is often highly contextual and may appear poorly differentiated or not very useful in other contexts.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// The data type is CodeableConcept because clinicalStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.
    /// </summary>
    public CodeableConcept ClinicalStatus { get; set; }
    /// <summary>
    /// Identification of the condition, problem or diagnosis.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter. This record indicates the encounter this particular record is associated with.  In the case of a "new" diagnosis reflecting ongoing/revised information about the condition, this might be distinct from the first encounter in which the underlying condition was first "known".
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// The evidence may be a simple list of coded symptoms/manifestations, or references to observations or formal assessments, or both.
    /// </summary>
    public List<ConditionEvidence> Evidence { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Additional information about the Condition. This is a general notes/comments entry  for description of the Condition, its diagnosis and prognosis.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Age is generally used when the patient reports an age at which the Condition began to occur.
    /// </summary>
    public string OnsetDateTime { get; set; }
    /// <summary>
    /// Extension container element for OnsetDateTime
    /// </summary>
    public Element _OnsetDateTime { get; set; }
    /// <summary>
    /// Age is generally used when the patient reports an age at which the Condition began to occur.
    /// </summary>
    public Age OnsetAge { get; set; }
    /// <summary>
    /// Age is generally used when the patient reports an age at which the Condition began to occur.
    /// </summary>
    public Period OnsetPeriod { get; set; }
    /// <summary>
    /// Age is generally used when the patient reports an age at which the Condition began to occur.
    /// </summary>
    public Range OnsetRange { get; set; }
    /// <summary>
    /// Age is generally used when the patient reports an age at which the Condition began to occur.
    /// </summary>
    public string OnsetString { get; set; }
    /// <summary>
    /// Extension container element for OnsetString
    /// </summary>
    public Element _OnsetString { get; set; }
    /// <summary>
    /// The recordedDate represents when this particular Condition record was created in the system, which is often a system-generated date.
    /// </summary>
    public string RecordedDate { get; set; }
    /// <summary>
    /// Extension container element for RecordedDate
    /// </summary>
    public Element _RecordedDate { get; set; }
    /// <summary>
    /// Individual who recorded the record and takes responsibility for its content.
    /// </summary>
    public Reference Recorder { get; set; }
    /// <summary>
    /// Coding of the severity with a terminology is preferred, where possible.
    /// </summary>
    public CodeableConcept Severity { get; set; }
    /// <summary>
    /// Clinical stage or grade of a condition. May include formal severity assessments.
    /// </summary>
    public List<ConditionStage> Stage { get; set; }
    /// <summary>
    /// Indicates the patient or group who the condition record is associated with.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// verificationStatus is not required.  For example, when a patient has abdominal pain in the ED, there is not likely going to be a verification status.
    /// The data type is CodeableConcept because verificationStatus has some clinical judgment involved, such that there might need to be more specificity than the required FHIR value set allows. For example, a SNOMED coding might allow for additional specificity.
    /// </summary>
    public CodeableConcept VerificationStatus { get; set; }
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

      if (ClinicalStatus != null)
      {
        writer.WritePropertyName("clinicalStatus");
        ClinicalStatus.SerializeJson(writer, options);
      }

      if (VerificationStatus != null)
      {
        writer.WritePropertyName("verificationStatus");
        VerificationStatus.SerializeJson(writer, options);
      }

      if ((Category != null) && (Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();

        foreach (CodeableConcept valCategory in Category)
        {
          valCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Severity != null)
      {
        writer.WritePropertyName("severity");
        Severity.SerializeJson(writer, options);
      }

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if ((BodySite != null) && (BodySite.Count != 0))
      {
        writer.WritePropertyName("bodySite");
        writer.WriteStartArray();

        foreach (CodeableConcept valBodySite in BodySite)
        {
          valBodySite.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OnsetDateTime))
      {
        writer.WriteString("onsetDateTime", (string)OnsetDateTime!);
      }

      if (_OnsetDateTime != null)
      {
        writer.WritePropertyName("_onsetDateTime");
        _OnsetDateTime.SerializeJson(writer, options);
      }

      if (OnsetAge != null)
      {
        writer.WritePropertyName("onsetAge");
        OnsetAge.SerializeJson(writer, options);
      }

      if (OnsetPeriod != null)
      {
        writer.WritePropertyName("onsetPeriod");
        OnsetPeriod.SerializeJson(writer, options);
      }

      if (OnsetRange != null)
      {
        writer.WritePropertyName("onsetRange");
        OnsetRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(OnsetString))
      {
        writer.WriteString("onsetString", (string)OnsetString!);
      }

      if (_OnsetString != null)
      {
        writer.WritePropertyName("_onsetString");
        _OnsetString.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(AbatementDateTime))
      {
        writer.WriteString("abatementDateTime", (string)AbatementDateTime!);
      }

      if (_AbatementDateTime != null)
      {
        writer.WritePropertyName("_abatementDateTime");
        _AbatementDateTime.SerializeJson(writer, options);
      }

      if (AbatementAge != null)
      {
        writer.WritePropertyName("abatementAge");
        AbatementAge.SerializeJson(writer, options);
      }

      if (AbatementPeriod != null)
      {
        writer.WritePropertyName("abatementPeriod");
        AbatementPeriod.SerializeJson(writer, options);
      }

      if (AbatementRange != null)
      {
        writer.WritePropertyName("abatementRange");
        AbatementRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(AbatementString))
      {
        writer.WriteString("abatementString", (string)AbatementString!);
      }

      if (_AbatementString != null)
      {
        writer.WritePropertyName("_abatementString");
        _AbatementString.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RecordedDate))
      {
        writer.WriteString("recordedDate", (string)RecordedDate!);
      }

      if (_RecordedDate != null)
      {
        writer.WritePropertyName("_recordedDate");
        _RecordedDate.SerializeJson(writer, options);
      }

      if (Recorder != null)
      {
        writer.WritePropertyName("recorder");
        Recorder.SerializeJson(writer, options);
      }

      if (Asserter != null)
      {
        writer.WritePropertyName("asserter");
        Asserter.SerializeJson(writer, options);
      }

      if ((Stage != null) && (Stage.Count != 0))
      {
        writer.WritePropertyName("stage");
        writer.WriteStartArray();

        foreach (ConditionStage valStage in Stage)
        {
          valStage.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Evidence != null) && (Evidence.Count != 0))
      {
        writer.WritePropertyName("evidence");
        writer.WriteStartArray();

        foreach (ConditionEvidence valEvidence in Evidence)
        {
          valEvidence.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(writer, options, true);
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
        case "abatementDateTime":
          AbatementDateTime = reader.GetString();
          break;

        case "_abatementDateTime":
          _AbatementDateTime = new fhirCsR4.Models.Element();
          _AbatementDateTime.DeserializeJson(ref reader, options);
          break;

        case "abatementAge":
          AbatementAge = new fhirCsR4.Models.Age();
          AbatementAge.DeserializeJson(ref reader, options);
          break;

        case "abatementPeriod":
          AbatementPeriod = new fhirCsR4.Models.Period();
          AbatementPeriod.DeserializeJson(ref reader, options);
          break;

        case "abatementRange":
          AbatementRange = new fhirCsR4.Models.Range();
          AbatementRange.DeserializeJson(ref reader, options);
          break;

        case "abatementString":
          AbatementString = reader.GetString();
          break;

        case "_abatementString":
          _AbatementString = new fhirCsR4.Models.Element();
          _AbatementString.DeserializeJson(ref reader, options);
          break;

        case "asserter":
          Asserter = new fhirCsR4.Models.Reference();
          Asserter.DeserializeJson(ref reader, options);
          break;

        case "bodySite":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          BodySite = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objBodySite = new fhirCsR4.Models.CodeableConcept();
            objBodySite.DeserializeJson(ref reader, options);
            BodySite.Add(objBodySite);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (BodySite.Count == 0)
          {
            BodySite = null;
          }

          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objCategory = new fhirCsR4.Models.CodeableConcept();
            objCategory.DeserializeJson(ref reader, options);
            Category.Add(objCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Category.Count == 0)
          {
            Category = null;
          }

          break;

        case "clinicalStatus":
          ClinicalStatus = new fhirCsR4.Models.CodeableConcept();
          ClinicalStatus.DeserializeJson(ref reader, options);
          break;

        case "code":
          Code = new fhirCsR4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR4.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "evidence":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Evidence = new List<ConditionEvidence>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.ConditionEvidence objEvidence = new fhirCsR4.Models.ConditionEvidence();
            objEvidence.DeserializeJson(ref reader, options);
            Evidence.Add(objEvidence);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Evidence.Count == 0)
          {
            Evidence = null;
          }

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

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Annotation objNote = new fhirCsR4.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "onsetDateTime":
          OnsetDateTime = reader.GetString();
          break;

        case "_onsetDateTime":
          _OnsetDateTime = new fhirCsR4.Models.Element();
          _OnsetDateTime.DeserializeJson(ref reader, options);
          break;

        case "onsetAge":
          OnsetAge = new fhirCsR4.Models.Age();
          OnsetAge.DeserializeJson(ref reader, options);
          break;

        case "onsetPeriod":
          OnsetPeriod = new fhirCsR4.Models.Period();
          OnsetPeriod.DeserializeJson(ref reader, options);
          break;

        case "onsetRange":
          OnsetRange = new fhirCsR4.Models.Range();
          OnsetRange.DeserializeJson(ref reader, options);
          break;

        case "onsetString":
          OnsetString = reader.GetString();
          break;

        case "_onsetString":
          _OnsetString = new fhirCsR4.Models.Element();
          _OnsetString.DeserializeJson(ref reader, options);
          break;

        case "recordedDate":
          RecordedDate = reader.GetString();
          break;

        case "_recordedDate":
          _RecordedDate = new fhirCsR4.Models.Element();
          _RecordedDate.DeserializeJson(ref reader, options);
          break;

        case "recorder":
          Recorder = new fhirCsR4.Models.Reference();
          Recorder.DeserializeJson(ref reader, options);
          break;

        case "severity":
          Severity = new fhirCsR4.Models.CodeableConcept();
          Severity.DeserializeJson(ref reader, options);
          break;

        case "stage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Stage = new List<ConditionStage>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.ConditionStage objStage = new fhirCsR4.Models.ConditionStage();
            objStage.DeserializeJson(ref reader, options);
            Stage.Add(objStage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Stage.Count == 0)
          {
            Stage = null;
          }

          break;

        case "subject":
          Subject = new fhirCsR4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "verificationStatus":
          VerificationStatus = new fhirCsR4.Models.CodeableConcept();
          VerificationStatus.DeserializeJson(ref reader, options);
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
}
