namespace Saber.Node;

public class StructPartNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new StructPart();
        return true;
    }
}