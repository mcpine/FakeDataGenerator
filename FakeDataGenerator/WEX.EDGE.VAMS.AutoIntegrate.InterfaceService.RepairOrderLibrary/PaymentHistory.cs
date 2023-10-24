using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class PaymentHistory
{
	private double _amount;

	[JsonPropertyName("Amount")]
	public double Amount {
		get => _amount;
		set => _amount = Math.Round(value, 2);
	}

	[JsonPropertyName("PaymentStatus")]
	public PaymentStatus PaymentStatus { get; set; }

	[JsonPropertyName("PaymentType")]
	public PaymentType PaymentType { get; set; }

	[JsonPropertyName("Reference")]
	public string Reference { get; set; }
}
