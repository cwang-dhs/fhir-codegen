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
  /// Note: This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<NutritionProductNutrient>))]
  public class NutritionProductNutrient : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The amount of nutrient expressed in one or more units: X per pack / per serving / per dose.
    /// </summary>
    public List<Ratio> Amount { get; set; }
    /// <summary>
    /// The (relevant) nutrients in the product.
    /// </summary>
    public CodeableReference Item { get; set; }
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

      if (Item != null)
      {
        writer.WritePropertyName("item");
        Item.SerializeJson(writer, options);
      }

      if ((Amount != null) && (Amount.Count != 0))
      {
        writer.WritePropertyName("amount");
        writer.WriteStartArray();

        foreach (Ratio valAmount in Amount)
        {
          valAmount.SerializeJson(writer, options, true);
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
        case "amount":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Amount = new List<Ratio>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Ratio objAmount = new fhirCsR5.Models.Ratio();
            objAmount.DeserializeJson(ref reader, options);
            Amount.Add(objAmount);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Amount.Count == 0)
          {
            Amount = null;
          }

          break;

        case "item":
          Item = new fhirCsR5.Models.CodeableReference();
          Item.DeserializeJson(ref reader, options);
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
  /// Ingredients contained in this product.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<NutritionProductIngredient>))]
  public class NutritionProductIngredient : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The amount of ingredient that is in the product.
    /// </summary>
    public List<Ratio> Amount { get; set; }
    /// <summary>
    /// The ingredient contained in the product.
    /// </summary>
    public CodeableReference Item { get; set; }
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

      if (Item != null)
      {
        writer.WritePropertyName("item");
        Item.SerializeJson(writer, options);
      }

      if ((Amount != null) && (Amount.Count != 0))
      {
        writer.WritePropertyName("amount");
        writer.WriteStartArray();

        foreach (Ratio valAmount in Amount)
        {
          valAmount.SerializeJson(writer, options, true);
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
        case "amount":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Amount = new List<Ratio>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Ratio objAmount = new fhirCsR5.Models.Ratio();
            objAmount.DeserializeJson(ref reader, options);
            Amount.Add(objAmount);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Amount.Count == 0)
          {
            Amount = null;
          }

          break;

        case "item":
          Item = new fhirCsR5.Models.CodeableReference();
          Item.DeserializeJson(ref reader, options);
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
  /// Specifies descriptive properties of the nutrition product.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<NutritionProductProductCharacteristic>))]
  public class NutritionProductProductCharacteristic : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A code specifying which characteristic of the product is being described (for example, colour, shape).
    /// </summary>
    public CodeableConcept Type { get; set; }
    /// <summary>
    /// The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.
    /// </summary>
    public CodeableConcept ValueCodeableConcept { get; set; }
    /// <summary>
    /// The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.
    /// </summary>
    public string ValueString { get; set; }
    /// <summary>
    /// Extension container element for ValueString
    /// </summary>
    public Element _ValueString { get; set; }
    /// <summary>
    /// The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.
    /// </summary>
    public byte[] ValueBase64Binary { get; set; }
    /// <summary>
    /// The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.
    /// </summary>
    public Attachment ValueAttachment { get; set; }
    /// <summary>
    /// The description should be provided as a CodeableConcept, SimpleQuantity or an image.  The description can be a string only when these others are not available.
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

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (ValueCodeableConcept != null)
      {
        writer.WritePropertyName("valueCodeableConcept");
        ValueCodeableConcept.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ValueString))
      {
        writer.WriteString("valueString", (string)ValueString!);
      }

      if (_ValueString != null)
      {
        writer.WritePropertyName("_valueString");
        _ValueString.SerializeJson(writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(writer, options);
      }

      if (ValueBase64Binary != null)
      {
        writer.WriteBase64String("valueBase64Binary", (byte[])ValueBase64Binary!);
      }

      if (ValueAttachment != null)
      {
        writer.WritePropertyName("valueAttachment");
        ValueAttachment.SerializeJson(writer, options);
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
        case "type":
          Type = new fhirCsR5.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          ValueCodeableConcept = new fhirCsR5.Models.CodeableConcept();
          ValueCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "valueString":
          ValueString = reader.GetString();
          break;

        case "_valueString":
          _ValueString = new fhirCsR5.Models.Element();
          _ValueString.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new fhirCsR5.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueBase64Binary":
          ValueBase64Binary = reader.GetBytesFromBase64();
          break;

        case "valueAttachment":
          ValueAttachment = new fhirCsR5.Models.Attachment();
          ValueAttachment.DeserializeJson(ref reader, options);
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
  /// Conveys instance-level information about this product item. One or several physical, countable instances or occurrences of the product.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<NutritionProductInstance>))]
  public class NutritionProductInstance : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The time after which the product is no longer expected to be in proper condition, or its use is not advised or not allowed.
    /// </summary>
    public string Expiry { get; set; }
    /// <summary>
    /// Extension container element for Expiry
    /// </summary>
    public Element _Expiry { get; set; }
    /// <summary>
    /// The identifier for the physical instance, typically a serial number.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The identification of the batch or lot of the product.
    /// </summary>
    public string LotNumber { get; set; }
    /// <summary>
    /// Extension container element for LotNumber
    /// </summary>
    public Element _LotNumber { get; set; }
    /// <summary>
    /// The amount of items or instances that the resource considers, for instance when referring to 2 identical units together.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// The time after which the product is no longer expected to be in proper condition, or its use is not advised or not allowed.
    /// </summary>
    public string UseBy { get; set; }
    /// <summary>
    /// Extension container element for UseBy
    /// </summary>
    public Element _UseBy { get; set; }
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

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(writer, options);
      }

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

      if (!string.IsNullOrEmpty(LotNumber))
      {
        writer.WriteString("lotNumber", (string)LotNumber!);
      }

      if (_LotNumber != null)
      {
        writer.WritePropertyName("_lotNumber");
        _LotNumber.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Expiry))
      {
        writer.WriteString("expiry", (string)Expiry!);
      }

      if (_Expiry != null)
      {
        writer.WritePropertyName("_expiry");
        _Expiry.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(UseBy))
      {
        writer.WriteString("useBy", (string)UseBy!);
      }

      if (_UseBy != null)
      {
        writer.WritePropertyName("_useBy");
        _UseBy.SerializeJson(writer, options);
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
        case "expiry":
          Expiry = reader.GetString();
          break;

        case "_expiry":
          _Expiry = new fhirCsR5.Models.Element();
          _Expiry.DeserializeJson(ref reader, options);
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

        case "lotNumber":
          LotNumber = reader.GetString();
          break;

        case "_lotNumber":
          _LotNumber = new fhirCsR5.Models.Element();
          _LotNumber.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new fhirCsR5.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "useBy":
          UseBy = reader.GetString();
          break;

        case "_useBy":
          _UseBy = new fhirCsR5.Models.Element();
          _UseBy.DeserializeJson(ref reader, options);
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
  /// A food or fluid product that is consumed by patients.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<NutritionProduct>))]
  public class NutritionProduct : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "NutritionProduct";
    /// <summary>
    /// Nutrition products can have different classifications - according to its nutritional properties, preparation methods, etc.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// The code assigned to the product, for example a manufacturer number or other terminology.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// Ingredients contained in this product.
    /// </summary>
    public List<NutritionProductIngredient> Ingredient { get; set; }
    /// <summary>
    /// Conveys instance-level information about this product item. One or several physical, countable instances or occurrences of the product.
    /// </summary>
    public NutritionProductInstance Instance { get; set; }
    /// <summary>
    /// Allergens that are known or suspected to be a part of this nutrition product.
    /// </summary>
    public List<CodeableReference> KnownAllergen { get; set; }
    /// <summary>
    /// The organisation (manufacturer, representative or legal authorisation holder) that is responsible for the device.
    /// </summary>
    public List<Reference> Manufacturer { get; set; }
    /// <summary>
    /// Comments made about the product.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Note: This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public List<NutritionProductNutrient> Nutrient { get; set; }
    /// <summary>
    /// Specifies descriptive properties of the nutrition product.
    /// </summary>
    public List<NutritionProductProductCharacteristic> ProductCharacteristic { get; set; }
    /// <summary>
    /// Unknown does not represent "other" - one of the defined statuses must apply.  Unknown is used when the authoring system is not sure what the current status is.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
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

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if ((Manufacturer != null) && (Manufacturer.Count != 0))
      {
        writer.WritePropertyName("manufacturer");
        writer.WriteStartArray();

        foreach (Reference valManufacturer in Manufacturer)
        {
          valManufacturer.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Nutrient != null) && (Nutrient.Count != 0))
      {
        writer.WritePropertyName("nutrient");
        writer.WriteStartArray();

        foreach (NutritionProductNutrient valNutrient in Nutrient)
        {
          valNutrient.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Ingredient != null) && (Ingredient.Count != 0))
      {
        writer.WritePropertyName("ingredient");
        writer.WriteStartArray();

        foreach (NutritionProductIngredient valIngredient in Ingredient)
        {
          valIngredient.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((KnownAllergen != null) && (KnownAllergen.Count != 0))
      {
        writer.WritePropertyName("knownAllergen");
        writer.WriteStartArray();

        foreach (CodeableReference valKnownAllergen in KnownAllergen)
        {
          valKnownAllergen.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ProductCharacteristic != null) && (ProductCharacteristic.Count != 0))
      {
        writer.WritePropertyName("productCharacteristic");
        writer.WriteStartArray();

        foreach (NutritionProductProductCharacteristic valProductCharacteristic in ProductCharacteristic)
        {
          valProductCharacteristic.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Instance != null)
      {
        writer.WritePropertyName("instance");
        Instance.SerializeJson(writer, options);
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
        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableConcept objCategory = new fhirCsR5.Models.CodeableConcept();
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

        case "code":
          Code = new fhirCsR5.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "ingredient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Ingredient = new List<NutritionProductIngredient>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.NutritionProductIngredient objIngredient = new fhirCsR5.Models.NutritionProductIngredient();
            objIngredient.DeserializeJson(ref reader, options);
            Ingredient.Add(objIngredient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Ingredient.Count == 0)
          {
            Ingredient = null;
          }

          break;

        case "instance":
          Instance = new fhirCsR5.Models.NutritionProductInstance();
          Instance.DeserializeJson(ref reader, options);
          break;

        case "knownAllergen":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          KnownAllergen = new List<CodeableReference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.CodeableReference objKnownAllergen = new fhirCsR5.Models.CodeableReference();
            objKnownAllergen.DeserializeJson(ref reader, options);
            KnownAllergen.Add(objKnownAllergen);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (KnownAllergen.Count == 0)
          {
            KnownAllergen = null;
          }

          break;

        case "manufacturer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Manufacturer = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Reference objManufacturer = new fhirCsR5.Models.Reference();
            objManufacturer.DeserializeJson(ref reader, options);
            Manufacturer.Add(objManufacturer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Manufacturer.Count == 0)
          {
            Manufacturer = null;
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
            fhirCsR5.Models.Annotation objNote = new fhirCsR5.Models.Annotation();
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

        case "nutrient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Nutrient = new List<NutritionProductNutrient>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.NutritionProductNutrient objNutrient = new fhirCsR5.Models.NutritionProductNutrient();
            objNutrient.DeserializeJson(ref reader, options);
            Nutrient.Add(objNutrient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Nutrient.Count == 0)
          {
            Nutrient = null;
          }

          break;

        case "productCharacteristic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ProductCharacteristic = new List<NutritionProductProductCharacteristic>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.NutritionProductProductCharacteristic objProductCharacteristic = new fhirCsR5.Models.NutritionProductProductCharacteristic();
            objProductCharacteristic.DeserializeJson(ref reader, options);
            ProductCharacteristic.Add(objProductCharacteristic);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ProductCharacteristic.Count == 0)
          {
            ProductCharacteristic = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR5.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
  /// Code Values for the NutritionProduct.status field
  /// </summary>
  public static class NutritionProductStatusCodes {
    public const string ACTIVE = "active";
    public const string INACTIVE = "inactive";
    public const string ENTERED_IN_ERROR = "entered-in-error";
  }
}
