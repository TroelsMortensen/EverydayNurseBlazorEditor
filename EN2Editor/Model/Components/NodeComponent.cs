using System;
using EN2Editor.Model;

namespace Models.Components {
public abstract class NodeComponent {
    public NodeModelBase Node { get; set; }
    public Guid ID { get; } = Guid.NewGuid();


}
}