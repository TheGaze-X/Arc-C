using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200348F RID: 13455
	[Token(Token = "0x200348F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ArtMagazineGainItemTrigger
	{
		// Token: 0x0601574A RID: 87882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601574A")]
		[Address(RVA = "0xDE6310", Offset = "0xDE4F10", VA = "0x180DE6310")]
		public static void HandleMessage(List<ArtMagazineGainItemPushMsg> msgList)
		{
		}

		// Token: 0x04019AF7 RID: 105207
		[Token(Token = "0x4019AF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
