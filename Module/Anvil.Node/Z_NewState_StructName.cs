namespace Saber.Node;

public class StructNameNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new StructName();
        return true;
    }
}