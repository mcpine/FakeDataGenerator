using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetUser
{
	[JsonPropertyName("ExternalReference")]
	public string ExternalReference { get; set; }

	[JsonPropertyName("Username")]
	public string Username { get; set; }
}
