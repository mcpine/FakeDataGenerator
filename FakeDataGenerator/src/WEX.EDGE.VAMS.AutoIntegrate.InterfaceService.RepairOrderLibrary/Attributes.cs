using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Attributes
{
	[JsonPropertyName("HertzLocation")]
	public string HertzLocation { get; set; }
}
