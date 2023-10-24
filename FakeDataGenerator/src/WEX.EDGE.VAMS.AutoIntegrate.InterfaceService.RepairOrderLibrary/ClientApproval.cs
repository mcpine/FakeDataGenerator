using System.Text.Json.Serialization;

namespace WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

public class ClientApproval
{
	[JsonPropertyName("ClientApprovalURL")]
	public string ClientApprovalUrl { get; set; }

	[JsonPropertyName("CompletedByName")]
	public string CompletedByName { get; set; }

	[JsonPropertyName("NotificationEmailAddresses")]
	public ClientNotificationAddress[] NotificationEmailAddresses { get; set; }
}
