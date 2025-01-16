namespace Z.Tool.Anvil.NodeList;

public class TravelGen : ClassTravelGen
{
    public override bool Init()
    {
        base.Init();
        this.PathOutput = this.S("../../Module/Anvil.Node/Travel.cs");
        return true;
    }
}