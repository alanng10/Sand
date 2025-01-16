namespace Saber.Node;

public class ArrayIntTypeNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        ArrayIntTypeName node;
        node = (ArrayIntTypeName)arg.Node;
        node.Kind = k.FieldInt;
        node.Count = (IntValue)k.Field01;
        return true;
    }
}