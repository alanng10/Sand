namespace Saber.Node;

public class IntDecSignValueNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new IntDecSignValue();
        return true;
    }
}