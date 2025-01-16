namespace Saber.Node;

public class IntDecValueNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new IntDecValue();
        return true;
    }
}