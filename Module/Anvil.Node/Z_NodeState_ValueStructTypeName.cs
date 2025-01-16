namespace Saber.Node;

public class ValueStructTypeNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteValueStructTypeName(range);
        return true;
    }
}