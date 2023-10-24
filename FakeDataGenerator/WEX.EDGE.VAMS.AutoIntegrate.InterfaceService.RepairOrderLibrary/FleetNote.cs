using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetNote
{
	[JsonPropertyName("CreatedBy")]
	public FleetUser CreatedBy { get; set; }

	[JsonPropertyName("CreatedDateTime")]
	public DateTime CreatedDateTime { get; set; }

	[JsonPropertyName("Source")]
	public string Source { get; set; }

	[JsonPropertyName("SubType")]
	public string SubType { get; set; }

	[JsonPropertyName("Text")]
	public string Text { get; set; }

	[JsonPropertyName("Type")]
	public string Type { get; set; }
}
