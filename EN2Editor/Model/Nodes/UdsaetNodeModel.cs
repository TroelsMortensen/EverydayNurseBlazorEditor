using Models;
using Models.Components;

namespace EN2Editor.Model {
public class UdsaetNodeModel : NodeModelBase {
    
    public UdsaetNodeModel() {
        TransitionStartModel = new TransitionStartModel(this);
        TransitionEndModel = new TransitionEndModel(this);
    }
    
    public override string Description { get; } = "Dette knudepunkt gør, at et patient case ligger i dvale i x timer og y minutter.";
    public override string Instruction { get; } = "Der kan enten vælges en fastsat ventetid, " +
                                                  "eller man kan tjekke boksen \"Tilfældig udsættelse\", " +
                                                  "hvorved man får mulighed for at angive et tidsinterval. " +
                                                  "Dette betyder, at dette patient case vil ligge i dvale i et tilfældigt " +
                                                  "interval mellem de to indtastede tider. \"fra\" tiden skal være mindre end \"til\" tiden.";

    public TransitionStartModel TransitionStartModel { get; }
    public TransitionEndModel TransitionEndModel { get; }
    
    public bool UseRandomRange { get; set; }
    public Time Time { get; set; } = new Time();
    public TimeRange ToFrom { get; set; } = new TimeRange();

}
}