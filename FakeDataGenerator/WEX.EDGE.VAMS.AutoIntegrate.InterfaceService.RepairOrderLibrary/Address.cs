using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Address
{
	[JsonPropertyName("Address1")]
	public string Address1 { get; set; }

	[JsonPropertyName("Address2")]
	public string Address2 { get; set; }

	[JsonPropertyName("City")]
	public string City { get; set; }

	[JsonPropertyName("Country")]
	public string Country { get; set; }

	[JsonPropertyName("State")]
	public string State { get; set; }

	[JsonPropertyName("Zip")]
	public string Zip { get; set; }
}
