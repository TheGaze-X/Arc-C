using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002879 RID: 10361
	[Token(Token = "0x2002879")]
	public class ParamPool : Singleton<ParamPool>
	{
		// Token: 0x060113FE RID: 70654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60113FE")]
		[Address(RVA = "0x9250C0", Offset = "0x923CC0", VA = "0x1809250C0")]
		private ParamPool()
		{
		}

		// Token: 0x060113FF RID: 70655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60113FF")]
		[Address(RVA = "0x9247F0", Offset = "0x9233F0", VA = "0x1809247F0")]
		public static ParamKeyValue AllocateParamKeyValue(string newKey, [Optional] ParamValue value)
		{
			return null;
		}

		// Token: 0x06011400 RID: 70656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011400")]
		[Address(RVA = "0x924B80", Offset = "0x923780", VA = "0x180924B80")]
		public static void RecycleParamKeyValue(ParamKeyValue paramKeyValue)
		{
		}

		// Token: 0x06011401 RID: 70657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011401")]
		[Address(RVA = "0x924A60", Offset = "0x923660", VA = "0x180924A60")]
		public static ParamValue AllocateParamValue(ParamRealType valueType, int valueLength = 0)
		{
			return null;
		}

		// Token: 0x06011402 RID: 70658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011402")]
		[Address(RVA = "0x924E70", Offset = "0x923A70", VA = "0x180924E70")]
		public static void RecycleParamValue(ParamValue paramValue)
		{
		}

		// Token: 0x06011403 RID: 70659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011403")]
		[Address(RVA = "0x924F40", Offset = "0x923B40", VA = "0x180924F40")]
		private Stack<ParamValueAtom[]> _TryGetParamValueAtomStack(ParamRealType valueType, int valueLength)
		{
			return null;
		}

		// Token: 0x06011404 RID: 70660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011404")]
		[Address(RVA = "0x924910", Offset = "0x923510", VA = "0x180924910")]
		public static ParamValueAtom[] AllocateParamValueAtomArray(ParamRealType valueType, int valueLength)
		{
			return null;
		}

		// Token: 0x06011405 RID: 70661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011405")]
		[Address(RVA = "0x924D00", Offset = "0x923900", VA = "0x180924D00")]
		public static void RecycleParamValueAtomArray(ParamValueAtom[] valueArray, ParamRealType valueType)
		{
		}

		// Token: 0x04013496 RID: 78998
		[Token(Token = "0x4013496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stack<ParamValue> m_paramValuePool;

		// Token: 0x04013497 RID: 78999
		[Token(Token = "0x4013497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stack<ParamKeyValue> m_paramKeyValuePool;

		// Token: 0x04013498 RID: 79000
		[Token(Token = "0x4013498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<ParamRealType, Dictionary<int, Stack<ParamValueAtom[]>>> m_paramValueAtomPool;

		// Token: 0x04013499 RID: 79001
		[Token(Token = "0x4013499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401349A RID: 79002
		[Token(Token = "0x401349A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AllocateParamKeyValue;

		// Token: 0x0401349B RID: 79003
		[Token(Token = "0x401349B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RecycleParamKeyValue;

		// Token: 0x0401349C RID: 79004
		[Token(Token = "0x401349C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AllocateParamValue;

		// Token: 0x0401349D RID: 79005
		[Token(Token = "0x401349D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RecycleParamValue;

		// Token: 0x0401349E RID: 79006
		[Token(Token = "0x401349E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryGetParamValueAtomStack;

		// Token: 0x0401349F RID: 79007
		[Token(Token = "0x401349F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AllocateParamValueAtomArray;

		// Token: 0x040134A0 RID: 79008
		[Token(Token = "0x40134A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RecycleParamValueAtomArray;
	}
}
