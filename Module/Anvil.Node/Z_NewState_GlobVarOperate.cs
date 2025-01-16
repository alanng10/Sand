namespace Saber.Node;

public class GlobVarOperateNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new GlobVarOperate();
        return true;
    }
}