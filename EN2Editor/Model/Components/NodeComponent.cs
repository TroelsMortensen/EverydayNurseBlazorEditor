using System;
using Model.Nodes;

namespace Model.Components {
public abstract class NodeComponent {
    public NodeModelBase Node { get; set; }
    public Guid ID { get; } = Guid.NewGuid();
    
    public abstract void   Validate();
    public abstract string Export();

}
}