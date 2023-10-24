using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class FleetShop
{
	[JsonPropertyName("Address")]
	public Address Address { get; set; }

	[JsonPropertyName("AllowedIndependentPaymentTypes")]
	public PaymentType[] AllowedIndependentPaymentTypes { get; set; }

	[JsonPropertyName("BillingAddress")]
	public Address BillingAddress { get; set; }

	[JsonPropertyName("BillingContact")]
	public BillingContact BillingContact { get; set; }

	[JsonPropertyName("DefaultIndependentPaymentTypeId")]
	public long? DefaultIndependentPaymentTypeId { get; set; }

	[JsonPropertyName("EmailAddress")]
	public string EmailAddress { get; set; }

	[JsonPropertyName("FaxNumber")]
	public string FaxNumber { get; set; }

	[JsonPropertyName("FederalTaxId")]
	public string FederalTaxId { get; set; }

	[JsonPropertyName("FleetNationalAccountCode")]
	public string FleetNationalAccountCode { get; set; }

	[JsonPropertyName("FleetShopId1")]
	public string FleetShopId1 { get; set; }

	[JsonPropertyName("FleetShopId2")]
	public string FleetShopId2 { get; set; }

	[JsonPropertyName("Id")]
	public long Id { get; set; }

	[JsonPropertyName("IsActiveToFleet")]
	public bool? IsActiveToFleet { get; set; }

	[JsonPropertyName("IsCompliant")]
	public bool? IsCompliant { get; set; }

	[JsonPropertyName("IsPreferredShop")]
	public bool? IsPreferredShop { get; set; }

	[JsonPropertyName("LegalName")]
	public string LegalName { get; set; }

	[JsonPropertyName("Name")]
	public string Name { get; set; }

	[JsonPropertyName("NationalAccountCode")]
	public string NationalAccountCode { get; set; }

	[JsonPropertyName("NationalPaymentDirections")]
	public PaymentDirection[] NationalPaymentDirections { get; set; }

	[JsonPropertyName("NationalStoreNumber")]
	public string NationalStoreNumber { get; set; }

	[JsonPropertyName("OverrideNonPreferredFee")]
	public bool? OverrideNonPreferredFee { get; set; }

	[JsonPropertyName("ProvincialTaxId")]
	public string ProvincialTaxId { get; set; }

	[JsonPropertyName("RegisteredDate")]
	public DateTime RegisteredDate { get; set; }

	[JsonPropertyName("Telephone")]
	public string Telephone { get; set; }
}
