using DevExpress.ExpressApp.Blazor.Components.Models;
using DevExpress.ExpressApp.Blazor.Editors;
using DevExpress.ExpressApp.Model;
using GemTex.ExpressApp.Blazor.Editors.Models;

namespace GemTex.ExpressApp.Blazor.Editors;

public class StepProgressBarPropertyEditor : BlazorPropertyEditorBase
{
    public StepProgressBarPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)
    {
    }

    public override StepProgressBarModel ComponentModel => (StepProgressBarModel)base.ComponentModel;

    protected override IComponentModel CreateComponentModel() => new StepProgressBarModel();

    protected override void ReadValueCore()
    {
        base.ReadValueCore();
        ComponentModel.Value = (int)PropertyValue;
    }
}