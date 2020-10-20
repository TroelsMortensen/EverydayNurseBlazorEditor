namespace Model.Nodes {
public class AktivFraStartenNodeModel : StartNodeModelBase {

    public override string Description { get; } = "Dette knudepunkt angiver at dette patient case er aktivt fra starten af spillet.";
    public override string Instruction { get; } = "Træk en transition fra dette knudepunkt til det første, der skal ske i dette patient case.";
    public override void Validate() {
        throw new System.NotImplementedException();
    }

    public override string Export() {
        throw new System.NotImplementedException();
    }
}
}