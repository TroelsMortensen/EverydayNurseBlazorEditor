using Models.Components;

namespace EN2Editor.Model {
public class AktivFraStartenNodeModel : NodeModelBase {
    
    public AktivFraStartenNodeModel() {
        TransitionStartModel = new TransitionStartModel(this);
    }

    public override string Description { get; } = "Denne type knudepunkt angiver at dette patient case er aktivt fra starten af spillet.";

    public TransitionStartModel TransitionStartModel { get; }
}
}