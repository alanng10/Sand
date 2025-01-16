namespace Saber.Node;

public class GlobNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new Glob();
        return true;
    }
}