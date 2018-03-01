//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FenixAppService
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommunicationMessagesShipmentOrdersSentItems
    {
        public int ID { get; set; }
        public int CMSOId { get; set; }
        public int SingleOrMaster { get; set; }
        public int ItemVerKit { get; set; }
        public int ItemOrKitID { get; set; }
        public string ItemOrKitDescription { get; set; }
        public decimal ItemOrKitQuantity { get; set; }
        public Nullable<decimal> ItemOrKitQuantityReal { get; set; }
        public int ItemOrKitUnitOfMeasureId { get; set; }
        public string ItemOrKitUnitOfMeasure { get; set; }
        public int ItemOrKitQualityId { get; set; }
        public string ItemOrKitQualityCode { get; set; }
        public string ItemType { get; set; }
        public int IncotermsId { get; set; }
        public string Incoterms { get; set; }
        public Nullable<int> PackageValue { get; set; }
        public int ShipmentOrderSource { get; set; }
        public Nullable<int> VydejkyId { get; set; }
        public Nullable<int> CardStockItemsId { get; set; }
        public int HeliosOrderRecordId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public int ModifyUserId { get; set; }
        public Nullable<int> IdRowReleaseNote { get; set; }
    }
}
