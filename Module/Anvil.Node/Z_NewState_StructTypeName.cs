namespace Saber.Node;

public class StructTypeNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new StructTypeName();
        return true;
    }
}