using Model.Nodes;

namespace Model.Components {
public class TransitionStartModel : NodeComponent {
    public TransitionStartModel(NodeModelBase node) {
        Node = node;
    }

    public double OffsetToNodeX { get; set; }
    public double OffsetToNodeY { get; set; }

    public LinkModel OutGoingLink { get; set; }
    public override void Validate() {
        throw new System.NotImplementedException();
    }

    public override string Export() {
        throw new System.NotImplementedException();
    }
}
}