namespace Saber.Node;

public class StructPartNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteStructPart(range);
        return true;
    }
}