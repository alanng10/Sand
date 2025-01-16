namespace Saber.Node;

public class GlobVarMarkCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        GlobVarMark node;
        node = (GlobVarMark)arg.Node;
        node.Class = (ClassName)k.Field00;
        node.Var = (VarName)k.Field01;
        return true;
    }
}