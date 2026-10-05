using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008D9 RID: 2265
	[Token(Token = "0x20008D9")]
	public class EvolveCharUseItemRequest
	{
		// Token: 0x0600658E RID: 25998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600658E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EvolveCharUseItemRequest()
		{
		}

		// Token: 0x040032E8 RID: 13032
		[Token(Token = "0x40032E8")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x040032E9 RID: 13033
		[Token(Token = "0x40032E9")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x040032EA RID: 13034
		[Token(Token = "0x40032EA")]
		[FieldOffset(Offset = "0x20")]
		public int instId;
	}
}
