using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200271F RID: 10015
	[Token(Token = "0x200271F")]
	public class ChooseStateSlot
	{
		// Token: 0x06010479 RID: 66681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010479")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChooseStateSlot()
		{
		}

		// Token: 0x0401231F RID: 74527
		[Token(Token = "0x401231F")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04012320 RID: 74528
		[Token(Token = "0x4012320")]
		[FieldOffset(Offset = "0x18")]
		public int slotId;

		// Token: 0x04012321 RID: 74529
		[Token(Token = "0x4012321")]
		[FieldOffset(Offset = "0x1C")]
		public int price;
	}
}
