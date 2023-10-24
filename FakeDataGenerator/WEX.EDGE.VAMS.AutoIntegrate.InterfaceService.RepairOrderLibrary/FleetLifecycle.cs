using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetLifecycle
{
	[JsonPropertyName("CompletedByClientDateTime")]
	public DateTime CompletedByClientDateTime { get; set; }

	[JsonPropertyName("CreatedByUser")]
	public FleetUser CreatedByUser { get; set; }

	[JsonPropertyName("CreatedDateTime")]
	public DateTime CreatedDateTime { get; set; }

	[JsonPropertyName("CurrentEstimatedCompletionDateTime")]
	public DateTime CurrentEstimatedCompletionDateTime { get; set; }

	[JsonPropertyName("DowntimeAudits")]
	public DowntimeAudit[] DowntimeAudits { get; set; }

	[JsonPropertyName("DowntimeTrackingRequired")]
	public bool DowntimeTrackingRequired { get; set; }

	[JsonPropertyName("EstimatedVehicleArrivalDateTime")]
	public DateTime EstimatedVehicleArrivalDateTime { get; set; }

	[JsonPropertyName("LastApprovedDateTime")]
	public DateTime LastApprovedDateTime { get; set; }

	[JsonPropertyName("LastSubmittedToFleetDateTime")]
	public DateTime LastSubmittedToFleetDateTime { get; set; }

	[JsonPropertyName("LastSubmittedToShopDateTime")]
	public DateTime LastSubmittedToShopDateTime { get; set; }

	[JsonPropertyName("OriginalEstimatedCompletionDateTime")]
	public DateTime OriginalEstimatedCompletionDateTime { get; set; }

	[JsonPropertyName("ShopCompletedWorkDateTime")]
	public DateTime ShopCompletedWorkDateTime { get; set; }

	[JsonPropertyName("ShopStartedWorkDateTime")]
	public DateTime ShopStartedWorkDateTime { get; set; }

	[JsonPropertyName("Status")]
	public string Status { get; set; }

	[JsonPropertyName("SubmittedToClientDateTime")]
	public DateTime SubmittedToClientDateTime { get; set; }

	[JsonPropertyName("UpdatedByUser")]
	public FleetUser UpdatedByUser { get; set; }

	[JsonPropertyName("UpdatedDateTime")]
	public DateTime UpdatedDateTime { get; set; }

	[JsonPropertyName("VehicleCollectionDateTime")]
	public DateTime VehicleCollectionDateTime { get; set; }

	[JsonPropertyName("VersionNumber")]
	public long VersionNumber { get; set; }
}
