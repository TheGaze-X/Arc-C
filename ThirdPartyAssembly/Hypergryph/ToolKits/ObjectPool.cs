using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Hypergryph.ToolKits
{
	// Token: 0x020000FD RID: 253
	[Token(Token = "0x20000FD")]
	internal class ObjectPool
	{
		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x1700008C")]
		public int countInactive
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x544D360", Offset = "0x544BF60", VA = "0x18544D360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x544D210", Offset = "0x544BE10", VA = "0x18544D210")]
		public ObjectPool(Func<object> actionNew, int poolSize = 0, [Optional] Action<object> actionOnGet, [Optional] Action<object> actionOnRelease)
		{
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x544D0B0", Offset = "0x544BCB0", VA = "0x18544D0B0")]
		public object Get()
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x544D150", Offset = "0x544BD50", VA = "0x18544D150")]
		public void Release(object element)
		{
		}

		// Token: 0x040005D0 RID: 1488
		[Token(Token = "0x40005D0")]
		private const int DEFAULT_POOL_SIZE = 20;

		// Token: 0x040005D1 RID: 1489
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Stack<object> m_Stack;

		// Token: 0x040005D2 RID: 1490
		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Func<object> m_ActionNew;

		// Token: 0x040005D3 RID: 1491
		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<object> m_ActionOnGet;

		// Token: 0x040005D4 RID: 1492
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Action<object> m_ActionOnRelease;

		// Token: 0x040005D5 RID: 1493
		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly int m_poolSize;
	}
}
