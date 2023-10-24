using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Diagnostic
{
	[JsonPropertyName("Index")]
	public long Index { get; set; }

	[JsonPropertyName("Measurement")]
	public Measurement Measurement { get; set; }

	[JsonPropertyName("SubType")]
	public string SubType { get; set; }

	[JsonPropertyName("Type")]
	public string Type { get; set; }
}
