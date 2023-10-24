using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetTireDetails
{
	[JsonPropertyName("AspectRatio")]
	public long AspectRatio { get; set; }

	[JsonPropertyName("Class")]
	public string Class { get; set; }

	[JsonPropertyName("Construction")]
	public string Construction { get; set; }

	[JsonPropertyName("LoadRange")]
	public string LoadRange { get; set; }

	[JsonPropertyName("Manufacturer")]
	public string Manufacturer { get; set; }

	[JsonPropertyName("Model")]
	public string Model { get; set; }

	[JsonPropertyName("Ply")]
	public string Ply { get; set; }

	[JsonPropertyName("RimDiameter")]
	public double RimDiameter { get; set; }

	[JsonPropertyName("Size")]
	public string Size { get; set; }

	[JsonPropertyName("SpeedRating")]
	public string SpeedRating { get; set; }

	[JsonPropertyName("Width")]
	public long Width { get; set; }
}
