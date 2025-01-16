namespace Z.Tool.Anvil.NodeList;

public class Read : ClassRead
{
    public override bool Init()
    {
        base.Init();
        this.NodeListFilePath = this.S("ToolData/Anvil/NodeList.txt");
        return true;
    }
}