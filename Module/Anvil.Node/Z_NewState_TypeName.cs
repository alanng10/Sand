namespace Saber.Node;

public class TypeNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new TypeName();
        return true;
    }
}