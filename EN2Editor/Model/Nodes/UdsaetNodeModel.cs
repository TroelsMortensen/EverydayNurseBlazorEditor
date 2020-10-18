using Models.Components;

namespace EN2Editor.Model {
public class UdsaetNodeModel : NodeModelBase {
    
    public UdsaetNodeModel() {
        TransitionStartModel = new TransitionStartModel(this);
        TransitionEndModel = new TransitionEndModel(this);
    }
    
    public override string Description { get; } = "Dette knudepunkt betyder at et patient case ligger i dvale i x timer og y minutter.";
    
    public TransitionStartModel TransitionStartModel { get; }
    public TransitionEndModel TransitionEndModel { get; }

}
}