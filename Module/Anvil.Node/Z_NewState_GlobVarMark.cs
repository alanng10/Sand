namespace Saber.Node;

public class GlobVarMarkNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new GlobVarMark();
        return true;
    }
}