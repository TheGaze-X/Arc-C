using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000298 RID: 664
	[Token(Token = "0x2000298")]
	internal class LinkedPool<T> where T : LinkedPoolItem<T>
	{
		// Token: 0x06001243 RID: 4675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001243")]
		public LinkedPool(Func<T> createFunc, Action<T> resetAction, int limit = 10000)
		{
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x00009CC0 File Offset: 0x00007EC0
		// (set) Token: 0x06001245 RID: 4677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700049A")]
		public int Count
		{
			[Token(Token = "0x6001244")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001245")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001246")]
		public void Clear()
		{
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001247")]
		public T Get()
		{
			return null;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		public void Return(T item)
		{
		}

		// Token: 0x04000991 RID: 2449
		[Token(Token = "0x4000991")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<T> m_CreateFunc;

		// Token: 0x04000992 RID: 2450
		[Token(Token = "0x4000992")]
		[FieldOffset(Offset = "0x0")]
		private readonly Action<T> m_ResetAction;

		// Token: 0x04000993 RID: 2451
		[Token(Token = "0x4000993")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_Limit;

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		[FieldOffset(Offset = "0x0")]
		private T m_PoolFirst;
	}
}
