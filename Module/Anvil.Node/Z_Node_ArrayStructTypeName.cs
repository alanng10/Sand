namespace Saber.Node;

public class ArrayStructTypeName : TypeName
{
    public virtual ClassName Class { get; set; }
    public virtual StructName Struct { get; set; }
    public virtual IntValue Count { get; set; }
}