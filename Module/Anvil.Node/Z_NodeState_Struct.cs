namespace Saber.Node;

public class StructNodeState : NodeState
{
    public override bool Execute()
    {
        Range range;
        range = (Range)this.Arg;
        
        this.Result = this.Create.ExecuteStruct(range);
        return true;
    }
}