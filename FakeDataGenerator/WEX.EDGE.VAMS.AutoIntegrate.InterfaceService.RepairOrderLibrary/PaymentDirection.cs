using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class PaymentDirection
{
	[JsonPropertyName("AIReference")]
	public string AiReference { get; set; }

	[JsonPropertyName("FleetNationalReference")]
	public string FleetNationalReference { get; set; }

	[JsonPropertyName("IsDefault")]
	public bool IsDefault { get; set; }

	[JsonPropertyName("StoreNumber")]
	public string StoreNumber { get; set; }
}
