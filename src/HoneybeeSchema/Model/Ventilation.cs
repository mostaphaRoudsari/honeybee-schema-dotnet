/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.27.1
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace HoneybeeSchema
{
    /// <summary>
    /// Base class for all objects requiring a valid EnergyPlus identifier.
    /// </summary>
    [DataContract]
    public partial class Ventilation : IDdEnergyBaseModel, IEquatable<Ventilation>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Ventilation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Ventilation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Ventilation" /> class.
        /// </summary>
        /// <param name="flowPerPerson">Intensity of ventilation in[] m3/s per person]. Note that setting this value does not mean that ventilation is varied based on real-time occupancy but rather that the design level of ventilation is determined using this value and the People object of the Room. (default to 0D).</param>
        /// <param name="flowPerArea">Intensity of ventilation in [m3/s per m2 of floor area]. (default to 0D).</param>
        /// <param name="airChangesPerHour">Intensity of ventilation in air changes per hour (ACH) for the entire Room. (default to 0D).</param>
        /// <param name="flowPerZone">Intensity of ventilation in m3/s for the entire Room. (default to 0D).</param>
        /// <param name="schedule">Schedule for the ventilation over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the total design flow rate (determined from the sum of the other 4 fields) to yield a complete ventilation profile..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Ventilation
        (
            string identifier, // Required parameters
            double flowPerPerson = 0D, double flowPerArea = 0D, double airChangesPerHour = 0D, double flowPerZone = 0D, AnyOf<ScheduleRuleset,ScheduleFixedInterval> schedule= default, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // use default value if no "flowPerPerson" provided
            if (flowPerPerson == null)
            {
                this.FlowPerPerson = 0D;
            }
            else
            {
                this.FlowPerPerson = flowPerPerson;
            }
            // use default value if no "flowPerArea" provided
            if (flowPerArea == null)
            {
                this.FlowPerArea = 0D;
            }
            else
            {
                this.FlowPerArea = flowPerArea;
            }
            // use default value if no "airChangesPerHour" provided
            if (airChangesPerHour == null)
            {
                this.AirChangesPerHour = 0D;
            }
            else
            {
                this.AirChangesPerHour = airChangesPerHour;
            }
            // use default value if no "flowPerZone" provided
            if (flowPerZone == null)
            {
                this.FlowPerZone = 0D;
            }
            else
            {
                this.FlowPerZone = flowPerZone;
            }
            this.Schedule = schedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "Ventilation";
        }
        
        /// <summary>
        /// Intensity of ventilation in[] m3/s per person]. Note that setting this value does not mean that ventilation is varied based on real-time occupancy but rather that the design level of ventilation is determined using this value and the People object of the Room.
        /// </summary>
        /// <value>Intensity of ventilation in[] m3/s per person]. Note that setting this value does not mean that ventilation is varied based on real-time occupancy but rather that the design level of ventilation is determined using this value and the People object of the Room.</value>
        [DataMember(Name="flow_per_person", EmitDefaultValue=false)]
        [JsonProperty("flow_per_person")]
        public double FlowPerPerson { get; set; }
        /// <summary>
        /// Intensity of ventilation in [m3/s per m2 of floor area].
        /// </summary>
        /// <value>Intensity of ventilation in [m3/s per m2 of floor area].</value>
        [DataMember(Name="flow_per_area", EmitDefaultValue=false)]
        [JsonProperty("flow_per_area")]
        public double FlowPerArea { get; set; }
        /// <summary>
        /// Intensity of ventilation in air changes per hour (ACH) for the entire Room.
        /// </summary>
        /// <value>Intensity of ventilation in air changes per hour (ACH) for the entire Room.</value>
        [DataMember(Name="air_changes_per_hour", EmitDefaultValue=false)]
        [JsonProperty("air_changes_per_hour")]
        public double AirChangesPerHour { get; set; }
        /// <summary>
        /// Intensity of ventilation in m3/s for the entire Room.
        /// </summary>
        /// <value>Intensity of ventilation in m3/s for the entire Room.</value>
        [DataMember(Name="flow_per_zone", EmitDefaultValue=false)]
        [JsonProperty("flow_per_zone")]
        public double FlowPerZone { get; set; }
        /// <summary>
        /// Schedule for the ventilation over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the total design flow rate (determined from the sum of the other 4 fields) to yield a complete ventilation profile.
        /// </summary>
        /// <value>Schedule for the ventilation over the course of the year. The type of this schedule should be Fractional and the fractional values will get multiplied by the total design flow rate (determined from the sum of the other 4 fields) to yield a complete ventilation profile.</value>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        [JsonProperty("schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> Schedule { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Ventilation {iDd.Identifier}";
       
            return "Ventilation";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public string ToString(bool detailed)
        {
            if (detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("Ventilation:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FlowPerPerson: ").Append(FlowPerPerson).Append("\n");
            sb.Append("  FlowPerArea: ").Append(FlowPerArea).Append("\n");
            sb.Append("  AirChangesPerHour: ").Append(AirChangesPerHour).Append("\n");
            sb.Append("  FlowPerZone: ").Append(FlowPerZone).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Ventilation object</returns>
        public static Ventilation FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Ventilation>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Ventilation);
        }

        /// <summary>
        /// Returns true if Ventilation instances are equal
        /// </summary>
        /// <param name="input">Instance of Ventilation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ventilation input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.FlowPerPerson == input.FlowPerPerson ||
                    (this.FlowPerPerson != null &&
                    this.FlowPerPerson.Equals(input.FlowPerPerson))
                ) && base.Equals(input) && 
                (
                    this.FlowPerArea == input.FlowPerArea ||
                    (this.FlowPerArea != null &&
                    this.FlowPerArea.Equals(input.FlowPerArea))
                ) && base.Equals(input) && 
                (
                    this.AirChangesPerHour == input.AirChangesPerHour ||
                    (this.AirChangesPerHour != null &&
                    this.AirChangesPerHour.Equals(input.AirChangesPerHour))
                ) && base.Equals(input) && 
                (
                    this.FlowPerZone == input.FlowPerZone ||
                    (this.FlowPerZone != null &&
                    this.FlowPerZone.Equals(input.FlowPerZone))
                ) && base.Equals(input) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FlowPerPerson != null)
                    hashCode = hashCode * 59 + this.FlowPerPerson.GetHashCode();
                if (this.FlowPerArea != null)
                    hashCode = hashCode * 59 + this.FlowPerArea.GetHashCode();
                if (this.AirChangesPerHour != null)
                    hashCode = hashCode * 59 + this.AirChangesPerHour.GetHashCode();
                if (this.FlowPerZone != null)
                    hashCode = hashCode * 59 + this.FlowPerZone.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;
            // Type (string) pattern
            Regex regexType = new Regex(@"^Ventilation$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // FlowPerPerson (double) minimum
            if(this.FlowPerPerson < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlowPerPerson, must be a value greater than or equal to 0.", new [] { "FlowPerPerson" });
            }

            // FlowPerArea (double) minimum
            if(this.FlowPerArea < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlowPerArea, must be a value greater than or equal to 0.", new [] { "FlowPerArea" });
            }

            // AirChangesPerHour (double) minimum
            if(this.AirChangesPerHour < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirChangesPerHour, must be a value greater than or equal to 0.", new [] { "AirChangesPerHour" });
            }

            // FlowPerZone (double) minimum
            if(this.FlowPerZone < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FlowPerZone, must be a value greater than or equal to 0.", new [] { "FlowPerZone" });
            }

            yield break;
        }
    }

}
