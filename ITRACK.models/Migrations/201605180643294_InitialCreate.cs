namespace ITRACK.models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AssetBarcodes",
                c => new
                    {
                        AssetBarcodeID = c.String(nullable: false, maxLength: 128),
                        Model = c.String(),
                        Brand = c.String(),
                        MachineType = c.String(),
                        AssetNo = c.String(),
                        MachineSerialNo = c.String(),
                    })
                .PrimaryKey(t => t.AssetBarcodeID);
            
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        AwardID = c.Int(nullable: false, identity: true),
                        AwardName = c.String(),
                        AwardDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AwardID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                        NicNo = c.String(),
                        EPFNo = c.String(),
                        ETFNo = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.String(),
                        MaritalStatus = c.String(),
                        Department = c.String(),
                        Designation = c.String(),
                        JobStatus = c.String(),
                        Address = c.String(),
                        MobileNo = c.String(),
                        LandNo = c.String(),
                        EmailAddress = c.String(),
                        EmergencyContactNo = c.String(),
                        EmergencyContactPerson = c.String(),
                        Image = c.Binary(storeType: "image"),
                        CompanyID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyID = c.Int(nullable: false, identity: true),
                        LocationCode = c.String(nullable: false, maxLength: 10),
                        CompanyName = c.String(),
                        CompanyAddress = c.String(),
                        TeleNo = c.String(),
                        FaxNo = c.String(),
                        isDefaultCompany = c.Boolean(nullable: false),
                        GroupID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CompanyID)
                .ForeignKey("dbo.Groups", t => t.GroupID)
                .Index(t => t.GroupID);
            
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        BuyerID = c.Int(nullable: false, identity: true),
                        BuyerName = c.String(),
                        BuyerShippingAddress = c.String(),
                        BuyerTeleNo = c.String(),
                        FaxNo = c.String(),
                        EmailAddress = c.String(),
                        CompanyID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.BuyerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Styles",
                c => new
                    {
                        StyleID = c.String(nullable: false, maxLength: 128),
                        Article = c.String(),
                        Season = c.String(),
                        GarmantType = c.String(),
                        Status = c.String(),
                        Remark = c.String(),
                        FeedingRule = c.String(),
                        ForecastingRule = c.String(),
                        CompanyID = c.Int(nullable: false),
                        BuyerID = c.Int(nullable: false),
                        WorkflowID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.StyleID)
                .ForeignKey("dbo.Buyers", t => t.BuyerID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .ForeignKey("dbo.Workflows", t => t.WorkflowID)
                .Index(t => t.CompanyID)
                .Index(t => t.BuyerID)
                .Index(t => t.WorkflowID);
            
            CreateTable(
                "dbo.CutIssueHeaders",
                c => new
                    {
                        CutIssueHeaderID = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        StyleNo = c.String(),
                        Type = c.String(),
                        LineNo = c.String(),
                        InputRequestedBy = c.String(),
                        Remark = c.String(),
                        Style_StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CutIssueHeaderID)
                .ForeignKey("dbo.Styles", t => t.Style_StyleID)
                .Index(t => t.Style_StyleID);
            
            CreateTable(
                "dbo.CutIssuItems",
                c => new
                    {
                        CutIssuItemID = c.Int(nullable: false, identity: true),
                        CutNo = c.String(),
                        PONo = c.String(),
                        LotNo = c.Int(nullable: false),
                        Color = c.String(),
                        Size = c.String(),
                        NoOfItem = c.Int(nullable: false),
                        From = c.Int(nullable: false),
                        To = c.Int(nullable: false),
                        CutIssueHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CutIssuItemID)
                .ForeignKey("dbo.CutIssueHeaders", t => t.CutIssueHeaderID)
                .Index(t => t.CutIssueHeaderID);
            
            CreateTable(
                "dbo.CuttingHeaders",
                c => new
                    {
                        CuttingHeaderID = c.String(nullable: false, maxLength: 128),
                        OrderQuantity = c.Int(nullable: false),
                        PlanQuantity = c.Int(nullable: false),
                        BundleSize = c.Int(nullable: false),
                        ItemType = c.String(),
                        Date = c.DateTime(nullable: false),
                        Remark = c.String(),
                        status = c.String(),
                        StyleID = c.String(maxLength: 128),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.CuttingHeaderID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.CuttingItems",
                c => new
                    {
                        CuttingItemID = c.Int(nullable: false, identity: true),
                        CutNo = c.Int(nullable: false),
                        PoNo = c.String(),
                        MarkerNo = c.String(),
                        FabricType = c.String(),
                        Date = c.DateTime(nullable: false),
                        MarkerLenth = c.Double(nullable: false),
                        MarkerWidth = c.Double(nullable: false),
                        LineNo = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Length = c.String(),
                        NoOfItem = c.Int(nullable: false),
                        NoOfLayer = c.Int(nullable: false),
                        NoOfPlysPlaned = c.Int(nullable: false),
                        NoOfPlysLayed = c.Int(nullable: false),
                        isGenaratedTags = c.Boolean(nullable: false),
                        GenaratedTime = c.String(),
                        isPrinted = c.Boolean(nullable: false),
                        PrinteTime = c.String(),
                        CuttingHeaderID = c.String(maxLength: 128),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.CuttingItemID)
                .ForeignKey("dbo.CuttingHeaders", t => t.CuttingHeaderID)
                .Index(t => t.CuttingHeaderID);
            
            CreateTable(
                "dbo.BundleHeaders",
                c => new
                    {
                        BundleHeaderID = c.Long(nullable: false, identity: true),
                        isBundleTagsGerated = c.Boolean(nullable: false),
                        BundleTagGenaratedBy = c.String(),
                        BundleTagGenaratedTime = c.String(),
                        isOprationTagGenated = c.Boolean(nullable: false),
                        OprationTagGeratedBy = c.String(),
                        OprationTagGenaratedTime = c.String(),
                        GenaratedDate = c.DateTime(nullable: false),
                        isCompleteGenarateTags = c.Boolean(nullable: false),
                        CuttingItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BundleHeaderID)
                .ForeignKey("dbo.CuttingItems", t => t.CuttingItemID)
                .Index(t => t.CuttingItemID);
            
            CreateTable(
                "dbo.DailyProductions",
                c => new
                    {
                        DailyProductionID = c.Int(nullable: false, identity: true),
                        PoNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        HourNo = c.Int(nullable: false),
                        LineNo = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Type = c.String(),
                        Qty = c.Double(nullable: false),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DailyProductionID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.DividingPlanHeaders",
                c => new
                    {
                        DividingPlanheaderID = c.Int(nullable: false, identity: true),
                        LineNo = c.String(),
                        TotalEmployee = c.Int(nullable: false),
                        Target = c.Int(nullable: false),
                        ProductionPerHour = c.Int(nullable: false),
                        Remark = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.DividingPlanheaderID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.FabricDetails",
                c => new
                    {
                        FabricDetailsID = c.Int(nullable: false, identity: true),
                        FabricType = c.String(),
                        FabricName = c.String(),
                        Color = c.String(),
                        PlanedConsumtion = c.Double(nullable: false),
                        Remark = c.String(),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FabricDetailsID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.PurchaseOrderHeaders",
                c => new
                    {
                        PurchaseOrderHeaderID = c.String(nullable: false, maxLength: 128),
                        Article = c.String(),
                        Season = c.String(),
                        DeliveryTerms = c.String(),
                        PlaceWashingFactory = c.Boolean(nullable: false),
                        OrderPrice = c.Double(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        isOpen = c.Boolean(nullable: false),
                        StyleID = c.String(maxLength: 128),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.PurchaseOrderHeaderID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.PurchaseOrderItems",
                c => new
                    {
                        PurchaseOrderID = c.String(nullable: false, maxLength: 128),
                        Color = c.String(nullable: false, maxLength: 128),
                        Size = c.String(nullable: false, maxLength: 128),
                        Length = c.String(nullable: false, maxLength: 128),
                        Quantity = c.Int(nullable: false),
                        PurchaseOrderHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.PurchaseOrderID, t.Color, t.Size, t.Length })
                .ForeignKey("dbo.PurchaseOrderHeaders", t => t.PurchaseOrderHeaderID)
                .Index(t => t.PurchaseOrderHeaderID);
            
            CreateTable(
                "dbo.SketchDefinitions",
                c => new
                    {
                        SketchDefinitionID = c.Int(nullable: false, identity: true),
                        SketchName = c.String(),
                        Remark = c.String(),
                        ItemType = c.String(),
                        Image = c.Binary(storeType: "image"),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SketchDefinitionID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.PartDefinitions",
                c => new
                    {
                        PartDefinitionID = c.Int(nullable: false, identity: true),
                        PartName = c.String(),
                        ItemType = c.String(),
                        Remark = c.String(),
                        SketchDefinitionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PartDefinitionID)
                .ForeignKey("dbo.SketchDefinitions", t => t.SketchDefinitionID)
                .Index(t => t.SketchDefinitionID);
            
            CreateTable(
                "dbo.StyleOperations",
                c => new
                    {
                        StyleOperationID = c.Int(nullable: false, identity: true),
                        SMV = c.Double(nullable: false),
                        PartDefinitionID = c.String(),
                        PartDefinition_PartDefinitionID = c.Int(),
                    })
                .PrimaryKey(t => t.StyleOperationID)
                .ForeignKey("dbo.PartDefinitions", t => t.PartDefinition_PartDefinitionID)
                .Index(t => t.PartDefinition_PartDefinitionID);
            
            CreateTable(
                "dbo.Workflows",
                c => new
                    {
                        WorkflowID = c.Int(nullable: false, identity: true),
                        WorkflowName = c.String(),
                        Remark = c.String(),
                    })
                .PrimaryKey(t => t.WorkflowID);
            
            CreateTable(
                "dbo.WorkflowSetups",
                c => new
                    {
                        WorkflowSetupID = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(nullable: false),
                        WorkflowID = c.Int(nullable: false),
                        Workstation_WorkstationID = c.Int(),
                    })
                .PrimaryKey(t => t.WorkflowSetupID)
                .ForeignKey("dbo.Workflows", t => t.WorkflowID)
                .ForeignKey("dbo.Workstations", t => t.Workstation_WorkstationID)
                .Index(t => t.WorkflowID)
                .Index(t => t.Workstation_WorkstationID);
            
            CreateTable(
                "dbo.Workstations",
                c => new
                    {
                        WorkstationID = c.Int(nullable: false, identity: true),
                        WorkstationName = c.String(),
                        Remark = c.String(),
                        Employee_EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.WorkstationID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .Index(t => t.Employee_EmployeeID);
            
            CreateTable(
                "dbo.CuttingLedgerHeaders",
                c => new
                    {
                        CuttingLedgerHeaderID = c.String(nullable: false, maxLength: 128),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.CuttingLedgerHeaderID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.CuttingLedgers",
                c => new
                    {
                        Date = c.DateTime(nullable: false),
                        StyleNo = c.String(nullable: false, maxLength: 128),
                        Po = c.String(nullable: false, maxLength: 128),
                        LineNo = c.String(nullable: false, maxLength: 128),
                        Size = c.String(nullable: false, maxLength: 128),
                        Color = c.String(nullable: false, maxLength: 128),
                        TrasctionType = c.String(nullable: false, maxLength: 128),
                        DocNo = c.String(nullable: false, maxLength: 128),
                        TransactionID = c.Int(nullable: false),
                        TableCut = c.Int(nullable: false),
                        CompletedPcs = c.Int(nullable: false),
                        TotalCutOut = c.Int(nullable: false),
                        Cumulative = c.Int(nullable: false),
                        LineIn = c.Int(nullable: false),
                        TotalLineIn = c.Int(nullable: false),
                        LineInCumm = c.Int(nullable: false),
                        HTechIn = c.Int(nullable: false),
                        TotalHTech = c.Int(nullable: false),
                        HTCumm = c.Int(nullable: false),
                        Stock = c.Int(nullable: false),
                        StockCumm = c.Int(nullable: false),
                        CuttingLedgerHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Date, t.StyleNo, t.Po, t.LineNo, t.Size, t.Color, t.TrasctionType, t.DocNo })
                .ForeignKey("dbo.CuttingLedgerHeaders", t => t.CuttingLedgerHeaderID)
                .Index(t => t.CuttingLedgerHeaderID);
            
            CreateTable(
                "dbo.CuttingStocks",
                c => new
                    {
                        Date = c.DateTime(nullable: false),
                        StyleNo = c.String(nullable: false, maxLength: 128),
                        PoNo = c.String(nullable: false, maxLength: 128),
                        ProductionLineNo = c.String(nullable: false, maxLength: 128),
                        Color = c.String(nullable: false, maxLength: 128),
                        Size = c.String(nullable: false, maxLength: 128),
                        TNoteNo = c.String(nullable: false, maxLength: 128),
                        FabricType = c.String(),
                        HtechIn = c.Int(nullable: false),
                        LineIn = c.Int(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Date, t.StyleNo, t.PoNo, t.ProductionLineNo, t.Color, t.Size, t.TNoteNo })
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.DayendHeaders",
                c => new
                    {
                        DayendHeaderID = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        DayendTime = c.String(),
                        DayendBy = c.String(),
                        ApprovedBy = c.String(),
                        ApprovedAt = c.String(),
                        Status = c.String(),
                        CompanyID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.DayendHeaderID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.CuttingSummaries",
                c => new
                    {
                        CuttingSummaryID = c.Int(nullable: false, identity: true),
                        CuttingIdDetails = c.Int(nullable: false),
                        ProductionLineNo = c.String(),
                        StyleNo = c.String(),
                        MarkerNo = c.String(),
                        FabricType = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        NoPcs = c.Int(nullable: false),
                        HtechIn = c.Int(nullable: false),
                        LineIn = c.Int(nullable: false),
                        CuttingStock = c.Int(nullable: false),
                        DayendHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CuttingSummaryID)
                .ForeignKey("dbo.DayendHeaders", t => t.DayendHeaderID)
                .Index(t => t.DayendHeaderID);
            
            CreateTable(
                "dbo.Dayends",
                c => new
                    {
                        DayendID = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        LineNo = c.String(nullable: false, maxLength: 128),
                        StyleNo = c.String(nullable: false, maxLength: 128),
                        Color = c.String(nullable: false, maxLength: 128),
                        Size = c.String(nullable: false, maxLength: 128),
                        Length = c.String(),
                        CutQty = c.Int(nullable: false),
                        LineIn = c.Int(nullable: false),
                        LineOut = c.Int(nullable: false),
                        WHIn = c.Int(nullable: false),
                        WHOut = c.Int(nullable: false),
                        DayendHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.DayendID, t.Date, t.LineNo, t.StyleNo, t.Color, t.Size })
                .ForeignKey("dbo.DayendHeaders", t => t.DayendHeaderID)
                .Index(t => t.DayendHeaderID);
            
            CreateTable(
                "dbo.IndividualProductionSummeries",
                c => new
                    {
                        IndividualProductionSummeryID = c.String(nullable: false, maxLength: 128),
                        EmployeeID = c.String(),
                        OprationNo = c.String(),
                        Pcs = c.Int(nullable: false),
                        WorkingHours = c.Double(nullable: false),
                        OfftadredHours = c.Double(nullable: false),
                        OfftanderdEffiency = c.Double(nullable: false),
                        EarnSAH = c.Double(nullable: false),
                        Effiency = c.Double(nullable: false),
                        DayendHeaderID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IndividualProductionSummeryID)
                .ForeignKey("dbo.DayendHeaders", t => t.DayendHeaderID)
                .Index(t => t.DayendHeaderID);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        GroupID = c.String(nullable: false, maxLength: 128),
                        GroupName = c.String(),
                        Address = c.String(),
                        TeleNo = c.String(),
                        FaxNo = c.String(),
                    })
                .PrimaryKey(t => t.GroupID);
            
            CreateTable(
                "dbo.IndividualProductionDetails",
                c => new
                    {
                        EmployeeID = c.String(nullable: false, maxLength: 128),
                        StyleNo = c.String(nullable: false, maxLength: 128),
                        Date = c.DateTime(nullable: false),
                        HourNo = c.Int(nullable: false),
                        OperationNo = c.String(nullable: false, maxLength: 128),
                        WorkstationNo = c.Int(nullable: false),
                        OperationName = c.String(),
                        Pcs = c.Int(nullable: false),
                        SMV = c.Double(nullable: false),
                        SAH = c.Double(nullable: false),
                        Efficiency = c.Double(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.StyleNo, t.Date, t.HourNo, t.OperationNo })
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.OperationPools",
                c => new
                    {
                        OperationPoolID = c.String(nullable: false, maxLength: 128),
                        OpationName = c.String(),
                        MachineType = c.String(),
                        SMV = c.Double(nullable: false),
                        SMVType = c.String(),
                        Remark = c.String(),
                        PartName = c.String(),
                        OprationRole = c.String(),
                        OprationGrade = c.String(),
                        CompanyID = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedTime = c.String(),
                        CreatedDate = c.DateTime(),
                        LastModifiedBy = c.String(),
                        LastModifiedAt = c.String(),
                    })
                .PrimaryKey(t => t.OperationPoolID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.OprationBarcodes",
                c => new
                    {
                        OprationBarcodesID = c.String(nullable: false, maxLength: 128),
                        LineNo = c.String(),
                        StyleNo = c.String(),
                        OprationNO = c.String(),
                        OparationName = c.String(),
                        OprationGrade = c.String(),
                        OprationRole = c.String(),
                        PartName = c.String(),
                        isOparationComplete = c.Boolean(nullable: false),
                        OprationComplteAt = c.DateTime(nullable: false),
                        EmployeeID = c.String(maxLength: 128),
                        BundleDetailsID = c.Int(nullable: false),
                        OperationPoolID = c.String(maxLength: 128),
                        HourNo = c.String(),
                        WorkstationNo = c.Int(nullable: false),
                        OpNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OprationBarcodesID)
                .ForeignKey("dbo.BundleDetails", t => t.BundleDetailsID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.OperationPools", t => t.OperationPoolID)
                .Index(t => t.EmployeeID)
                .Index(t => t.BundleDetailsID)
                .Index(t => t.OperationPoolID);
            
            CreateTable(
                "dbo.BundleDetails",
                c => new
                    {
                        BundleDetailsID = c.Int(nullable: false, identity: true),
                        BundleNo = c.Int(nullable: false),
                        SerailNo = c.String(),
                        NoOfItem = c.Long(nullable: false),
                        CutNo = c.Long(nullable: false),
                        IsPrintBundleSticker = c.Boolean(nullable: false),
                        BundleStickerPrintedBy = c.String(),
                        BundleStickerPrintedTime = c.String(),
                        isBundleTagsPrinted = c.Boolean(nullable: false),
                        BundleTagPrintedBy = c.String(),
                        BundleTagPrintedTime = c.String(),
                        IsLineIn = c.Boolean(nullable: false),
                        LineInTime = c.DateTime(nullable: false),
                        IsHtechIn = c.Boolean(nullable: false),
                        HTechInTime = c.DateTime(nullable: false),
                        isLineOut = c.Boolean(nullable: false),
                        LineOutTime = c.DateTime(nullable: false),
                        isWhouseIn = c.Boolean(nullable: false),
                        WHouseInTime = c.DateTime(nullable: false),
                        isSuspended = c.Boolean(nullable: false),
                        BundleHeaderID = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BundleDetailsID)
                .ForeignKey("dbo.BundleHeaders", t => t.BundleHeaderID)
                .Index(t => t.BundleHeaderID);
            
            CreateTable(
                "dbo.ScaningTimeSchaduals",
                c => new
                    {
                        ScaningTimeSchadualID = c.Int(nullable: false, identity: true),
                        ScaningTime = c.String(),
                        HourNO = c.Int(nullable: false),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScaningTimeSchadualID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Werehouses",
                c => new
                    {
                        WerehouseID = c.Int(nullable: false, identity: true),
                        WerehouseName = c.String(),
                        Remark = c.String(),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WerehouseID)
                .ForeignKey("dbo.Companies", t => t.CompanyID)
                .Index(t => t.CompanyID);
            
            CreateTable(
                "dbo.Racks",
                c => new
                    {
                        RackID = c.Int(nullable: false, identity: true),
                        RackName = c.String(),
                        Remark = c.String(),
                        WerehouseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RackID)
                .ForeignKey("dbo.Werehouses", t => t.WerehouseID)
                .Index(t => t.WerehouseID);
            
            CreateTable(
                "dbo.Bins",
                c => new
                    {
                        BinID = c.Int(nullable: false, identity: true),
                        BinName = c.String(),
                        Remark = c.String(),
                        RackID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BinID)
                .ForeignKey("dbo.Racks", t => t.RackID)
                .Index(t => t.RackID);
            
            CreateTable(
                "dbo.PastEmployeements",
                c => new
                    {
                        PastEmployeementID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(),
                        Designation = c.String(),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        Remark = c.String(),
                        EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PastEmployeementID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Promotions",
                c => new
                    {
                        PromotionID = c.Int(nullable: false, identity: true),
                        FromDesignation = c.String(),
                        ToDesignation = c.String(),
                        PromotedDate = c.DateTime(nullable: false),
                        JobDescription = c.String(),
                        Remark = c.String(),
                        EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PromotionID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .Index(t => t.EmployeeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Role = c.String(),
                        UserStatus = c.String(),
                        Employee_EmployeeID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserID)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeID)
                .Index(t => t.Employee_EmployeeID);
            
            CreateTable(
                "dbo.DividingPlanItems",
                c => new
                    {
                        DividingPlanItemID = c.Int(nullable: false, identity: true),
                        OprationNo = c.String(),
                        OprationName = c.String(),
                        SMVType = c.String(),
                        MachineType = c.String(),
                        OperationRole = c.String(),
                        PartName = c.String(),
                        SMV = c.Double(nullable: false),
                        WorkstationNo = c.Int(nullable: false),
                        OpNo = c.Int(nullable: false),
                        DividingPlanHeaderID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DividingPlanItemID)
                .ForeignKey("dbo.DividingPlanHeaders", t => t.DividingPlanHeaderID)
                .Index(t => t.DividingPlanHeaderID);
            
            CreateTable(
                "dbo.DividingPlanTemps",
                c => new
                    {
                        DividingPlanTempID = c.Int(nullable: false, identity: true),
                        LineNo = c.String(),
                        TotalEmployee = c.String(),
                        Target = c.String(),
                        ProductionPerHour = c.String(),
                        StyleID = c.String(),
                        OprationNo = c.String(),
                        OprationName = c.String(),
                        SMVType = c.String(),
                        MachineType = c.String(),
                        SMV = c.String(),
                        Selected = c.Boolean(nullable: false),
                        PartName = c.String(),
                    })
                .PrimaryKey(t => t.DividingPlanTempID);
            
            CreateTable(
                "dbo.LayinDetails",
                c => new
                    {
                        LayinDetailsID = c.Int(nullable: false, identity: true),
                        MarkerNo = c.String(),
                        Date = c.DateTime(nullable: false),
                        FabricRollID = c.String(),
                        LayerLenth = c.Double(nullable: false),
                        FabricRollLenth = c.Double(nullable: false),
                        NoofPlys = c.Int(nullable: false),
                        Rest = c.Double(nullable: false),
                        FabricUsed = c.Double(nullable: false),
                        TotalPcs = c.Int(nullable: false),
                        StyleID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LayinDetailsID)
                .ForeignKey("dbo.Styles", t => t.StyleID)
                .Index(t => t.StyleID);
            
            CreateTable(
                "dbo.TempOprations",
                c => new
                    {
                        TempOprationID = c.Int(nullable: false, identity: true),
                        OprationID = c.String(),
                        OparationName = c.String(),
                        MachineType = c.String(),
                        SMV = c.Double(nullable: false),
                        SMVType = c.String(),
                        Remark = c.String(),
                        PartName = c.String(),
                        OprationRole = c.String(),
                        OprationGrade = c.String(),
                    })
                .PrimaryKey(t => t.TempOprationID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LayinDetails", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.DividingPlanItems", "DividingPlanHeaderID", "dbo.DividingPlanHeaders");
            DropForeignKey("dbo.Workstations", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Users", "Employee_EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Promotions", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.PastEmployeements", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Racks", "WerehouseID", "dbo.Werehouses");
            DropForeignKey("dbo.Bins", "RackID", "dbo.Racks");
            DropForeignKey("dbo.Werehouses", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.ScaningTimeSchaduals", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.OprationBarcodes", "OperationPoolID", "dbo.OperationPools");
            DropForeignKey("dbo.OprationBarcodes", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.OprationBarcodes", "BundleDetailsID", "dbo.BundleDetails");
            DropForeignKey("dbo.BundleDetails", "BundleHeaderID", "dbo.BundleHeaders");
            DropForeignKey("dbo.OperationPools", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.IndividualProductionDetails", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Companies", "GroupID", "dbo.Groups");
            DropForeignKey("dbo.Employees", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.IndividualProductionSummeries", "DayendHeaderID", "dbo.DayendHeaders");
            DropForeignKey("dbo.Dayends", "DayendHeaderID", "dbo.DayendHeaders");
            DropForeignKey("dbo.CuttingSummaries", "DayendHeaderID", "dbo.DayendHeaders");
            DropForeignKey("dbo.DayendHeaders", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.CuttingStocks", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.CuttingLedgers", "CuttingLedgerHeaderID", "dbo.CuttingLedgerHeaders");
            DropForeignKey("dbo.CuttingLedgerHeaders", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.WorkflowSetups", "Workstation_WorkstationID", "dbo.Workstations");
            DropForeignKey("dbo.WorkflowSetups", "WorkflowID", "dbo.Workflows");
            DropForeignKey("dbo.Styles", "WorkflowID", "dbo.Workflows");
            DropForeignKey("dbo.StyleOperations", "PartDefinition_PartDefinitionID", "dbo.PartDefinitions");
            DropForeignKey("dbo.PartDefinitions", "SketchDefinitionID", "dbo.SketchDefinitions");
            DropForeignKey("dbo.SketchDefinitions", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.PurchaseOrderHeaders", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.PurchaseOrderItems", "PurchaseOrderHeaderID", "dbo.PurchaseOrderHeaders");
            DropForeignKey("dbo.FabricDetails", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.DividingPlanHeaders", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.DailyProductions", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.CuttingHeaders", "StyleID", "dbo.Styles");
            DropForeignKey("dbo.CuttingItems", "CuttingHeaderID", "dbo.CuttingHeaders");
            DropForeignKey("dbo.BundleHeaders", "CuttingItemID", "dbo.CuttingItems");
            DropForeignKey("dbo.CutIssueHeaders", "Style_StyleID", "dbo.Styles");
            DropForeignKey("dbo.CutIssuItems", "CutIssueHeaderID", "dbo.CutIssueHeaders");
            DropForeignKey("dbo.Styles", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Styles", "BuyerID", "dbo.Buyers");
            DropForeignKey("dbo.Buyers", "CompanyID", "dbo.Companies");
            DropForeignKey("dbo.Awards", "EmployeeID", "dbo.Employees");
            DropIndex("dbo.LayinDetails", new[] { "StyleID" });
            DropIndex("dbo.DividingPlanItems", new[] { "DividingPlanHeaderID" });
            DropIndex("dbo.Users", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.Promotions", new[] { "EmployeeID" });
            DropIndex("dbo.PastEmployeements", new[] { "EmployeeID" });
            DropIndex("dbo.Bins", new[] { "RackID" });
            DropIndex("dbo.Racks", new[] { "WerehouseID" });
            DropIndex("dbo.Werehouses", new[] { "CompanyID" });
            DropIndex("dbo.ScaningTimeSchaduals", new[] { "CompanyID" });
            DropIndex("dbo.BundleDetails", new[] { "BundleHeaderID" });
            DropIndex("dbo.OprationBarcodes", new[] { "OperationPoolID" });
            DropIndex("dbo.OprationBarcodes", new[] { "BundleDetailsID" });
            DropIndex("dbo.OprationBarcodes", new[] { "EmployeeID" });
            DropIndex("dbo.OperationPools", new[] { "CompanyID" });
            DropIndex("dbo.IndividualProductionDetails", new[] { "CompanyID" });
            DropIndex("dbo.IndividualProductionSummeries", new[] { "DayendHeaderID" });
            DropIndex("dbo.Dayends", new[] { "DayendHeaderID" });
            DropIndex("dbo.CuttingSummaries", new[] { "DayendHeaderID" });
            DropIndex("dbo.DayendHeaders", new[] { "CompanyID" });
            DropIndex("dbo.CuttingStocks", new[] { "CompanyID" });
            DropIndex("dbo.CuttingLedgers", new[] { "CuttingLedgerHeaderID" });
            DropIndex("dbo.CuttingLedgerHeaders", new[] { "CompanyID" });
            DropIndex("dbo.Workstations", new[] { "Employee_EmployeeID" });
            DropIndex("dbo.WorkflowSetups", new[] { "Workstation_WorkstationID" });
            DropIndex("dbo.WorkflowSetups", new[] { "WorkflowID" });
            DropIndex("dbo.StyleOperations", new[] { "PartDefinition_PartDefinitionID" });
            DropIndex("dbo.PartDefinitions", new[] { "SketchDefinitionID" });
            DropIndex("dbo.SketchDefinitions", new[] { "StyleID" });
            DropIndex("dbo.PurchaseOrderItems", new[] { "PurchaseOrderHeaderID" });
            DropIndex("dbo.PurchaseOrderHeaders", new[] { "StyleID" });
            DropIndex("dbo.FabricDetails", new[] { "StyleID" });
            DropIndex("dbo.DividingPlanHeaders", new[] { "StyleID" });
            DropIndex("dbo.DailyProductions", new[] { "StyleID" });
            DropIndex("dbo.BundleHeaders", new[] { "CuttingItemID" });
            DropIndex("dbo.CuttingItems", new[] { "CuttingHeaderID" });
            DropIndex("dbo.CuttingHeaders", new[] { "StyleID" });
            DropIndex("dbo.CutIssuItems", new[] { "CutIssueHeaderID" });
            DropIndex("dbo.CutIssueHeaders", new[] { "Style_StyleID" });
            DropIndex("dbo.Styles", new[] { "WorkflowID" });
            DropIndex("dbo.Styles", new[] { "BuyerID" });
            DropIndex("dbo.Styles", new[] { "CompanyID" });
            DropIndex("dbo.Buyers", new[] { "CompanyID" });
            DropIndex("dbo.Companies", new[] { "GroupID" });
            DropIndex("dbo.Employees", new[] { "CompanyID" });
            DropIndex("dbo.Awards", new[] { "EmployeeID" });
            DropTable("dbo.TempOprations");
            DropTable("dbo.LayinDetails");
            DropTable("dbo.DividingPlanTemps");
            DropTable("dbo.DividingPlanItems");
            DropTable("dbo.Users");
            DropTable("dbo.Promotions");
            DropTable("dbo.PastEmployeements");
            DropTable("dbo.Bins");
            DropTable("dbo.Racks");
            DropTable("dbo.Werehouses");
            DropTable("dbo.ScaningTimeSchaduals");
            DropTable("dbo.BundleDetails");
            DropTable("dbo.OprationBarcodes");
            DropTable("dbo.OperationPools");
            DropTable("dbo.IndividualProductionDetails");
            DropTable("dbo.Groups");
            DropTable("dbo.IndividualProductionSummeries");
            DropTable("dbo.Dayends");
            DropTable("dbo.CuttingSummaries");
            DropTable("dbo.DayendHeaders");
            DropTable("dbo.CuttingStocks");
            DropTable("dbo.CuttingLedgers");
            DropTable("dbo.CuttingLedgerHeaders");
            DropTable("dbo.Workstations");
            DropTable("dbo.WorkflowSetups");
            DropTable("dbo.Workflows");
            DropTable("dbo.StyleOperations");
            DropTable("dbo.PartDefinitions");
            DropTable("dbo.SketchDefinitions");
            DropTable("dbo.PurchaseOrderItems");
            DropTable("dbo.PurchaseOrderHeaders");
            DropTable("dbo.FabricDetails");
            DropTable("dbo.DividingPlanHeaders");
            DropTable("dbo.DailyProductions");
            DropTable("dbo.BundleHeaders");
            DropTable("dbo.CuttingItems");
            DropTable("dbo.CuttingHeaders");
            DropTable("dbo.CutIssuItems");
            DropTable("dbo.CutIssueHeaders");
            DropTable("dbo.Styles");
            DropTable("dbo.Buyers");
            DropTable("dbo.Companies");
            DropTable("dbo.Employees");
            DropTable("dbo.Awards");
            DropTable("dbo.AssetBarcodes");
        }
    }
}
