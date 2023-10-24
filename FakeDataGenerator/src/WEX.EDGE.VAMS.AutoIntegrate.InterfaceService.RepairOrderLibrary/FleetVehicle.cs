using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetVehicle
{
	[JsonPropertyName("Driver")]
	public Driver Driver { get; set; }

	[JsonPropertyName("EngineIdleHours")]
	public long? EngineIdleHours { get; set; }

	[JsonPropertyName("FleetHierarchyReference")]
	public string FleetHierarchyReference { get; set; }

	[JsonPropertyName("Make")]
	public string Make { get; set; }

	[JsonPropertyName("ModelDescription")]
	public string ModelDescription { get; set; }

	[JsonPropertyName("ModelYear")]
	public long? ModelYear { get; set; }

	[JsonPropertyName("OdometerReading")]
	public long OdometerReading { get; set; }

	[JsonPropertyName("OdometerUnits")]
	public string OdometerUnits { get; set; }

	[JsonPropertyName("UnitId")]
	public string UnitId { get; set; }

	[JsonPropertyName("Vin")]
	public string Vin { get; set; }
}
