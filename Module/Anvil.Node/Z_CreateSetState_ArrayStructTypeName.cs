namespace Saber.Node;

public class ArrayStructTypeNameCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        ArrayStructTypeName node;
        node = (ArrayStructTypeName)arg.Node;
        node.Class = (ClassName)k.Field00;
        node.Struct = (StructName)k.Field01;
        node.Count = (IntValue)k.Field02;
        return true;
    }
}