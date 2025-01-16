namespace Z.Tool.Anvil.NodeList;

public class Gen : ClassGen
{
    protected override ClassRead CreateRead()
    {
        ClassRead a;
        a = new Read();
        a.Init();
        return a;
    }
}