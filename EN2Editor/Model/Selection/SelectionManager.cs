namespace EN2Editor.Model.Selection {
public class SelectionManager {
    public bool IsDraggingToolbarNode;
    public NodeModelBase GrabbedNode;
    public double InitialX, InitialY;
    public double LastX { get; set; }
    public double LastY { get; set; }
}
}