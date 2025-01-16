namespace Saber.Node;

public class StructVarOperateNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new StructVarOperate();
        return true;
    }
}