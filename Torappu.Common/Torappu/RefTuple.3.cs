using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	public class RefTuple<T1, T2> : RefTuple
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004EE")]
		public RefTuple(T1 pItem1, T2 pItem2)
		{
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004EF")]
		public RefTuple()
		{
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004F0")]
		public override void Reset()
		{
		}

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[FieldOffset(Offset = "0x0")]
		public T1 item1;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[FieldOffset(Offset = "0x0")]
		public T2 item2;
	}
}
