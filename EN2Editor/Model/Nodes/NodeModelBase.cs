using Microsoft.AspNetCore.Components;

namespace EN2Editor.Model {
public class NodeModelBase {

    public enum NodeTypes {
        // Start
        InitiallyActive,
        
        // internal
        Delay,
        
        // end
        DestroyOnCompletion
    }

    public NodeTypes NodeType;
    public double X { get; set; }
    public double Y { get; set; }
    public bool IsSelected { get; set; }

}
}