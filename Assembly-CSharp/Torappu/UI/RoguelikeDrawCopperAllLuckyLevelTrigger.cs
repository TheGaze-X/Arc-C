using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B2F RID: 15151
	[Token(Token = "0x2003B2F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeDrawCopperAllLuckyLevelTrigger
	{
		// Token: 0x06017D2E RID: 97582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D2E")]
		[Address(RVA = "0x1014480", Offset = "0x1013080", VA = "0x181014480")]
		private static void _HandleMessage(List<RoguelikeDrawCopperAllLuckyLevelPushMsg> msgList)
		{
		}

		// Token: 0x06017D2F RID: 97583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D2F")]
		[Address(RVA = "0x10143A0", Offset = "0x1012FA0", VA = "0x1810143A0")]
		public static void HandleMessage(List<RoguelikeDrawCopperAllLuckyLevelPushMsg> msgList)
		{
		}

		// Token: 0x0401CC68 RID: 117864
		[Token(Token = "0x401CC68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC69 RID: 117865
		[Token(Token = "0x401CC69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
