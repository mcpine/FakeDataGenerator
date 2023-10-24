using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary {
	public class FleetRepairOrderDetailNotification
    {
	    [JsonPropertyName("Id")]
	    public Guid Id { get; set; }

	    [JsonPropertyName("EventId")]
	    public Guid EventId { get; set; }

	    [JsonPropertyName("Attributes")]
        public Attributes Attributes { get; set; }

        [JsonPropertyName("AuthorizationNumber")]
        public string AuthorizationNumber { get; set; }

        [JsonPropertyName("Billing")]
        public BillingDetail Billing { get; set; }

        [JsonPropertyName("Client")]
        public Client Client { get; set; }

        [JsonPropertyName("Diagnostics")]
        public Diagnostic[] Diagnostics { get; set; }

        [JsonPropertyName("ExternalTicketId")]
        public long? ExternalTicketId { get; set; }

        [JsonPropertyName("Items")]
        public FleetDetailItems Items { get; set; }

        [JsonPropertyName("Lifecycle")]
        public FleetLifecycle Lifecycle { get; set; }

        [JsonPropertyName("Notes")]
        public FleetNote[] Notes { get; set; }

        [JsonPropertyName("PaymentHistory")]
        public PaymentHistory[] PaymentHistory { get; set; }

        [JsonPropertyName("PortalUrl")]
        public string PortalUrl { get; set; }

        [JsonPropertyName("RepairOrderId")]
        public string RepairOrderId { get; set; }

        [JsonPropertyName("Shop")]
        public FleetShop Shop { get; set; }

        [JsonPropertyName("ShopContact")]
        public ShopContact ShopContact { get; set; }

        [JsonPropertyName("Vehicle")]
        public FleetVehicle Vehicle { get; set; }
    }
}
