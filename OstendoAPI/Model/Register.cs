/* 
 * Simple Asset Register API
 *
 * This is a simple asset register API
 *
 * OpenAPI spec version: 1.0.0
 * Contact: you@your-company.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using System.Xml.Serialization;
using RestSharp.Serializers;
using SwaggerDateConverter = OstendoAPI.Client.SwaggerDateConverter;

namespace OstendoAPI.Model
{
    /// <summary>
    /// Register
    /// </summary>
    [DataContract]
    public partial class Register :  IEquatable<Register>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Register" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Register() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Register" /> class.
        /// </summary>
        /// <param name="Dongleid">Dongleid (required).</param>
        /// <param name="Macid">Macid (required).</param>
        /// <param name="Imeiid">Imeiid (required).</param>
        /// <param name="Systemid">Systemid (required).</param>
        public Register(string Dongleid = default(string), string Macid = default(string), string Imeiid = default(string), string Systemid = default(string))
        {
            // to ensure "Dongleid" is required (not null)
            if (Dongleid == null)
            {
                throw new InvalidDataException("Dongleid is a required property for Register and cannot be null");
            }
            else
            {
                this.Dongleid = Dongleid;
            }
            // to ensure "Macid" is required (not null)
            if (Macid == null)
            {
                throw new InvalidDataException("Macid is a required property for Register and cannot be null");
            }
            else
            {
                this.Macid = Macid;
            }
            // to ensure "Imeiid" is required (not null)
            if (Imeiid == null)
            {
                throw new InvalidDataException("Imeiid is a required property for Register and cannot be null");
            }
            else
            {
                this.Imeiid = Imeiid;
            }
            // to ensure "Systemid" is required (not null)
            if (Systemid == null)
            {
                throw new InvalidDataException("Systemid is a required property for Register and cannot be null");
            }
            else
            {
                this.Systemid = Systemid;
            }
        }
        
        /// <summary>
        /// Gets or Sets Dongleid
        /// </summary>
        [DataMember(Name="dongleid", EmitDefaultValue=false), XmlElement(ElementName = "dongleid"), SerializeAs(Name = "dongleid")]
        public string Dongleid { get; set; }

        /// <summary>
        /// Gets or Sets Macid
        /// </summary>
        [DataMember(Name="macid", EmitDefaultValue=false), XmlElement(ElementName = "macid"), SerializeAs(Name = "macid")]
        public string Macid { get; set; }

        /// <summary>
        /// Gets or Sets Imeiid
        /// </summary>
        [DataMember(Name="imeiid", EmitDefaultValue=false), XmlElement(ElementName = "imeiid"), SerializeAs(Name = "imeiid")]
        public string Imeiid { get; set; }

        /// <summary>
        /// Gets or Sets Systemid
        /// </summary>
        [DataMember(Name="systemid", EmitDefaultValue=false), XmlElement(ElementName = "systemid"), SerializeAs(Name = "systemid")]
        public string Systemid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Register {\n");
            sb.Append("  Dongleid: ").Append(Dongleid).Append("\n");
            sb.Append("  Macid: ").Append(Macid).Append("\n");
            sb.Append("  Imeiid: ").Append(Imeiid).Append("\n");
            sb.Append("  Systemid: ").Append(Systemid).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Register);
        }

        /// <summary>
        /// Returns true if Register instances are equal
        /// </summary>
        /// <param name="input">Instance of Register to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Register input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Dongleid == input.Dongleid ||
                    (this.Dongleid != null &&
                    this.Dongleid.Equals(input.Dongleid))
                ) && 
                (
                    this.Macid == input.Macid ||
                    (this.Macid != null &&
                    this.Macid.Equals(input.Macid))
                ) && 
                (
                    this.Imeiid == input.Imeiid ||
                    (this.Imeiid != null &&
                    this.Imeiid.Equals(input.Imeiid))
                ) && 
                (
                    this.Systemid == input.Systemid ||
                    (this.Systemid != null &&
                    this.Systemid.Equals(input.Systemid))
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
                if (this.Dongleid != null)
                    hashCode = hashCode * 59 + this.Dongleid.GetHashCode();
                if (this.Macid != null)
                    hashCode = hashCode * 59 + this.Macid.GetHashCode();
                if (this.Imeiid != null)
                    hashCode = hashCode * 59 + this.Imeiid.GetHashCode();
                if (this.Systemid != null)
                    hashCode = hashCode * 59 + this.Systemid.GetHashCode();
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
            yield break;
        }
    }

}
