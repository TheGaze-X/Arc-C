using System;
using Il2CppDummyDll;

namespace System.Buffers
{
	// Token: 0x0200063A RID: 1594
	[Token(Token = "0x200063A")]
	public abstract class MemoryManager<T>
	{
		// Token: 0x06002FE0 RID: 12256
		[Token(Token = "0x6002FE0")]
		public abstract System.Span<T> GetSpan();

		// Token: 0x06002FE1 RID: 12257
		[Token(Token = "0x6002FE1")]
		public abstract MemoryHandle Pin(int elementIndex = 0);

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00019F08 File Offset: 0x00018108
		[Token(Token = "0x6002FE2")]
		protected internal virtual bool TryGetArray(out System.ArraySegment<T> segment)
		{
			return default(bool);
		}
	}
}
