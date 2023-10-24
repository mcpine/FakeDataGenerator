using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetDetailFee
{
	[JsonPropertyName("Cause")]
	public string Cause { get; set; }

	[JsonPropertyName("CostSaving")]
	public bool CostSaving { get; set; }

	[JsonPropertyName("CreatedBy")]
	public FleetUser CreatedBy { get; set; }

	[JsonPropertyName("CreatedDateTime")]
	public DateTime CreatedDateTime { get; set; }

	[JsonPropertyName("DiscountExclusion")]
	public bool DiscountExclusion { get; set; }

	[JsonPropertyName("FleetExternalReference")]
	public string FleetExternalReference { get; set; }

	[JsonPropertyName("ItemDescription")]
	public string ItemDescription { get; set; }

	[JsonPropertyName("ItemNotes")]
	public FleetNote[] ItemNotes { get; set; }

	[JsonPropertyName("ItemStatus")]
	public string ItemStatus { get; set; }

	[JsonPropertyName("LineItemId")]
	public long LineItemId { get; set; }

	[JsonPropertyName("NationalCatalogCode")]
	public string NationalCatalogCode { get; set; }

	[JsonPropertyName("RejectionReason")]
	public string RejectionReason { get; set; }

	[JsonPropertyName("ServiceCode")]
	public FleetServiceCode ServiceCode { get; set; }

	[JsonPropertyName("UpdatedBy")]
	public FleetUser UpdatedBy { get; set; }

	[JsonPropertyName("UpdatedDateTime")]
	public DateTime UpdatedDateTime { get; set; }

	[JsonPropertyName("Values")]
	public FleetFeeValues Values { get; set; }
}
