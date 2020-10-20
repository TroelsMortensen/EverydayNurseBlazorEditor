namespace Model.Nodes {
public class SletVedAfslutningNodeModel : EndNodeModelBase {
    public override string Description { get; } = "Når et patient case når dette knudepunkt, slettes det permanent. " +
                                                  "Dette case kan altså aktiveres max een gang per patient.";

    public override string Instruction { get; }
}
}