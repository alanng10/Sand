namespace Saber.Node;

public class IntValueCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        IntValue node;
        node = (IntValue)arg.Node;
        return true;
    }
}