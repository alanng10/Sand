namespace Saber.Node;

public class TypeNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        TypeName node;
        node = (TypeName)arg.Node;
        return true;
    }
}