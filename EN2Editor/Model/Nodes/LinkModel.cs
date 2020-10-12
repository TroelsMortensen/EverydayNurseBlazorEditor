namespace EN2Editor.Model {
public class LinkModel {
    private int endX;
    private int endY;

    public bool IsEndConnected { get; set; }

    public NodeModelBase SourceNode { get; set; }
    public double OffsetToSourceNodeX { private get; set; }
    public double OffsetToSourceNodeY { private get; set; }

    public NodeModelBase TargetNode { get; set; }
    public double OffsetToTargetNodeX { private get; set; }
    public double OffsetToTargetNodeY { private get; set; }

    public double OffsetToCanvasX { get; set; }
    public double OffsetToCanvasY { get; set; }

    public int EndX {
        get =>
            IsEndConnected ?
                (int) (TargetNode.X + OffsetToTargetNodeX) :
                (int) (endX - OffsetToCanvasX);

        // if (!IsEndConnected)
        //     return (int) (endX - OffsetToCanvasX);
        // else return (int) (TargetNode.X + OffsetToTargetNodeX);

        set => endX = value;
    }

    public int EndY {
        get =>
            IsEndConnected ?
                (int) (TargetNode.Y + OffsetToTargetNodeY) :
                (int) (endY - OffsetToCanvasY);

        // if (!IsEndConnected)
        //     return (int) (endY - OffsetToCanvasY);
        // else return (int) (TargetNode.Y + OffsetToTargetNodeY);
       
        set => endY = value;
    }

    public int StartX => (int) (SourceNode.X + OffsetToSourceNodeX);

    public int StartY => (int) (SourceNode.Y + OffsetToSourceNodeY);
}
}