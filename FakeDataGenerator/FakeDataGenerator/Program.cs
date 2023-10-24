// Use Bogus to generate random data for the FleetRepairOrderDetailNotification class

using System.Diagnostics.Metrics;
using System.Text.Json;
using Bogus;
using WEX.EDGE.VAMS.AutoIntegrate.InterfaceService.RepairOrderLibrary;

var unitMeasure = new List<string> { "ft", "m" };
var fd_FleetUser = new Faker<FleetUser>()
.RuleFor(f => f.ExternalReference, d => d.Random.AlphaNumeric(10))
.RuleFor(f => f.Username,  d => d.Random.AlphaNumeric(8));
var fd_Driver = new Faker<Driver>()
				.RuleFor(f => f.Name, d => d.Name.FullName())
				.RuleFor(f => f.DriverCardNumber, d => d.Random.Int(100000, 999999).ToString());
			var fd_PaymentDirection = new Faker<PaymentDirection>()
				.RuleFor(f => f.AiReference, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.FleetNationalReference, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.IsDefault, d => d.Random.Bool())
				.RuleFor(f => f.StoreNumber, d => d.Random.Int(1, 100).ToString());
			var fd_Address = new Faker<Address>()
				.RuleFor(f => f.Address1, d => d.Address.StreetAddress())
				.RuleFor(f => f.Address2, d => d.Address.SecondaryAddress())
				.RuleFor(f => f.City, d => d.Address.City())
				.RuleFor(f => f.State, d => d.Address.StateAbbr())
				.RuleFor(f => f.Zip, d => d.Address.ZipCode())
				.RuleFor(f => f.Country, d => d.Address.Country());
			var fd_PaymentStatus = new Faker<PaymentStatus>()
				.RuleFor(f => f.Id, d => d.Random.Long(10001, 19999))
				.RuleFor(f => f.Description, d => d.Lorem.Sentence(10));
			var fd_DownTimeAudit = new Faker<DowntimeAudit>()
				.RuleFor(f => f.CreatedByUser, fd_FleetUser.Generate())
				.RuleFor(f => f.CreatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.Comment, d => d.Lorem.Sentence())
				.RuleFor(f => f.Id, d => d.Random.Long(10001, 19999))
				.RuleFor(f => f.Type, d => d.Lorem.Word())
				.RuleFor(f => f.EstimatedCompletionDateTime, d => d.Date.Past())
				.RuleFor(f => f.Reason, d => d.Lorem.Sentence(10));
			var fd_FleetNote = new Faker<FleetNote>()
				.RuleFor(f => f.CreatedBy, fd_FleetUser.Generate())
				.RuleFor(f => f.CreatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.Source, d => d.Lorem.Word())
				.RuleFor(f => f.SubType, d => d.Lorem.Word())
				.RuleFor(f => f.Text, d => d.Lorem.Sentence(6))
				.RuleFor(f => f.Type, d => d.Lorem.Word());
			var fd_FleetServiceCode = new Faker<FleetServiceCode>()
				.RuleFor(f => f.Description, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.Id, d => d.Random.Long(10001,19999))
				.RuleFor(f => f.ExternalReference1, new Guid().ToString())
				.RuleFor(f => f.ExternalReference2, new Guid().ToString())
				.RuleFor(f => f.ExternalReference3, new Guid().ToString());
			var fd_FleetPartValues = new Faker<FleetPartValues>()
				.RuleFor(f => f.CurrentQuantity, d => d.Random.Int(1,200))
				.RuleFor(f => f.CurrentTotalPrice, d => d.Random.Double(1.00, 100.00))
				.RuleFor(f => f.OriginalQuantity, d => d.Random.Int(1,200))
				.RuleFor(f => f.OriginalTotalPrice, d => d.Random.Double(1.00, 100.00))
				.RuleFor(f => f.CurrentUnitPrice, d => d.Random.Double(10.00, 100.00))
				.RuleFor(f => f.OriginalUnitPrice, d => d.Random.Double(10.00, 100.00));
			var tireManufacturer = new List<string>() { "Michelin", "Firestone", "Bridgestone" };
			var fd_FleetTireDetails = new Faker<FleetTireDetails>()
				.RuleFor(f => f.AspectRatio, d => d.Random.Long(1, 100))
				.RuleFor(f => f.Class, d => d.Random.Word())
				.RuleFor(f => f.Construction, d => d.Lorem.Word())
				.RuleFor(f => f.LoadRange, d => d.Lorem.Word())
				.RuleFor(f => f.Manufacturer, d => d.Random.ListItem(tireManufacturer))
				.RuleFor(f => f.Model, d => d.Random.AlphaNumeric(4))
				.RuleFor(f => f.Ply, d => d.Random.AlphaNumeric(3))
				.RuleFor(f => f.RimDiameter, d => d.Random.Double(17, 32))
				.RuleFor(f => f.Size, d => d.Random.AlphaNumeric(3))
				.RuleFor(f => f.SpeedRating, d => d.Random.Word())
				.RuleFor(f => f.Width, d => d.Random.Long(5, 12));
			var fd_FleetDetailTire = new Faker<FleetDetailTire>()
				.RuleFor(f => f.CreatedBy, fd_FleetUser)
				.RuleFor(f => f.Cause, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ItemNotes, fd_FleetNote.Generate(3).ToArray())
				.RuleFor(f => f.CostSaving, d => d.Random.Bool())
				.RuleFor(f => f.DiscountExclusion, d => d.Random.Bool())
				.RuleFor(f => f.FleetExternalReference, new Guid().ToString())
				.RuleFor(f => f.ItemDescription, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ServiceCode, fd_FleetServiceCode.Generate())
				.RuleFor(f => f.CreatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.ItemStatus, d => d.Lorem.Word())
				.RuleFor(f => f.LineItemId, d => d.Random.Long(10001,19999))
				.RuleFor(f => f.Manufacturer, d => d.Company.CompanyName())
				.RuleFor(f => f.NationalCatalogCode, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.PartNumber, d => d.Random.AlphaNumeric(5))
				.RuleFor(f => f.RejectionReason, d => d.Lorem.Sentence(12))
				.RuleFor(f => f.UpdatedBy, fd_FleetUser.Generate())
				.RuleFor(f => f.Values, fd_FleetPartValues.Generate())
				.RuleFor(f => f.Details, fd_FleetTireDetails.Generate());
			var fd_FleetDetailPart = new Faker<FleetDetailPart>()
				.RuleFor(f => f.CreatedBy, fd_FleetUser)
				.RuleFor(f => f.Cause, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ItemNotes, fd_FleetNote.Generate(3).ToArray())
				.RuleFor(f => f.CostSaving, d => d.Random.Bool())
				.RuleFor(f => f.DiscountExclusion, d => d.Random.Bool())
				.RuleFor(f => f.FleetExternalReference, new Guid().ToString())
				.RuleFor(f => f.ItemDescription, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ServiceCode, fd_FleetServiceCode.Generate())
				.RuleFor(f => f.CreatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.ItemStatus, d => d.Lorem.Word())
				.RuleFor(f => f.LineItemId, d => d.Random.Long(10001,19999))
				.RuleFor(f => f.Manufacturer, d => d.Company.CompanyName())
				.RuleFor(f => f.NationalCatalogCode, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.PartNumber, d => d.Random.AlphaNumeric(5))
				.RuleFor(f => f.RejectionReason, d => d.Lorem.Sentence(12))
				.RuleFor(f => f.UpdatedBy, fd_FleetUser.Generate())
				.RuleFor(f => f.Values, fd_FleetPartValues.Generate());
			var fd_FleetLaborValues = new Faker<FleetLaborValues>()
				.RuleFor(f => f.CurrentFlatRate, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.CurrentLaborRate, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.OriginalQuantity, d => d.Random.Int(1,200))
				.RuleFor(f => f.CurrentQuantity, d => d.Random.Int(1, 200))
				.RuleFor(f => f.CurrentTotalPrice, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.OriginalTotalPrice, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.CurrentLaborTimeHours, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.OriginalLaborRate, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.OriginalFlatRate, d => d.Random.Double(2.00, 2000.00))
				.RuleFor(f => f.OriginalLaborTimeHours, d => d.Random.Double(2.00, 2000.00));
			var fd_FleetDetailLabor = new Faker<FleetDetailLabor>()
				.RuleFor(f => f.Cause, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.Correction, d => d.Lorem.Sentence(5))
				.RuleFor(f => f.CostSaving, d => d.Random.Bool())
				.RuleFor(f => f.CreatedBy, fd_FleetUser)
				.RuleFor(f => f.CreatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.DiscountExclusion, d => d.Random.Bool())
				.RuleFor(f => f.FleetExternalReference, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.ItemDescription, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ItemNotes, fd_FleetNote.Generate(3).ToArray())
				.RuleFor(f => f.ItemStatus, d => d.Random.Word())
				.RuleFor(f => f.LineItemId, d => d.Random.Long(10001,19999))
				.RuleFor(f => f.NationalCatalogCode, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.RejectionReason, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ServiceCode, fd_FleetServiceCode.Generate())
				.RuleFor(f => f.UpdatedBy, fd_FleetUser.Generate())
				.RuleFor(f => f.UpdatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.Values, fd_FleetLaborValues.Generate());
			var fd_FleetFeeValues = new Faker<FleetFeeValues>()
				.RuleFor(f => f.CurrentQuantity, d => d.Random.Int(1,1000))
				.RuleFor(f => f.CurrentTotalPrice, d => d.Random.Double(1.00, 100.00))
				.RuleFor(f => f.OriginalQuantity, d => d.Random.Int(1,1000))
				.RuleFor(f => f.OriginalTotalPrice, d => d.Random.Double(1.00, 100.00))
				.RuleFor(f => f.CurrentUnitPrice, d => d.Random.Double(10.00, 100.00))
				.RuleFor(f => f.OriginalUnitPrice, d => d.Random.Double(10.00, 100.00));
			var fd_FleetDetailFee = new Faker<FleetDetailFee>()
				.RuleFor(f => f.CreatedBy, fd_FleetUser.Generate())
				.RuleFor(f => f.Cause, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.CostSaving, d => d.Random.Bool())
				.RuleFor(f => f.DiscountExclusion, d => d.Random.Bool())
				.RuleFor(f => f.FleetExternalReference, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.ItemDescription, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ItemNotes, d => fd_FleetNote.Generate(3).ToArray())
				.RuleFor(f => f.ServiceCode, fd_FleetServiceCode.Generate())
				.RuleFor(f => f.ItemStatus, d => d.Lorem.Word())
				.RuleFor(f => f.CreatedDateTime, d => d.Date.Past())
				.RuleFor(f => f.LineItemId, d => d.Random.Long(101, 999))
				.RuleFor(f => f.NationalCatalogCode, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.RejectionReason, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.UpdatedBy, fd_FleetUser)
				.RuleFor(f => f.Values, fd_FleetFeeValues.Generate());
			var fd_Measurement = new Faker<Measurement>()
				.RuleFor(f => f.Unit, d => d.Random.ListItem(unitMeasure))
				.RuleFor(f => f.Value, d => d.Random.Double(5, 20));
			var fd_PaymentType = new Faker<PaymentType>()
				.RuleFor(f => f.Description, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.Id, d => d.Random.Long(10001,19999));
			var fd_BillingContact = new Faker<BillingContact>()
				.RuleFor(f => f.EmailAddress, (f, e) => f.Internet.Email(e.FirstName, e.LastName))
				.RuleFor(f => f.FaxNumber, sd => sd.Phone.PhoneNumber("(###) ###-####"))
				.RuleFor(f => f.FirstName, sd => sd.Name.FirstName())
				.RuleFor(f => f.LastName, sd => sd.Name.LastName());
			var fd_Attributes = new Faker<Attributes>()
				.RuleFor(f => f.HertzLocation, d => d.Company.CompanyName());
			var fd_AuthorizationNumber = new Guid().ToString();
			var fd_Tax = new Faker<Tax>()
				.RuleFor(f => f.Amount, d => d.Random.Double(1.00, 10000.0))
				.RuleFor(f => f.Type, d => d.Lorem.Word());
			var fd_NationalCompany = new Faker<NationalCompany>()
				.RuleFor(f => f.Id, d => d.Random.Int(1, 100))
				.RuleFor(f => f.Name, d => d.Company.CompanyName());
			var fd_Billing = new Faker<BillingDetail>()
				.RuleFor(f => f.BillingContact, fd_BillingContact)
				.RuleFor(f => f.IndependentPaymentType, fd_PaymentType)
				.RuleFor(f => f.NationalCompany, fd_NationalCompany.Generate())
				.RuleFor(f => f.Taxes, fd_Tax.Generate(2).ToArray())
				.RuleFor(f => f.AiShopFeeShortPay, d => d.Random.Double(10.00, 200.00))
				.RuleFor(f => f.FleetNationalAccountCode, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.ManuallyPaid, d => d.Random.Bool())
				.RuleFor(f => f.NationalAccountCode, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.PayableAmount, d => d.Random.Double(20.00, 300.00))
				.RuleFor(f => f.ShopInvoiceNumber, d => d.Random.AlphaNumeric(5))
				.RuleFor(f => f.TaxExemptionCode, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.TaxExemptionExpiryDate, d => d.Date.Future())
				.RuleFor(f => f.TaxTotal, d => d.Random.Double(10.00, 100.00))
				.RuleFor(f => f.Taxes, fd_Tax.Generate(3).ToArray())
				.RuleFor(f => f.Total, d => d.Random.Double(20.00, 1000.00));
			var fd_ClientNotificationAddress = new Faker<ClientNotificationAddress>()
				.RuleFor(f => f.EmailAddress, sd => sd.Internet.Email())
				.RuleFor(f => f.IsCurrent, sd => sd.Random.Bool());
			var fd_ClientApproval = new Faker<ClientApproval>()
				.RuleFor(f => f.ClientApprovalUrl, sd => sd.Internet.Url())
				.RuleFor(f => f.CompletedByName, sd => sd.Name.FullName())
				.RuleFor(f => f.NotificationEmailAddresses, fd_ClientNotificationAddress.Generate(3).ToArray());
			var fd_Client = new Faker<Client>()
				.RuleFor(f => f.ClientApproval, fd_ClientApproval.Generate())
				.RuleFor(f => f.FleetReference, d => d.Random.AlphaNumeric(10));
			var fd_Diagnostics = new Faker<Diagnostic>()
				.RuleFor(f => f.Measurement, fd_Measurement)
				.RuleFor(f => f.Index, d => d.UniqueIndex)
				.RuleFor(f => f.SubType, d => d.Random.Word())
				.RuleFor(f => f.Type, d => d.Random.Word());
			var fd_ExternalTicketId = 0;
			var fd_Items = new Faker<FleetDetailItems>()
				.RuleFor(f => f.Fees, fd_FleetDetailFee.Generate(3).ToArray())
				.RuleFor(f => f.Labors, fd_FleetDetailLabor.Generate(3).ToArray())
				.RuleFor(f => f.Parts, fd_FleetDetailPart.Generate(3).ToArray())
				.RuleFor(f => f.Tires, fd_FleetDetailTire.Generate(4).ToArray());
			var fd_Lifecycle = new Faker<FleetLifecycle>()
				.RuleFor(f => f.CreatedByUser, fd_FleetUser.Generate())
				.RuleFor(f => f.UpdatedByUser, fd_FleetUser.Generate())
				.RuleFor(f => f.DowntimeAudits, fd_DownTimeAudit.Generate(3).ToArray())
				.RuleFor(f => f.Status, d => d.Lorem.Word());

			var fd_PaymentHistory = new Faker<PaymentHistory>()
				.RuleFor(f => f.PaymentStatus, fd_PaymentStatus)
				.RuleFor(f => f.PaymentType, fd_PaymentType)
				.RuleFor(f => f.Reference, d => d.Random.AlphaNumeric(5))
				.RuleFor(f => f.Amount, d => d.Random.Double(1.00, 1000.00));
			var fd_PortalUrl = "";
			var fd_RepairOrderId = new Guid().ToString();
			var fd_Shop = new Faker<FleetShop>()
				.RuleFor(f => f.Address, fd_Address)
				.RuleFor(f => f.BillingAddress, fd_Address)
				.RuleFor(f => f.BillingContact, fd_BillingContact)
				.RuleFor(f => f.AllowedIndependentPaymentTypes, fd_PaymentType.Generate(3).ToArray())
				.RuleFor(f => f.NationalPaymentDirections, fd_PaymentDirection.Generate(3).ToArray())
				.RuleFor(f => f.Name, d => d.Name.FullName())
				.RuleFor(f => f.DefaultIndependentPaymentTypeId, d => d.Random.Long(10001, 19999))
				.RuleFor(f => f.EmailAddress, d => d.Internet.Email())
				.RuleFor(f => f.FaxNumber, d => d.Phone.PhoneNumber("(###) ###-####"))
				.RuleFor(f => f.FederalTaxId, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.FleetNationalAccountCode, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.FleetShopId1, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.FleetShopId2, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.IsActiveToFleet, d => d.Random.Bool())
				.RuleFor(f => f.IsCompliant, d => d.Random.Bool())
				.RuleFor(f => f.IsPreferredShop, d => d.Random.Bool())
				.RuleFor(f => f.LegalName, d => d.Name.FullName())
				.RuleFor(f => f.NationalAccountCode, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.NationalStoreNumber, d => d.Random.Int(1, 300).ToString())
				.RuleFor(f => f.OverrideNonPreferredFee, d => d.Random.Bool())
				.RuleFor(f => f.ProvincialTaxId, d => d.Random.AlphaNumeric(10))
				.RuleFor(f => f.Telephone, d => d.Phone.PhoneNumber("(###) ###-####"));
			var fd_ShopContact = new Faker<ShopContact>()
				.RuleFor(f => f.Name, d => d.Name.FullName())
				.RuleFor(f => f.TelephoneNumber, sd => sd.Phone.PhoneNumber("(###) ###-####"));
			var carMake = new List<string>{"Ford","Toyota", "Nissan", "Chevrolet"};
			var fd_Vehicle = new Faker<FleetVehicle>()
				.RuleFor(f => f.Driver, fd_Driver)
				.RuleFor(f => f.Make, d => d.Random.ListItem(carMake))
				.RuleFor(f => f.EngineIdleHours, d => d.Random.Long(10001,20000))
				.RuleFor(f => f.FleetHierarchyReference, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.ModelDescription, d => d.Lorem.Sentence(10))
				.RuleFor(f => f.ModelYear, d => d.Random.Int(1999, DateTime.Now.Year - 1))
				.RuleFor(f => f.OdometerReading, d => d.Random.Int(1, 250000))
				.RuleFor(f => f.OdometerUnits, "Miles")
				.RuleFor(f => f.UnitId, d => d.Random.AlphaNumeric(8))
				.RuleFor(f => f.Vin, d => d.Random.AlphaNumeric(16));


			var roFaker = new FleetRepairOrderDetailNotification() {
				Attributes = fd_Attributes.Generate(),
				AuthorizationNumber = fd_AuthorizationNumber,
				Billing = fd_Billing.Generate(),
				Client = fd_Client.Generate(),
				Diagnostics = fd_Diagnostics.Generate(3).ToArray(),
				ExternalTicketId = fd_ExternalTicketId,
				Items = fd_Items.Generate(),
				Lifecycle = fd_Lifecycle.Generate(),
				Notes = fd_FleetNote.Generate(3).ToArray(),
				PaymentHistory = fd_PaymentHistory.Generate(3).ToArray(),
				PortalUrl = fd_PortalUrl,
				RepairOrderId = fd_RepairOrderId,
				Shop = fd_Shop.Generate(),
				ShopContact = fd_ShopContact.Generate(),
				Vehicle = fd_Vehicle.Generate()

			};
			var json = JsonSerializer.Serialize(roFaker);
			Console.WriteLine(json);
			Console.ReadLine();