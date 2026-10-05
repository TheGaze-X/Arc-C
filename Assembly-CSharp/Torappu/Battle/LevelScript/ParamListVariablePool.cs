using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002889 RID: 10377
	[Token(Token = "0x2002889")]
	public class ParamListVariablePool<T> : SingletonWithMonoHost<ParamListVariablePool<T>, BattleController>, IParamVariablePool, IDisposable
	{
		// Token: 0x06011494 RID: 70804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011494")]
		private ParamListVariablePool()
		{
		}

		// Token: 0x06011495 RID: 70805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011495")]
		public static ParamListVariable<T> Allocate(bool fromPool = true)
		{
			return null;
		}

		// Token: 0x06011496 RID: 70806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011496")]
		public static void Recycle(ParamListVariable<T> variable)
		{
		}

		// Token: 0x06011497 RID: 70807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011497")]
		public static void Recycle(ParamVariable variable)
		{
		}

		// Token: 0x06011498 RID: 70808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011498")]
		public ParamVariable AllocateFromMainPool()
		{
			return null;
		}

		// Token: 0x06011499 RID: 70809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011499")]
		public void RecycleFromMainPool(ParamVariable variable)
		{
		}

		// Token: 0x0601149A RID: 70810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601149A")]
		public void Dispose()
		{
		}

		// Token: 0x040134EA RID: 79082
		[Token(Token = "0x40134EA")]
		[FieldOffset(Offset = "0x0")]
		private Stack<ParamListVariable<T>> m_pool;

		// Token: 0x040134EB RID: 79083
		[Token(Token = "0x40134EB")]
		[FieldOffset(Offset = "0x0")]
		private ParamRealType m_realType;

		// Token: 0x040134EC RID: 79084
		[Token(Token = "0x40134EC")]
		[FieldOffset(Offset = "0x0")]
		private ParamValueType m_valueType;

		// Token: 0x040134ED RID: 79085
		[Token(Token = "0x40134ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040134EE RID: 79086
		[Token(Token = "0x40134EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Allocate;

		// Token: 0x040134EF RID: 79087
		[Token(Token = "0x40134EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Recycle;

		// Token: 0x040134F0 RID: 79088
		[Token(Token = "0x40134F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_Recycle;

		// Token: 0x040134F1 RID: 79089
		[Token(Token = "0x40134F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AllocateFromMainPool;

		// Token: 0x040134F2 RID: 79090
		[Token(Token = "0x40134F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RecycleFromMainPool;

		// Token: 0x040134F3 RID: 79091
		[Token(Token = "0x40134F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Dispose;
	}
}
