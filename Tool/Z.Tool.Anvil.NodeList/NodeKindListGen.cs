namespace Z.Tool.Anvil.NodeList;

public class NodeKindListGen : ClassNodeKindListGen
{
    public override bool Init()
    {
        base.Init();
        this.Module = this.S("Anvil.Node");
        this.OutputFilePath = this.S("../../Module/Anvil.Node/NodeKindList.cs");
        return true;
    }
}