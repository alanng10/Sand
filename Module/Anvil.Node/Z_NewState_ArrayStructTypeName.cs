namespace Saber.Node;

public class ArrayStructTypeNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new ArrayStructTypeName();
        return true;
    }
}