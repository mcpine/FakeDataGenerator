using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Measurement
{
	[JsonPropertyName("Unit")]
	public string Unit { get; set; }

	[JsonPropertyName("Value")]
	public double Value { get; set; }
}
