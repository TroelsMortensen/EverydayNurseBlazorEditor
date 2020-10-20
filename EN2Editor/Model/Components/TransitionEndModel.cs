using Model.Nodes;

namespace Model.Components {
public class TransitionEndModel : NodeComponent {
    public TransitionEndModel(NodeModelBase udsaetNodeModel) {
        Node = udsaetNodeModel;
    }

    public double OffsetToNodeX { get; set; }
    public double OffsetToNodeY { get; set; }

    public LinkModel InComingLink { get; set; }
}
}