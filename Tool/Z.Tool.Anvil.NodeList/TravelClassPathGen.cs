namespace Z.Tool.Anvil.NodeList;

public class TravelClassPathGen : ClassTravelClassPathGen
{
    public override bool Init()
    {
        base.Init();
        this.PathOutput = this.S("../../Module/Anvil.Node/ClassPathTravel_Part.cs");
        return true;
    }
}