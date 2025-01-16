namespace Saber.Node;

public class GlobVarMarkNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteGlobVarMark(range);
        return true;
    }
}