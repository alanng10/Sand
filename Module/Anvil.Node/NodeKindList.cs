namespace Anvil.Node;

public class NodeKindList : Any
{
    public static NodeKindList This { get; } = ShareCreate();

    private static NodeKindList ShareCreate()
    {
        NodeKindList share;
        share = new NodeKindList();
        Any a;
        a = share;
        a.Init();
        return share;
    }

    public override bool Init()
    {
        base.Init();
        this.TextStringValue = TextStringValue.This;
        this.InitArray();
        this.Count = this.Array.Count;
        this.Index = 0;

        this.Class = this.AddItem("Class", new Class(), new ClassNewState(), new ClassNodeState(), new ClassCreateSetState());
        this.Part = this.AddItem("Part", new Part(), new PartNewState(), new PartNodeState(), new PartCreateSetState());
        this.Comp = this.AddItem("Comp", new Comp(), new CompNewState(), new CompNodeState(), new CompCreateSetState());
        this.Struct = this.AddItem("Struct", new Struct(), new StructNewState(), new StructNodeState(), new StructCreateSetState());
        this.Glob = this.AddItem("Glob", new Glob(), new GlobNewState(), new GlobNodeState(), new GlobCreateSetState());
        this.Maide = this.AddItem("Maide", new Maide(), new MaideNewState(), new MaideNodeState(), new MaideCreateSetState());
        this.StructPart = this.AddItem("StructPart", new StructPart(), new StructPartNewState(), new StructPartNodeState(), new StructPartCreateSetState());
        this.Param = this.AddItem("Param", new Param(), new ParamNewState(), new ParamNodeState(), new ParamCreateSetState());
        this.Var = this.AddItem("Var", new Var(), new VarNewState(), new VarNodeState(), new VarCreateSetState());
        this.ItemCount = this.AddItem("Count", new Count(), new CountNewState(), new CountNodeState(), new CountCreateSetState());
        this.PrusateCount = this.AddItem("PrusateCount", new PrusateCount(), new PrusateCountNewState(), new PrusateCountNodeState(), new PrusateCountCreateSetState());
        this.PronateCount = this.AddItem("PronateCount", new PronateCount(), new PronateCountNewState(), new PronateCountNodeState(), new PronateCountCreateSetState());
        this.PrivateCount = this.AddItem("PrivateCount", new PrivateCount(), new PrivateCountNewState(), new PrivateCountNodeState(), new PrivateCountCreateSetState());
        this.State = this.AddItem("State", new State(), new StateNewState(), new StateNodeState(), new StateCreateSetState());
        this.Execute = this.AddItem("Execute", new Execute(), new ExecuteNewState(), new ExecuteNodeState(), new ExecuteCreateSetState());
        this.InfExecute = this.AddItem("InfExecute", new InfExecute(), new InfExecuteNewState(), new InfExecuteNodeState(), new InfExecuteCreateSetState());
        this.WhileExecute = this.AddItem("WhileExecute", new WhileExecute(), new WhileExecuteNewState(), new WhileExecuteNodeState(), new WhileExecuteCreateSetState());
        this.ReturnExecute = this.AddItem("ReturnExecute", new ReturnExecute(), new ReturnExecuteNewState(), new ReturnExecuteNodeState(), new ReturnExecuteCreateSetState());
        this.ReferExecute = this.AddItem("ReferExecute", new ReferExecute(), new ReferExecuteNewState(), new ReferExecuteNodeState(), new ReferExecuteCreateSetState());
        this.AreExecute = this.AddItem("AreExecute", new AreExecute(), new AreExecuteNewState(), new AreExecuteNodeState(), new AreExecuteCreateSetState());
        this.OperateExecute = this.AddItem("OperateExecute", new OperateExecute(), new OperateExecuteNewState(), new OperateExecuteNodeState(), new OperateExecuteCreateSetState());
        this.Argue = this.AddItem("Argue", new Argue(), new ArgueNewState(), new ArgueNodeState(), new ArgueCreateSetState());
        this.Mark = this.AddItem("Mark", new Mark(), new MarkNewState(), new MarkNodeState(), new MarkCreateSetState());
        this.VarMark = this.AddItem("VarMark", new VarMark(), new VarMarkNewState(), new VarMarkNodeState(), new VarMarkCreateSetState());
        this.StructVarMark = this.AddItem("StructVarMark", new StructVarMark(), new StructVarMarkNewState(), new StructVarMarkNodeState(), new StructVarMarkCreateSetState());
        this.GlobVarMark = this.AddItem("GlobVarMark", new GlobVarMark(), new GlobVarMarkNewState(), new GlobVarMarkNodeState(), new GlobVarMarkCreateSetState());
        this.Operate = this.AddItem("Operate", new Operate(), new OperateNewState(), new OperateNodeState(), new OperateCreateSetState());
        this.VarOperate = this.AddItem("VarOperate", new VarOperate(), new VarOperateNewState(), new VarOperateNodeState(), new VarOperateCreateSetState());
        this.StructVarOperate = this.AddItem("StructVarOperate", new StructVarOperate(), new StructVarOperateNewState(), new StructVarOperateNodeState(), new StructVarOperateCreateSetState());
        this.GlobVarOperate = this.AddItem("GlobVarOperate", new GlobVarOperate(), new GlobVarOperateNewState(), new GlobVarOperateNodeState(), new GlobVarOperateCreateSetState());
        this.CallOperate = this.AddItem("CallOperate", new CallOperate(), new CallOperateNewState(), new CallOperateNodeState(), new CallOperateCreateSetState());
        this.NullOperate = this.AddItem("NullOperate", new NullOperate(), new NullOperateNewState(), new NullOperateNodeState(), new NullOperateCreateSetState());
        this.CastOperate = this.AddItem("CastOperate", new CastOperate(), new CastOperateNewState(), new CastOperateNodeState(), new CastOperateCreateSetState());
        this.ValueOperate = this.AddItem("ValueOperate", new ValueOperate(), new ValueOperateNewState(), new ValueOperateNodeState(), new ValueOperateCreateSetState());
        this.BraceOperate = this.AddItem("BraceOperate", new BraceOperate(), new BraceOperateNewState(), new BraceOperateNodeState(), new BraceOperateCreateSetState());
        this.Value = this.AddItem("Value", new Value(), new ValueNewState(), new ValueNodeState(), new ValueCreateSetState());
        this.BoolValue = this.AddItem("BoolValue", new BoolValue(), new BoolValueNewState(), new BoolValueNodeState(), new BoolValueCreateSetState());
        this.IntValue = this.AddItem("IntValue", new IntValue(), new IntValueNewState(), new IntValueNodeState(), new IntValueCreateSetState());
        this.IntDecValue = this.AddItem("IntDecValue", new IntDecValue(), new IntDecValueNewState(), new IntDecValueNodeState(), new IntDecValueCreateSetState());
        this.IntDecSignValue = this.AddItem("IntDecSignValue", new IntDecSignValue(), new IntDecSignValueNewState(), new IntDecSignValueNodeState(), new IntDecSignValueCreateSetState());
        this.IntHexValue = this.AddItem("IntHexValue", new IntHexValue(), new IntHexValueNewState(), new IntHexValueNodeState(), new IntHexValueCreateSetState());
        this.IntHexSignValue = this.AddItem("IntHexSignValue", new IntHexSignValue(), new IntHexSignValueNewState(), new IntHexSignValueNodeState(), new IntHexSignValueCreateSetState());
        this.StringValue = this.AddItem("StringValue", new StringValue(), new StringValueNewState(), new StringValueNodeState(), new StringValueCreateSetState());
        this.ClassName = this.AddItem("ClassName", new ClassName(), new ClassNameNewState(), new ClassNameNodeState(), new ClassNameCreateSetState());
        this.StructName = this.AddItem("StructName", new StructName(), new StructNameNewState(), new StructNameNodeState(), new StructNameCreateSetState());
        this.MaideName = this.AddItem("MaideName", new MaideName(), new MaideNameNewState(), new MaideNameNodeState(), new MaideNameCreateSetState());
        this.VarName = this.AddItem("VarName", new VarName(), new VarNameNewState(), new VarNameNodeState(), new VarNameCreateSetState());
        this.TypeName = this.AddItem("TypeName", new TypeName(), new TypeNameNewState(), new TypeNameNodeState(), new TypeNameCreateSetState());
        this.IntTypeName = this.AddItem("IntTypeName", new IntTypeName(), new IntTypeNameNewState(), new IntTypeNameNodeState(), new IntTypeNameCreateSetState());
        this.StructTypeName = this.AddItem("StructTypeName", new StructTypeName(), new StructTypeNameNewState(), new StructTypeNameNodeState(), new StructTypeNameCreateSetState());
        this.ValueStructTypeName = this.AddItem("ValueStructTypeName", new ValueStructTypeName(), new ValueStructTypeNameNewState(), new ValueStructTypeNameNodeState(), new ValueStructTypeNameCreateSetState());
        this.ArrayStructTypeName = this.AddItem("ArrayStructTypeName", new ArrayStructTypeName(), new ArrayStructTypeNameNewState(), new ArrayStructTypeNameNodeState(), new ArrayStructTypeNameCreateSetState());
        this.ArrayIntTypeName = this.AddItem("ArrayIntTypeName", new ArrayIntTypeName(), new ArrayIntTypeNameNewState(), new ArrayIntTypeNameNodeState(), new ArrayIntTypeNameCreateSetState());
        this.SameOperate = this.AddItem("SameOperate", new SameOperate(), new SameOperateNewState(), new SameOperateNodeState(), new SameOperateCreateSetState());
        this.AndOperate = this.AddItem("AndOperate", new AndOperate(), new AndOperateNewState(), new AndOperateNodeState(), new AndOperateCreateSetState());
        this.OrnOperate = this.AddItem("OrnOperate", new OrnOperate(), new OrnOperateNewState(), new OrnOperateNodeState(), new OrnOperateCreateSetState());
        this.NotOperate = this.AddItem("NotOperate", new NotOperate(), new NotOperateNewState(), new NotOperateNodeState(), new NotOperateCreateSetState());
        this.LessOperate = this.AddItem("LessOperate", new LessOperate(), new LessOperateNewState(), new LessOperateNodeState(), new LessOperateCreateSetState());
        this.AddOperate = this.AddItem("AddOperate", new AddOperate(), new AddOperateNewState(), new AddOperateNodeState(), new AddOperateCreateSetState());
        this.SubOperate = this.AddItem("SubOperate", new SubOperate(), new SubOperateNewState(), new SubOperateNodeState(), new SubOperateCreateSetState());
        this.MulOperate = this.AddItem("MulOperate", new MulOperate(), new MulOperateNewState(), new MulOperateNodeState(), new MulOperateCreateSetState());
        this.DivOperate = this.AddItem("DivOperate", new DivOperate(), new DivOperateNewState(), new DivOperateNodeState(), new DivOperateCreateSetState());
        this.SignLessOperate = this.AddItem("SignLessOperate", new SignLessOperate(), new SignLessOperateNewState(), new SignLessOperateNodeState(), new SignLessOperateCreateSetState());
        this.SignMulOperate = this.AddItem("SignMulOperate", new SignMulOperate(), new SignMulOperateNewState(), new SignMulOperateNodeState(), new SignMulOperateCreateSetState());
        this.SignDivOperate = this.AddItem("SignDivOperate", new SignDivOperate(), new SignDivOperateNewState(), new SignDivOperateNodeState(), new SignDivOperateCreateSetState());
        this.BitAndOperate = this.AddItem("BitAndOperate", new BitAndOperate(), new BitAndOperateNewState(), new BitAndOperateNodeState(), new BitAndOperateCreateSetState());
        this.BitOrnOperate = this.AddItem("BitOrnOperate", new BitOrnOperate(), new BitOrnOperateNewState(), new BitOrnOperateNodeState(), new BitOrnOperateCreateSetState());
        this.BitNotOperate = this.AddItem("BitNotOperate", new BitNotOperate(), new BitNotOperateNewState(), new BitNotOperateNodeState(), new BitNotOperateCreateSetState());
        this.BitLiteOperate = this.AddItem("BitLiteOperate", new BitLiteOperate(), new BitLiteOperateNewState(), new BitLiteOperateNodeState(), new BitLiteOperateCreateSetState());
        this.BitRiteOperate = this.AddItem("BitRiteOperate", new BitRiteOperate(), new BitRiteOperateNewState(), new BitRiteOperateNodeState(), new BitRiteOperateCreateSetState());
        this.BitSignRiteOperate = this.AddItem("BitSignRiteOperate", new BitSignRiteOperate(), new BitSignRiteOperateNewState(), new BitSignRiteOperateNodeState(), new BitSignRiteOperateCreateSetState());
        return true;
    }

    public virtual NodeKind Class { get; set; }
    public virtual NodeKind Part { get; set; }
    public virtual NodeKind Comp { get; set; }
    public virtual NodeKind Struct { get; set; }
    public virtual NodeKind Glob { get; set; }
    public virtual NodeKind Maide { get; set; }
    public virtual NodeKind StructPart { get; set; }
    public virtual NodeKind Param { get; set; }
    public virtual NodeKind Var { get; set; }
    public virtual NodeKind ItemCount { get; set; }
    public virtual NodeKind PrusateCount { get; set; }
    public virtual NodeKind PronateCount { get; set; }
    public virtual NodeKind PrivateCount { get; set; }
    public virtual NodeKind State { get; set; }
    public virtual NodeKind Execute { get; set; }
    public virtual NodeKind InfExecute { get; set; }
    public virtual NodeKind WhileExecute { get; set; }
    public virtual NodeKind ReturnExecute { get; set; }
    public virtual NodeKind ReferExecute { get; set; }
    public virtual NodeKind AreExecute { get; set; }
    public virtual NodeKind OperateExecute { get; set; }
    public virtual NodeKind Argue { get; set; }
    public virtual NodeKind Mark { get; set; }
    public virtual NodeKind VarMark { get; set; }
    public virtual NodeKind StructVarMark { get; set; }
    public virtual NodeKind GlobVarMark { get; set; }
    public virtual NodeKind Operate { get; set; }
    public virtual NodeKind VarOperate { get; set; }
    public virtual NodeKind StructVarOperate { get; set; }
    public virtual NodeKind GlobVarOperate { get; set; }
    public virtual NodeKind CallOperate { get; set; }
    public virtual NodeKind NullOperate { get; set; }
    public virtual NodeKind CastOperate { get; set; }
    public virtual NodeKind ValueOperate { get; set; }
    public virtual NodeKind BraceOperate { get; set; }
    public virtual NodeKind Value { get; set; }
    public virtual NodeKind BoolValue { get; set; }
    public virtual NodeKind IntValue { get; set; }
    public virtual NodeKind IntDecValue { get; set; }
    public virtual NodeKind IntDecSignValue { get; set; }
    public virtual NodeKind IntHexValue { get; set; }
    public virtual NodeKind IntHexSignValue { get; set; }
    public virtual NodeKind StringValue { get; set; }
    public virtual NodeKind ClassName { get; set; }
    public virtual NodeKind StructName { get; set; }
    public virtual NodeKind MaideName { get; set; }
    public virtual NodeKind VarName { get; set; }
    public virtual NodeKind TypeName { get; set; }
    public virtual NodeKind IntTypeName { get; set; }
    public virtual NodeKind StructTypeName { get; set; }
    public virtual NodeKind ValueStructTypeName { get; set; }
    public virtual NodeKind ArrayStructTypeName { get; set; }
    public virtual NodeKind ArrayIntTypeName { get; set; }
    public virtual NodeKind SameOperate { get; set; }
    public virtual NodeKind AndOperate { get; set; }
    public virtual NodeKind OrnOperate { get; set; }
    public virtual NodeKind NotOperate { get; set; }
    public virtual NodeKind LessOperate { get; set; }
    public virtual NodeKind AddOperate { get; set; }
    public virtual NodeKind SubOperate { get; set; }
    public virtual NodeKind MulOperate { get; set; }
    public virtual NodeKind DivOperate { get; set; }
    public virtual NodeKind SignLessOperate { get; set; }
    public virtual NodeKind SignMulOperate { get; set; }
    public virtual NodeKind SignDivOperate { get; set; }
    public virtual NodeKind BitAndOperate { get; set; }
    public virtual NodeKind BitOrnOperate { get; set; }
    public virtual NodeKind BitNotOperate { get; set; }
    public virtual NodeKind BitLiteOperate { get; set; }
    public virtual NodeKind BitRiteOperate { get; set; }
    public virtual NodeKind BitSignRiteOperate { get; set; }

    protected virtual TextStringValue TextStringValue { get; set; }

    protected virtual NodeKind AddItem(string name, Node node, InfraState newState, NodeState nodeState, CreateSetState createSetState)
    {
        node.Init();
        newState.Init();
        nodeState.Init();
        createSetState.Init();

        String k;
        k = this.TextStringValue.Execute(name);

        NodeKind item;
        item = new NodeKind();
        item.Init();
        item.Index = this.Index;
        item.Name = k;
        item.Node = node;
        item.NewState = newState;
        item.NodeState = nodeState;
        item.CreateSetState = createSetState;
        this.Array.SetAt(item.Index, item);
        this.Index = this.Index + 1;
        return item;
    }

    protected virtual bool InitArray()
    {
        this.Array = new Array();
        this.Array.Count = this.ArrayCount;
        this.Array.Init();
        return true;
    }

    protected virtual Array Array { get; set; }

    protected virtual long ArrayCount { get { return 71; } set { } }

    public virtual long Count { get; set; }
    
    protected virtual long Index { get; set; }

    public virtual NodeKind Get(long index)
    {
        return (NodeKind)this.Array.GetAt(index);
    }
}