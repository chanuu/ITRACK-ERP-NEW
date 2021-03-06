﻿using ITRACK.DBConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XtraSchedulerEFTest;

namespace ITRACK.models
{
    public class ItrackContext : DbContext

    {

        
        public ItrackContext()
            : base("AppDbContext")
        {
            //Create database always, even If exists
          //  Database.SetInitializer<ItrackContext>(new ItrackContextInitializer());
            Configuration.AutoDetectChangesEnabled = false;
            ConnectionDetails Con = new ConnectionDetails();
            this.Database.Connection.ConnectionString = Con.readConnection();
          
        }

      

        public DbSet<Group> Group { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Buyer> Buyer { get; set; }

        public DbSet<Style> Style { get; set; }

        public DbSet<SketchDefinition> SketchDefinition { get; set; }

        public DbSet<User> User { get; set; }


        public DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }


        public DbSet<PurchaseOrderItems> PurchaseOrderItems { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Promotion> Promotion { get; set; }

        public DbSet<Award> Award { get; set; }

        public DbSet<PastEmployeement> PastEmployeement { get; set; }


        public DbSet<Workflow> Workflow { get; set; }

        public DbSet<WorkflowSetup> WorkflowSetup { get; set; }

        public DbSet<Workstation> Workstation { get; set; }

        public DbSet<Werehouse> Werehouse { get; set; }

        public DbSet<Rack> Rack { get; set; }

        public DbSet<Bin> Bin { get; set; }

        public DbSet<OperationPool> Operation { get; set; }

        public DbSet<CuttingHeader> CuttingHeader { get; set; }

        public DbSet<CuttingItem> CuttingItem { get; set; }

        public DbSet<StyleOperation> StyleOperation { get; set; }

        public DbSet<PartDefinition> PartDefinition { get; set; }

        public DbSet<TempOpration> TempOpration { get; set; }

        public DbSet<DividingPlanHeader> DividingPlanHeader { get; set; }


        public DbSet<DividingPlanItem> DividingPlanItem { get; set; }


        public DbSet<BundleHeader> BundleHeader { get; set; }


        public DbSet<BundleDetails> BundleDetails { get; set; }


        public DbSet<OprationBarcodes> OprationBarcodes { get; set; }

        public DbSet<DayendHeader> DayendHeader { get; set; }

        public DbSet<Dayend> Dayend { get; set; }

        public DbSet<IndividualProductionSummery> IndividualProductionSummery { get; set; }

        public DbSet<LayinDetails> LayinDetails { get; set; }


        public DbSet<DailyProduction> DailyProduction { get; set; }

        public DbSet<IndividualProductionDetails> IndividualProductionDetails { get; set; }


        public DbSet<CuttingStock> CuttingStock { get; set; }

        public DbSet<CuttingLedger> CuttingLedger { get; set; }

        public DbSet<CuttingLedgerHeader> CuttingLedgerHeader { get; set; }

        public DbSet<CutIssueHeader> CutIssueHeader { get; set; }

        public DbSet<CutIssuItem> CutIssuItem { get; set; }

        public DbSet<AssetBarcode> AssetBarcode { get; set; }



        public DbSet<CustomeFieldSetup> CustomeFieldSetup { get; set; }

        public DbSet<PO> PO { get; set; }

        public DbSet<Items> Items { get; set; }

        public DbSet<VehicleRequisition> VehicleRequisition { get; set; }

        public DbSet<StockRequisition> StockRequisition { get; set; }

        public DbSet<SpecialEntry> SpecialEntry { get; set; }

        public DbSet<StockLedger> StockLedger { get; set; }

        public DbSet<SerialEntry> SerialEntry { get; set; }

       

        public DbSet<AssetVerification> AssetVerification { get; set; }

        public DbSet<AssetVerificationDetails> AssetVerificationDetails { get; set; }

        public DbSet<AssetLedger> AssetLedger { get; set; }


        public DbSet<DividingPlanTemp> DividingPlanTemp { get; set; }

        public DbSet<RunningNo> RunningNo { get; set; }

        public DbSet<MachineType> MachineType { get; set; }

        public DbSet<StyleLoading> StyleLoading { get; set; }

        public DbSet<MachineRequirement> MachineRequirement { get; set; }

        public DbSet<AssetRequisition> AssetRequisition { get; set; }

        public DbSet<MachineRequirementItem> MachineRequirementItem { get; set; }


        public DbSet<CuttingRatio> CuttingRatio { get; set; }

        public DbSet<RatioItem> RatioItem { get; set; }


        public DbSet<Department> Department { get; set; }

        public DbSet<FabricLedger> FabricLedger { get; set; }

        public DbSet<FabricConsumption> FabricConsumption { get; set; }

        public DbSet<EstimateFabricConsumption> EstimateFabricConsumption { get; set; }


        public DbSet<RentManagement> RentManagement { get; set; }





        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            //create one to one or one to zero replationsip in Employee - user Entity
            modelBuilder.Entity<User>()
                            .HasKey(t => t.UserID);

            modelBuilder.Entity<Employee>()
                .HasOptional(t => t.User)
                .WithOptionalPrincipal(t => t.Employee);

            // one to one relationship between workstation - worklow rule
            modelBuilder.Entity<WorkflowSetup>()
                           .HasKey(t => t.WorkflowSetupID);

            modelBuilder.Entity<Workstation>()
                .HasOptional(t => t.WorkflowSetup)
                .WithOptionalPrincipal(t => t.Workstation);



            //create one to one or one to zero replationsip in Employee - Workstation Entity
            modelBuilder.Entity<Workstation>()
                            .HasKey(t => t.WorkstationID);

            modelBuilder.Entity<Employee>()
                .HasOptional(t => t.Workstation)
                .WithOptionalPrincipal(t => t.Employee);


      

        }

    }
}
