using System;
using Mono.Cecil;
using Mono.Cecil.Cil;

namespace FluentCecil
{
    partial class FluentMethodBody
	{
        public FluentMethodBody Add()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Add));
	        return this;
	    }

        public FluentMethodBody AddOvf()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Add_Ovf));
	        return this;
	    }

        public FluentMethodBody AddOvfUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Add_Ovf_Un));
	        return this;
	    }

        public FluentMethodBody And()
	    {
			addInstruction(ilProcessor.Create(OpCodes.And));
	        return this;
	    }

        public FluentMethodBody Arglist()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Arglist));
	        return this;
	    }

		public FluentMethodBody Beq(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Beq, i));
	        return this;
	    }

		public FluentMethodBody BeqS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Beq_S, i));
	        return this;
	    }

		public FluentMethodBody Bge(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bge, i));
	        return this;
	    }

		public FluentMethodBody BgeS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bge_S, i));
	        return this;
	    }

		public FluentMethodBody BgeUn(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bge_Un, i));
	        return this;
	    }

		public FluentMethodBody BgeUnS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bge_Un_S, i));
	        return this;
	    }

		public FluentMethodBody Bgt(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bgt, i));
	        return this;
	    }

		public FluentMethodBody BgtS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bgt_S, i));
	        return this;
	    }

		public FluentMethodBody BgtUn(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bgt_Un, i));
	        return this;
	    }

		public FluentMethodBody BgtUnS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bgt_Un_S, i));
	        return this;
	    }

		public FluentMethodBody Ble(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ble, i));
	        return this;
	    }

		public FluentMethodBody BleS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ble_S, i));
	        return this;
	    }

		public FluentMethodBody BleUn(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ble_Un, i));
	        return this;
	    }

		public FluentMethodBody BleUnS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ble_Un_S, i));
	        return this;
	    }

		public FluentMethodBody Blt(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Blt, i));
	        return this;
	    }

		public FluentMethodBody BltS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Blt_S, i));
	        return this;
	    }

		public FluentMethodBody BltUn(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Blt_Un, i));
	        return this;
	    }

		public FluentMethodBody BltUnS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Blt_Un_S, i));
	        return this;
	    }

		public FluentMethodBody BneUn(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bne_Un, i));
	        return this;
	    }

		public FluentMethodBody BneUnS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Bne_Un_S, i));
	        return this;
	    }

		public FluentMethodBody Box(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Box, t));
	        return this;
	    }

		public FluentMethodBody Br(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Br, i));
	        return this;
	    }

		public FluentMethodBody BrS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Br_S, i));
	        return this;
	    }

        public FluentMethodBody Break()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Break));
	        return this;
	    }

		public FluentMethodBody Brfalse(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Brfalse, i));
	        return this;
	    }

		public FluentMethodBody BrfalseS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Brfalse_S, i));
	        return this;
	    }

		public FluentMethodBody Brtrue(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Brtrue, i));
	        return this;
	    }

		public FluentMethodBody BrtrueS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Brtrue_S, i));
	        return this;
	    }

		public FluentMethodBody Call(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Call, m));
	        return this;
	    }

        public FluentMethodBody Calli()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Calli));
	        return this;
	    }

		public FluentMethodBody Callvirt(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Callvirt, m));
	        return this;
	    }

		public FluentMethodBody Castclass(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Castclass, t));
	        return this;
	    }

        public FluentMethodBody Ceq()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ceq));
	        return this;
	    }

        public FluentMethodBody Cgt()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Cgt));
	        return this;
	    }

        public FluentMethodBody CgtUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Cgt_Un));
	        return this;
	    }

        public FluentMethodBody Ckfinite()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ckfinite));
	        return this;
	    }

        public FluentMethodBody Clt()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Clt));
	        return this;
	    }

        public FluentMethodBody CltUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Clt_Un));
	        return this;
	    }

        public FluentMethodBody ConvI()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_I));
	        return this;
	    }

        public FluentMethodBody ConvI1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_I1));
	        return this;
	    }

        public FluentMethodBody ConvI2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_I2));
	        return this;
	    }

        public FluentMethodBody ConvI4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_I4));
	        return this;
	    }

        public FluentMethodBody ConvI8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_I8));
	        return this;
	    }

        public FluentMethodBody ConvOvfI()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I));
	        return this;
	    }

        public FluentMethodBody ConvOvfIUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfI1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I1));
	        return this;
	    }

        public FluentMethodBody ConvOvfI1Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I1_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfI2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I2));
	        return this;
	    }

        public FluentMethodBody ConvOvfI2Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I2_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfI4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I4));
	        return this;
	    }

        public FluentMethodBody ConvOvfI4Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I4_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfI8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I8));
	        return this;
	    }

        public FluentMethodBody ConvOvfI8Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_I8_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfU()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U));
	        return this;
	    }

        public FluentMethodBody ConvOvfUUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfU1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U1));
	        return this;
	    }

        public FluentMethodBody ConvOvfU1Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U1_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfU2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U2));
	        return this;
	    }

        public FluentMethodBody ConvOvfU2Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U2_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfU4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U4));
	        return this;
	    }

        public FluentMethodBody ConvOvfU4Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U4_Un));
	        return this;
	    }

        public FluentMethodBody ConvOvfU8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U8));
	        return this;
	    }

        public FluentMethodBody ConvOvfU8Un()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_Ovf_U8_Un));
	        return this;
	    }

        public FluentMethodBody ConvRUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_R_Un));
	        return this;
	    }

        public FluentMethodBody ConvR4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_R4));
	        return this;
	    }

        public FluentMethodBody ConvR8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_R8));
	        return this;
	    }

        public FluentMethodBody ConvU()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_U));
	        return this;
	    }

        public FluentMethodBody ConvU1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_U1));
	        return this;
	    }

        public FluentMethodBody ConvU2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_U2));
	        return this;
	    }

        public FluentMethodBody ConvU4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_U4));
	        return this;
	    }

        public FluentMethodBody ConvU8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Conv_U8));
	        return this;
	    }

        public FluentMethodBody Cpblk()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Cpblk));
	        return this;
	    }

		public FluentMethodBody Cpobj(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Cpobj, t));
	        return this;
	    }

        public FluentMethodBody Div()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Div));
	        return this;
	    }

        public FluentMethodBody DivUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Div_Un));
	        return this;
	    }

        public FluentMethodBody Dup()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Dup));
	        return this;
	    }

        public FluentMethodBody Endfilter()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Endfilter));
	        return this;
	    }

        public FluentMethodBody Endfinally()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Endfinally));
	        return this;
	    }

        public FluentMethodBody Initblk()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Initblk));
	        return this;
	    }

		public FluentMethodBody Initobj(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Initobj, t));
	        return this;
	    }

		public FluentMethodBody Isinst(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Isinst, t));
	        return this;
	    }

		public FluentMethodBody Jmp(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Jmp, m));
	        return this;
	    }

		public FluentMethodBody Ldarg(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarg, i));
	        return this;
	    }

        public FluentMethodBody Ldarg0()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarg_0));
	        return this;
	    }

        public FluentMethodBody Ldarg1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarg_1));
	        return this;
	    }

        public FluentMethodBody Ldarg2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarg_2));
	        return this;
	    }

        public FluentMethodBody Ldarg3()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarg_3));
	        return this;
	    }

		public FluentMethodBody LdargS(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarg_S, b));
	        return this;
	    }

		public FluentMethodBody Ldarga(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarga, i));
	        return this;
	    }

		public FluentMethodBody LdargaS(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldarga_S, b));
	        return this;
	    }

		public FluentMethodBody LdcI4(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4, i));
	        return this;
	    }

        public FluentMethodBody LdcI40()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_0));
	        return this;
	    }

        public FluentMethodBody LdcI41()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_1));
	        return this;
	    }

        public FluentMethodBody LdcI42()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_2));
	        return this;
	    }

        public FluentMethodBody LdcI43()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_3));
	        return this;
	    }

        public FluentMethodBody LdcI44()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_4));
	        return this;
	    }

        public FluentMethodBody LdcI45()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_5));
	        return this;
	    }

        public FluentMethodBody LdcI46()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_6));
	        return this;
	    }

        public FluentMethodBody LdcI47()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_7));
	        return this;
	    }

        public FluentMethodBody LdcI48()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_8));
	        return this;
	    }

        public FluentMethodBody LdcI4M1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_M1));
	        return this;
	    }

		public FluentMethodBody LdcI4S(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I4_S, b));
	        return this;
	    }

		public FluentMethodBody LdcI8(long l)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_I8, l));
	        return this;
	    }

		public FluentMethodBody LdcR4(float f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_R4, f));
	        return this;
	    }

		public FluentMethodBody LdcR8(double d)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldc_R8, d));
	        return this;
	    }

		public FluentMethodBody LdelemAny(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_Any, t));
	        return this;
	    }

        public FluentMethodBody LdelemI()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_I));
	        return this;
	    }

        public FluentMethodBody LdelemI1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_I1));
	        return this;
	    }

        public FluentMethodBody LdelemI2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_I2));
	        return this;
	    }

        public FluentMethodBody LdelemI4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_I4));
	        return this;
	    }

        public FluentMethodBody LdelemI8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_I8));
	        return this;
	    }

        public FluentMethodBody LdelemR4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_R4));
	        return this;
	    }

        public FluentMethodBody LdelemR8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_R8));
	        return this;
	    }

        public FluentMethodBody LdelemRef()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_Ref));
	        return this;
	    }

        public FluentMethodBody LdelemU1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_U1));
	        return this;
	    }

        public FluentMethodBody LdelemU2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_U2));
	        return this;
	    }

        public FluentMethodBody LdelemU4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelem_U4));
	        return this;
	    }

		public FluentMethodBody Ldelema(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldelema, t));
	        return this;
	    }

		public FluentMethodBody Ldfld(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldfld, f));
	        return this;
	    }

		public FluentMethodBody Ldflda(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldflda, f));
	        return this;
	    }

		public FluentMethodBody Ldftn(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldftn, m));
	        return this;
	    }

        public FluentMethodBody LdindI()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_I));
	        return this;
	    }

        public FluentMethodBody LdindI1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_I1));
	        return this;
	    }

        public FluentMethodBody LdindI2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_I2));
	        return this;
	    }

        public FluentMethodBody LdindI4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_I4));
	        return this;
	    }

        public FluentMethodBody LdindI8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_I8));
	        return this;
	    }

        public FluentMethodBody LdindR4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_R4));
	        return this;
	    }

        public FluentMethodBody LdindR8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_R8));
	        return this;
	    }

        public FluentMethodBody LdindRef()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_Ref));
	        return this;
	    }

        public FluentMethodBody LdindU1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_U1));
	        return this;
	    }

        public FluentMethodBody LdindU2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_U2));
	        return this;
	    }

        public FluentMethodBody LdindU4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldind_U4));
	        return this;
	    }

        public FluentMethodBody Ldlen()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldlen));
	        return this;
	    }

		public FluentMethodBody Ldloc(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc, i));
	        return this;
	    }

		public FluentMethodBody Ldloc(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc, i));
	        return this;
	    }

        public FluentMethodBody Ldloc0()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc_0));
	        return this;
	    }

        public FluentMethodBody Ldloc1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc_1));
	        return this;
	    }

        public FluentMethodBody Ldloc2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc_2));
	        return this;
	    }

        public FluentMethodBody Ldloc3()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc_3));
	        return this;
	    }

		public FluentMethodBody LdlocS(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloc_S, b));
	        return this;
	    }

		public FluentMethodBody Ldloca(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloca, i));
	        return this;
	    }

		public FluentMethodBody Ldloca(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloca, i));
	        return this;
	    }

		public FluentMethodBody LdlocaS(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldloca_S, b));
	        return this;
	    }

        public FluentMethodBody Ldnull()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldnull));
	        return this;
	    }

		public FluentMethodBody Ldobj(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldobj, t));
	        return this;
	    }

		public FluentMethodBody Ldsfld(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldsfld, f));
	        return this;
	    }

		public FluentMethodBody Ldsflda(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldsflda, f));
	        return this;
	    }

		public FluentMethodBody Ldstr(string s)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldstr, s));
	        return this;
	    }

		public FluentMethodBody Ldtoken(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldtoken, f));
	        return this;
	    }

		public FluentMethodBody Ldtoken(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldtoken, m));
	        return this;
	    }

		public FluentMethodBody Ldtoken(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldtoken, t));
	        return this;
	    }

		public FluentMethodBody Ldvirtftn(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ldvirtftn, m));
	        return this;
	    }

		public FluentMethodBody Leave(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Leave, i));
	        return this;
	    }

		public FluentMethodBody LeaveS(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Leave_S, i));
	        return this;
	    }

        public FluentMethodBody Localloc()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Localloc));
	        return this;
	    }

		public FluentMethodBody Mkrefany(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Mkrefany, t));
	        return this;
	    }

        public FluentMethodBody Mul()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Mul));
	        return this;
	    }

        public FluentMethodBody MulOvf()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Mul_Ovf));
	        return this;
	    }

        public FluentMethodBody MulOvfUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Mul_Ovf_Un));
	        return this;
	    }

        public FluentMethodBody Neg()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Neg));
	        return this;
	    }

		public FluentMethodBody Newarr(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Newarr, t));
	        return this;
	    }

		public FluentMethodBody Newobj(MethodReference m)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Newobj, m));
	        return this;
	    }

        public FluentMethodBody Nop()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Nop));
	        return this;
	    }

        public FluentMethodBody Not()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Not));
	        return this;
	    }

        public FluentMethodBody Or()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Or));
	        return this;
	    }

        public FluentMethodBody Pop()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Pop));
	        return this;
	    }

        public FluentMethodBody Refanytype()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Refanytype));
	        return this;
	    }

		public FluentMethodBody Refanyval(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Refanyval, t));
	        return this;
	    }

        public FluentMethodBody Rem()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Rem));
	        return this;
	    }

        public FluentMethodBody RemUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Rem_Un));
	        return this;
	    }

        public FluentMethodBody Ret()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Ret));
	        return this;
	    }

        public FluentMethodBody Rethrow()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Rethrow));
	        return this;
	    }

        public FluentMethodBody Shl()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Shl));
	        return this;
	    }

        public FluentMethodBody Shr()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Shr));
	        return this;
	    }

        public FluentMethodBody ShrUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Shr_Un));
	        return this;
	    }

		public FluentMethodBody Sizeof(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Sizeof, t));
	        return this;
	    }

		public FluentMethodBody Starg(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Starg, i));
	        return this;
	    }

		public FluentMethodBody StargS(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Starg_S, b));
	        return this;
	    }

		public FluentMethodBody StelemAny(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_Any, t));
	        return this;
	    }

        public FluentMethodBody StelemI()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_I));
	        return this;
	    }

        public FluentMethodBody StelemI1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_I1));
	        return this;
	    }

        public FluentMethodBody StelemI2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_I2));
	        return this;
	    }

        public FluentMethodBody StelemI4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_I4));
	        return this;
	    }

        public FluentMethodBody StelemI8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_I8));
	        return this;
	    }

        public FluentMethodBody StelemR4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_R4));
	        return this;
	    }

        public FluentMethodBody StelemR8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_R8));
	        return this;
	    }

        public FluentMethodBody StelemRef()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stelem_Ref));
	        return this;
	    }

		public FluentMethodBody Stfld(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stfld, f));
	        return this;
	    }

        public FluentMethodBody StindI()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_I));
	        return this;
	    }

        public FluentMethodBody StindI1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_I1));
	        return this;
	    }

        public FluentMethodBody StindI2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_I2));
	        return this;
	    }

        public FluentMethodBody StindI4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_I4));
	        return this;
	    }

        public FluentMethodBody StindI8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_I8));
	        return this;
	    }

        public FluentMethodBody StindR4()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_R4));
	        return this;
	    }

        public FluentMethodBody StindR8()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_R8));
	        return this;
	    }

        public FluentMethodBody StindRef()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stind_Ref));
	        return this;
	    }

		public FluentMethodBody Stloc(int i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc, i));
	        return this;
	    }

		public FluentMethodBody Stloc(Instruction i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc, i));
	        return this;
	    }

        public FluentMethodBody Stloc0()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc_0));
	        return this;
	    }

        public FluentMethodBody Stloc1()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc_1));
	        return this;
	    }

        public FluentMethodBody Stloc2()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc_2));
	        return this;
	    }

        public FluentMethodBody Stloc3()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc_3));
	        return this;
	    }

		public FluentMethodBody StlocS(byte b)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stloc_S, b));
	        return this;
	    }

		public FluentMethodBody Stobj(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stobj, t));
	        return this;
	    }

		public FluentMethodBody Stsfld(FieldReference f)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Stsfld, f));
	        return this;
	    }

        public FluentMethodBody Sub()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Sub));
	        return this;
	    }

        public FluentMethodBody SubOvf()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Sub_Ovf));
	        return this;
	    }

        public FluentMethodBody SubOvfUn()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Sub_Ovf_Un));
	        return this;
	    }

		public FluentMethodBody Switch(Instruction[] i)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Switch, i));
	        return this;
	    }

        public FluentMethodBody Throw()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Throw));
	        return this;
	    }

		public FluentMethodBody Unbox(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Unbox, t));
	        return this;
	    }

		public FluentMethodBody UnboxAny(TypeReference t)
	    {
			addInstruction(ilProcessor.Create(OpCodes.Unbox_Any, t));
	        return this;
	    }

        public FluentMethodBody Xor()
	    {
			addInstruction(ilProcessor.Create(OpCodes.Xor));
	        return this;
	    }

	}
}