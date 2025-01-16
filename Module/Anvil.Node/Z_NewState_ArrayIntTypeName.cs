namespace Saber.Node;

public class ArrayIntTypeNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new ArrayIntTypeName();
        return true;
    }
}