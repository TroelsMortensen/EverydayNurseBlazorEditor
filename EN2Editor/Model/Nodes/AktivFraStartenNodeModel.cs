using Models.Components;

namespace EN2Editor.Model {
public class AktivFraStartenNodeModel : NodeModelBase {
    
    public AktivFraStartenNodeModel() {
        TransitionStartModel = new TransitionStartModel(this);
    }

    public override string Description { get; } = "Dette knudepunkt angiver at dette patient case er aktivt fra starten af spillet.";
    public override string Instruction { get; } = "Træk en transition fra dette knudepunkt til det første, der skal ske i dette patient case.";

    public TransitionStartModel TransitionStartModel { get; }
}
}