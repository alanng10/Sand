namespace Saber.Node;

public class IntDecValueCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        IntDecValue node;
        node = (IntDecValue)arg.Node;
        node.Value = k.FieldInt;
        return true;
    }
}