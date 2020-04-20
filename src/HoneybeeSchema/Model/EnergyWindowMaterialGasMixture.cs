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
    /// Create a mixture of two to four different gases to fill the panes of multiple pane windows.
    /// </summary>
    [DataContract]
    public partial class EnergyWindowMaterialGasMixture : IDdEnergyBaseModel, IEquatable<EnergyWindowMaterialGasMixture>, IValidatableObject
    {

        /// <summary>
        /// Defines GasTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GasTypesEnum
        {
            /// <summary>
            /// Enum Air for value: Air
            /// </summary>
            [EnumMember(Value = "Air")]
            Air = 1,

            /// <summary>
            /// Enum Argon for value: Argon
            /// </summary>
            [EnumMember(Value = "Argon")]
            Argon = 2,

            /// <summary>
            /// Enum Krypton for value: Krypton
            /// </summary>
            [EnumMember(Value = "Krypton")]
            Krypton = 3,

            /// <summary>
            /// Enum Xenon for value: Xenon
            /// </summary>
            [EnumMember(Value = "Xenon")]
            Xenon = 4

        }


        /// <summary>
        /// List of gases in the gas mixture.
        /// </summary>
        /// <value>List of gases in the gas mixture.</value>
        [DataMember(Name="gas_types", EmitDefaultValue=false)]
        public List<GasTypesEnum> GasTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGasMixture" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialGasMixture() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialGasMixture" /> class.
        /// </summary>
        /// <param name="gasTypes">List of gases in the gas mixture..</param>
        /// <param name="gasFractions">A list of fractional numbers describing the volumetric fractions of gas types in the mixture. This list must align with the gas_types list and must sum to 1..</param>
        /// <param name="thickness">The thickness of the gas mixture layer in meters. (default to 0.0125D).</param>
        /// <param name="identifier">Text string for a unique object ID. This identifier remains constant as the object is mutated, copied, and serialized to different formats (eg. dict, idf, osm). This identifier is also used to reference the object across a Model. It must be &lt; 100 characters, use only ASCII characters and exclude (, ; ! \\n \\t). (required).</param>
        /// <param name="displayName">Display name of the object with no character restrictions..</param>
        public EnergyWindowMaterialGasMixture
        (
            string identifier, // Required parameters
            List<GasTypesEnum> gasTypes= default, List<double> gasFractions= default, double thickness = 0.0125D, string displayName= default// Optional parameters
        ) : base(identifier: identifier, displayName: displayName )// BaseClass
        {
            this.GasTypes = gasTypes;
            this.GasFractions = gasFractions;
            // use default value if no "thickness" provided
            if (thickness == null)
            {
                this.Thickness = 0.0125D;
            }
            else
            {
                this.Thickness = thickness;
            }

            // Set non-required readonly properties with defaultValue
            this.Type = "EnergyWindowMaterialGasMixture";
        }
        
        /// <summary>
        /// A list of fractional numbers describing the volumetric fractions of gas types in the mixture. This list must align with the gas_types list and must sum to 1.
        /// </summary>
        /// <value>A list of fractional numbers describing the volumetric fractions of gas types in the mixture. This list must align with the gas_types list and must sum to 1.</value>
        [DataMember(Name="gas_fractions", EmitDefaultValue=false)]
        [JsonProperty("gas_fractions")]
        public List<double> GasFractions { get; set; }
        /// <summary>
        /// The thickness of the gas mixture layer in meters.
        /// </summary>
        /// <value>The thickness of the gas mixture layer in meters.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        [JsonProperty("thickness")]
        public double Thickness { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            if (this is IIDdBase iDd)
                return $"EnergyWindowMaterialGasMixture {iDd.Identifier}";
       
            return "EnergyWindowMaterialGasMixture";
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
            sb.Append("EnergyWindowMaterialGasMixture:\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  GasTypes: ").Append(GasTypes).Append("\n");
            sb.Append("  GasFractions: ").Append(GasFractions).Append("\n");
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
        /// <returns>EnergyWindowMaterialGasMixture object</returns>
        public static EnergyWindowMaterialGasMixture FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyWindowMaterialGasMixture>(json, new AnyOfJsonConverter());
        }
     

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyWindowMaterialGasMixture);
        }

        /// <summary>
        /// Returns true if EnergyWindowMaterialGasMixture instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyWindowMaterialGasMixture to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyWindowMaterialGasMixture input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.GasTypes == input.GasTypes ||
                    this.GasTypes != null &&
                    input.GasTypes != null &&
                    this.GasTypes.SequenceEqual(input.GasTypes)
                ) && base.Equals(input) && 
                (
                    this.GasFractions == input.GasFractions ||
                    this.GasFractions != null &&
                    input.GasFractions != null &&
                    this.GasFractions.SequenceEqual(input.GasFractions)
                ) && base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Thickness == input.Thickness ||
                    (this.Thickness != null &&
                    this.Thickness.Equals(input.Thickness))
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
                if (this.GasTypes != null)
                    hashCode = hashCode * 59 + this.GasTypes.GetHashCode();
                if (this.GasFractions != null)
                    hashCode = hashCode * 59 + this.GasFractions.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Thickness != null)
                    hashCode = hashCode * 59 + this.Thickness.GetHashCode();
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
            Regex regexType = new Regex(@"^EnergyWindowMaterialGasMixture$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }

}
