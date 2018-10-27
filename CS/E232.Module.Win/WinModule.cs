using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using DevExpress.ExpressApp;

namespace E232.Module.Win {
   [ToolboxItemFilter("Xaf.Platform.Win")]
   public sealed partial class E232WindowsFormsModule : ModuleBase {
      public E232WindowsFormsModule() {
         InitializeComponent();
      }
   }
}
