namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _merge_project : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetVerificationDetails",
                c => new
                    {
                        AssetVerificationDetailsID = c.Int(nullable: false, identity: true),
                        AssetID = c.String(),
                        RefNo = c.String(),
                        UserdBy = c.String(),
                        Condition = c.String(),
                        Remark = c.String(),
                        AssetVerificationID = c.String(maxLength: 128),
                        AssetBarcodeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AssetVerificationDetailsID)
                .ForeignKey("dbo.AssetBarcodes", t => t.AssetBarcodeID)
                .ForeignKey("dbo.AssetVerifications", t => t.AssetVerificationID)
                .Index(t => t.AssetVerificationID)
                .Index(t => t.AssetBarcodeID);
            
            CreateTable(
                "dbo.AssetVerifications",
                c => new
                    {
                        AssetVerificationID = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        LocationCode = c.String(),
                        VerificationBy = c.String(),
                        Remark = c.String(),
                        ApprovedBy = c.String(),
                        ApprovedAt = c.DateTime(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AssetVerificationID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.CustomeFieldSetups",
                c => new
                    {
                        CustomeFieldSetupID = c.Int(nullable: false, identity: true),
                        ItemType = c.String(),
                        CustomField1 = c.String(),
                        CustomField2 = c.String(),
                        CustomField3 = c.String(),
                        CustomField4 = c.String(),
                        CustomField5 = c.String(),
                        CustomField6 = c.String(),
                        CodeLength = c.Int(nullable: false),
                        ItemCodeGenerate = c.Boolean(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomeFieldSetupID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemsID = c.String(nullable: false, maxLength: 128),
                        ItemType = c.String(),
                        CustomFiled1 = c.String(),
                        CustomField2 = c.String(),
                        CustomField3 = c.String(),
                        CustomField4 = c.String(),
                        CustomField5 = c.String(),
                        CustomField6 = c.String(),
                        SupplierItemCode = c.String(),
                        Uom = c.String(),
                        Status = c.String(),
                        MaxQty = c.String(),
                        ReOrderQty = c.String(),
                        MinimumQty = c.String(),
                        BatchItem = c.Boolean(nullable: false),
                        ServiceItem = c.Boolean(nullable: false),
                        ShowInFrontEnd = c.Boolean(nullable: false),
                        Discount = c.Boolean(nullable: false),
                        CustomerReturnOrder = c.Boolean(nullable: false),
                        SerialItems = c.Boolean(nullable: false),
                        Image = c.Binary(storeType: "image"),
                        CustomeFieldSetupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemsID)
                .ForeignKey("dbo.CustomeFieldSetups", t => t.CustomeFieldSetupID)
                .Index(t => t.CustomeFieldSetupID);
            
            CreateTable(
                "dbo.PoItems",
                c => new
                    {
                        PoItemsID = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Qty = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        Colors = c.String(),
                        Width = c.String(),
                        Unit = c.String(),
                        SubTotal = c.Double(nullable: false),
                        ItemsID = c.String(maxLength: 128),
                        POID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PoItemsID)
                .ForeignKey("dbo.Items", t => t.ItemsID)
                .ForeignKey("dbo.POes", t => t.POID)
                .Index(t => t.ItemsID)
                .Index(t => t.POID);
            
            CreateTable(
                "dbo.POes",
                c => new
                    {
                        POID = c.String(nullable: false, maxLength: 128),
                        SupplierMasterID = c.String(maxLength: 128),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                        CompanyCode = c.String(),
                        CompanyName = c.String(),
                        CompamyAddress = c.String(),
                        ReferenceNo = c.String(),
                        Date = c.String(),
                        PurchaseType = c.String(),
                        Currency = c.String(),
                        Country = c.String(),
                        ShippingType = c.String(),
                        DeliveryDate = c.String(),
                        port = c.String(),
                        ShippingDate = c.String(),
                        HandleBy = c.String(),
                        CreditTerms = c.String(),
                        ReturnPolicy = c.String(),
                        Qty = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.POID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .ForeignKey("dbo.SupplierMasters", t => t.SupplierMasterID)
                .Index(t => t.SupplierMasterID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.GRNs",
                c => new
                    {
                        GRNID = c.String(nullable: false, maxLength: 128),
                        LocationCode = c.String(),
                        POID = c.String(maxLength: 128),
                        PoDate = c.String(),
                        Date = c.String(),
                        Supplier = c.String(),
                        SupplierCode = c.String(),
                        SupplierInvoiceNo = c.String(),
                        InvoiceDate = c.String(),
                        ShipmentType = c.String(),
                        Currency = c.String(),
                        ExchangeRate = c.String(),
                    })
                .PrimaryKey(t => t.GRNID)
                .ForeignKey("dbo.POes", t => t.POID)
                .Index(t => t.POID);
            
            CreateTable(
                "dbo.GrnItems",
                c => new
                    {
                        GrnItemsID = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(),
                        Description = c.String(),
                        Color = c.String(),
                        Width = c.String(),
                        Unit = c.String(),
                        Qty = c.Double(nullable: false),
                        ReceivedQty = c.Double(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        ReceivedPrice = c.Double(nullable: false),
                        LineDiscount = c.Double(nullable: false),
                        waistadeQty = c.Double(nullable: false),
                        SubTotal = c.Double(nullable: false),
                        GRNID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.GrnItemsID)
                .ForeignKey("dbo.GRNs", t => t.GRNID)
                .Index(t => t.GRNID);
            
            CreateTable(
                "dbo.SupplierMasters",
                c => new
                    {
                        SupplierMasterID = c.String(nullable: false, maxLength: 128),
                        SupplierName = c.String(),
                        SupplierType = c.String(),
                        SupplierAddress = c.String(),
                        City = c.String(),
                        Country = c.String(),
                        Status = c.String(),
                        ContactName = c.String(),
                        ContactTitle = c.String(),
                        TelephoneNumber = c.String(),
                        FaxNumber = c.String(),
                        EmailAddress = c.String(),
                        WebAddress = c.String(),
                        PosalCode = c.String(),
                        BankName = c.String(),
                        AccountNumber = c.String(),
                        ChequeType = c.String(),
                        Currency = c.String(),
                        CreditTerm = c.String(),
                        AccountName = c.String(),
                        Branch = c.String(),
                        BankAddress = c.String(),
                        SvatNo = c.String(),
                        CompanyID = c.Int(nullable: false),
                        POID = c.String(),
                    })
                .PrimaryKey(t => t.SupplierMasterID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.SerialEntries",
                c => new
                    {
                        SerialEntryID = c.String(nullable: false, maxLength: 128),
                        RollNo = c.String(),
                        SRNo = c.Int(nullable: false),
                        TotalMeters = c.Double(nullable: false),
                        Color = c.String(),
                        ItemsID = c.String(maxLength: 128),
                        SpecialEntryID = c.String(),
                    })
                .PrimaryKey(t => t.SerialEntryID)
                .ForeignKey("dbo.Items", t => t.ItemsID)
                .Index(t => t.ItemsID);
            
            CreateTable(
                "dbo.SpecialEntries",
                c => new
                    {
                        SpecialEntryID = c.String(nullable: false, maxLength: 128),
                        PoNo = c.String(),
                        GrnNo = c.String(),
                        Date = c.String(),
                        DispatchNo = c.String(),
                        TotalRollQty = c.String(),
                        TotalLength = c.String(),
                        Remarks = c.String(),
                        CompanyID = c.Int(nullable: false),
                        SerialEntryID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SpecialEntryID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .ForeignKey("dbo.SerialEntries", t => t.SerialEntryID)
                .Index(t => t.CompanyID)
                .Index(t => t.SerialEntryID);
            
            CreateTable(
                "dbo.StockRequisitionDetails",
                c => new
                    {
                        StockRequisitionDetailsID = c.Int(nullable: false, identity: true),
                        ItemCode = c.String(),
                        Description = c.String(),
                        AvailableBalance = c.Double(nullable: false),
                        RequestedQty = c.Int(nullable: false),
                        StockRequisitionID = c.String(maxLength: 128),
                        Items_ItemsID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StockRequisitionDetailsID)
                .ForeignKey("dbo.Items", t => t.Items_ItemsID)
                .ForeignKey("dbo.StockRequisitions", t => t.StockRequisitionID)
                .Index(t => t.StockRequisitionID)
                .Index(t => t.Items_ItemsID);
            
            CreateTable(
                "dbo.StockRequisitions",
                c => new
                    {
                        StockRequisitionID = c.String(nullable: false, maxLength: 128),
                        LocationCode = c.String(),
                        LocationName = c.String(),
                        Date = c.String(),
                        FromDepartment = c.String(),
                        ToDepartment = c.String(),
                        StockRequisitionDetailsID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockRequisitionID);
            
            CreateTable(
                "dbo.AssetLedgers",
                c => new
                    {
                        TransactionID = c.String(nullable: false, maxLength: 128),
                        LocationCode = c.String(),
                        Date = c.DateTime(nullable: false),
                        AssetID = c.String(),
                        DocType = c.String(),
                        DocNo = c.String(),
                        AssetType = c.String(),
                        UsedBy = c.String(),
                        Status = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.StockLedgers",
                c => new
                    {
                        TransactionID = c.String(nullable: false, maxLength: 128),
                        ItemCode = c.String(),
                        ItemType = c.String(),
                        Category = c.String(),
                        TransactionType = c.String(),
                        DocNo = c.String(),
                        TransactionTime = c.DateTime(nullable: false),
                        TransactionBy = c.String(),
                        Qty = c.Double(nullable: false),
                        Balance = c.Double(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.VehicleRequisitions",
                c => new
                    {
                        VehicleRequisitionID = c.String(nullable: false, maxLength: 128),
                        RequestDate = c.String(),
                        RequestTime = c.String(),
                        RequestBy = c.String(),
                        Department = c.String(),
                        VehicleType = c.String(),
                        Purpose = c.String(),
                        DriverName = c.String(),
                        ContactNo = c.String(),
                        VehicleNo = c.String(),
                        SpeedDialNo = c.String(),
                        Payment = c.String(),
                        AssignToJob = c.String(),
                        TimeStart = c.String(),
                        TimeFinished = c.String(),
                        MyProperty = c.String(),
                        StartMeter = c.String(),
                        FinishedMeter = c.String(),
                        TravelledDistance = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VehicleRequisitionID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            AddColumn("dbo.AssetBarcodes", "AssetName", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Description", c => c.String());
            AddColumn("dbo.AssetBarcodes", "AlternetAsset", c => c.String());
            AddColumn("dbo.AssetBarcodes", "AssetStatus", c => c.String());
            AddColumn("dbo.AssetBarcodes", "WarrantyPeriod", c => c.String());
            AddColumn("dbo.AssetBarcodes", "PurchaseLocation", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Location", c => c.String());
            AddColumn("dbo.AssetBarcodes", "AssetUsedBy", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Category01", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Category02", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Category03", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Category04", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Category05", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CustomField1", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CustomField2", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CustomField3", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CustomField4", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CustomField5", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CustomField6", c => c.String());
            AddColumn("dbo.AssetBarcodes", "PurchaseDate", c => c.String());
            AddColumn("dbo.AssetBarcodes", "PurchasePrice", c => c.String());
            AddColumn("dbo.AssetBarcodes", "SupplierName", c => c.String());
            AddColumn("dbo.AssetBarcodes", "DepreciationMode", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CurrentValue", c => c.String());
            AddColumn("dbo.AssetBarcodes", "CompanyID", c => c.Int(nullable: false));
            AddColumn("dbo.AssetBarcodes", "CustomeFieldSetupID", c => c.Int(nullable: false));
            CreateIndex("dbo.AssetBarcodes", "CompanyID");
            CreateIndex("dbo.AssetBarcodes", "CustomeFieldSetupID");
            AddForeignKey("dbo.AssetBarcodes", "CompanyID", "dbo.Companies", "CompanyID");
            AddForeignKey("dbo.AssetBarcodes", "CustomeFieldSetupID", "dbo.CustomeFieldSetups", "CustomeFieldSetupID");
            DropColumn("dbo.AssetBarcodes", "Model");
            DropColumn("dbo.AssetBarcodes", "Brand");
            DropColumn("dbo.AssetBarcodes", "MachineType");
            DropColumn("dbo.AssetBarcodes", "AssetNo");
            DropColumn("dbo.AssetBarcodes", "MachineSerialNo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AssetBarcodes", "MachineSerialNo", c => c.String());
            AddColumn("dbo.AssetBarcodes", "AssetNo", c => c.String());
            AddColumn("dbo.AssetBarcodes", "MachineType", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Brand", c => c.String());
            AddColumn("dbo.AssetBarcodes", "Model", c => c.String());
            DropForeignKey("dbo.VehicleRequisitions", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.StockLedgers", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.AssetLedgers", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.StockRequisitionDetails", "StockRequisitionID", "dbo.StockRequisitions");
            DropForeignKey("dbo.StockRequisitionDetails", "Items_ItemsID", "dbo.Items");
            DropForeignKey("dbo.SpecialEntries", "SerialEntryID", "dbo.SerialEntries");
            DropForeignKey("dbo.SpecialEntries", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.SerialEntries", "ItemsID", "dbo.Items");
            DropForeignKey("dbo.POes", "SupplierMasterID", "dbo.SupplierMasters");
            DropForeignKey("dbo.SupplierMasters", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.PoItems", "POID", "dbo.POes");
            DropForeignKey("dbo.GRNs", "POID", "dbo.POes");
            DropForeignKey("dbo.GrnItems", "GRNID", "dbo.GRNs");
            DropForeignKey("dbo.POes", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.PoItems", "ItemsID", "dbo.Items");
            DropForeignKey("dbo.Items", "CustomeFieldSetupID", "dbo.CustomeFieldSetups");
            DropForeignKey("dbo.CustomeFieldSetups", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.AssetBarcodes", "CustomeFieldSetupID", "dbo.CustomeFieldSetups");
            DropForeignKey("dbo.AssetBarcodes", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.AssetVerifications", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.AssetVerificationDetails", "AssetVerificationID", "dbo.AssetVerifications");
            DropForeignKey("dbo.AssetVerificationDetails", "AssetBarcodeID", "dbo.AssetBarcodes");
            DropIndex("dbo.VehicleRequisitions", new[] { "CompanyID" });
            DropIndex("dbo.StockLedgers", new[] { "CompanyID" });
            DropIndex("dbo.AssetLedgers", new[] { "CompanyID" });
            DropIndex("dbo.StockRequisitionDetails", new[] { "Items_ItemsID" });
            DropIndex("dbo.StockRequisitionDetails", new[] { "StockRequisitionID" });
            DropIndex("dbo.SpecialEntries", new[] { "SerialEntryID" });
            DropIndex("dbo.SpecialEntries", new[] { "CompanyID" });
            DropIndex("dbo.SerialEntries", new[] { "ItemsID" });
            DropIndex("dbo.SupplierMasters", new[] { "CompanyID" });
            DropIndex("dbo.GrnItems", new[] { "GRNID" });
            DropIndex("dbo.GRNs", new[] { "POID" });
            DropIndex("dbo.POes", new[] { "CompanyID" });
            DropIndex("dbo.POes", new[] { "SupplierMasterID" });
            DropIndex("dbo.PoItems", new[] { "POID" });
            DropIndex("dbo.PoItems", new[] { "ItemsID" });
            DropIndex("dbo.Items", new[] { "CustomeFieldSetupID" });
            DropIndex("dbo.CustomeFieldSetups", new[] { "CompanyID" });
            DropIndex("dbo.AssetVerifications", new[] { "CompanyID" });
            DropIndex("dbo.AssetVerificationDetails", new[] { "AssetBarcodeID" });
            DropIndex("dbo.AssetVerificationDetails", new[] { "AssetVerificationID" });
            DropIndex("dbo.AssetBarcodes", new[] { "CustomeFieldSetupID" });
            DropIndex("dbo.AssetBarcodes", new[] { "CompanyID" });
            DropColumn("dbo.AssetBarcodes", "CustomeFieldSetupID");
            DropColumn("dbo.AssetBarcodes", "CompanyID");
            DropColumn("dbo.AssetBarcodes", "CurrentValue");
            DropColumn("dbo.AssetBarcodes", "DepreciationMode");
            DropColumn("dbo.AssetBarcodes", "SupplierName");
            DropColumn("dbo.AssetBarcodes", "PurchasePrice");
            DropColumn("dbo.AssetBarcodes", "PurchaseDate");
            DropColumn("dbo.AssetBarcodes", "CustomField6");
            DropColumn("dbo.AssetBarcodes", "CustomField5");
            DropColumn("dbo.AssetBarcodes", "CustomField4");
            DropColumn("dbo.AssetBarcodes", "CustomField3");
            DropColumn("dbo.AssetBarcodes", "CustomField2");
            DropColumn("dbo.AssetBarcodes", "CustomField1");
            DropColumn("dbo.AssetBarcodes", "Category05");
            DropColumn("dbo.AssetBarcodes", "Category04");
            DropColumn("dbo.AssetBarcodes", "Category03");
            DropColumn("dbo.AssetBarcodes", "Category02");
            DropColumn("dbo.AssetBarcodes", "Category01");
            DropColumn("dbo.AssetBarcodes", "AssetUsedBy");
            DropColumn("dbo.AssetBarcodes", "Location");
            DropColumn("dbo.AssetBarcodes", "PurchaseLocation");
            DropColumn("dbo.AssetBarcodes", "WarrantyPeriod");
            DropColumn("dbo.AssetBarcodes", "AssetStatus");
            DropColumn("dbo.AssetBarcodes", "AlternetAsset");
            DropColumn("dbo.AssetBarcodes", "Description");
            DropColumn("dbo.AssetBarcodes", "AssetName");
            DropTable("dbo.VehicleRequisitions");
            DropTable("dbo.StockLedgers");
            DropTable("dbo.AssetLedgers");
            DropTable("dbo.StockRequisitions");
            DropTable("dbo.StockRequisitionDetails");
            DropTable("dbo.SpecialEntries");
            DropTable("dbo.SerialEntries");
            DropTable("dbo.SupplierMasters");
            DropTable("dbo.GrnItems");
            DropTable("dbo.GRNs");
            DropTable("dbo.POes");
            DropTable("dbo.PoItems");
            DropTable("dbo.Items");
            DropTable("dbo.CustomeFieldSetups");
            DropTable("dbo.AssetVerifications");
            DropTable("dbo.AssetVerificationDetails");
        }
    }
}
