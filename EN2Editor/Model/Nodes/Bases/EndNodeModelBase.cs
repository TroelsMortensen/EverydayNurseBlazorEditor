using Model.Components;

namespace Model.Nodes {
public abstract class EndNodeModelBase : NodeModelBase {
    public TransitionEndModel TransitionEndModel { get; }

    protected EndNodeModelBase() {
        TransitionEndModel = new TransitionEndModel(this);
    }

}
}