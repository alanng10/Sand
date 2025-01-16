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

    protected override ClassNodeGen CreateNodeGen()
    {
        ClassNodeGen a;
        a = new NodeGen();
        a.Init();
        return a;
    }

    protected override ClassNewStateGen CreateNewStateGen()
    {
        ClassNewStateGen a;
        a = new NewStateGen();
        a.Init();
        return a;
    }

    protected override ClassNodeStateGen CreateNodeStateGen()
    {
        ClassNodeStateGen a;
        a = new NodeStateGen();
        a.Init();
        return a;
    }

    protected override ClassCreateSetStateGen CreateCreateSetStateGen()
    {
        ClassCreateSetStateGen a;
        a = new CreateSetStateGen();
        a.Init();
        return a;
    }

    protected override ClassNodeKindListGen CreateNodeKindListGen()
    {
        ClassNodeKindListGen a;
        a = new NodeKindListGen();
        a.Init();
        return a;
    }
}