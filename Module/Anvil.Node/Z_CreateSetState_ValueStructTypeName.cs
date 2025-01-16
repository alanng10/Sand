namespace Saber.Node;

public class ValueStructTypeNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        ValueStructTypeName node;
        node = (ValueStructTypeName)arg.Node;
        node.Class = (ClassName)k.Field00;
        node.Struct = (StructName)k.Field01;
        return true;
    }
}