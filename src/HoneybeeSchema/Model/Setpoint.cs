/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.25.5
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
    /// Used to specify information about the setpoint schedule.
    /// </summary>
    [DataContract]
    public partial class Setpoint : IDdEnergyBaseModel, IEquatable<Setpoint>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="Setpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Setpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Setpoint" /> class.
        /// </summary>
        /// <param name="coolingSchedule">Schedule for the cooling setpoint. The values in this schedule should be temperature in [C]..</param>
        /// <param name="heatingSchedule">Schedule for the heating setpoint. The values in this schedule should be temperature in [C]..</param>
        /// <param name="humidifyingSchedule">Schedule for the humidification setpoint. The values in this schedule should be in [%]..</param>
        /// <param name="dehumidifyingSchedule">Schedule for the dehumidification setpoint. The values in this schedule should be in [%]..</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public Setpoint
        (
            string identifier, // Required parameters
            AnyOf<ScheduleRuleset,ScheduleFixedInterval> coolingSchedule= default, AnyOf<ScheduleRuleset,ScheduleFixedInterval> heatingSchedule= default, AnyOf<ScheduleRuleset,ScheduleFixedInterval> humidifyingSchedule= default, AnyOf<ScheduleRuleset,ScheduleFixedInterval> dehumidifyingSchedule= default, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.CoolingSchedule = coolingSchedule;
            this.HeatingSchedule = heatingSchedule;
            this.HumidifyingSchedule = humidifyingSchedule;
            this.DehumidifyingSchedule = dehumidifyingSchedule;

            // Set non-required readonly properties with defaultValue
            this.Type = "Setpoint";
        }
        
        /// <summary>
        /// Schedule for the cooling setpoint. The values in this schedule should be temperature in [C].
        /// </summary>
        /// <value>Schedule for the cooling setpoint. The values in this schedule should be temperature in [C].</value>
        [DataMember(Name="cooling_schedule", EmitDefaultValue=false)]
        [JsonProperty("cooling_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> CoolingSchedule { get; set; }
        /// <summary>
        /// Schedule for the heating setpoint. The values in this schedule should be temperature in [C].
        /// </summary>
        /// <value>Schedule for the heating setpoint. The values in this schedule should be temperature in [C].</value>
        [DataMember(Name="heating_schedule", EmitDefaultValue=false)]
        [JsonProperty("heating_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> HeatingSchedule { get; set; }
        /// <summary>
        /// Schedule for the humidification setpoint. The values in this schedule should be in [%].
        /// </summary>
        /// <value>Schedule for the humidification setpoint. The values in this schedule should be in [%].</value>
        [DataMember(Name="humidifying_schedule", EmitDefaultValue=false)]
        [JsonProperty("humidifying_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> HumidifyingSchedule { get; set; }
        /// <summary>
        /// Schedule for the dehumidification setpoint. The values in this schedule should be in [%].
        /// </summary>
        /// <value>Schedule for the dehumidification setpoint. The values in this schedule should be in [%].</value>
        [DataMember(Name="dehumidifying_schedule", EmitDefaultValue=false)]
        [JsonProperty("dehumidifying_schedule")]
        public AnyOf<ScheduleRuleset,ScheduleFixedInterval> DehumidifyingSchedule { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"Setpoint {iDd.Identifier}";
       
            return "Setpoint";
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
            sb.Append("Setpoint:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CoolingSchedule: ").Append(CoolingSchedule).Append("\n");
            sb.Append("  HeatingSchedule: ").Append(HeatingSchedule).Append("\n");
            sb.Append("  HumidifyingSchedule: ").Append(HumidifyingSchedule).Append("\n");
            sb.Append("  DehumidifyingSchedule: ").Append(DehumidifyingSchedule).Append("\n");
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
        /// <returns>Setpoint object</returns>
        public static Setpoint FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Setpoint>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Setpoint);
        }

        /// <summary>
        /// Returns true if Setpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of Setpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Setpoint input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CoolingSchedule == input.CoolingSchedule ||
                    (this.CoolingSchedule != null &&
                    this.CoolingSchedule.Equals(input.CoolingSchedule))
                ) && base.Equals(input) && 
                (
                    this.HeatingSchedule == input.HeatingSchedule ||
                    (this.HeatingSchedule != null &&
                    this.HeatingSchedule.Equals(input.HeatingSchedule))
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.HumidifyingSchedule == input.HumidifyingSchedule ||
                    (this.HumidifyingSchedule != null &&
                    this.HumidifyingSchedule.Equals(input.HumidifyingSchedule))
                ) && base.Equals(input) && 
                (
                    this.DehumidifyingSchedule == input.DehumidifyingSchedule ||
                    (this.DehumidifyingSchedule != null &&
                    this.DehumidifyingSchedule.Equals(input.DehumidifyingSchedule))
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
                if (this.CoolingSchedule != null)
                    hashCode = hashCode * 59 + this.CoolingSchedule.GetHashCode();
                if (this.HeatingSchedule != null)
                    hashCode = hashCode * 59 + this.HeatingSchedule.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.HumidifyingSchedule != null)
                    hashCode = hashCode * 59 + this.HumidifyingSchedule.GetHashCode();
                if (this.DehumidifyingSchedule != null)
                    hashCode = hashCode * 59 + this.DehumidifyingSchedule.GetHashCode();
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
            Regex regexType = new Regex(@"^Setpoint$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
