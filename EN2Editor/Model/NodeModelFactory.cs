using Model.Nodes;

namespace Models {
public class NodeModelFactory {
    public static NodeModelBase CreateNode(NodeModelBase.NodeTypes type, double x, double y) {
        return type switch {
            NodeModelBase.NodeTypes.AktivFraStarten => new AktivFraStartenNodeModel {X = x, Y = y, NodeType = type},
            NodeModelBase.NodeTypes.Udsaet => new UdsaetNodeModel {X = x, Y = y, NodeType = type},
            NodeModelBase.NodeTypes.SletVedAfslutning => new SletVedAfslutningNodeModel {X = x, Y = y, NodeType = type},
            _ => null // TODO create null-represenation?
        };
    }
}
}