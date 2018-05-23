using System;

using DevExpress.Xpo;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace HowToSetMaskForCustomWinPropertyEdtior.Module {
   [DefaultClassOptions]
   public class DomainObject1 : BaseObject {
      public DomainObject1(Session session) : base(session) { }
      private decimal number;

      public decimal Number {
         get { return number; }
         set { SetPropertyValue("Number", ref number, value); }
      }

   }

}
