namespace Saber.Node;

public class IntTypeNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new IntTypeName();
        return true;
    }
}