namespace Saber.Node;

public class ClassCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        Class node;
        node = (Class)arg.Node;
        node.Name = (ClassName)k.Field00;
        node.Part = (Part)k.Field01;
        return true;
    }
}