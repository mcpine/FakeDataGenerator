using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Driver
{
	[JsonPropertyName("DriverCardNumber")]
	public string DriverCardNumber { get; set; }

	[JsonPropertyName("Name")]
	public string Name { get; set; }
}
