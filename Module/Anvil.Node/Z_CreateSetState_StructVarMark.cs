namespace Saber.Node;

public class StructVarMarkCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        StructVarMark node;
        node = (StructVarMark)arg.Node;
        node.This = (Operate)k.Field00;
        node.Var = (VarName)k.Field01;
        return true;
    }
}