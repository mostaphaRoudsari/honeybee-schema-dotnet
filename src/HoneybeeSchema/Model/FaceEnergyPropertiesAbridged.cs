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
    /// Base class for all objects that are not extensible with additional keys.  This effectively includes all objects except for the Properties classes that are assigned to geometry objects.
    /// </summary>
    [DataContract]
    public partial class FaceEnergyPropertiesAbridged : HoneybeeObject, IEquatable<FaceEnergyPropertiesAbridged>, IValidatableObject
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="FaceEnergyPropertiesAbridged" /> class.
        /// </summary>
        /// <param name="construction">Identifier of an OpaqueConstruction for the Face. If None, the construction is set by the parent Room construction_set or the Model global_construction_set..</param>
        public FaceEnergyPropertiesAbridged
        (
            // Required parameters
            string construction= default// Optional parameters
        )// BaseClass
        {
            this.Construction = construction;

            // Set non-required readonly properties with defaultValue
            this.Type = "FaceEnergyPropertiesAbridged";
        }
        
        /// <summary>
        /// Identifier of an OpaqueConstruction for the Face. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.
        /// </summary>
        /// <value>Identifier of an OpaqueConstruction for the Face. If None, the construction is set by the parent Room construction_set or the Model global_construction_set.</value>
        [DataMember(Name="construction", EmitDefaultValue=false)]
        [JsonProperty("construction")]
        public string Construction { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"FaceEnergyPropertiesAbridged {iDd.Identifier}";
       
            return "FaceEnergyPropertiesAbridged";
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
            sb.Append("FaceEnergyPropertiesAbridged:\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Construction: ").Append(Construction).Append("\n");
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
        /// <returns>FaceEnergyPropertiesAbridged object</returns>
        public static FaceEnergyPropertiesAbridged FromJson(string json)
        {
            return JsonConvert.DeserializeObject<FaceEnergyPropertiesAbridged>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FaceEnergyPropertiesAbridged);
        }

        /// <summary>
        /// Returns true if FaceEnergyPropertiesAbridged instances are equal
        /// </summary>
        /// <param name="input">Instance of FaceEnergyPropertiesAbridged to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaceEnergyPropertiesAbridged input)
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
                    this.Construction == input.Construction ||
                    (this.Construction != null &&
                    this.Construction.Equals(input.Construction))
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
                if (this.Construction != null)
                    hashCode = hashCode * 59 + this.Construction.GetHashCode();
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
            Regex regexType = new Regex(@"^FaceEnergyPropertiesAbridged$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // Construction (string) maxLength
            if(this.Construction != null && this.Construction.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be less than 100.", new [] { "Construction" });
            }

            // Construction (string) minLength
            if(this.Construction != null && this.Construction.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Construction, length must be greater than 1.", new [] { "Construction" });
            }

            yield break;
        }
    }

}
