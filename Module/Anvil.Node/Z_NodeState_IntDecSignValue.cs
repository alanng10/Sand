namespace Saber.Node;

public class IntDecSignValueNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteIntDecSignValue(range);
        return true;
    }
}