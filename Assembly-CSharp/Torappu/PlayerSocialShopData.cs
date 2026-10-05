using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A27 RID: 2599
	[Token(Token = "0x2000A27")]
	public class PlayerSocialShopData
	{
		// Token: 0x060066E6 RID: 26342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066E6")]
		[Address(RVA = "0x1EFEA60", Offset = "0x1EFD660", VA = "0x181EFEA60")]
		public PlayerSocialShopData()
		{
		}

		// Token: 0x040037CD RID: 14285
		[Token(Token = "0x40037CD")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerGoodItemData> info;
	}
}
