namespace Saber.Node;

public class GlobVarOperateCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        GlobVarOperate node;
        node = (GlobVarOperate)arg.Node;
        node.Class = (ClassName)k.Field00;
        node.Var = (VarName)k.Field01;
        return true;
    }
}