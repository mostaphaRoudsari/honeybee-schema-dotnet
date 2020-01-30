/* 
 * Honeybee Model Schema
 *
 * This is the documentation for Honeybee model schema.
 *
 * The version of the OpenAPI document: 1.3.0
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
using OpenAPIDateConverter = HoneybeeDotNet.Client.OpenAPIDateConverter;

namespace HoneybeeDotNet.Model
{
    /// <summary>
    /// This object specifies the properties of window shade materials.
    /// </summary>
    [DataContract]
    public partial class EnergyWindowMaterialShade :  IEquatable<EnergyWindowMaterialShade>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialShade" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnergyWindowMaterialShade() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnergyWindowMaterialShade" /> class.
        /// </summary>
        /// <param name="name">Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters. (required).</param>
        /// <param name="type">type (default to &quot;EnergyWindowMaterialShade&quot;).</param>
        /// <param name="solarTransmittance">The transmittance averaged over the solar spectrum. It is assumed independent of incidence angle. Default value is 0.4. (default to 0.4).</param>
        /// <param name="solarReflectance">The reflectance averaged over the solar spectrum. It us assumed same on both sides of shade and independent of incidence angle. Default value is 0.5 (default to 0.5).</param>
        /// <param name="visibleTransmittance">The transmittance averaged over the solar spectrum and weighted by the response of the human eye. It is assumed independent of incidence angle. Default value is 0.4. (default to 0.4).</param>
        /// <param name="visibleReflectance">The transmittance averaged over the solar spectrum and weighted by the response of the human eye. It is assumed independent of incidence angle. Default value is 0.4 (default to 0.4).</param>
        /// <param name="emissivity">The effective long-wave infrared hemispherical emissivity. It is assumed same on both sides of shade. Default value is 0.9. (default to 0.9).</param>
        /// <param name="infraredTransmittance">The effective long-wave transmittance. It is assumed independent of incidence angle. Default value is 0. (default to 0).</param>
        /// <param name="thickness">The thickness of the shade material in meters. Default value is 0.005. (default to 0.005).</param>
        /// <param name="conductivity">The conductivity of the shade material in W/(m-K). Default value is 0.1. (default to 0.1).</param>
        /// <param name="distanceToGlass">The distance from shade to adjacent glass in meters. Default value is 0.05 (default to 0.05).</param>
        /// <param name="topOpeningMultiplier">The effective area for air flow at the top of the shade, divided by the horizontal area between glass and shade. Default value is 0.5. (default to 0.5).</param>
        /// <param name="bottomOpeningMultiplier">The effective area for air flow at the bottom of the shade, divided by the horizontal area between glass and shade. Default value is 0.5. (default to 0.5).</param>
        /// <param name="leftOpeningMultiplier">The effective area for air flow at the left side of the shade, divided by the vertical area between glass and shade. Default value is 0.5. (default to 0.5).</param>
        /// <param name="rightOpeningMultiplier">The effective area for air flow at the right side of the shade, divided by the vertical area between glass and shade. Default value is 0.5. (default to 0.5).</param>
        /// <param name="airflowPermeability">The fraction of the shade surface that is open to air flow. If air cannot pass through the shade material, airflow_permeability &#x3D; 0. Default value is 0. (default to 0).</param>
        public EnergyWindowMaterialShade(string name, string type = "EnergyWindowMaterialShade", double solarTransmittance = 0.4, double solarReflectance = 0.5, double visibleTransmittance = 0.4, double visibleReflectance = 0.4, double emissivity = 0.9, double infraredTransmittance = 0, double thickness = 0.005, double conductivity = 0.1, double distanceToGlass = 0.05, double topOpeningMultiplier = 0.5, double bottomOpeningMultiplier = 0.5, double leftOpeningMultiplier = 0.5, double rightOpeningMultiplier = 0.5, double airflowPermeability = 0)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for EnergyWindowMaterialShade and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // use default value if no "type" provided
            if (type == null)
            {
                this.Type = "EnergyWindowMaterialShade";
            }
            else
            {
                this.Type = type;
            }
            // use default value if no "solarTransmittance" provided
            if (solarTransmittance == null)
            {
                this.SolarTransmittance = 0.4;
            }
            else
            {
                this.SolarTransmittance = solarTransmittance;
            }
            // use default value if no "solarReflectance" provided
            if (solarReflectance == null)
            {
                this.SolarReflectance = 0.5;
            }
            else
            {
                this.SolarReflectance = solarReflectance;
            }
            // use default value if no "visibleTransmittance" provided
            if (visibleTransmittance == null)
            {
                this.VisibleTransmittance = 0.4;
            }
            else
            {
                this.VisibleTransmittance = visibleTransmittance;
            }
            // use default value if no "visibleReflectance" provided
            if (visibleReflectance == null)
            {
                this.VisibleReflectance = 0.4;
            }
            else
            {
                this.VisibleReflectance = visibleReflectance;
            }
            // use default value if no "emissivity" provided
            if (emissivity == null)
            {
                this.Emissivity = 0.9;
            }
            else
            {
                this.Emissivity = emissivity;
            }
            // use default value if no "infraredTransmittance" provided
            if (infraredTransmittance == null)
            {
                this.InfraredTransmittance = 0;
            }
            else
            {
                this.InfraredTransmittance = infraredTransmittance;
            }
            // use default value if no "thickness" provided
            if (thickness == null)
            {
                this.Thickness = 0.005;
            }
            else
            {
                this.Thickness = thickness;
            }
            // use default value if no "conductivity" provided
            if (conductivity == null)
            {
                this.Conductivity = 0.1;
            }
            else
            {
                this.Conductivity = conductivity;
            }
            // use default value if no "distanceToGlass" provided
            if (distanceToGlass == null)
            {
                this.DistanceToGlass = 0.05;
            }
            else
            {
                this.DistanceToGlass = distanceToGlass;
            }
            // use default value if no "topOpeningMultiplier" provided
            if (topOpeningMultiplier == null)
            {
                this.TopOpeningMultiplier = 0.5;
            }
            else
            {
                this.TopOpeningMultiplier = topOpeningMultiplier;
            }
            // use default value if no "bottomOpeningMultiplier" provided
            if (bottomOpeningMultiplier == null)
            {
                this.BottomOpeningMultiplier = 0.5;
            }
            else
            {
                this.BottomOpeningMultiplier = bottomOpeningMultiplier;
            }
            // use default value if no "leftOpeningMultiplier" provided
            if (leftOpeningMultiplier == null)
            {
                this.LeftOpeningMultiplier = 0.5;
            }
            else
            {
                this.LeftOpeningMultiplier = leftOpeningMultiplier;
            }
            // use default value if no "rightOpeningMultiplier" provided
            if (rightOpeningMultiplier == null)
            {
                this.RightOpeningMultiplier = 0.5;
            }
            else
            {
                this.RightOpeningMultiplier = rightOpeningMultiplier;
            }
            // use default value if no "airflowPermeability" provided
            if (airflowPermeability == null)
            {
                this.AirflowPermeability = 0;
            }
            else
            {
                this.AirflowPermeability = airflowPermeability;
            }
        }
        
        /// <summary>
        /// Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.
        /// </summary>
        /// <value>Name of the object. Must use only ASCII characters and exclude (, ; ! \\n \\t). It cannot be longer than 100 characters.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The transmittance averaged over the solar spectrum. It is assumed independent of incidence angle. Default value is 0.4.
        /// </summary>
        /// <value>The transmittance averaged over the solar spectrum. It is assumed independent of incidence angle. Default value is 0.4.</value>
        [DataMember(Name="solar_transmittance", EmitDefaultValue=false)]
        [JsonProperty("solar_transmittance")]
        public double SolarTransmittance { get; set; }

        /// <summary>
        /// The reflectance averaged over the solar spectrum. It us assumed same on both sides of shade and independent of incidence angle. Default value is 0.5
        /// </summary>
        /// <value>The reflectance averaged over the solar spectrum. It us assumed same on both sides of shade and independent of incidence angle. Default value is 0.5</value>
        [DataMember(Name="solar_reflectance", EmitDefaultValue=false)]
        [JsonProperty("solar_reflectance")]
        public double SolarReflectance { get; set; }

        /// <summary>
        /// The transmittance averaged over the solar spectrum and weighted by the response of the human eye. It is assumed independent of incidence angle. Default value is 0.4.
        /// </summary>
        /// <value>The transmittance averaged over the solar spectrum and weighted by the response of the human eye. It is assumed independent of incidence angle. Default value is 0.4.</value>
        [DataMember(Name="visible_transmittance", EmitDefaultValue=false)]
        [JsonProperty("visible_transmittance")]
        public double VisibleTransmittance { get; set; }

        /// <summary>
        /// The transmittance averaged over the solar spectrum and weighted by the response of the human eye. It is assumed independent of incidence angle. Default value is 0.4
        /// </summary>
        /// <value>The transmittance averaged over the solar spectrum and weighted by the response of the human eye. It is assumed independent of incidence angle. Default value is 0.4</value>
        [DataMember(Name="visible_reflectance", EmitDefaultValue=false)]
        [JsonProperty("visible_reflectance")]
        public double VisibleReflectance { get; set; }

        /// <summary>
        /// The effective long-wave infrared hemispherical emissivity. It is assumed same on both sides of shade. Default value is 0.9.
        /// </summary>
        /// <value>The effective long-wave infrared hemispherical emissivity. It is assumed same on both sides of shade. Default value is 0.9.</value>
        [DataMember(Name="emissivity", EmitDefaultValue=false)]
        [JsonProperty("emissivity")]
        public double Emissivity { get; set; }

        /// <summary>
        /// The effective long-wave transmittance. It is assumed independent of incidence angle. Default value is 0.
        /// </summary>
        /// <value>The effective long-wave transmittance. It is assumed independent of incidence angle. Default value is 0.</value>
        [DataMember(Name="infrared_transmittance", EmitDefaultValue=false)]
        [JsonProperty("infrared_transmittance")]
        public double InfraredTransmittance { get; set; }

        /// <summary>
        /// The thickness of the shade material in meters. Default value is 0.005.
        /// </summary>
        /// <value>The thickness of the shade material in meters. Default value is 0.005.</value>
        [DataMember(Name="thickness", EmitDefaultValue=false)]
        [JsonProperty("thickness")]
        public double Thickness { get; set; }

        /// <summary>
        /// The conductivity of the shade material in W/(m-K). Default value is 0.1.
        /// </summary>
        /// <value>The conductivity of the shade material in W/(m-K). Default value is 0.1.</value>
        [DataMember(Name="conductivity", EmitDefaultValue=false)]
        [JsonProperty("conductivity")]
        public double Conductivity { get; set; }

        /// <summary>
        /// The distance from shade to adjacent glass in meters. Default value is 0.05
        /// </summary>
        /// <value>The distance from shade to adjacent glass in meters. Default value is 0.05</value>
        [DataMember(Name="distance_to_glass", EmitDefaultValue=false)]
        [JsonProperty("distance_to_glass")]
        public double DistanceToGlass { get; set; }

        /// <summary>
        /// The effective area for air flow at the top of the shade, divided by the horizontal area between glass and shade. Default value is 0.5.
        /// </summary>
        /// <value>The effective area for air flow at the top of the shade, divided by the horizontal area between glass and shade. Default value is 0.5.</value>
        [DataMember(Name="top_opening_multiplier", EmitDefaultValue=false)]
        [JsonProperty("top_opening_multiplier")]
        public double TopOpeningMultiplier { get; set; }

        /// <summary>
        /// The effective area for air flow at the bottom of the shade, divided by the horizontal area between glass and shade. Default value is 0.5.
        /// </summary>
        /// <value>The effective area for air flow at the bottom of the shade, divided by the horizontal area between glass and shade. Default value is 0.5.</value>
        [DataMember(Name="bottom_opening_multiplier", EmitDefaultValue=false)]
        [JsonProperty("bottom_opening_multiplier")]
        public double BottomOpeningMultiplier { get; set; }

        /// <summary>
        /// The effective area for air flow at the left side of the shade, divided by the vertical area between glass and shade. Default value is 0.5.
        /// </summary>
        /// <value>The effective area for air flow at the left side of the shade, divided by the vertical area between glass and shade. Default value is 0.5.</value>
        [DataMember(Name="left_opening_multiplier", EmitDefaultValue=false)]
        [JsonProperty("left_opening_multiplier")]
        public double LeftOpeningMultiplier { get; set; }

        /// <summary>
        /// The effective area for air flow at the right side of the shade, divided by the vertical area between glass and shade. Default value is 0.5.
        /// </summary>
        /// <value>The effective area for air flow at the right side of the shade, divided by the vertical area between glass and shade. Default value is 0.5.</value>
        [DataMember(Name="right_opening_multiplier", EmitDefaultValue=false)]
        [JsonProperty("right_opening_multiplier")]
        public double RightOpeningMultiplier { get; set; }

        /// <summary>
        /// The fraction of the shade surface that is open to air flow. If air cannot pass through the shade material, airflow_permeability &#x3D; 0. Default value is 0.
        /// </summary>
        /// <value>The fraction of the shade surface that is open to air flow. If air cannot pass through the shade material, airflow_permeability &#x3D; 0. Default value is 0.</value>
        [DataMember(Name="airflow_permeability", EmitDefaultValue=false)]
        [JsonProperty("airflow_permeability")]
        public double AirflowPermeability { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnergyWindowMaterialShade {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SolarTransmittance: ").Append(SolarTransmittance).Append("\n");
            sb.Append("  SolarReflectance: ").Append(SolarReflectance).Append("\n");
            sb.Append("  VisibleTransmittance: ").Append(VisibleTransmittance).Append("\n");
            sb.Append("  VisibleReflectance: ").Append(VisibleReflectance).Append("\n");
            sb.Append("  Emissivity: ").Append(Emissivity).Append("\n");
            sb.Append("  InfraredTransmittance: ").Append(InfraredTransmittance).Append("\n");
            sb.Append("  Thickness: ").Append(Thickness).Append("\n");
            sb.Append("  Conductivity: ").Append(Conductivity).Append("\n");
            sb.Append("  DistanceToGlass: ").Append(DistanceToGlass).Append("\n");
            sb.Append("  TopOpeningMultiplier: ").Append(TopOpeningMultiplier).Append("\n");
            sb.Append("  BottomOpeningMultiplier: ").Append(BottomOpeningMultiplier).Append("\n");
            sb.Append("  LeftOpeningMultiplier: ").Append(LeftOpeningMultiplier).Append("\n");
            sb.Append("  RightOpeningMultiplier: ").Append(RightOpeningMultiplier).Append("\n");
            sb.Append("  AirflowPermeability: ").Append(AirflowPermeability).Append("\n");
            sb.Append("}\n");
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
        /// <returns>EnergyWindowMaterialShade object</returns>
        public static EnergyWindowMaterialShade FromJson(string json)
        {
            return JsonConvert.DeserializeObject<EnergyWindowMaterialShade>(json, new AnyOfJsonConverter());
        }


        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnergyWindowMaterialShade);
        }

        /// <summary>
        /// Returns true if EnergyWindowMaterialShade instances are equal
        /// </summary>
        /// <param name="input">Instance of EnergyWindowMaterialShade to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnergyWindowMaterialShade input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.SolarTransmittance == input.SolarTransmittance ||
                    (this.SolarTransmittance != null &&
                    this.SolarTransmittance.Equals(input.SolarTransmittance))
                ) && 
                (
                    this.SolarReflectance == input.SolarReflectance ||
                    (this.SolarReflectance != null &&
                    this.SolarReflectance.Equals(input.SolarReflectance))
                ) && 
                (
                    this.VisibleTransmittance == input.VisibleTransmittance ||
                    (this.VisibleTransmittance != null &&
                    this.VisibleTransmittance.Equals(input.VisibleTransmittance))
                ) && 
                (
                    this.VisibleReflectance == input.VisibleReflectance ||
                    (this.VisibleReflectance != null &&
                    this.VisibleReflectance.Equals(input.VisibleReflectance))
                ) && 
                (
                    this.Emissivity == input.Emissivity ||
                    (this.Emissivity != null &&
                    this.Emissivity.Equals(input.Emissivity))
                ) && 
                (
                    this.InfraredTransmittance == input.InfraredTransmittance ||
                    (this.InfraredTransmittance != null &&
                    this.InfraredTransmittance.Equals(input.InfraredTransmittance))
                ) && 
                (
                    this.Thickness == input.Thickness ||
                    (this.Thickness != null &&
                    this.Thickness.Equals(input.Thickness))
                ) && 
                (
                    this.Conductivity == input.Conductivity ||
                    (this.Conductivity != null &&
                    this.Conductivity.Equals(input.Conductivity))
                ) && 
                (
                    this.DistanceToGlass == input.DistanceToGlass ||
                    (this.DistanceToGlass != null &&
                    this.DistanceToGlass.Equals(input.DistanceToGlass))
                ) && 
                (
                    this.TopOpeningMultiplier == input.TopOpeningMultiplier ||
                    (this.TopOpeningMultiplier != null &&
                    this.TopOpeningMultiplier.Equals(input.TopOpeningMultiplier))
                ) && 
                (
                    this.BottomOpeningMultiplier == input.BottomOpeningMultiplier ||
                    (this.BottomOpeningMultiplier != null &&
                    this.BottomOpeningMultiplier.Equals(input.BottomOpeningMultiplier))
                ) && 
                (
                    this.LeftOpeningMultiplier == input.LeftOpeningMultiplier ||
                    (this.LeftOpeningMultiplier != null &&
                    this.LeftOpeningMultiplier.Equals(input.LeftOpeningMultiplier))
                ) && 
                (
                    this.RightOpeningMultiplier == input.RightOpeningMultiplier ||
                    (this.RightOpeningMultiplier != null &&
                    this.RightOpeningMultiplier.Equals(input.RightOpeningMultiplier))
                ) && 
                (
                    this.AirflowPermeability == input.AirflowPermeability ||
                    (this.AirflowPermeability != null &&
                    this.AirflowPermeability.Equals(input.AirflowPermeability))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SolarTransmittance != null)
                    hashCode = hashCode * 59 + this.SolarTransmittance.GetHashCode();
                if (this.SolarReflectance != null)
                    hashCode = hashCode * 59 + this.SolarReflectance.GetHashCode();
                if (this.VisibleTransmittance != null)
                    hashCode = hashCode * 59 + this.VisibleTransmittance.GetHashCode();
                if (this.VisibleReflectance != null)
                    hashCode = hashCode * 59 + this.VisibleReflectance.GetHashCode();
                if (this.Emissivity != null)
                    hashCode = hashCode * 59 + this.Emissivity.GetHashCode();
                if (this.InfraredTransmittance != null)
                    hashCode = hashCode * 59 + this.InfraredTransmittance.GetHashCode();
                if (this.Thickness != null)
                    hashCode = hashCode * 59 + this.Thickness.GetHashCode();
                if (this.Conductivity != null)
                    hashCode = hashCode * 59 + this.Conductivity.GetHashCode();
                if (this.DistanceToGlass != null)
                    hashCode = hashCode * 59 + this.DistanceToGlass.GetHashCode();
                if (this.TopOpeningMultiplier != null)
                    hashCode = hashCode * 59 + this.TopOpeningMultiplier.GetHashCode();
                if (this.BottomOpeningMultiplier != null)
                    hashCode = hashCode * 59 + this.BottomOpeningMultiplier.GetHashCode();
                if (this.LeftOpeningMultiplier != null)
                    hashCode = hashCode * 59 + this.LeftOpeningMultiplier.GetHashCode();
                if (this.RightOpeningMultiplier != null)
                    hashCode = hashCode * 59 + this.RightOpeningMultiplier.GetHashCode();
                if (this.AirflowPermeability != null)
                    hashCode = hashCode * 59 + this.AirflowPermeability.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Type (string) pattern
            Regex regexType = new Regex(@"^EnergyWindowMaterialShade$", RegexOptions.CultureInvariant);
            if (false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            // SolarTransmittance (double) minimum
            if(this.SolarTransmittance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarTransmittance, must be a value greater than or equal to 0.", new [] { "SolarTransmittance" });
            }

            // SolarReflectance (double) minimum
            if(this.SolarReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SolarReflectance, must be a value greater than or equal to 0.", new [] { "SolarReflectance" });
            }

            // VisibleTransmittance (double) minimum
            if(this.VisibleTransmittance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleTransmittance, must be a value greater than or equal to 0.", new [] { "VisibleTransmittance" });
            }

            // VisibleReflectance (double) minimum
            if(this.VisibleReflectance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for VisibleReflectance, must be a value greater than or equal to 0.", new [] { "VisibleReflectance" });
            }

            // InfraredTransmittance (double) minimum
            if(this.InfraredTransmittance < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for InfraredTransmittance, must be a value greater than or equal to 0.", new [] { "InfraredTransmittance" });
            }

            // DistanceToGlass (double) maximum
            if(this.DistanceToGlass > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistanceToGlass, must be a value less than or equal to 1.", new [] { "DistanceToGlass" });
            }

            // DistanceToGlass (double) minimum
            if(this.DistanceToGlass < (double)0.001)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DistanceToGlass, must be a value greater than or equal to 0.001.", new [] { "DistanceToGlass" });
            }

            // TopOpeningMultiplier (double) maximum
            if(this.TopOpeningMultiplier > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TopOpeningMultiplier, must be a value less than or equal to 1.", new [] { "TopOpeningMultiplier" });
            }

            // TopOpeningMultiplier (double) minimum
            if(this.TopOpeningMultiplier < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TopOpeningMultiplier, must be a value greater than or equal to 0.", new [] { "TopOpeningMultiplier" });
            }

            // BottomOpeningMultiplier (double) maximum
            if(this.BottomOpeningMultiplier > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BottomOpeningMultiplier, must be a value less than or equal to 1.", new [] { "BottomOpeningMultiplier" });
            }

            // BottomOpeningMultiplier (double) minimum
            if(this.BottomOpeningMultiplier < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BottomOpeningMultiplier, must be a value greater than or equal to 0.", new [] { "BottomOpeningMultiplier" });
            }

            // LeftOpeningMultiplier (double) maximum
            if(this.LeftOpeningMultiplier > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LeftOpeningMultiplier, must be a value less than or equal to 1.", new [] { "LeftOpeningMultiplier" });
            }

            // LeftOpeningMultiplier (double) minimum
            if(this.LeftOpeningMultiplier < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LeftOpeningMultiplier, must be a value greater than or equal to 0.", new [] { "LeftOpeningMultiplier" });
            }

            // RightOpeningMultiplier (double) maximum
            if(this.RightOpeningMultiplier > (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RightOpeningMultiplier, must be a value less than or equal to 1.", new [] { "RightOpeningMultiplier" });
            }

            // RightOpeningMultiplier (double) minimum
            if(this.RightOpeningMultiplier < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RightOpeningMultiplier, must be a value greater than or equal to 0.", new [] { "RightOpeningMultiplier" });
            }

            // AirflowPermeability (double) maximum
            if(this.AirflowPermeability > (double)0.8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirflowPermeability, must be a value less than or equal to 0.8.", new [] { "AirflowPermeability" });
            }

            // AirflowPermeability (double) minimum
            if(this.AirflowPermeability < (double)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AirflowPermeability, must be a value greater than or equal to 0.", new [] { "AirflowPermeability" });
            }

            yield break;
        }
    }

}
