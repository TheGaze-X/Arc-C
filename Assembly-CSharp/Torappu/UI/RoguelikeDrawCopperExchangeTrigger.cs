using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B2D RID: 15149
	[Token(Token = "0x2003B2D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeDrawCopperExchangeTrigger
	{
		// Token: 0x06017D2B RID: 97579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D2B")]
		[Address(RVA = "0x1014770", Offset = "0x1013370", VA = "0x181014770")]
		private static void _HandleMessage(List<RoguelikeDrawCopperExchangePushMsg> msgList)
		{
		}

		// Token: 0x06017D2C RID: 97580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D2C")]
		[Address(RVA = "0x1014690", Offset = "0x1013290", VA = "0x181014690")]
		public static void HandleMessage(List<RoguelikeDrawCopperExchangePushMsg> msgList)
		{
		}

		// Token: 0x0401CC65 RID: 117861
		[Token(Token = "0x401CC65")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC66 RID: 117862
		[Token(Token = "0x401CC66")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
