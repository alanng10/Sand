namespace Saber.Node;

public class Travel : Any
{
    public virtual bool ExecuteClass(Class varClass)
    {
        if (varClass == null)
        {
            return true;
        }
        this.ExecuteNode(varClass);

        this.ExecuteClassName(varClass.Name);
        this.ExecutePart(varClass.Part);
        return true;
    }

    public virtual bool ExecutePart(Part part)
    {
        if (part == null)
        {
            return true;
        }
        this.ExecuteNode(part);

        long count;
        count = part.Value.Count;
        long i;
        i = 0;
        while (i < count)
        {
            Comp item;
            item = part.Value.GetAt(i) as Comp;
            this.ExecuteComp(item);

            i = i + 1;
        }
        return true;
    }

    public virtual bool ExecuteComp(Comp comp)
    {
        if (comp == null)
        {
            return true;
        }

        if (comp is Struct)
        {
            this.ExecuteStruct((Struct)comp);
        }
        if (comp is Glob)
        {
            this.ExecuteGlob((Glob)comp);
        }
        if (comp is Maide)
        {
            this.ExecuteMaide((Maide)comp);
        }
        return true;
    }

    public virtual bool ExecuteStruct(Struct struct)
    {
        if (struct == null)
        {
            return true;
        }
        this.ExecuteNode(struct);

        this.ExecuteStructName(struct.Name);
        this.ExecuteCount(struct.Count);
        this.ExecuteStructPart(struct.Part);
        return true;
    }

    public virtual bool ExecuteGlob(Glob glob)
    {
        if (glob == null)
        {
            return true;
        }
        this.ExecuteNode(glob);

        this.ExecuteCount(glob.Count);
        this.ExecuteVar(glob.Var);
        return true;
    }

    public virtual bool ExecuteMaide(Maide varMaide)
    {
        if (varMaide == null)
        {
            return true;
        }
        this.ExecuteNode(varMaide);

        this.ExecuteTypeName(varMaide.Type);
        this.ExecuteMaideName(varMaide.Name);
        this.ExecuteCount(varMaide.Count);
        this.ExecuteParam(varMaide.Param);
        this.ExecuteState(varMaide.Call);
        return true;
    }

    public virtual bool ExecuteStructPart(StructPart structPart)
    {
        if (structPart == null)
        {
            return true;
        }
        this.ExecuteNode(structPart);

        long count;
        count = structPart.Value.Count;
        long i;
        i = 0;
        while (i < count)
        {
            Var item;
            item = structPart.Value.GetAt(i) as Var;
            this.ExecuteVar(item);

            i = i + 1;
        }
        return true;
    }

    public virtual bool ExecuteParam(Param param)
    {
        if (param == null)
        {
            return true;
        }
        this.ExecuteNode(param);

        long count;
        count = param.Value.Count;
        long i;
        i = 0;
        while (i < count)
        {
            Var item;
            item = param.Value.GetAt(i) as Var;
            this.ExecuteVar(item);

            i = i + 1;
        }
        return true;
    }

    public virtual bool ExecuteVar(Var varVar)
    {
        if (varVar == null)
        {
            return true;
        }
        this.ExecuteNode(varVar);

        this.ExecuteTypeName(varVar.Type);
        this.ExecuteVarName(varVar.Name);
        return true;
    }

    public virtual bool ExecuteCount(Count count)
    {
        if (count == null)
        {
            return true;
        }

        if (count is PrusateCount)
        {
            this.ExecutePrusateCount((PrusateCount)count);
        }
        if (count is PronateCount)
        {
            this.ExecutePronateCount((PronateCount)count);
        }
        if (count is PrivateCount)
        {
            this.ExecutePrivateCount((PrivateCount)count);
        }
        return true;
    }

    public virtual bool ExecutePrusateCount(PrusateCount prusateCount)
    {
        if (prusateCount == null)
        {
            return true;
        }
        this.ExecuteNode(prusateCount);
        return true;
    }

    public virtual bool ExecutePronateCount(PronateCount pronateCount)
    {
        if (pronateCount == null)
        {
            return true;
        }
        this.ExecuteNode(pronateCount);
        return true;
    }

    public virtual bool ExecutePrivateCount(PrivateCount privateCount)
    {
        if (privateCount == null)
        {
            return true;
        }
        this.ExecuteNode(privateCount);
        return true;
    }

    public virtual bool ExecuteState(State state)
    {
        if (state == null)
        {
            return true;
        }
        this.ExecuteNode(state);

        long count;
        count = state.Value.Count;
        long i;
        i = 0;
        while (i < count)
        {
            Execute item;
            item = state.Value.GetAt(i) as Execute;
            this.ExecuteExecute(item);

            i = i + 1;
        }
        return true;
    }

    public virtual bool ExecuteExecute(Execute execute)
    {
        if (execute == null)
        {
            return true;
        }

        if (execute is InfExecute)
        {
            this.ExecuteInfExecute((InfExecute)execute);
        }
        if (execute is WhileExecute)
        {
            this.ExecuteWhileExecute((WhileExecute)execute);
        }
        if (execute is ReturnExecute)
        {
            this.ExecuteReturnExecute((ReturnExecute)execute);
        }
        if (execute is ReferExecute)
        {
            this.ExecuteReferExecute((ReferExecute)execute);
        }
        if (execute is AreExecute)
        {
            this.ExecuteAreExecute((AreExecute)execute);
        }
        if (execute is OperateExecute)
        {
            this.ExecuteOperateExecute((OperateExecute)execute);
        }
        return true;
    }

    public virtual bool ExecuteInfExecute(InfExecute infExecute)
    {
        if (infExecute == null)
        {
            return true;
        }
        this.ExecuteNode(infExecute);

        this.ExecuteOperate(infExecute.Cond);
        this.ExecuteState(infExecute.Then);
        return true;
    }

    public virtual bool ExecuteWhileExecute(WhileExecute whileExecute)
    {
        if (whileExecute == null)
        {
            return true;
        }
        this.ExecuteNode(whileExecute);

        this.ExecuteOperate(whileExecute.Cond);
        this.ExecuteState(whileExecute.Loop);
        return true;
    }

    public virtual bool ExecuteReturnExecute(ReturnExecute returnExecute)
    {
        if (returnExecute == null)
        {
            return true;
        }
        this.ExecuteNode(returnExecute);

        this.ExecuteOperate(returnExecute.Result);
        return true;
    }

    public virtual bool ExecuteReferExecute(ReferExecute referExecute)
    {
        if (referExecute == null)
        {
            return true;
        }
        this.ExecuteNode(referExecute);

        this.ExecuteVar(referExecute.Var);
        return true;
    }

    public virtual bool ExecuteAreExecute(AreExecute areExecute)
    {
        if (areExecute == null)
        {
            return true;
        }
        this.ExecuteNode(areExecute);

        this.ExecuteMark(areExecute.Mark);
        this.ExecuteOperate(areExecute.Value);
        return true;
    }

    public virtual bool ExecuteOperateExecute(OperateExecute operateExecute)
    {
        if (operateExecute == null)
        {
            return true;
        }
        this.ExecuteNode(operateExecute);

        this.ExecuteOperate(operateExecute.Any);
        return true;
    }

    public virtual bool ExecuteArgue(Argue argue)
    {
        if (argue == null)
        {
            return true;
        }
        this.ExecuteNode(argue);

        long count;
        count = argue.Value.Count;
        long i;
        i = 0;
        while (i < count)
        {
            Operate item;
            item = argue.Value.GetAt(i) as Operate;
            this.ExecuteOperate(item);

            i = i + 1;
        }
        return true;
    }

    public virtual bool ExecuteMark(Mark mark)
    {
        if (mark == null)
        {
            return true;
        }

        if (mark is VarMark)
        {
            this.ExecuteVarMark((VarMark)mark);
        }
        if (mark is StructVarMark)
        {
            this.ExecuteStructVarMark((StructVarMark)mark);
        }
        if (mark is GlobVarMark)
        {
            this.ExecuteGlobVarMark((GlobVarMark)mark);
        }
        return true;
    }

    public virtual bool ExecuteVarMark(VarMark varMark)
    {
        if (varMark == null)
        {
            return true;
        }
        this.ExecuteNode(varMark);

        this.ExecuteVarName(varMark.Var);
        return true;
    }

    public virtual bool ExecuteStructVarMark(StructVarMark structVarMark)
    {
        if (structVarMark == null)
        {
            return true;
        }
        this.ExecuteNode(structVarMark);

        this.ExecuteOperate(structVarMark.This);
        this.ExecuteVarName(structVarMark.Var);
        return true;
    }

    public virtual bool ExecuteGlobVarMark(GlobVarMark globVarMark)
    {
        if (globVarMark == null)
        {
            return true;
        }
        this.ExecuteNode(globVarMark);

        this.ExecuteClassName(globVarMark.Class);
        this.ExecuteVarName(globVarMark.Var);
        return true;
    }

    public virtual bool ExecuteOperate(Operate operate)
    {
        if (operate == null)
        {
            return true;
        }

        if (operate is VarOperate)
        {
            this.ExecuteVarOperate((VarOperate)operate);
        }
        if (operate is StructVarOperate)
        {
            this.ExecuteStructVarOperate((StructVarOperate)operate);
        }
        if (operate is GlobVarOperate)
        {
            this.ExecuteGlobVarOperate((GlobVarOperate)operate);
        }
        if (operate is CallOperate)
        {
            this.ExecuteCallOperate((CallOperate)operate);
        }
        if (operate is NullOperate)
        {
            this.ExecuteNullOperate((NullOperate)operate);
        }
        if (operate is CastOperate)
        {
            this.ExecuteCastOperate((CastOperate)operate);
        }
        if (operate is ValueOperate)
        {
            this.ExecuteValueOperate((ValueOperate)operate);
        }
        if (operate is BraceOperate)
        {
            this.ExecuteBraceOperate((BraceOperate)operate);
        }
        if (operate is SameOperate)
        {
            this.ExecuteSameOperate((SameOperate)operate);
        }
        if (operate is AndOperate)
        {
            this.ExecuteAndOperate((AndOperate)operate);
        }
        if (operate is OrnOperate)
        {
            this.ExecuteOrnOperate((OrnOperate)operate);
        }
        if (operate is NotOperate)
        {
            this.ExecuteNotOperate((NotOperate)operate);
        }
        if (operate is LessOperate)
        {
            this.ExecuteLessOperate((LessOperate)operate);
        }
        if (operate is AddOperate)
        {
            this.ExecuteAddOperate((AddOperate)operate);
        }
        if (operate is SubOperate)
        {
            this.ExecuteSubOperate((SubOperate)operate);
        }
        if (operate is MulOperate)
        {
            this.ExecuteMulOperate((MulOperate)operate);
        }
        if (operate is DivOperate)
        {
            this.ExecuteDivOperate((DivOperate)operate);
        }
        if (operate is SignLessOperate)
        {
            this.ExecuteSignLessOperate((SignLessOperate)operate);
        }
        if (operate is SignMulOperate)
        {
            this.ExecuteSignMulOperate((SignMulOperate)operate);
        }
        if (operate is SignDivOperate)
        {
            this.ExecuteSignDivOperate((SignDivOperate)operate);
        }
        if (operate is BitAndOperate)
        {
            this.ExecuteBitAndOperate((BitAndOperate)operate);
        }
        if (operate is BitOrnOperate)
        {
            this.ExecuteBitOrnOperate((BitOrnOperate)operate);
        }
        if (operate is BitNotOperate)
        {
            this.ExecuteBitNotOperate((BitNotOperate)operate);
        }
        if (operate is BitLiteOperate)
        {
            this.ExecuteBitLiteOperate((BitLiteOperate)operate);
        }
        if (operate is BitRiteOperate)
        {
            this.ExecuteBitRiteOperate((BitRiteOperate)operate);
        }
        if (operate is BitSignRiteOperate)
        {
            this.ExecuteBitSignRiteOperate((BitSignRiteOperate)operate);
        }
        return true;
    }

    public virtual bool ExecuteVarOperate(VarOperate varOperate)
    {
        if (varOperate == null)
        {
            return true;
        }
        this.ExecuteNode(varOperate);

        this.ExecuteVarName(varOperate.Var);
        return true;
    }

    public virtual bool ExecuteStructVarOperate(StructVarOperate structVarOperate)
    {
        if (structVarOperate == null)
        {
            return true;
        }
        this.ExecuteNode(structVarOperate);

        this.ExecuteOperate(structVarOperate.This);
        this.ExecuteVarName(structVarOperate.Var);
        return true;
    }

    public virtual bool ExecuteGlobVarOperate(GlobVarOperate globVarOperate)
    {
        if (globVarOperate == null)
        {
            return true;
        }
        this.ExecuteNode(globVarOperate);

        this.ExecuteClassName(globVarOperate.Class);
        this.ExecuteVarName(globVarOperate.Var);
        return true;
    }

    public virtual bool ExecuteCallOperate(CallOperate callOperate)
    {
        if (callOperate == null)
        {
            return true;
        }
        this.ExecuteNode(callOperate);

        this.ExecuteClassName(callOperate.Class);
        this.ExecuteMaideName(callOperate.Maide);
        this.ExecuteArgue(callOperate.Argue);
        return true;
    }

    public virtual bool ExecuteNullOperate(NullOperate nullOperate)
    {
        if (nullOperate == null)
        {
            return true;
        }
        this.ExecuteNode(nullOperate);
        return true;
    }

    public virtual bool ExecuteCastOperate(CastOperate castOperate)
    {
        if (castOperate == null)
        {
            return true;
        }
        this.ExecuteNode(castOperate);

        this.ExecuteTypeName(castOperate.Class);
        this.ExecuteOperate(castOperate.Any);
        return true;
    }

    public virtual bool ExecuteValueOperate(ValueOperate valueOperate)
    {
        if (valueOperate == null)
        {
            return true;
        }
        this.ExecuteNode(valueOperate);

        this.ExecuteValue(valueOperate.Value);
        return true;
    }

    public virtual bool ExecuteBraceOperate(BraceOperate braceOperate)
    {
        if (braceOperate == null)
        {
            return true;
        }
        this.ExecuteNode(braceOperate);

        this.ExecuteOperate(braceOperate.Any);
        return true;
    }

    public virtual bool ExecuteValue(Value value)
    {
        if (value == null)
        {
            return true;
        }

        if (value is BoolValue)
        {
            this.ExecuteBoolValue((BoolValue)value);
        }
        if (value is IntValue)
        {
            this.ExecuteIntValue((IntValue)value);
        }
        if (value is StringValue)
        {
            this.ExecuteStringValue((StringValue)value);
        }
        return true;
    }

    public virtual bool ExecuteBoolValue(BoolValue boolValue)
    {
        if (boolValue == null)
        {
            return true;
        }
        this.ExecuteNode(boolValue);
        return true;
    }

    public virtual bool ExecuteIntValue(IntValue intValue)
    {
        if (intValue == null)
        {
            return true;
        }

        if (intValue is IntDecValue)
        {
            this.ExecuteIntDecValue((IntDecValue)intValue);
        }
        if (intValue is IntDecSignValue)
        {
            this.ExecuteIntDecSignValue((IntDecSignValue)intValue);
        }
        if (intValue is IntHexValue)
        {
            this.ExecuteIntHexValue((IntHexValue)intValue);
        }
        if (intValue is IntHexSignValue)
        {
            this.ExecuteIntHexSignValue((IntHexSignValue)intValue);
        }
        return true;
    }

    public virtual bool ExecuteIntDecValue(IntDecValue intDecValue)
    {
        if (intDecValue == null)
        {
            return true;
        }
        this.ExecuteNode(intDecValue);
        return true;
    }

    public virtual bool ExecuteIntDecSignValue(IntDecSignValue intDecSignValue)
    {
        if (intDecSignValue == null)
        {
            return true;
        }
        this.ExecuteNode(intDecSignValue);
        return true;
    }

    public virtual bool ExecuteIntHexValue(IntHexValue intHexValue)
    {
        if (intHexValue == null)
        {
            return true;
        }
        this.ExecuteNode(intHexValue);
        return true;
    }

    public virtual bool ExecuteIntHexSignValue(IntHexSignValue intHexSignValue)
    {
        if (intHexSignValue == null)
        {
            return true;
        }
        this.ExecuteNode(intHexSignValue);
        return true;
    }

    public virtual bool ExecuteStringValue(StringValue stringValue)
    {
        if (stringValue == null)
        {
            return true;
        }
        this.ExecuteNode(stringValue);
        return true;
    }

    public virtual bool ExecuteClassName(ClassName className)
    {
        if (className == null)
        {
            return true;
        }
        this.ExecuteNode(className);
        return true;
    }

    public virtual bool ExecuteStructName(StructName structName)
    {
        if (structName == null)
        {
            return true;
        }
        this.ExecuteNode(structName);
        return true;
    }

    public virtual bool ExecuteMaideName(MaideName maideName)
    {
        if (maideName == null)
        {
            return true;
        }
        this.ExecuteNode(maideName);
        return true;
    }

    public virtual bool ExecuteVarName(VarName varName)
    {
        if (varName == null)
        {
            return true;
        }
        this.ExecuteNode(varName);
        return true;
    }

    public virtual bool ExecuteTypeName(TypeName typeName)
    {
        if (typeName == null)
        {
            return true;
        }

        if (typeName is IntTypeName)
        {
            this.ExecuteIntTypeName((IntTypeName)typeName);
        }
        if (typeName is StructTypeName)
        {
            this.ExecuteStructTypeName((StructTypeName)typeName);
        }
        if (typeName is ValueStructTypeName)
        {
            this.ExecuteValueStructTypeName((ValueStructTypeName)typeName);
        }
        if (typeName is ArrayStructTypeName)
        {
            this.ExecuteArrayStructTypeName((ArrayStructTypeName)typeName);
        }
        if (typeName is ArrayIntTypeName)
        {
            this.ExecuteArrayIntTypeName((ArrayIntTypeName)typeName);
        }
        return true;
    }

    public virtual bool ExecuteIntTypeName(IntTypeName intTypeName)
    {
        if (intTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(intTypeName);
        return true;
    }

    public virtual bool ExecuteStructTypeName(StructTypeName structTypeName)
    {
        if (structTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(structTypeName);

        this.ExecuteClassName(structTypeName.Class);
        this.ExecuteStructName(structTypeName.Struct);
        return true;
    }

    public virtual bool ExecuteValueStructTypeName(ValueStructTypeName valueStructTypeName)
    {
        if (valueStructTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(valueStructTypeName);

        this.ExecuteClassName(valueStructTypeName.Class);
        this.ExecuteStructName(valueStructTypeName.Struct);
        return true;
    }

    public virtual bool ExecuteArrayStructTypeName(ArrayStructTypeName arrayStructTypeName)
    {
        if (arrayStructTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(arrayStructTypeName);

        this.ExecuteClassName(arrayStructTypeName.Class);
        this.ExecuteStructName(arrayStructTypeName.Struct);
        this.ExecuteIntValue(arrayStructTypeName.Count);
        return true;
    }

    public virtual bool ExecuteArrayIntTypeName(ArrayIntTypeName arrayIntTypeName)
    {
        if (arrayIntTypeName == null)
        {
            return true;
        }
        this.ExecuteNode(arrayIntTypeName);

        this.ExecuteIntValue(arrayIntTypeName.Count);
        return true;
    }

    public virtual bool ExecuteSameOperate(SameOperate sameOperate)
    {
        if (sameOperate == null)
        {
            return true;
        }
        this.ExecuteNode(sameOperate);

        this.ExecuteOperate(sameOperate.Lite);
        this.ExecuteOperate(sameOperate.Rite);
        return true;
    }

    public virtual bool ExecuteAndOperate(AndOperate andOperate)
    {
        if (andOperate == null)
        {
            return true;
        }
        this.ExecuteNode(andOperate);

        this.ExecuteOperate(andOperate.Lite);
        this.ExecuteOperate(andOperate.Rite);
        return true;
    }

    public virtual bool ExecuteOrnOperate(OrnOperate ornOperate)
    {
        if (ornOperate == null)
        {
            return true;
        }
        this.ExecuteNode(ornOperate);

        this.ExecuteOperate(ornOperate.Lite);
        this.ExecuteOperate(ornOperate.Rite);
        return true;
    }

    public virtual bool ExecuteNotOperate(NotOperate notOperate)
    {
        if (notOperate == null)
        {
            return true;
        }
        this.ExecuteNode(notOperate);

        this.ExecuteOperate(notOperate.Value);
        return true;
    }

    public virtual bool ExecuteLessOperate(LessOperate lessOperate)
    {
        if (lessOperate == null)
        {
            return true;
        }
        this.ExecuteNode(lessOperate);

        this.ExecuteOperate(lessOperate.Lite);
        this.ExecuteOperate(lessOperate.Rite);
        return true;
    }

    public virtual bool ExecuteAddOperate(AddOperate addOperate)
    {
        if (addOperate == null)
        {
            return true;
        }
        this.ExecuteNode(addOperate);

        this.ExecuteOperate(addOperate.Lite);
        this.ExecuteOperate(addOperate.Rite);
        return true;
    }

    public virtual bool ExecuteSubOperate(SubOperate subOperate)
    {
        if (subOperate == null)
        {
            return true;
        }
        this.ExecuteNode(subOperate);

        this.ExecuteOperate(subOperate.Lite);
        this.ExecuteOperate(subOperate.Rite);
        return true;
    }

    public virtual bool ExecuteMulOperate(MulOperate mulOperate)
    {
        if (mulOperate == null)
        {
            return true;
        }
        this.ExecuteNode(mulOperate);

        this.ExecuteOperate(mulOperate.Lite);
        this.ExecuteOperate(mulOperate.Rite);
        return true;
    }

    public virtual bool ExecuteDivOperate(DivOperate divOperate)
    {
        if (divOperate == null)
        {
            return true;
        }
        this.ExecuteNode(divOperate);

        this.ExecuteOperate(divOperate.Lite);
        this.ExecuteOperate(divOperate.Rite);
        return true;
    }

    public virtual bool ExecuteSignLessOperate(SignLessOperate signLessOperate)
    {
        if (signLessOperate == null)
        {
            return true;
        }
        this.ExecuteNode(signLessOperate);

        this.ExecuteOperate(signLessOperate.Lite);
        this.ExecuteOperate(signLessOperate.Rite);
        return true;
    }

    public virtual bool ExecuteSignMulOperate(SignMulOperate signMulOperate)
    {
        if (signMulOperate == null)
        {
            return true;
        }
        this.ExecuteNode(signMulOperate);

        this.ExecuteOperate(signMulOperate.Lite);
        this.ExecuteOperate(signMulOperate.Rite);
        return true;
    }

    public virtual bool ExecuteSignDivOperate(SignDivOperate signDivOperate)
    {
        if (signDivOperate == null)
        {
            return true;
        }
        this.ExecuteNode(signDivOperate);

        this.ExecuteOperate(signDivOperate.Lite);
        this.ExecuteOperate(signDivOperate.Rite);
        return true;
    }

    public virtual bool ExecuteBitAndOperate(BitAndOperate bitAndOperate)
    {
        if (bitAndOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitAndOperate);

        this.ExecuteOperate(bitAndOperate.Lite);
        this.ExecuteOperate(bitAndOperate.Rite);
        return true;
    }

    public virtual bool ExecuteBitOrnOperate(BitOrnOperate bitOrnOperate)
    {
        if (bitOrnOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitOrnOperate);

        this.ExecuteOperate(bitOrnOperate.Lite);
        this.ExecuteOperate(bitOrnOperate.Rite);
        return true;
    }

    public virtual bool ExecuteBitNotOperate(BitNotOperate bitNotOperate)
    {
        if (bitNotOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitNotOperate);

        this.ExecuteOperate(bitNotOperate.Value);
        return true;
    }

    public virtual bool ExecuteBitLiteOperate(BitLiteOperate bitLiteOperate)
    {
        if (bitLiteOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitLiteOperate);

        this.ExecuteOperate(bitLiteOperate.Value);
        this.ExecuteOperate(bitLiteOperate.Count);
        return true;
    }

    public virtual bool ExecuteBitRiteOperate(BitRiteOperate bitRiteOperate)
    {
        if (bitRiteOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitRiteOperate);

        this.ExecuteOperate(bitRiteOperate.Value);
        this.ExecuteOperate(bitRiteOperate.Count);
        return true;
    }

    public virtual bool ExecuteBitSignRiteOperate(BitSignRiteOperate bitSignRiteOperate)
    {
        if (bitSignRiteOperate == null)
        {
            return true;
        }
        this.ExecuteNode(bitSignRiteOperate);

        this.ExecuteOperate(bitSignRiteOperate.Value);
        this.ExecuteOperate(bitSignRiteOperate.Count);
        return true;
    }

    protected virtual bool ExecuteNode(Node node)
    {
        return true;
    }
}