namespace Z.Tool.Anvil.NodeList;

public class NodeStateGen : ClassNodeStateGen
{
    public override bool Init()
    {
        base.Init();
        this.OutputFoldPath = this.S("../../Module/Anvil.Node");
        return true;
    }
}