/* 
 * Rabbitmq Http API
 *
 * This is the OpenAPI specification of the RabbitMQ HTTP API. For more information, please refer to [HTTP API](https://cdn.rawgit.com/rabbitmq/rabbitmq-management/v3.7.14/priv/www/api/index.html) official documentation.
 *
 * OpenAPI spec version: 1.0
 * Contact: carlos@adaptive.me
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
using OpenAPIDateConverter = Thinkcode.RabbitMQ.OpenAPI.Client.OpenAPIDateConverter;

namespace Thinkcode.RabbitMQ.OpenAPI.Model
{
    /// <summary>
    /// VHostMessageStats
    /// </summary>
    [DataContract]
    public partial class VHostMessageStats :  IEquatable<VHostMessageStats>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VHostMessageStats" /> class.
        /// </summary>
        /// <param name="getNoAckDetails">getNoAckDetails.</param>
        /// <param name="deliverNoAck">deliverNoAck.</param>
        /// <param name="publishDetails">publishDetails.</param>
        /// <param name="redeliverDetails">redeliverDetails.</param>
        /// <param name="confirmDetails">confirmDetails.</param>
        /// <param name="ack">ack.</param>
        /// <param name="deliver">deliver.</param>
        /// <param name="deliverGet">deliverGet.</param>
        /// <param name="redeliver">redeliver.</param>
        /// <param name="returnUnroutable">returnUnroutable.</param>
        /// <param name="confirm">confirm.</param>
        /// <param name="getDetails">getDetails.</param>
        /// <param name="deliverGetDetails">deliverGetDetails.</param>
        /// <param name="deliverNoAckDetails">deliverNoAckDetails.</param>
        /// <param name="getNoAck">getNoAck.</param>
        /// <param name="returnUnroutableDetails">returnUnroutableDetails.</param>
        /// <param name="deliverDetails">deliverDetails.</param>
        /// <param name="get">get.</param>
        /// <param name="publish">publish.</param>
        /// <param name="ackDetails">ackDetails.</param>
        public VHostMessageStats(ExchangeMessageStatsPublishInDetails getNoAckDetails = default(ExchangeMessageStatsPublishInDetails), int deliverNoAck = default(int), ExchangeMessageStatsPublishInDetails publishDetails = default(ExchangeMessageStatsPublishInDetails), ExchangeMessageStatsPublishInDetails redeliverDetails = default(ExchangeMessageStatsPublishInDetails), ExchangeMessageStatsPublishInDetails confirmDetails = default(ExchangeMessageStatsPublishInDetails), int ack = default(int), int deliver = default(int), int deliverGet = default(int), int redeliver = default(int), int returnUnroutable = default(int), int confirm = default(int), ExchangeMessageStatsPublishInDetails getDetails = default(ExchangeMessageStatsPublishInDetails), ExchangeMessageStatsPublishInDetails deliverGetDetails = default(ExchangeMessageStatsPublishInDetails), ExchangeMessageStatsPublishInDetails deliverNoAckDetails = default(ExchangeMessageStatsPublishInDetails), int getNoAck = default(int), ExchangeMessageStatsPublishInDetails returnUnroutableDetails = default(ExchangeMessageStatsPublishInDetails), ExchangeMessageStatsPublishInDetails deliverDetails = default(ExchangeMessageStatsPublishInDetails), int get = default(int), int publish = default(int), ExchangeMessageStatsPublishInDetails ackDetails = default(ExchangeMessageStatsPublishInDetails))
        {
            this.GetNoAckDetails = getNoAckDetails;
            this.DeliverNoAck = deliverNoAck;
            this.PublishDetails = publishDetails;
            this.RedeliverDetails = redeliverDetails;
            this.ConfirmDetails = confirmDetails;
            this.Ack = ack;
            this.Deliver = deliver;
            this.DeliverGet = deliverGet;
            this.Redeliver = redeliver;
            this.ReturnUnroutable = returnUnroutable;
            this.Confirm = confirm;
            this.GetDetails = getDetails;
            this.DeliverGetDetails = deliverGetDetails;
            this.DeliverNoAckDetails = deliverNoAckDetails;
            this.GetNoAck = getNoAck;
            this.ReturnUnroutableDetails = returnUnroutableDetails;
            this.DeliverDetails = deliverDetails;
            this.Get = get;
            this.Publish = publish;
            this.AckDetails = ackDetails;
        }
        
        /// <summary>
        /// Gets or Sets GetNoAckDetails
        /// </summary>
        [DataMember(Name="get_no_ack_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails GetNoAckDetails { get; set; }

        /// <summary>
        /// Gets or Sets DeliverNoAck
        /// </summary>
        [DataMember(Name="deliver_no_ack", EmitDefaultValue=false)]
        public int DeliverNoAck { get; set; }

        /// <summary>
        /// Gets or Sets PublishDetails
        /// </summary>
        [DataMember(Name="publish_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails PublishDetails { get; set; }

        /// <summary>
        /// Gets or Sets RedeliverDetails
        /// </summary>
        [DataMember(Name="redeliver_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails RedeliverDetails { get; set; }

        /// <summary>
        /// Gets or Sets ConfirmDetails
        /// </summary>
        [DataMember(Name="confirm_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails ConfirmDetails { get; set; }

        /// <summary>
        /// Gets or Sets Ack
        /// </summary>
        [DataMember(Name="ack", EmitDefaultValue=false)]
        public int Ack { get; set; }

        /// <summary>
        /// Gets or Sets Deliver
        /// </summary>
        [DataMember(Name="deliver", EmitDefaultValue=false)]
        public int Deliver { get; set; }

        /// <summary>
        /// Gets or Sets DeliverGet
        /// </summary>
        [DataMember(Name="deliver_get", EmitDefaultValue=false)]
        public int DeliverGet { get; set; }

        /// <summary>
        /// Gets or Sets Redeliver
        /// </summary>
        [DataMember(Name="redeliver", EmitDefaultValue=false)]
        public int Redeliver { get; set; }

        /// <summary>
        /// Gets or Sets ReturnUnroutable
        /// </summary>
        [DataMember(Name="return_unroutable", EmitDefaultValue=false)]
        public int ReturnUnroutable { get; set; }

        /// <summary>
        /// Gets or Sets Confirm
        /// </summary>
        [DataMember(Name="confirm", EmitDefaultValue=false)]
        public int Confirm { get; set; }

        /// <summary>
        /// Gets or Sets GetDetails
        /// </summary>
        [DataMember(Name="get_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails GetDetails { get; set; }

        /// <summary>
        /// Gets or Sets DeliverGetDetails
        /// </summary>
        [DataMember(Name="deliver_get_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails DeliverGetDetails { get; set; }

        /// <summary>
        /// Gets or Sets DeliverNoAckDetails
        /// </summary>
        [DataMember(Name="deliver_no_ack_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails DeliverNoAckDetails { get; set; }

        /// <summary>
        /// Gets or Sets GetNoAck
        /// </summary>
        [DataMember(Name="get_no_ack", EmitDefaultValue=false)]
        public int GetNoAck { get; set; }

        /// <summary>
        /// Gets or Sets ReturnUnroutableDetails
        /// </summary>
        [DataMember(Name="return_unroutable_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails ReturnUnroutableDetails { get; set; }

        /// <summary>
        /// Gets or Sets DeliverDetails
        /// </summary>
        [DataMember(Name="deliver_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails DeliverDetails { get; set; }

        /// <summary>
        /// Gets or Sets Get
        /// </summary>
        [DataMember(Name="get", EmitDefaultValue=false)]
        public int Get { get; set; }

        /// <summary>
        /// Gets or Sets Publish
        /// </summary>
        [DataMember(Name="publish", EmitDefaultValue=false)]
        public int Publish { get; set; }

        /// <summary>
        /// Gets or Sets AckDetails
        /// </summary>
        [DataMember(Name="ack_details", EmitDefaultValue=false)]
        public ExchangeMessageStatsPublishInDetails AckDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VHostMessageStats {\n");
            sb.Append("  GetNoAckDetails: ").Append(GetNoAckDetails).Append("\n");
            sb.Append("  DeliverNoAck: ").Append(DeliverNoAck).Append("\n");
            sb.Append("  PublishDetails: ").Append(PublishDetails).Append("\n");
            sb.Append("  RedeliverDetails: ").Append(RedeliverDetails).Append("\n");
            sb.Append("  ConfirmDetails: ").Append(ConfirmDetails).Append("\n");
            sb.Append("  Ack: ").Append(Ack).Append("\n");
            sb.Append("  Deliver: ").Append(Deliver).Append("\n");
            sb.Append("  DeliverGet: ").Append(DeliverGet).Append("\n");
            sb.Append("  Redeliver: ").Append(Redeliver).Append("\n");
            sb.Append("  ReturnUnroutable: ").Append(ReturnUnroutable).Append("\n");
            sb.Append("  Confirm: ").Append(Confirm).Append("\n");
            sb.Append("  GetDetails: ").Append(GetDetails).Append("\n");
            sb.Append("  DeliverGetDetails: ").Append(DeliverGetDetails).Append("\n");
            sb.Append("  DeliverNoAckDetails: ").Append(DeliverNoAckDetails).Append("\n");
            sb.Append("  GetNoAck: ").Append(GetNoAck).Append("\n");
            sb.Append("  ReturnUnroutableDetails: ").Append(ReturnUnroutableDetails).Append("\n");
            sb.Append("  DeliverDetails: ").Append(DeliverDetails).Append("\n");
            sb.Append("  Get: ").Append(Get).Append("\n");
            sb.Append("  Publish: ").Append(Publish).Append("\n");
            sb.Append("  AckDetails: ").Append(AckDetails).Append("\n");
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
            return this.Equals(input as VHostMessageStats);
        }

        /// <summary>
        /// Returns true if VHostMessageStats instances are equal
        /// </summary>
        /// <param name="input">Instance of VHostMessageStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VHostMessageStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GetNoAckDetails == input.GetNoAckDetails ||
                    (this.GetNoAckDetails != null &&
                    this.GetNoAckDetails.Equals(input.GetNoAckDetails))
                ) && 
                (
                    this.DeliverNoAck == input.DeliverNoAck ||
                    (this.DeliverNoAck != null &&
                    this.DeliverNoAck.Equals(input.DeliverNoAck))
                ) && 
                (
                    this.PublishDetails == input.PublishDetails ||
                    (this.PublishDetails != null &&
                    this.PublishDetails.Equals(input.PublishDetails))
                ) && 
                (
                    this.RedeliverDetails == input.RedeliverDetails ||
                    (this.RedeliverDetails != null &&
                    this.RedeliverDetails.Equals(input.RedeliverDetails))
                ) && 
                (
                    this.ConfirmDetails == input.ConfirmDetails ||
                    (this.ConfirmDetails != null &&
                    this.ConfirmDetails.Equals(input.ConfirmDetails))
                ) && 
                (
                    this.Ack == input.Ack ||
                    (this.Ack != null &&
                    this.Ack.Equals(input.Ack))
                ) && 
                (
                    this.Deliver == input.Deliver ||
                    (this.Deliver != null &&
                    this.Deliver.Equals(input.Deliver))
                ) && 
                (
                    this.DeliverGet == input.DeliverGet ||
                    (this.DeliverGet != null &&
                    this.DeliverGet.Equals(input.DeliverGet))
                ) && 
                (
                    this.Redeliver == input.Redeliver ||
                    (this.Redeliver != null &&
                    this.Redeliver.Equals(input.Redeliver))
                ) && 
                (
                    this.ReturnUnroutable == input.ReturnUnroutable ||
                    (this.ReturnUnroutable != null &&
                    this.ReturnUnroutable.Equals(input.ReturnUnroutable))
                ) && 
                (
                    this.Confirm == input.Confirm ||
                    (this.Confirm != null &&
                    this.Confirm.Equals(input.Confirm))
                ) && 
                (
                    this.GetDetails == input.GetDetails ||
                    (this.GetDetails != null &&
                    this.GetDetails.Equals(input.GetDetails))
                ) && 
                (
                    this.DeliverGetDetails == input.DeliverGetDetails ||
                    (this.DeliverGetDetails != null &&
                    this.DeliverGetDetails.Equals(input.DeliverGetDetails))
                ) && 
                (
                    this.DeliverNoAckDetails == input.DeliverNoAckDetails ||
                    (this.DeliverNoAckDetails != null &&
                    this.DeliverNoAckDetails.Equals(input.DeliverNoAckDetails))
                ) && 
                (
                    this.GetNoAck == input.GetNoAck ||
                    (this.GetNoAck != null &&
                    this.GetNoAck.Equals(input.GetNoAck))
                ) && 
                (
                    this.ReturnUnroutableDetails == input.ReturnUnroutableDetails ||
                    (this.ReturnUnroutableDetails != null &&
                    this.ReturnUnroutableDetails.Equals(input.ReturnUnroutableDetails))
                ) && 
                (
                    this.DeliverDetails == input.DeliverDetails ||
                    (this.DeliverDetails != null &&
                    this.DeliverDetails.Equals(input.DeliverDetails))
                ) && 
                (
                    this.Get == input.Get ||
                    (this.Get != null &&
                    this.Get.Equals(input.Get))
                ) && 
                (
                    this.Publish == input.Publish ||
                    (this.Publish != null &&
                    this.Publish.Equals(input.Publish))
                ) && 
                (
                    this.AckDetails == input.AckDetails ||
                    (this.AckDetails != null &&
                    this.AckDetails.Equals(input.AckDetails))
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
                if (this.GetNoAckDetails != null)
                    hashCode = hashCode * 59 + this.GetNoAckDetails.GetHashCode();
                if (this.DeliverNoAck != null)
                    hashCode = hashCode * 59 + this.DeliverNoAck.GetHashCode();
                if (this.PublishDetails != null)
                    hashCode = hashCode * 59 + this.PublishDetails.GetHashCode();
                if (this.RedeliverDetails != null)
                    hashCode = hashCode * 59 + this.RedeliverDetails.GetHashCode();
                if (this.ConfirmDetails != null)
                    hashCode = hashCode * 59 + this.ConfirmDetails.GetHashCode();
                if (this.Ack != null)
                    hashCode = hashCode * 59 + this.Ack.GetHashCode();
                if (this.Deliver != null)
                    hashCode = hashCode * 59 + this.Deliver.GetHashCode();
                if (this.DeliverGet != null)
                    hashCode = hashCode * 59 + this.DeliverGet.GetHashCode();
                if (this.Redeliver != null)
                    hashCode = hashCode * 59 + this.Redeliver.GetHashCode();
                if (this.ReturnUnroutable != null)
                    hashCode = hashCode * 59 + this.ReturnUnroutable.GetHashCode();
                if (this.Confirm != null)
                    hashCode = hashCode * 59 + this.Confirm.GetHashCode();
                if (this.GetDetails != null)
                    hashCode = hashCode * 59 + this.GetDetails.GetHashCode();
                if (this.DeliverGetDetails != null)
                    hashCode = hashCode * 59 + this.DeliverGetDetails.GetHashCode();
                if (this.DeliverNoAckDetails != null)
                    hashCode = hashCode * 59 + this.DeliverNoAckDetails.GetHashCode();
                if (this.GetNoAck != null)
                    hashCode = hashCode * 59 + this.GetNoAck.GetHashCode();
                if (this.ReturnUnroutableDetails != null)
                    hashCode = hashCode * 59 + this.ReturnUnroutableDetails.GetHashCode();
                if (this.DeliverDetails != null)
                    hashCode = hashCode * 59 + this.DeliverDetails.GetHashCode();
                if (this.Get != null)
                    hashCode = hashCode * 59 + this.Get.GetHashCode();
                if (this.Publish != null)
                    hashCode = hashCode * 59 + this.Publish.GetHashCode();
                if (this.AckDetails != null)
                    hashCode = hashCode * 59 + this.AckDetails.GetHashCode();
                return hashCode;
            }
        }

    }

}
