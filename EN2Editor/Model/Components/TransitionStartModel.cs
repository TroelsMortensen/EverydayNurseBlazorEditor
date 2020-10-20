using Model.Nodes;

namespace Model.Components {
public class TransitionStartModel : NodeComponent {
    public TransitionStartModel(NodeModelBase node) {
        Node = node;
    }

    public double OffsetToNodeX { get; set; }
    public double OffsetToNodeY { get; set; }

    public LinkModel OutGoingLink { get; set; }
}
}