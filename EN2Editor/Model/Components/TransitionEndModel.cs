using System;
using EN2Editor.Model;

namespace Models.Components {
public class TransitionEndModel {
    public Guid ID { get; } = new Guid();
    
    public double OffsetToNodeX { get; set; }
    public double OffsetToNodeY { get; set; }
    
    public NodeModelBase Node { get; set; }
    public LinkModel InComingLink { get; set; }
}
}