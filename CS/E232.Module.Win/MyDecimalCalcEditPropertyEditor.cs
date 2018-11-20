using System;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Editors;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.XtraEditors.Repository;

namespace E232.Module.Win {
    [PropertyEditor(typeof(decimal), MyDecimalCalcEditPropertyEditor.CalcEditorAlias, false)]
    public class MyDecimalCalcEditPropertyEditor : DXPropertyEditor {
        public const string CalcEditorAlias = "CalcEditor";
        public MyDecimalCalcEditPropertyEditor(Type objectType, IModelMemberViewItem model)
            : base(objectType, model) {
            this.ControlBindingProperty = "EditValue";
        }
        protected override object CreateControlCore() {
            return new CalcEdit();
        }
        protected override void SetupRepositoryItem(RepositoryItem item) {
            base.SetupRepositoryItem(item);
            ((RepositoryItemCalcEdit)item).Mask.EditMask = "C";
            ((RepositoryItemCalcEdit)item).Mask.UseMaskAsDisplayFormat = true;
        }
        protected override RepositoryItem CreateRepositoryItem() {
            return new RepositoryItemCalcEdit();
        }
        public override bool CanFormatPropertyValue {
            get { return true; }
        }
    }
    [NavigationItem("E232")]
    public class TestObject : BaseObject {
        public TestObject(Session session)
            : base(session) { }

        private decimal _Amount;
        [EditorAlias(MyDecimalCalcEditPropertyEditor.CalcEditorAlias)]
        public decimal Amount {
            get {
                return _Amount;
            }
            set {
                SetPropertyValue("Amount", ref _Amount, value);
            }
        }
    }
}