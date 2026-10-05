using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B25 RID: 15141
	[Token(Token = "0x2003B25")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeGotRandCopperTrigger
	{
		// Token: 0x06017D1F RID: 97567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D1F")]
		[Address(RVA = "0x1015C10", Offset = "0x1014810", VA = "0x181015C10")]
		private static void _HandleMessage(List<RoguelikeGotRandCopperPushMsg> msgList)
		{
		}

		// Token: 0x06017D20 RID: 97568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D20")]
		[Address(RVA = "0x1015B30", Offset = "0x1014730", VA = "0x181015B30")]
		public static void HandleMessage(List<RoguelikeGotRandCopperPushMsg> msgList)
		{
		}

		// Token: 0x0401CC58 RID: 117848
		[Token(Token = "0x401CC58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC59 RID: 117849
		[Token(Token = "0x401CC59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
