using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class ClientNotificationAddress
{
	[JsonPropertyName("EmailAddress")]
	public string EmailAddress { get; set; }

	[JsonPropertyName("IsCurrent")]
	public bool IsCurrent { get; set; }
}
