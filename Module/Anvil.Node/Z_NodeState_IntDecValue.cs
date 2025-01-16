namespace Saber.Node;

public class IntDecValueNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteIntDecValue(range);
        return true;
    }
}