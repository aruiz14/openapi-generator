/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// DateOnlyClass
    /// </summary>
    [DataContract(Name = "DateOnlyClass")]
    public partial class DateOnlyClass : IEquatable<DateOnlyClass>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateOnlyClass" /> class.
        /// </summary>
        /// <param name="dateOnlyProperty">dateOnlyProperty.</param>
        public DateOnlyClass(DateTime dateOnlyProperty = default(DateTime))
        {
            this._DateOnlyProperty = dateOnlyProperty;
            if (this.DateOnlyProperty != null)
            {
                this._flagDateOnlyProperty = true;
            }
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets DateOnlyProperty
        /// </summary>
        /// <example>&quot;Fri Jul 21 00:00:00 UTC 2017&quot;</example>
        [JsonConverter(typeof(OpenAPIDateConverter))]
        [DataMember(Name = "dateOnlyProperty", EmitDefaultValue = false)]
        public DateTime DateOnlyProperty
        {
            get{ return _DateOnlyProperty;}
            set
            {
                _DateOnlyProperty = value;
                _flagDateOnlyProperty = true;
            }
        }
        private DateTime _DateOnlyProperty;
        private bool _flagDateOnlyProperty;

        /// <summary>
        /// Returns false as DateOnlyProperty should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDateOnlyProperty()
        {
            return _flagDateOnlyProperty;
        }
        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DateOnlyClass {\n");
            sb.Append("  DateOnlyProperty: ").Append(DateOnlyProperty).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input as DateOnlyClass).AreEqual;
        }

        /// <summary>
        /// Returns true if DateOnlyClass instances are equal
        /// </summary>
        /// <param name="input">Instance of DateOnlyClass to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateOnlyClass input)
        {
            return OpenAPIClientUtils.compareLogic.Compare(this, input).AreEqual;
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
                hashCode = (hashCode * 59) + this.DateOnlyProperty.GetHashCode();
                if (this.AdditionalProperties != null)
                {
                    hashCode = (hashCode * 59) + this.AdditionalProperties.GetHashCode();
                }
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
