namespace Saber.Node;

public class StructTypeNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        StructTypeName node;
        node = (StructTypeName)arg.Node;
        node.Class = (ClassName)k.Field00;
        node.Struct = (StructName)k.Field01;
        return true;
    }
}