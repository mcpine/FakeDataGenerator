using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class PaymentStatus
{
	[JsonPropertyName("Description")]
	public string Description { get; set; }

	[JsonPropertyName("Id")]
	public long Id { get; set; }
}
