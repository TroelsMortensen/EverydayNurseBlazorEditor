using System;

namespace Model.Nodes {
public abstract class NodeModelBase {

    public enum NodeTypes {
        // Start
        AktivFraStarten,
        
        // internal
        Udsaet,
        KaldSygeplejerske,
        Dialog,
        
        // end
        SletVedAfslutning
    }

    public abstract string Description { get;  }
    public abstract string Instruction { get;  }
    
    public Guid ID { get; } = Guid.NewGuid();
    
    public NodeTypes NodeType { get; set; }
    
    public double X { get; set; }
    public double Y { get; set; }

    public virtual void OnDeleteNode() { }

    public abstract void Validate();
    public abstract string Export();
}
}