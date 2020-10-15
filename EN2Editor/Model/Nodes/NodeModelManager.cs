using System.Collections.Generic;

namespace EN2Editor.Model {
public class NodeModelManager {
    public List<NodeModelBase> Nodes { get;}
    public List<LinkModel> Links { get; }

    public NodeModelManager() {
        Nodes = new List<NodeModelBase>();
        Links = new List<LinkModel>();
        
        /*NodeModelBase startNode = new NodeModelBase {
            X = 10,
            Y = 10,
            NodeType = NodeModelBase.NodeTypes.InitiallyActive
        };
        Nodes.Add(startNode);
        NodeModelBase endNode = new NodeModelBase {
            X = 400,
            Y = 100,
            NodeType = NodeModelBase.NodeTypes.Delay
        };
        Nodes.Add(endNode);*/
        // Links.Add(new LinkModel {
        //     SourceNode = startNode,
        //     TargetNode = endNode
        // });
    }

    public void DeleteNode(NodeModelBase node) {
        Nodes.Remove(node);
        // TODO remove links here too, at some point
    }
}
}