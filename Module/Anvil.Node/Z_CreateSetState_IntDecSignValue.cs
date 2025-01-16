namespace Saber.Node;

public class IntDecSignValueCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        IntDecSignValue node;
        node = (IntDecSignValue)arg.Node;
        node.Value = k.FieldInt;
        return true;
    }
}