using System;
using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class BillingDetail {
	private double _aiShopFeeShortPay;
	private double _payableAmount;
	private double _taxTotal;
	private double _total;

	[JsonPropertyName("AIShopFeeShortPay")]
	public double AiShopFeeShortPay { get { return _aiShopFeeShortPay;} set { _aiShopFeeShortPay = Math.Round(value, 2); } }

	[JsonPropertyName("BillingContact")]
	public BillingContact BillingContact { get; set; }

	[JsonPropertyName("FleetNationalAccountCode")]
	public string FleetNationalAccountCode { get; set; }

	[JsonPropertyName("IndependentPaymentType")]
	public PaymentType IndependentPaymentType { get; set; }

	[JsonPropertyName("ManuallyPaid")]
	public bool? ManuallyPaid { get; set; }

	[JsonPropertyName("NationalAccountCode")]
	public string NationalAccountCode { get; set; }

	[JsonPropertyName("NationalCompany")]
	public NationalCompany NationalCompany { get; set; }

	[JsonPropertyName("PayableAmount")]
	public double PayableAmount {
		get => _payableAmount;
		set => _payableAmount = Math.Round(value, 2);
	}

	[JsonPropertyName("ShopInvoiceNumber")]
	public string ShopInvoiceNumber { get; set; }

	[JsonPropertyName("Taxes")]
	public Tax[] Taxes { get; set; }

	[JsonPropertyName("TaxExemptionCode")]
	public string TaxExemptionCode { get; set; }

	[JsonPropertyName("TaxExemptionExpiryDate")]
	public DateTime TaxExemptionExpiryDate { get; set; }

	[JsonPropertyName("TaxTotal")]
	public double TaxTotal {
		get => _taxTotal;
		set => _taxTotal = Math.Round(value, 2);
	}

	[JsonPropertyName("Total")]
	public double Total {
		get => _total;
		set => _total = Math.Round(value, 2);
	}
}
