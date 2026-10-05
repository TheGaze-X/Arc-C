using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020000CF RID: 207
	[Token(Token = "0x20000CF")]
	public class RefTuple<T1, T2, T3> : RefTuple
	{
		// Token: 0x060004F1 RID: 1265 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004F1")]
		public RefTuple(T1 pItem1, T2 pItem2, T3 pItem3)
		{
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004F2")]
		public RefTuple()
		{
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60004F3")]
		public override void Reset()
		{
		}

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[FieldOffset(Offset = "0x0")]
		public T1 item1;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[FieldOffset(Offset = "0x0")]
		public T2 item2;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[FieldOffset(Offset = "0x0")]
		public T3 item3;
	}
}
