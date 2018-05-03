//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fenix
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommunicationMessagesShipmentOrdersSent
    {
        public int ID { get; set; }
        public int MessageId { get; set; }
        public int MessageTypeId { get; set; }
        public string MessageDescription { get; set; }
        public Nullable<System.DateTime> MessageDateOfShipment { get; set; }
        public System.DateTime RequiredDateOfShipment { get; set; }
        public int MessageStatusId { get; set; }
        public int HeliosOrderId { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress1 { get; set; }
        public string CustomerAddress2 { get; set; }
        public string CustomerAddress3 { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerZipCode { get; set; }
        public string CustomerCountryISO { get; set; }
        public int ContactID { get; set; }
        public string ContactTitle { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }
        public string ContactPhoneNumber1 { get; set; }
        public string ContactPhoneNumber2 { get; set; }
        public string ContactFaxNumber { get; set; }
        public string ContactEmail { get; set; }
        public Nullable<bool> IsManually { get; set; }
        public int StockId { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime ModifyDate { get; set; }
        public int ModifyUserId { get; set; }
        public Nullable<int> IdWf { get; set; }
        public string Remark { get; set; }
    }
}
