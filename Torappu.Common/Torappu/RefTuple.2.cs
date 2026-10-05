using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	public class RefTuple<T> : RefTuple
	{
		// Token: 0x060004EB RID: 1259 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004EB")]
		public RefTuple(T pItem)
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004EC")]
		public RefTuple()
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004ED")]
		public override void Reset()
		{
		}

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[FieldOffset(Offset = "0x0")]
		public T item;
	}
}
