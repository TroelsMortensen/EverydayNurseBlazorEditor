using Models.Components;

namespace EN2Editor.Model {
public class LinkModel {
    private int endX;
    private int endY;

    public bool IsEndConnected { get; set; }

    public TransitionStartModel TransitionStartModel { get; set; }
    public TransitionEndModel TransitionEndModel { get; set; }

    public double OffsetToCanvasX { get; set; }
    public double OffsetToCanvasY { get; set; }

    public int EndX {
        get =>
            IsEndConnected ?
                (int) (TransitionEndModel.OffsetToNodeX + (int)TransitionEndModel.Node.X) :
                (int) (endX - OffsetToCanvasX - 20);
        set => endX = value;
    }

    public int EndY {
        get =>
            IsEndConnected ?
                (int) (TransitionEndModel.OffsetToNodeY + (int)TransitionEndModel.Node.Y) :
                (int) (endY - OffsetToCanvasY);
        set => endY = value;
    }

    public int StartX => (int) (TransitionStartModel.OffsetToNodeX + (int)TransitionStartModel.Node.X);

    public int StartY => (int) (TransitionStartModel.OffsetToNodeY + (int)TransitionStartModel.Node.Y);
    public bool IsSelected { get; set; }
}
}