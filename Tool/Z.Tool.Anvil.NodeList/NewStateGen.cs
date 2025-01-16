namespace Z.Tool.Anvil.NodeList;

public class NewStateGen : ClassNewStateGen
{
    public override bool Init()
    {
        base.Init();
        this.OutputFoldPath = this.S("../../Module/Anvil.Node");
        return true;
    }
}