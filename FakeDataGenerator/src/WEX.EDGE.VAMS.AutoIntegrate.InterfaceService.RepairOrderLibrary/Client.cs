using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Client
{
	[JsonPropertyName("ClientApproval")]
	public ClientApproval ClientApproval { get; set; }

	[JsonPropertyName("FleetReference")]
	public string FleetReference { get; set; }
}
