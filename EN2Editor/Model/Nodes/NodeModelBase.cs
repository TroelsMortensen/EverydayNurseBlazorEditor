using System;

namespace EN2Editor.Model {
public abstract class NodeModelBase {

    public enum NodeTypes {
        // Start
        AktivFraStarten,
        
        // internal
        Udsaet,
        
        // end
        SletVedAfslutning
    }

    public abstract string Description { get;  }
    
    public Guid ID { get; } = new Guid();
    
    public NodeTypes NodeType;
    
    public double X { get; set; }
    public double Y { get; set; }

    public virtual void OnDeleteNode() { }
}
}