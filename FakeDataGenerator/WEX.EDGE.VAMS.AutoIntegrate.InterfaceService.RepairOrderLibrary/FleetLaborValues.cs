using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetLaborValues
{
	private double _currentFlatRate;
	private double _currentLaborRate;
	private double _currentLaborTimeHours;
	private double _currentQuantity;
	private double _currentTotalPrice;
	private double _originalFlatRate;
	private double _originalLaborRate;
	private double _originalLaborTimeHours;
	private double _originalQuantity;
	private double _originalTotalPrice;

	[JsonPropertyName("CurrentFlatRate")]
	public double CurrentFlatRate
	{
		get => _currentFlatRate;
		set => _currentFlatRate = Math.Round(value, 2);
	}

	[JsonPropertyName("CurrentLaborRate")]
	public double CurrentLaborRate {
		get => _currentLaborRate;
		set => _currentLaborRate = Math.Round(value, 2);
	}

	[JsonPropertyName("CurrentLaborTimeHours")]
	public double CurrentLaborTimeHours {
		get => _currentLaborTimeHours;
		set => _currentLaborTimeHours = Math.Round(value, 2);
	}

	[JsonPropertyName("CurrentQuantity")]
	public double CurrentQuantity {
		get => _currentQuantity;
		set => _currentQuantity = Math.Round(value, 2);
	}

	[JsonPropertyName("CurrentTotalPrice")]
	public double CurrentTotalPrice {
		get => _currentTotalPrice;
		set => _currentTotalPrice = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalFlatRate")]
	public double OriginalFlatRate {
		get => _originalFlatRate;
		set => _originalFlatRate = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalLaborRate")]
	public double OriginalLaborRate {
		get => _originalLaborRate;
		set => _originalLaborRate = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalLaborTimeHours")]
	public double OriginalLaborTimeHours {
		get => _originalLaborTimeHours;
		set => _originalLaborTimeHours = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalQuantity")]
	public double OriginalQuantity {
		get => _originalQuantity;
		set => _originalQuantity = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalTotalPrice")]
	public double OriginalTotalPrice {
		get => _originalTotalPrice;
		set => _originalTotalPrice = Math.Round(value, 2);
	}
}
