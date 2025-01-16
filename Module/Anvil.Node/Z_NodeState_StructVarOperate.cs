namespace Saber.Node;

public class StructVarOperateNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteStructVarOperate(range);
        return true;
    }
}