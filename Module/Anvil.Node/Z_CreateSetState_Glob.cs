namespace Saber.Node;

public class GlobCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        Glob node;
        node = (Glob)arg.Node;
        node.Count = (Count)k.Field00;
        node.Var = (Var)k.Field01;
        return true;
    }
}