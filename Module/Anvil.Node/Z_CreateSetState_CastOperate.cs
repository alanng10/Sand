namespace Saber.Node;

public class CastOperateCreateSetState : CreateSetState
{
    public override bool Execute()
    {
        CreateSetStateArg arg;
        arg = (CreateSetStateArg)this.Arg;
        CreateSetArg k;
        k = arg.SetArg;

        CastOperate node;
        node = (CastOperate)arg.Node;
        node.Class = (TypeName)k.Field00;
        node.Any = (Operate)k.Field01;
        return true;
    }
}