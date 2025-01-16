namespace Saber.Console;

partial class ClassPathTravel
{
    public virtual bool InitString()
    {
        this.SFieldName = this.S("Name");
        this.SFieldPart = this.S("Part");
        this.SFieldValue = this.S("Value");
        this.SFieldCount = this.S("Count");
        this.SFieldVar = this.S("Var");
        this.SFieldType = this.S("Type");
        this.SFieldParam = this.S("Param");
        this.SFieldCall = this.S("Call");
        this.SFieldCond = this.S("Cond");
        this.SFieldThen = this.S("Then");
        this.SFieldLoop = this.S("Loop");
        this.SFieldResult = this.S("Result");
        this.SFieldMark = this.S("Mark");
        this.SFieldAny = this.S("Any");
        this.SFieldThis = this.S("This");
        this.SFieldClass = this.S("Class");
        this.SFieldMaide = this.S("Maide");
        this.SFieldArgue = this.S("Argue");
        this.SFieldKind = this.S("Kind");
        this.SFieldStruct = this.S("Struct");
        this.SFieldLite = this.S("Lite");
        this.SFieldRite = this.S("Rite");
        return true;
    }

    protected virtual String SFieldName { get; set; }
    protected virtual String SFieldPart { get; set; }
    protected virtual String SFieldValue { get; set; }
    protected virtual String SFieldCount { get; set; }
    protected virtual String SFieldVar { get; set; }
    protected virtual String SFieldType { get; set; }
    protected virtual String SFieldParam { get; set; }
    protected virtual String SFieldCall { get; set; }
    protected virtual String SFieldCond { get; set; }
    protected virtual String SFieldThen { get; set; }
    protected virtual String SFieldLoop { get; set; }
    protected virtual String SFieldResult { get; set; }
    protected virtual String SFieldMark { get; set; }
    protected virtual String SFieldAny { get; set; }
    protected virtual String SFieldThis { get; set; }
    protected virtual String SFieldClass { get; set; }
    protected virtual String SFieldMaide { get; set; }
    protected virtual String SFieldArgue { get; set; }
    protected virtual String SFieldKind { get; set; }
    protected virtual String SFieldStruct { get; set; }
    protected virtual String SFieldLite { get; set; }
    protected virtual String SFieldRite { get; set; }

    public override bool ExecuteClass(NodeClass varClass)
    {
        if (varClass == null)
        {
            return true;
        }
        this.ExecuteNode(varClass);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldName))
        {
            this.ExecuteClassName(varClass.Name);
            return true;
        }
        if (this.FieldEqual(this.SFieldPart))
        {
            this.ExecutePart(varClass.Part);
            return true;
        }
        return true;
    }

    public override bool ExecutePart(Part part)
    {
        if (part == null)
        {
            return true;
        }

        long k;
        k = this.Index;

        Array array;
        array = part.Value;
        if (!(this.InfraInfra.ValidIndex(array.Count, k)))
        {
            return true;
        }

        Comp item;
        item = (Comp)array.GetAt(k);
        this.ExecuteComp(item);
        return true;
    }

    public override bool ExecuteStruct(Struct struct)
    {
        if (struct == null)
        {
            return true;
        }
        this.ExecuteNode(struct);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldName))
        {
            this.ExecuteStructName(struct.Name);
            return true;
        }
        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteCount(struct.Count);
            return true;
        }
        if (this.FieldEqual(this.SFieldPart))
        {
            this.ExecuteStructPart(struct.Part);
            return true;
        }
        return true;
    }

    public override bool ExecuteGlob(Glob glob)
    {
        if (glob == null)
        {
            return true;
        }
        this.ExecuteNode(glob);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteCount(glob.Count);
            return true;
        }
        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVar(glob.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteMaide(NodeMaide varMaide)
    {
        if (varMaide == null)
        {
            return true;
        }
        this.ExecuteNode(varMaide);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldType))
        {
            this.ExecuteTypeName(varMaide.Type);
            return true;
        }
        if (this.FieldEqual(this.SFieldName))
        {
            this.ExecuteMaideName(varMaide.Name);
            return true;
        }
        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteCount(varMaide.Count);
            return true;
        }
        if (this.FieldEqual(this.SFieldParam))
        {
            this.ExecuteParam(varMaide.Param);
            return true;
        }
        if (this.FieldEqual(this.SFieldCall))
        {
            this.ExecuteState(varMaide.Call);
            return true;
        }
        return true;
    }

    public override bool ExecuteStructPart(StructPart structPart)
    {
        if (structPart == null)
        {
            return true;
        }

        long k;
        k = this.Index;

        Array array;
        array = structPart.Value;
        if (!(this.InfraInfra.ValidIndex(array.Count, k)))
        {
            return true;
        }

        NodeVar item;
        item = (NodeVar)array.GetAt(k);
        this.ExecuteVar(item);
        return true;
    }

    public override bool ExecuteParam(Param param)
    {
        if (param == null)
        {
            return true;
        }

        long k;
        k = this.Index;

        Array array;
        array = param.Value;
        if (!(this.InfraInfra.ValidIndex(array.Count, k)))
        {
            return true;
        }

        NodeVar item;
        item = (NodeVar)array.GetAt(k);
        this.ExecuteVar(item);
        return true;
    }

    public override bool ExecuteVar(NodeVar varVar)
    {
        if (varVar == null)
        {
            return true;
        }
        this.ExecuteNode(varVar);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldType))
        {
            this.ExecuteTypeName(varVar.Type);
            return true;
        }
        if (this.FieldEqual(this.SFieldName))
        {
            this.ExecuteVarName(varVar.Name);
            return true;
        }
        return true;
    }

    public override bool ExecutePrusateCount(PrusateCount prusateCount)
    {
        if (prusateCount == null)
        {
            return true;
        }
        this.ExecuteNode(prusateCount);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecutePronateCount(PronateCount pronateCount)
    {
        if (pronateCount == null)
        {
            return true;
        }
        this.ExecuteNode(pronateCount);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecutePrivateCount(PrivateCount privateCount)
    {
        if (privateCount == null)
        {
            return true;
        }
        this.ExecuteNode(privateCount);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteState(State state)
    {
        if (state == null)
        {
            return true;
        }

        long k;
        k = this.Index;

        Array array;
        array = state.Value;
        if (!(this.InfraInfra.ValidIndex(array.Count, k)))
        {
            return true;
        }

        Execute item;
        item = (Execute)array.GetAt(k);
        this.ExecuteExecute(item);
        return true;
    }

    public override bool ExecuteInfExecute(InfExecute infExecute)
    {
        if (infExecute == null)
        {
            return true;
        }
        this.ExecuteNode(infExecute);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldCond))
        {
            this.ExecuteOperate(infExecute.Cond);
            return true;
        }
        if (this.FieldEqual(this.SFieldThen))
        {
            this.ExecuteState(infExecute.Then);
            return true;
        }
        return true;
    }

    public override bool ExecuteWhileExecute(WhileExecute whileExecute)
    {
        if (whileExecute == null)
        {
            return true;
        }
        this.ExecuteNode(whileExecute);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldCond))
        {
            this.ExecuteOperate(whileExecute.Cond);
            return true;
        }
        if (this.FieldEqual(this.SFieldLoop))
        {
            this.ExecuteState(whileExecute.Loop);
            return true;
        }
        return true;
    }

    public override bool ExecuteReturnExecute(ReturnExecute returnExecute)
    {
        if (returnExecute == null)
        {
            return true;
        }
        this.ExecuteNode(returnExecute);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldResult))
        {
            this.ExecuteOperate(returnExecute.Result);
            return true;
        }
        return true;
    }

    public override bool ExecuteReferExecute(ReferExecute referExecute)
    {
        if (referExecute == null)
        {
            return true;
        }
        this.ExecuteNode(referExecute);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVar(referExecute.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteAreExecute(AreExecute areExecute)
    {
        if (areExecute == null)
        {
            return true;
        }
        this.ExecuteNode(areExecute);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldMark))
        {
            this.ExecuteMark(areExecute.Mark);
            return true;
        }
        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteOperate(areExecute.Value);
            return true;
        }
        return true;
    }

    public override bool ExecuteOperateExecute(OperateExecute operateExecute)
    {
        if (operateExecute == null)
        {
            return true;
        }
        this.ExecuteNode(operateExecute);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldAny))
        {
            this.ExecuteOperate(operateExecute.Any);
            return true;
        }
        return true;
    }

    public override bool ExecuteArgue(Argue argue)
    {
        if (argue == null)
        {
            return true;
        }

        long k;
        k = this.Index;

        Array array;
        array = argue.Value;
        if (!(this.InfraInfra.ValidIndex(array.Count, k)))
        {
            return true;
        }

        Operate item;
        item = (Operate)array.GetAt(k);
        this.ExecuteOperate(item);
        return true;
    }

    public override bool ExecuteVarMark(VarMark varMark)
    {
        if (varMark == null)
        {
            return true;
        }
        this.ExecuteNode(varMark);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVarName(varMark.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteStructVarMark(StructVarMark structVarMark)
    {
        if (structVarMark == null)
        {
            return true;
        }
        this.ExecuteNode(structVarMark);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldThis))
        {
            this.ExecuteOperate(structVarMark.This);
            return true;
        }
        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVarName(structVarMark.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteGlobVarMark(GlobVarMark globVarMark)
    {
        if (globVarMark == null)
        {
            return true;
        }
        this.ExecuteNode(globVarMark);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteClassName(globVarMark.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVarName(globVarMark.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteVarOperate(VarOperate varOperate)
    {
        if (varOperate == null)
        {
            return true;
        }
        this.ExecuteNode(varOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVarName(varOperate.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteStructVarOperate(StructVarOperate structVarOperate)
    {
        if (structVarOperate == null)
        {
            return true;
        }
        this.ExecuteNode(structVarOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldThis))
        {
            this.ExecuteOperate(structVarOperate.This);
            return true;
        }
        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVarName(structVarOperate.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteGlobVarOperate(GlobVarOperate globVarOperate)
    {
        if (globVarOperate == null)
        {
            return true;
        }
        this.ExecuteNode(globVarOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteClassName(globVarOperate.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldVar))
        {
            this.ExecuteVarName(globVarOperate.Var);
            return true;
        }
        return true;
    }

    public override bool ExecuteCallOperate(CallOperate callOperate)
    {
        if (callOperate == null)
        {
            return true;
        }
        this.ExecuteNode(callOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteClassName(callOperate.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldMaide))
        {
            this.ExecuteMaideName(callOperate.Maide);
            return true;
        }
        if (this.FieldEqual(this.SFieldArgue))
        {
            this.ExecuteArgue(callOperate.Argue);
            return true;
        }
        return true;
    }

    public override bool ExecuteNullOperate(NullOperate nullOperate)
    {
        if (nullOperate == null)
        {
            return true;
        }
        this.ExecuteNode(nullOperate);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteCastOperate(CastOperate castOperate)
    {
        if (castOperate == null)
        {
            return true;
        }
        this.ExecuteNode(castOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteTypeName(castOperate.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldAny))
        {
            this.ExecuteOperate(castOperate.Any);
            return true;
        }
        return true;
    }

    public override bool ExecuteValueOperate(ValueOperate valueOperate)
    {
        if (valueOperate == null)
        {
            return true;
        }
        this.ExecuteNode(valueOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteValue(valueOperate.Value);
            return true;
        }
        return true;
    }

    public override bool ExecuteBraceOperate(BraceOperate braceOperate)
    {
        if (braceOperate == null)
        {
            return true;
        }
        this.ExecuteNode(braceOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldAny))
        {
            this.ExecuteOperate(braceOperate.Any);
            return true;
        }
        return true;
    }

    public override bool ExecuteBoolValue(BoolValue boolValue)
    {
        if (boolValue == null)
        {
            return true;
        }
        this.ExecuteNode(boolValue);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteIntDecValue(IntDecValue intDecValue)
    {
        if (intDecValue == null)
        {
            return true;
        }
        this.ExecuteNode(intDecValue);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteIntDecSignValue(IntDecSignValue intDecSignValue)
    {
        if (intDecSignValue == null)
        {
            return true;
        }
        this.ExecuteNode(intDecSignValue);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteIntHexValue(IntHexValue intHexValue)
    {
        if (intHexValue == null)
        {
            return true;
        }
        this.ExecuteNode(intHexValue);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteIntHexSignValue(IntHexSignValue intHexSignValue)
    {
        if (intHexSignValue == null)
        {
            return true;
        }
        this.ExecuteNode(intHexSignValue);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteStringValue(StringValue stringValue)
    {
        if (stringValue == null)
        {
            return true;
        }
        this.ExecuteNode(stringValue);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteClassName(ClassName className)
    {
        if (className == null)
        {
            return true;
        }
        this.ExecuteNode(className);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteStructName(StructName structName)
    {
        if (structName == null)
        {
            return true;
        }
        this.ExecuteNode(structName);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteMaideName(MaideName maideName)
    {
        if (maideName == null)
        {
            return true;
        }
        this.ExecuteNode(maideName);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteVarName(VarName varName)
    {
        if (varName == null)
        {
            return true;
        }
        this.ExecuteNode(varName);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteIntTypeName(IntTypeName intTypeName)
    {
        if (intTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(intTypeName);

        if (this.HasResult())
        {
            return true;
        }
        return true;
    }

    public override bool ExecuteStructTypeName(StructTypeName structTypeName)
    {
        if (structTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(structTypeName);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteClassName(structTypeName.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldStruct))
        {
            this.ExecuteStructName(structTypeName.Struct);
            return true;
        }
        return true;
    }

    public override bool ExecuteValueStructTypeName(ValueStructTypeName valueStructTypeName)
    {
        if (valueStructTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(valueStructTypeName);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteClassName(valueStructTypeName.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldStruct))
        {
            this.ExecuteStructName(valueStructTypeName.Struct);
            return true;
        }
        return true;
    }

    public override bool ExecuteArrayStructTypeName(ArrayStructTypeName arrayStructTypeName)
    {
        if (arrayStructTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(arrayStructTypeName);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldClass))
        {
            this.ExecuteClassName(arrayStructTypeName.Class);
            return true;
        }
        if (this.FieldEqual(this.SFieldStruct))
        {
            this.ExecuteStructName(arrayStructTypeName.Struct);
            return true;
        }
        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteIntValue(arrayStructTypeName.Count);
            return true;
        }
        return true;
    }

    public override bool ExecuteArrayIntTypeName(ArrayIntTypeName arrayIntTypeName)
    {
        if (arrayIntTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(arrayIntTypeName);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteIntValue(arrayIntTypeName.Count);
            return true;
        }
        return true;
    }

    public override bool ExecuteSameOperate(SameOperate sameOperate)
    {
        if (sameOperate == null)
        {
            return true;
        }
        this.ExecuteNode(sameOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(sameOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(sameOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteAndOperate(AndOperate andOperate)
    {
        if (andOperate == null)
        {
            return true;
        }
        this.ExecuteNode(andOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(andOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(andOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteOrnOperate(OrnOperate ornOperate)
    {
        if (ornOperate == null)
        {
            return true;
        }
        this.ExecuteNode(ornOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(ornOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(ornOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteNotOperate(NotOperate notOperate)
    {
        if (notOperate == null)
        {
            return true;
        }
        this.ExecuteNode(notOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteOperate(notOperate.Value);
            return true;
        }
        return true;
    }

    public override bool ExecuteLessOperate(LessOperate lessOperate)
    {
        if (lessOperate == null)
        {
            return true;
        }
        this.ExecuteNode(lessOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(lessOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(lessOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteAddOperate(AddOperate addOperate)
    {
        if (addOperate == null)
        {
            return true;
        }
        this.ExecuteNode(addOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(addOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(addOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteSubOperate(SubOperate subOperate)
    {
        if (subOperate == null)
        {
            return true;
        }
        this.ExecuteNode(subOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(subOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(subOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteMulOperate(MulOperate mulOperate)
    {
        if (mulOperate == null)
        {
            return true;
        }
        this.ExecuteNode(mulOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(mulOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(mulOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteDivOperate(DivOperate divOperate)
    {
        if (divOperate == null)
        {
            return true;
        }
        this.ExecuteNode(divOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(divOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(divOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteSignLessOperate(SignLessOperate signLessOperate)
    {
        if (signLessOperate == null)
        {
            return true;
        }
        this.ExecuteNode(signLessOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(signLessOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(signLessOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteSignMulOperate(SignMulOperate signMulOperate)
    {
        if (signMulOperate == null)
        {
            return true;
        }
        this.ExecuteNode(signMulOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(signMulOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(signMulOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteSignDivOperate(SignDivOperate signDivOperate)
    {
        if (signDivOperate == null)
        {
            return true;
        }
        this.ExecuteNode(signDivOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(signDivOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(signDivOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteBitAndOperate(BitAndOperate bitAndOperate)
    {
        if (bitAndOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitAndOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(bitAndOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(bitAndOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteBitOrnOperate(BitOrnOperate bitOrnOperate)
    {
        if (bitOrnOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitOrnOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldLite))
        {
            this.ExecuteOperate(bitOrnOperate.Lite);
            return true;
        }
        if (this.FieldEqual(this.SFieldRite))
        {
            this.ExecuteOperate(bitOrnOperate.Rite);
            return true;
        }
        return true;
    }

    public override bool ExecuteBitNotOperate(BitNotOperate bitNotOperate)
    {
        if (bitNotOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitNotOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteOperate(bitNotOperate.Value);
            return true;
        }
        return true;
    }

    public override bool ExecuteBitLiteOperate(BitLiteOperate bitLiteOperate)
    {
        if (bitLiteOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitLiteOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteOperate(bitLiteOperate.Value);
            return true;
        }
        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteOperate(bitLiteOperate.Count);
            return true;
        }
        return true;
    }

    public override bool ExecuteBitRiteOperate(BitRiteOperate bitRiteOperate)
    {
        if (bitRiteOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitRiteOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteOperate(bitRiteOperate.Value);
            return true;
        }
        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteOperate(bitRiteOperate.Count);
            return true;
        }
        return true;
    }

    public override bool ExecuteBitSignRiteOperate(BitSignRiteOperate bitSignRiteOperate)
    {
        if (bitSignRiteOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitSignRiteOperate);

        if (this.HasResult())
        {
            return true;
        }

        if (this.FieldEqual(this.SFieldValue))
        {
            this.ExecuteOperate(bitSignRiteOperate.Value);
            return true;
        }
        if (this.FieldEqual(this.SFieldCount))
        {
            this.ExecuteOperate(bitSignRiteOperate.Count);
            return true;
        }
        return true;
    }

}