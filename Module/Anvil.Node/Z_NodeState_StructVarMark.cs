namespace Saber.Node;

public class StructVarMarkNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteStructVarMark(range);
        return true;
    }
}