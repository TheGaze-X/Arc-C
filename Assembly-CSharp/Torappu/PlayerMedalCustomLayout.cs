using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A43 RID: 2627
	[Token(Token = "0x2000A43")]
	public class PlayerMedalCustomLayout
	{
		// Token: 0x06006702 RID: 26370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006702")]
		[Address(RVA = "0x1EFB280", Offset = "0x1EF9E80", VA = "0x181EFB280")]
		public PlayerMedalCustomLayout()
		{
		}

		// Token: 0x04003827 RID: 14375
		[Token(Token = "0x4003827")]
		[FieldOffset(Offset = "0x10")]
		public List<PlayerMedalCustomLayoutItem> layout;
	}
}
