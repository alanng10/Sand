namespace Saber.Node;

public class StructVarMarkNewState : InfraState
{
    public override bool Execute()
    {
        this.Result = new StructVarMark();
        return true;
    }
}