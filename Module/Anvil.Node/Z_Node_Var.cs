namespace Saber.Node;

public class Var : Node
{
    public virtual TypeName Type { get; set; }
    public virtual VarName Name { get; set; }
}