using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002725 RID: 10021
	[Token(Token = "0x2002725")]
	public class ChessGoods
	{
		// Token: 0x0601047F RID: 66687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601047F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChessGoods()
		{
		}

		// Token: 0x04012330 RID: 74544
		[Token(Token = "0x4012330")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x04012331 RID: 74545
		[Token(Token = "0x4012331")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x04012332 RID: 74546
		[Token(Token = "0x4012332")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x04012333 RID: 74547
		[Token(Token = "0x4012333")]
		[FieldOffset(Offset = "0x20")]
		public bool isFrozen;
	}
}
