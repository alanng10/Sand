namespace Saber.Node;

public class ArrayIntTypeNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteArrayIntTypeName(range);
        return true;
    }
}