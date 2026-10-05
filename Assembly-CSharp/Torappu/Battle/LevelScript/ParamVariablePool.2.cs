using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002888 RID: 10376
	[Token(Token = "0x2002888")]
	public class ParamVariablePool<T> : SingletonWithMonoHost<ParamVariablePool<T>, BattleController>, IParamVariablePool, IDisposable
	{
		// Token: 0x0601148D RID: 70797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601148D")]
		private ParamVariablePool()
		{
		}

		// Token: 0x0601148E RID: 70798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601148E")]
		public static ParamVariable<T> Allocate(bool fromPool = true)
		{
			return null;
		}

		// Token: 0x0601148F RID: 70799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601148F")]
		public static void Recycle(ParamVariable<T> variable)
		{
		}

		// Token: 0x06011490 RID: 70800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011490")]
		public static void Recycle(ParamVariable variable)
		{
		}

		// Token: 0x06011491 RID: 70801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011491")]
		public ParamVariable AllocateFromMainPool()
		{
			return null;
		}

		// Token: 0x06011492 RID: 70802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011492")]
		public void RecycleFromMainPool(ParamVariable variable)
		{
		}

		// Token: 0x06011493 RID: 70803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011493")]
		public void Dispose()
		{
		}

		// Token: 0x040134E0 RID: 79072
		[Token(Token = "0x40134E0")]
		[FieldOffset(Offset = "0x0")]
		private Stack<ParamVariable<T>> m_pool;

		// Token: 0x040134E1 RID: 79073
		[Token(Token = "0x40134E1")]
		[FieldOffset(Offset = "0x0")]
		private ParamRealType m_realType;

		// Token: 0x040134E2 RID: 79074
		[Token(Token = "0x40134E2")]
		[FieldOffset(Offset = "0x0")]
		private ParamValueType m_valueType;

		// Token: 0x040134E3 RID: 79075
		[Token(Token = "0x40134E3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040134E4 RID: 79076
		[Token(Token = "0x40134E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Allocate;

		// Token: 0x040134E5 RID: 79077
		[Token(Token = "0x40134E5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x040134E6 RID: 79078
		[Token(Token = "0x40134E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Recycle;

		// Token: 0x040134E7 RID: 79079
		[Token(Token = "0x40134E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AllocateFromMainPool;

		// Token: 0x040134E8 RID: 79080
		[Token(Token = "0x40134E8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RecycleFromMainPool;

		// Token: 0x040134E9 RID: 79081
		[Token(Token = "0x40134E9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
