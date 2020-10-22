using System;
using System.Collections.Generic;
using EN2Editor.Pages.NodeComponents;
using Model.Components;

namespace Model.Nodes {
public class DialogNodeModel : EndNodeModelBase {

    public List<DialogOption> Options { get; } = new List<DialogOption>();
    public override string Description { get; } = "TODO"; // TODO
    public override string Instruction { get; } = "TODO";
    public string PatientSays { get; set; }

    public override void Validate() {
        throw new System.NotImplementedException();
    }

    public override string Export() {
        throw new System.NotImplementedException();
    }

    public class DialogOption {
        public DialogOption(DialogNodeModel node) {
            tsm = new TransitionStartModel(node);
        }

        public float TimeToComplete { get; set; }
        public string DialogText { get; set; }
        public TransitionStartModel tsm { get; set; }
        public Guid ID = Guid.NewGuid();
    }
}
}