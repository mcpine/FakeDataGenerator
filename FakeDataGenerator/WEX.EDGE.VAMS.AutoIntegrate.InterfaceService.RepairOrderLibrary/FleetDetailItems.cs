using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetDetailItems
{
	[JsonPropertyName("Fees")]
	public FleetDetailFee[] Fees { get; set; }

	[JsonPropertyName("FeeTotal")]
	public double FeeTotal { get; set; }

	[JsonPropertyName("HasLubeOilFilter")]
	public bool HasLubeOilFilter { get; set; }

	[JsonPropertyName("HasTireRotation")]
	public bool HasTireRotation { get; set; }

	[JsonPropertyName("Labors")]
	public FleetDetailLabor[] Labors { get; set; }

	[JsonPropertyName("LaborTotal")]
	public double LaborTotal { get; set; }

	[JsonPropertyName("OriginalSubTotal")]
	public double OriginalSubTotal { get; set; }

	[JsonPropertyName("Parts")]
	public FleetDetailPart[] Parts { get; set; }

	[JsonPropertyName("PartTotal")]
	public double PartTotal { get; set; }

	[JsonPropertyName("SubTotal")]
	public double SubTotal { get; set; }

	[JsonPropertyName("Tires")]
	public FleetDetailTire[] Tires { get; set; }

	[JsonPropertyName("TireTotal")]
	public double TireTotal { get; set; }
}
