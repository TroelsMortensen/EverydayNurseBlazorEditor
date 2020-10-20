using Model.Components;

namespace Model.Nodes {
public abstract class StartNodeModelBase : NodeModelBase{
    public TransitionStartModel TransitionStartModel { get; }

    protected StartNodeModelBase() {
        TransitionStartModel = new TransitionStartModel(this);
    }
}
}