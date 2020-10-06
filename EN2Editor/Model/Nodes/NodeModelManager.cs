using System.Collections.Generic;

namespace EN2Editor.Model {
public class NodeModelManager {
    public List<NodeModelBase> Nodes { get;}

    public NodeModelManager() {
        Nodes = new List<NodeModelBase>();
        Nodes.Add(new NodeModelBase());
    }

    public void DeleteNode(NodeModelBase node) {
        Nodes.Remove(node);
        // TODO remove links here too, at some point
    }
}
}