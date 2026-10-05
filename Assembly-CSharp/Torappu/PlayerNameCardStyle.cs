using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C03 RID: 3075
	[Token(Token = "0x2000C03")]
	public class PlayerNameCardStyle
	{
		// Token: 0x06006897 RID: 26775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006897")]
		[Address(RVA = "0x1EFBD00", Offset = "0x1EFA900", VA = "0x181EFBD00")]
		public PlayerNameCardStyle()
		{
		}

		// Token: 0x04003EC3 RID: 16067
		[Token(Token = "0x4003EC3")]
		[FieldOffset(Offset = "0x10")]
		public List<string> componentOrder;

		// Token: 0x04003EC4 RID: 16068
		[Token(Token = "0x4003EC4")]
		[FieldOffset(Offset = "0x18")]
		public PlayerNameCardSkin skin;

		// Token: 0x04003EC5 RID: 16069
		[Token(Token = "0x4003EC5")]
		[FieldOffset(Offset = "0x20")]
		public PlayerNameCardMisc misc;
	}
}
