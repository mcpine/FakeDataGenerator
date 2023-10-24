using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class BillingContact
{
	[JsonPropertyName("EmailAddress")]
	public string EmailAddress { get; set; }

	[JsonPropertyName("FaxNumber")]
	public string FaxNumber { get; set; }

	[JsonPropertyName("FirstName")]
	public string FirstName { get; set; }

	[JsonPropertyName("LastName")]
	public string LastName { get; set; }
}
