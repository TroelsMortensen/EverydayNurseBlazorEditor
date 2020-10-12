using System.Collections.Generic;

namespace EN2Editor.Model {
public class NodeModelManager {
    public List<NodeModelBase> Nodes { get;}
    public List<LinkModel> Links { get; }

    public NodeModelManager() {
        Nodes = new List<NodeModelBase>();
        Nodes.Add(new NodeModelBase {
            X = 10,
            Y = 10,
            NodeType = NodeModelBase.NodeTypes.InitiallyActive
        });
        Nodes.Add(new NodeModelBase {
            X = 400,
            Y = 100,
            NodeType = NodeModelBase.NodeTypes.Delay
        });
        Links = new List<LinkModel>();   
    }

    public void DeleteNode(NodeModelBase node) {
        Nodes.Remove(node);
        // TODO remove links here too, at some point
    }
}
}