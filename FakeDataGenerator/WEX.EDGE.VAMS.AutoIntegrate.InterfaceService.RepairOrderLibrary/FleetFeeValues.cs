using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetFeeValues
{
	private int _currentQuantity;
	private double _currentTotalPrice;
	private double _currentUnitPrice;
	private int _originalQuantity;
	private double _originalTotalPrice;
	private double _originalUnitPrice;

	[JsonPropertyName("CurrentQuantity")]
	public int CurrentQuantity {
		get => _currentQuantity;
		set => _currentQuantity = value;
	}

	[JsonPropertyName("CurrentTotalPrice")]
	public double CurrentTotalPrice {
		get => _currentTotalPrice;
		set => _currentTotalPrice = Math.Round(value, 2);
	}

	[JsonPropertyName("CurrentUnitPrice")]
	public double CurrentUnitPrice {
		get => _currentUnitPrice;
		set => _currentUnitPrice = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalQuantity")]
	public int OriginalQuantity {
		get => _originalQuantity;
		set => _originalQuantity = value;
	}

	[JsonPropertyName("OriginalTotalPrice")]
	public double OriginalTotalPrice {
		get => _originalTotalPrice;
		set => _originalTotalPrice = Math.Round(value, 2);
	}

	[JsonPropertyName("OriginalUnitPrice")]
	public double OriginalUnitPrice {
		get => _originalUnitPrice;
		set => _originalUnitPrice = Math.Round(value, 2);
	}
}
