using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class DowntimeAudit
{
	[JsonPropertyName("Comment")]
	public string Comment { get; set; }

	[JsonPropertyName("CreatedByUser")]
	public FleetUser CreatedByUser { get; set; }

	[JsonPropertyName("CreatedDateTime")]
	public DateTime CreatedDateTime { get; set; }

	[JsonPropertyName("EstimatedCompletionDateTime")]
	public DateTime EstimatedCompletionDateTime { get; set; }

	[JsonPropertyName("Id")]
	public long Id { get; set; }

	[JsonPropertyName("Reason")]
	public string Reason { get; set; }

	[JsonPropertyName("Type")]
	public string Type { get; set; }
}
