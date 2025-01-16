namespace Saber.Node;

public class GlobVarOperateNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteGlobVarOperate(range);
        return true;
    }
}