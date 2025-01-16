namespace Saber.Node;

public class Maide : Comp
{
    public virtual TypeName Type { get; set; }
    public virtual MaideName Name { get; set; }
    public virtual Count Count { get; set; }
    public virtual Param Param { get; set; }
    public virtual State Call { get; set; }
}