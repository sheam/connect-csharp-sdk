/* 
 * Square Connect API
 *
 * Client library for accessing the Square Connect APIs
 *
 * OpenAPI spec version: 2.0
 * Contact: developers@squareup.com
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

namespace Square.Connect.Model
{
    /// <summary>
    /// Represents a discount that can apply to either a single line item or an entire order.
    /// </summary>
    [DataContract]
    public partial class CreateOrderRequestDiscount :  IEquatable<CreateOrderRequestDiscount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequestDiscount" /> class.
        /// </summary>
        /// <param name="CatalogObjectId">Only used for catalog discounts. The catalog object ID for an existing [CatalogDiscount](#type-catalogdiscount).  Do not provide a value for this field if you provide values in other fields for an ad hoc discount..</param>
        /// <param name="Name">Only used for ad hoc discounts. The discount&#39;s name..</param>
        /// <param name="Percentage">Only used for ad hoc discounts. The percentage of the discount, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. This value range between 0.0 up to 100.0.</param>
        /// <param name="AmountMoney">Only used for ad hoc discounts. The monetary amount of the discount..</param>
        public CreateOrderRequestDiscount(string CatalogObjectId = default(string), string Name = default(string), string Percentage = default(string), Money AmountMoney = default(Money))
        {
            this.CatalogObjectId = CatalogObjectId;
            this.Name = Name;
            this.Percentage = Percentage;
            this.AmountMoney = AmountMoney;
        }
        
        /// <summary>
        /// Only used for catalog discounts. The catalog object ID for an existing [CatalogDiscount](#type-catalogdiscount).  Do not provide a value for this field if you provide values in other fields for an ad hoc discount.
        /// </summary>
        /// <value>Only used for catalog discounts. The catalog object ID for an existing [CatalogDiscount](#type-catalogdiscount).  Do not provide a value for this field if you provide values in other fields for an ad hoc discount.</value>
        [DataMember(Name="catalog_object_id", EmitDefaultValue=false)]
        public string CatalogObjectId { get; set; }
        /// <summary>
        /// Only used for ad hoc discounts. The discount&#39;s name.
        /// </summary>
        /// <value>Only used for ad hoc discounts. The discount&#39;s name.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Only used for ad hoc discounts. The percentage of the discount, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. This value range between 0.0 up to 100.0
        /// </summary>
        /// <value>Only used for ad hoc discounts. The percentage of the discount, as a string representation of a decimal number.  A value of &#x60;7.25&#x60; corresponds to a percentage of 7.25%. This value range between 0.0 up to 100.0</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public string Percentage { get; set; }
        /// <summary>
        /// Only used for ad hoc discounts. The monetary amount of the discount.
        /// </summary>
        /// <value>Only used for ad hoc discounts. The monetary amount of the discount.</value>
        [DataMember(Name="amount_money", EmitDefaultValue=false)]
        public Money AmountMoney { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateOrderRequestDiscount {\n");
            sb.Append("  CatalogObjectId: ").Append(CatalogObjectId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  AmountMoney: ").Append(AmountMoney).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CreateOrderRequestDiscount);
        }

        /// <summary>
        /// Returns true if CreateOrderRequestDiscount instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateOrderRequestDiscount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequestDiscount other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CatalogObjectId == other.CatalogObjectId ||
                    this.CatalogObjectId != null &&
                    this.CatalogObjectId.Equals(other.CatalogObjectId)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.AmountMoney == other.AmountMoney ||
                    this.AmountMoney != null &&
                    this.AmountMoney.Equals(other.AmountMoney)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.CatalogObjectId != null)
                    hash = hash * 59 + this.CatalogObjectId.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                if (this.AmountMoney != null)
                    hash = hash * 59 + this.AmountMoney.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            // CatalogObjectId (string) maxLength
            if(this.CatalogObjectId != null && this.CatalogObjectId.Length > 192)
            {
                yield return new ValidationResult("Invalid value for CatalogObjectId, length must be less than 192.", new [] { "CatalogObjectId" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Percentage (string) maxLength
            if(this.Percentage != null && this.Percentage.Length > 10)
            {
                yield return new ValidationResult("Invalid value for Percentage, length must be less than 10.", new [] { "Percentage" });
            }

            yield break;
        }
    }

}
