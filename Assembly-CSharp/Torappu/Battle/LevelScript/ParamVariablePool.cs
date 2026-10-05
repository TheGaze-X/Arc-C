using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002887 RID: 10375
	[Token(Token = "0x2002887")]
	public class ParamVariablePool : SingletonWithMonoHost<ParamVariablePool, BattleController>, IDisposable
	{
		// Token: 0x06011488 RID: 70792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011488")]
		[Address(RVA = "0x926A20", Offset = "0x925620", VA = "0x180926A20")]
		private ParamVariablePool()
		{
		}

		// Token: 0x06011489 RID: 70793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011489")]
		[Address(RVA = "0x926300", Offset = "0x924F00", VA = "0x180926300")]
		public void AddToMainPool(Type type, IParamVariablePool pool)
		{
		}

		// Token: 0x0601148A RID: 70794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601148A")]
		[Address(RVA = "0x9263B0", Offset = "0x924FB0", VA = "0x1809263B0")]
		public static ParamVariable Allocate(Type type, bool fromPool = true)
		{
			return null;
		}

		// Token: 0x0601148B RID: 70795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601148B")]
		[Address(RVA = "0x9267B0", Offset = "0x9253B0", VA = "0x1809267B0")]
		public static void Recycle(ParamVariable variable)
		{
		}

		// Token: 0x0601148C RID: 70796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601148C")]
		[Address(RVA = "0x926730", Offset = "0x925330", VA = "0x180926730", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x040134DA RID: 79066
		[Token(Token = "0x40134DA")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, IParamVariablePool> m_poolDict;

		// Token: 0x040134DB RID: 79067
		[Token(Token = "0x40134DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040134DC RID: 79068
		[Token(Token = "0x40134DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddToMainPool;

		// Token: 0x040134DD RID: 79069
		[Token(Token = "0x40134DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Allocate;

		// Token: 0x040134DE RID: 79070
		[Token(Token = "0x40134DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x040134DF RID: 79071
		[Token(Token = "0x40134DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
