using Model.Components;

namespace Model.Nodes {
public abstract class InternalNodeModelBase : NodeModelBase {
    protected InternalNodeModelBase() {
        TransitionStartModel = new TransitionStartModel(this);
        TransitionEndModel = new TransitionEndModel(this);
    }
    
    public TransitionStartModel TransitionStartModel { get; }
    public TransitionEndModel TransitionEndModel { get; }

}
}