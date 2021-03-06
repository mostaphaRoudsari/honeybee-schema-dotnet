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
    /// Used to describe the daily schedule for a single simulation day.
    /// </summary>
    [DataContract]
    public partial class ScheduleDay : IDdEnergyBaseModel, IEquatable<ScheduleDay>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDay" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleDay() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDay" /> class.
        /// </summary>
        /// <param name="values">A list of floats or integers for the values of the schedule. The length of this list must match the length of the times list. (required).</param>
        /// <param name="times">A list of lists with each sub-list possesing 2 values for [hour, minute]. The length of the master list must match the length of the values list. Each time in the master list represents the time of day that the corresponding value begins to take effect. For example [(0,0), (9,0), (17,0)] in combination with the values [0, 1, 0] denotes a schedule value of 0 from 0:00 to 9:00, a value of 1 from 9:00 to 17:00 and 0 from 17:00 to the end of the day. Note that this representation of times as the \&quot;time of beginning\&quot; is a different convention than EnergyPlus, which uses \&quot;time until\&quot;..</param>
        /// <param name="interpolate">Boolean to note whether values in between times should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corrsponding to them. (default to false).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public ScheduleDay
        (
            string identifier, List<double> values, // Required parameters
            List<List<int>> times= default, bool interpolate = false, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            // to ensure "values" is required (not null)
            if (values == null)
            {
                throw new InvalidDataException("values is a required property for ScheduleDay and cannot be null");
            }
            else
            {
                this.Values = values;
            }
            
            this.Times = times;
            // use default value if no "interpolate" provided
            if (interpolate == null)
            {
                this.Interpolate = false;
            }
            else
            {
                this.Interpolate = interpolate;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "ScheduleDay";
        }
        
        /// <summary>
        /// A list of floats or integers for the values of the schedule. The length of this list must match the length of the times list.
        /// </summary>
        /// <value>A list of floats or integers for the values of the schedule. The length of this list must match the length of the times list.</value>
        [DataMember(Name="values", EmitDefaultValue=false)]
        [JsonProperty("values")]
        public List<double> Values { get; set; }
        /// <summary>
        /// A list of lists with each sub-list possesing 2 values for [hour, minute]. The length of the master list must match the length of the values list. Each time in the master list represents the time of day that the corresponding value begins to take effect. For example [(0,0), (9,0), (17,0)] in combination with the values [0, 1, 0] denotes a schedule value of 0 from 0:00 to 9:00, a value of 1 from 9:00 to 17:00 and 0 from 17:00 to the end of the day. Note that this representation of times as the \&quot;time of beginning\&quot; is a different convention than EnergyPlus, which uses \&quot;time until\&quot;.
        /// </summary>
        /// <value>A list of lists with each sub-list possesing 2 values for [hour, minute]. The length of the master list must match the length of the values list. Each time in the master list represents the time of day that the corresponding value begins to take effect. For example [(0,0), (9,0), (17,0)] in combination with the values [0, 1, 0] denotes a schedule value of 0 from 0:00 to 9:00, a value of 1 from 9:00 to 17:00 and 0 from 17:00 to the end of the day. Note that this representation of times as the \&quot;time of beginning\&quot; is a different convention than EnergyPlus, which uses \&quot;time until\&quot;.</value>
        [DataMember(Name="times", EmitDefaultValue=false)]
        [JsonProperty("times")]
        public List<List<int>> Times { get; set; }
        /// <summary>
        /// Boolean to note whether values in between times should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corrsponding to them.
        /// </summary>
        /// <value>Boolean to note whether values in between times should be linearly interpolated or whether successive values should take effect immediately upon the beginning time corrsponding to them.</value>
        [DataMember(Name="interpolate", EmitDefaultValue=false)]
        [JsonProperty("interpolate")]
        public bool Interpolate { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"ScheduleDay {iDd.Identifier}";
       
            return "ScheduleDay";
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
            sb.Append("ScheduleDay:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Times: ").Append(Times).Append("\n");
            sb.Append("  Interpolate: ").Append(Interpolate).Append("\n");
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
        /// <returns>ScheduleDay object</returns>
        public static ScheduleDay FromJson(string json)
        {
            return JsonConvert.DeserializeObject<ScheduleDay>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduleDay);
        }

        /// <summary>
        /// Returns true if ScheduleDay instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduleDay to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduleDay input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Times == input.Times ||
                    this.Times != null &&
                    input.Times != null &&
                    this.Times.SequenceEqual(input.Times)
                ) && base.Equals(input) && 
                (
                    this.Interpolate == input.Interpolate ||
                    (this.Interpolate != null &&
                    this.Interpolate.Equals(input.Interpolate))
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
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Times != null)
                    hashCode = hashCode * 59 + this.Times.GetHashCode();
                if (this.Interpolate != null)
                    hashCode = hashCode * 59 + this.Interpolate.GetHashCode();
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
            Regex regexType = new Regex(@"^ScheduleDay$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
