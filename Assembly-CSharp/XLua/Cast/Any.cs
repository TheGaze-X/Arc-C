using System;
using Il2CppDummyDll;

namespace XLua.Cast
{
	// Token: 0x020002FD RID: 765
	[Token(Token = "0x20002FD")]
	public class Any<T> : RawObject
	{
		// Token: 0x06003812 RID: 14354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003812")]
		public Any(T i)
		{
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700015D")]
		public object Target
		{
			[Token(Token = "0x6003813")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000DD7 RID: 3543
		[Token(Token = "0x4000DD7")]
		[FieldOffset(Offset = "0x0")]
		private T mTarget;
	}
}
