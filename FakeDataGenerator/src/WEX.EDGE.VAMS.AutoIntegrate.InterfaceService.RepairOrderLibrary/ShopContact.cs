using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class ShopContact
{
	[JsonPropertyName("Name")]
	public string Name { get; set; }

	[JsonPropertyName("TelephoneNumber")]
	public string TelephoneNumber { get; set; }
}
