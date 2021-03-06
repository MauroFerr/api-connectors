/* 
 * Bybit API
 *
 * ## REST API for the Bybit Exchange. Base URI: [https://api-testnet.bybit.com]  
 *
 * OpenAPI spec version: 1.0.0
 * Contact: support@bybit.com
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// extra fields
    /// </summary>
    [DataContract]
    public partial class ExtFields :  IEquatable<ExtFields>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtFields" /> class.
        /// </summary>
        /// <param name="oReqNum">oReqNum.</param>
        /// <param name="xreqType">xreqType.</param>
        /// <param name="xreqOffset">xreqOffset.</param>
        public ExtFields(decimal? oReqNum = default(decimal?), string xreqType = default(string), decimal? xreqOffset = default(decimal?))
        {
            this.OReqNum = oReqNum;
            this.XreqType = xreqType;
            this.XreqOffset = xreqOffset;
        }
        
        /// <summary>
        /// Gets or Sets OReqNum
        /// </summary>
        [DataMember(Name="o_req_num", EmitDefaultValue=false)]
        public decimal? OReqNum { get; set; }

        /// <summary>
        /// Gets or Sets XreqType
        /// </summary>
        [DataMember(Name="xreq_type", EmitDefaultValue=false)]
        public string XreqType { get; set; }

        /// <summary>
        /// Gets or Sets XreqOffset
        /// </summary>
        [DataMember(Name="xreq_offset", EmitDefaultValue=false)]
        public decimal? XreqOffset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtFields {\n");
            sb.Append("  OReqNum: ").Append(OReqNum).Append("\n");
            sb.Append("  XreqType: ").Append(XreqType).Append("\n");
            sb.Append("  XreqOffset: ").Append(XreqOffset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as ExtFields);
        }

        /// <summary>
        /// Returns true if ExtFields instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtFields input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OReqNum == input.OReqNum ||
                    (this.OReqNum != null &&
                    this.OReqNum.Equals(input.OReqNum))
                ) && 
                (
                    this.XreqType == input.XreqType ||
                    (this.XreqType != null &&
                    this.XreqType.Equals(input.XreqType))
                ) && 
                (
                    this.XreqOffset == input.XreqOffset ||
                    (this.XreqOffset != null &&
                    this.XreqOffset.Equals(input.XreqOffset))
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
                if (this.OReqNum != null)
                    hashCode = hashCode * 59 + this.OReqNum.GetHashCode();
                if (this.XreqType != null)
                    hashCode = hashCode * 59 + this.XreqType.GetHashCode();
                if (this.XreqOffset != null)
                    hashCode = hashCode * 59 + this.XreqOffset.GetHashCode();
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
