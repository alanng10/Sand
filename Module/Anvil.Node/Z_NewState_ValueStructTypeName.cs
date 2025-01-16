namespace Saber.Node;

public class ValueStructTypeNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new ValueStructTypeName();
        return true;
    }
}