/* 
 * Honeybee Energy Simulation Parameter Schema
 *
 * This is the documentation for Honeybee energy simulation parameter schema.
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
    /// Used to specify heating and cooling sizing criteria and safety factors.
    /// </summary>
    [DataContract]
    public partial class SizingParameter : HoneybeeObject, IEquatable<SizingParameter>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="SizingParameter" /> class.
        /// </summary>
        /// <param name="designDays">A list of DesignDays that represent the criteria for which the HVAC systems will be sized..</param>
        /// <param name="heatingFactor">A number that will be multiplied by the peak heating load for each zone in order to size the heating system. (default to 1.25D).</param>
        /// <param name="coolingFactor">A number that will be multiplied by the peak cooling load for each zone in order to size the heating system. (default to 1.15D).</param>
        public SizingParameter
        ( // Required parameters
            List<DesignDay> designDays= default, double heatingFactor = 1.25D, double coolingFactor = 1.15D// Optional parameters
        )// BaseClass
        {
            this.DesignDays = designDays;
            // use default value if no "heatingFactor" provided
            if (heatingFactor == null)
            {
                this.HeatingFactor = 1.25D;
            }
            else
            {
                this.HeatingFactor = heatingFactor;
            }
            // use default value if no "coolingFactor" provided
            if (coolingFactor == null)
            {
                this.CoolingFactor = 1.15D;
            }
            else
            {
                this.CoolingFactor = coolingFactor;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "SizingParameter";
        }
        
        /// <summary>
        /// A list of DesignDays that represent the criteria for which the HVAC systems will be sized.
        /// </summary>
        /// <value>A list of DesignDays that represent the criteria for which the HVAC systems will be sized.</value>
        [DataMember(Name="design_days", EmitDefaultValue=false)]
        [JsonProperty("design_days")]
        public List<DesignDay> DesignDays { get; set; }
        /// <summary>
        /// A number that will be multiplied by the peak heating load for each zone in order to size the heating system.
        /// </summary>
        /// <value>A number that will be multiplied by the peak heating load for each zone in order to size the heating system.</value>
        [DataMember(Name="heating_factor", EmitDefaultValue=false)]
        [JsonProperty("heating_factor")]
        public double HeatingFactor { get; set; }
        /// <summary>
        /// A number that will be multiplied by the peak cooling load for each zone in order to size the heating system.
        /// </summary>
        /// <value>A number that will be multiplied by the peak cooling load for each zone in order to size the heating system.</value>
        [DataMember(Name="cooling_factor", EmitDefaultValue=false)]
        [JsonProperty("cooling_factor")]
        public double CoolingFactor { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"SizingParameter {iDd.Identifier}";
       
            return "SizingParameter";
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
            sb.Append("SizingParameter:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DesignDays: ").Append(DesignDays).Append("\n");
            sb.Append("  HeatingFactor: ").Append(HeatingFactor).Append("\n");
            sb.Append("  CoolingFactor: ").Append(CoolingFactor).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented, new AnyOfJsonConverter());
        }

        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>SizingParameter object</returns>
        public static SizingParameter FromJson(string json)
        {
            return JsonConvert.DeserializeObject<SizingParameter>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SizingParameter);
        }

        /// <summary>
        /// Returns true if SizingParameter instances are equal
        /// </summary>
        /// <param name="input">Instance of SizingParameter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SizingParameter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DesignDays == input.DesignDays ||
                    this.DesignDays != null &&
                    input.DesignDays != null &&
                    this.DesignDays.SequenceEqual(input.DesignDays)
                ) && 
                (
                    this.HeatingFactor == input.HeatingFactor ||
                    (this.HeatingFactor != null &&
                    this.HeatingFactor.Equals(input.HeatingFactor))
                ) && 
                (
                    this.CoolingFactor == input.CoolingFactor ||
                    (this.CoolingFactor != null &&
                    this.CoolingFactor.Equals(input.CoolingFactor))
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
                int hashCode = 41;
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DesignDays != null)
                    hashCode = hashCode * 59 + this.DesignDays.GetHashCode();
                if (this.HeatingFactor != null)
                    hashCode = hashCode * 59 + this.HeatingFactor.GetHashCode();
                if (this.CoolingFactor != null)
                    hashCode = hashCode * 59 + this.CoolingFactor.GetHashCode();
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
            // Type (string) pattern
            Regex regexType = new Regex(@"^SizingParameter$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
