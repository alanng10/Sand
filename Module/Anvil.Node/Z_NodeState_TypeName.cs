namespace Saber.Node;

public class TypeNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteTypeName(range);
        return true;
    }
}