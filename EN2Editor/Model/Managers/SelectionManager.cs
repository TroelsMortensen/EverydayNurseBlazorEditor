using Model.Nodes;

namespace Model.Managers {
public class SelectionManager {
    
    public bool IsDraggingToolbarNode;
    
    
    public NodeModelBase GrabbedNode;
    public LinkModel DraggedLink;
    
    public double InitialX, InitialY;
    public double LastX { get; set; }
    public double LastY { get; set; }
    public NodeModelBase.NodeTypes NodeTypeInCreation { get; set; }
    public LinkModel SelectedLink { get; set; }
}
}