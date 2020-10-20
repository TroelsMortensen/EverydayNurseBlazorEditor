namespace Model.Nodes {
public class KaldSygeplejerskeNodeModel : InternalNodeModelBase {
    public override string Description { get; } = "Når et patient case når dette knudepunkt, bliver sygeplejersken tilkaldt af patienten.";
    public override string Instruction { get; } = "";
    public override void Validate() {
        throw new System.NotImplementedException();
    }

    public override string Export() {
        throw new System.NotImplementedException();
    }
}
}