using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class Tax
{
	private double _amount;

	[JsonPropertyName("Amount")]
	public double Amount {
		get => _amount;
		set => _amount = Math.Round(value, 2);
	}

	[JsonPropertyName("Type")]
	public string Type { get; set; }
}
