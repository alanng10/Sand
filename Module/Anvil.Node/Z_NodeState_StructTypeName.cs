namespace Saber.Node;

public class StructTypeNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteStructTypeName(range);
        return true;
    }
}