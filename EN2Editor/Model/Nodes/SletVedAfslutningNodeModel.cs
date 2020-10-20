using Models.Components;

namespace EN2Editor.Model {
public class SletVedAfslutningNodeModel : NodeModelBase {
 
    public SletVedAfslutningNodeModel() {
        TransitionEndModel = new TransitionEndModel(this);
    }
    public TransitionEndModel TransitionEndModel { get; }

    public override string Description { get; } = "Når et patient case når dette knudepunkt, slettes det permanent.";
    public override string Instruction { get; } 
}
}