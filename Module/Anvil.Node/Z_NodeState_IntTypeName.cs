namespace Saber.Node;

public class IntTypeNameNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteIntTypeName(range);
        return true;
    }
}