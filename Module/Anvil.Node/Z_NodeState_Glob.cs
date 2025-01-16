namespace Saber.Node;

public class GlobNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteGlob(range);
        return true;
    }
}