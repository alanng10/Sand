namespace Saber.Node;

public class StructNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        StructName node;
        node = (StructName)arg.Node;
        node.Value = (String)k.Field00;
        return true;
    }
}