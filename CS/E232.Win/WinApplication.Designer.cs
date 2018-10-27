namespace E232.Win {
   partial class E232WindowsFormsApplication {
      /// <summary> 
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null)) {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary> 
      /// Required method for Designer support - do not modify 
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module4 = new E232.Module.Win.E232WindowsFormsModule();
            this.module6 = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=HowToSetMaskForCustomWinPropertyEdtior;Integr" +
    "ated Security=SSPI;Pooling=false";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsApplication
            // 
            this.ApplicationName = "HowToSetMaskForCustomWinPropertyEdtior";
            this.Connection = this.sqlConnection1;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module6);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.securityModule1);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.HowToSetMaskForCustomWinPropertyEdtiorWindowsFormsApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.ExpressApp.SystemModule.SystemModule module1;
      private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
      private E232.Module.Win.E232WindowsFormsModule module4;
      private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule module6;
      private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
      private System.Data.SqlClient.SqlConnection sqlConnection1;
   }
}
