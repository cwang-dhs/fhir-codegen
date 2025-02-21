// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The status of a subscription.
  /// </summary>
  public static class SubscriptionStatusCodes
  {
    /// <summary>
    /// The subscription is active.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/subscription-status"
    };
    /// <summary>
    /// The server has an error executing the notification.
    /// </summary>
    public static readonly Coding Error = new Coding
    {
      Code = "error",
      Display = "Error",
      System = "http://hl7.org/fhir/subscription-status"
    };
    /// <summary>
    /// Too many errors have occurred or the subscription has expired.
    /// </summary>
    public static readonly Coding Off = new Coding
    {
      Code = "off",
      Display = "Off",
      System = "http://hl7.org/fhir/subscription-status"
    };
    /// <summary>
    /// The client has requested the subscription, and the server has not yet set it up.
    /// </summary>
    public static readonly Coding Requested = new Coding
    {
      Code = "requested",
      Display = "Requested",
      System = "http://hl7.org/fhir/subscription-status"
    };
  };
}
