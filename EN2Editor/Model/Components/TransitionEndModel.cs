using Model.Nodes;

namespace Model.Components {
public class TransitionEndModel : NodeComponent {
    public TransitionEndModel(NodeModelBase udsaetNodeModel) {
        Node = udsaetNodeModel;
    }

    public double OffsetToNodeX { get; set; }
    public double OffsetToNodeY { get; set; }

    public LinkModel InComingLink { get; set; }
    public override void Validate() {
        throw new System.NotImplementedException();
    }

    public override string Export() {
        throw new System.NotImplementedException();
    }
}
}