using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class NationalCompany
{
	[JsonPropertyName("Id")]
	public long? Id { get; set; }

	[JsonPropertyName("Name")]
	public string Name { get; set; }
}
