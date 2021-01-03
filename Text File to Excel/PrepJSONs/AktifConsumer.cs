using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PrepJSONs
{
    public class AktifConsumer
    {
        #region Properties

        [DataMember]
        [JsonProperty(PropertyName = "client_id")]
        public string CLIENT_ID { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "consumer_id")]
        public string CONSUMER_ID { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "consumer_no")]
        public string CONSUMER_NO { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "commodity")]
        public string COMMODITY { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "name1")]
        public string NAME1 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "name2")]
        public string NAME2 { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "city")]
        public string CITY { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "zipcode")]
        public string ZIPCODE { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "street")]
        public string STREET { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "streetno")]
        public string STREETNO { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "serialid")]
        public string SERIALID { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "carrier_id")]
        public string CARRIER_ID { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "consumption")]
        public string CONSUMPTION { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "supplystart")]
        public string SUPPLYSTART { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "supplyend")]
        public string SUPPLYEND { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "profile")]
        public string PROFILE { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "oldsupplier")]
        public string OLDSUPPLIER { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "oldsupplier_no")]
        public string OLDSUPPLIER_NO { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "supply_reason")]
        public string SUPPLY_REASON { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "change_date")]
        public string CHANGE_DATE { get; set; }

        [DataMember]
        [JsonProperty(PropertyName = "product")]
        public string PRODUCT { get; set; }


        [DataMember]
        [JsonProperty(PropertyName = "denounce")] // what is this
        public string DENOUNCE { get; set; }


        [DataMember]
        [JsonProperty(PropertyName = "duration")] // what is this
        public string DURATION { get; set; }


        [DataMember]
        [JsonProperty(PropertyName = "denouncetarget")] // what is this
        public string DENOUNCE_TARGET { get; set; }

        #endregion
        //public AktifConsumer()
        //{
        //    this.CLIENT_ID = user.Id.ToString();
        //    this.CONSUMER_ID = consumer_id;
        //    this.CONSUMER_NO = consumer_no;
        //    this.COMMODITY = quote.EnergyType == EnergyType.Gas
        //        ? AktifConstants.AKTIF_GAS_COMODITY_CODE
        //        : AktifConstants.AKTIF_ELECTRICITY_COMODITY_CODE; // Commodity of payment. E=Electricity, G=Gas
        //    this.NAME1 = user.FirstName;
        //    this.NAME2 = user.LastName; //Helper.RemoveDiacritics(user.LastName);
        //    this.CITY = user.MailingAddress.Town;
        //    this.ZIPCODE = user.MailingAddress.PostCode;
        //    this.STREET = user.MailingAddress.Street;
        //    this.STREETNO = user.MailingAddress.HouseNumber;
        //    this.SERIALID = meter.PointNumber; // Seriald ID of Metering. If empty, virtual one is created 
        //    //this.LOCATION_ID = string.Empty; // market location. should come from somewhere???
        //    //this.METERINGCODE = string.Empty; // Metering point code. If empty, virtual on is created 
        //    this.CARRIER_ID = quote.NetworkOperatorNumber; // MarktpartnerID of network operator 
        //    this.CONSUMPTION = quote.UsageAnnual.ToString(); // Estimated consumption of a year. in kWh 
        //    this.SUPPLYSTART = AktifConstants.SUPPLY_START_ASAP;
        //    this.SUPPLYEND = supplyEndDate.HasValue
        //        ? supplyEndDate.Value.ToString("dd'.'MM'.'yyyy", CultureInfo.InvariantCulture)
        //        : null;
        //    this.PROFILE = AktifConstants.CONSUMER_PROFILE; // Profile of consumer, if applicable. If empty, then “RLM” is assumed 
        //    this.SUPPLY_REASON = AktifConstants.SUPPLY_REASON_CHANGE_SUPPLIER; // Reason for supply (1=einzug/collection, 2=Lieferantenwechsel/change of supplier, 3=erstbezug/brand new
        //    this.CHANGE_DATE = DateTime.Now; // Date of change of information 
        //    this.PRODUCT = quote.EnergyType == EnergyType.Gas ? AktifConstants.AKTIF_GAS_PRODUCT_CODE : AktifConstants.AKTIF_ELECTRICITY_PRODUCT_CODE;// Number of Product. (ID of tariff) 1 for electricity and 2 for gas
        //    this.ENERGY_PRICE = quote.UnitRatePerKWh.ToString();
        //    this.BASE_PRICE = quote.StandingChargeMonthly.ToString();
        //    this.DURATION = ((int)DurationType._1Month).ToString();// how long is the Duration of supply
        //    this.DENOUNCE = ((int)DenounceType._4Weeks).ToString();// cancellation period
        //    this.DENOUNCE_TARGET = ((int)DenounceTargetType._MonthEnd).ToString(); // what is the end for the canelation e.g. end of month or end of duration
        //}
    }
}
