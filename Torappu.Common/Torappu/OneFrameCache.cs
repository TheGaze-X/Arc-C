using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public struct OneFrameCache<T> : IHotfixable
	{
		// Token: 0x060001CB RID: 459 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001CB")]
		public OneFrameCache(T cache)
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x60001CC")]
		public bool TryGetCache(out T result)
		{
			return default(bool);
		}

		// Token: 0x04000333 RID: 819
		[Token(Token = "0x4000333")]
		[FieldOffset(Offset = "0x0")]
		private readonly ulong m_frame;

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x0")]
		private readonly T m_cache;
	}
}
