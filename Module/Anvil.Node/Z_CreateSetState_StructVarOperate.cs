namespace Saber.Node;

public class StructVarOperateCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        StructVarOperate node;
        node = (StructVarOperate)arg.Node;
        node.This = (Operate)k.Field00;
        node.Var = (VarName)k.Field01;
        return true;
    }
}