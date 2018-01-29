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
    /// Ostendoimport
    /// </summary>
    [DataContract, SerializeAs(Name = "ostendoimport")]
    public partial class Ostendoimport :  IEquatable<Ostendoimport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ostendoimport" /> class.
        /// </summary>
        /// <param name="OstdefSystemidupload">OstdefSystemidupload.</param>
        public Ostendoimport(Register OstdefSystemidupload = default(Register))
        {
            this.OstdefSystemidupload = OstdefSystemidupload;
        }
        
        /// <summary>
        /// Gets or Sets OstdefSystemidupload
        /// </summary>
        [DataMember(Name="ostdef_systemidupload", EmitDefaultValue=false), XmlElement(ElementName = "ostdef_systemidupload"), SerializeAs(Name = "ostdef_systemidupload")]
        public Register OstdefSystemidupload { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ostendoimport {\n");
            sb.Append("  OstdefSystemidupload: ").Append(OstdefSystemidupload).Append("\n");
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
            return this.Equals(input as Ostendoimport);
        }

        /// <summary>
        /// Returns true if Ostendoimport instances are equal
        /// </summary>
        /// <param name="input">Instance of Ostendoimport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ostendoimport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OstdefSystemidupload == input.OstdefSystemidupload ||
                    (this.OstdefSystemidupload != null &&
                    this.OstdefSystemidupload.Equals(input.OstdefSystemidupload))
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
                if (this.OstdefSystemidupload != null)
                    hashCode = hashCode * 59 + this.OstdefSystemidupload.GetHashCode();
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