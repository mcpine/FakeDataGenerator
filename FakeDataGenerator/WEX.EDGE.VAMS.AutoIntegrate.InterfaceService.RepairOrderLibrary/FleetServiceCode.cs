using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetServiceCode
{
	[JsonPropertyName("Description")]
	public string Description { get; set; }

	[JsonPropertyName("ExternalReference1")]
	public string ExternalReference1 { get; set; }

	[JsonPropertyName("ExternalReference2")]
	public string ExternalReference2 { get; set; }

	[JsonPropertyName("ExternalReference3")]
	public string ExternalReference3 { get; set; }

	[JsonPropertyName("Id")]
	public long Id { get; set; }
}
