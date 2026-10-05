using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public class StructWrapper<T> where T : struct
	{
		// Token: 0x0600051B RID: 1307 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600051B")]
		public StructWrapper()
		{
		}

		// Token: 0x040004E6 RID: 1254
		[Token(Token = "0x40004E6")]
		[FieldOffset(Offset = "0x0")]
		public T value;
	}
}
