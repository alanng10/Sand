namespace Saber.Node;

public class StructCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        Struct node;
        node = (Struct)arg.Node;
        node.Name = (StructName)k.Field00;
        node.Count = (Count)k.Field01;
        node.Part = (StructPart)k.Field02;
        return true;
    }
}