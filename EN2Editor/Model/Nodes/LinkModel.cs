using Models.Components;

namespace EN2Editor.Model {
public class LinkModel {
    private int endX;
    private int endY;

    public bool IsEndConnected { get; set; }

    // public NodeModelBase SourceNode { get; set; }
    public TransitionStartModel TransitionStartModel { get; set; }
    // public double OffsetToStartX { private get; set; }
    // public double OffsetToStartY { private get; set; }

    // public NodeModelBase TargetNode { get; set; }
    public TransitionEndModel TransitionEndModel { get; set; }
    public double OffsetToEndX { private get; set; }
    public double OffsetToEndY { private get; set; }

    public double OffsetToCanvasX { get; set; }
    public double OffsetToCanvasY { get; set; }

    public int EndX {
        get =>
            IsEndConnected ?
                (int) (TransitionEndModel.OffsetToNodeX + OffsetToEndX) :
                (int) (endX - OffsetToCanvasX - 20);

        // if (!IsEndConnected)
        //     return (int) (endX - OffsetToCanvasX);
        // else return (int) (TargetNode.X + OffsetToTargetNodeX);

        set => endX = value;
    }

    public int EndY {
        get =>
            IsEndConnected ?
                (int) (TransitionEndModel.OffsetToNodeY + OffsetToEndY) :
                (int) (endY - OffsetToCanvasY);

        // if (!IsEndConnected)
        //     return (int) (endY - OffsetToCanvasY);
        // else return (int) (TargetNode.Y + OffsetToTargetNodeY);

        set => endY = value;
    }

    public int StartX => (int) (TransitionStartModel.OffsetToNodeX + (int)TransitionStartModel.Node.X);

    public int StartY => (int) (TransitionStartModel.OffsetToNodeY + (int)TransitionStartModel.Node.Y);
    public bool IsSelected { get; set; }
}
}