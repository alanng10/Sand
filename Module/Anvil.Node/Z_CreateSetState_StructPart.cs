namespace Saber.Node;

public class StructPartCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        StructPart node;
        node = (StructPart)arg.Node;
        node.Value = (Array)k.Field00;
        return true;
    }
}