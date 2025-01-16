namespace Saber.Node;

public class StructNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new Struct();
        return true;
    }
}