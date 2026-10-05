using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B04 RID: 15108
	[Token(Token = "0x2003B04")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeRelicGetTrigger
	{
		// Token: 0x06017CDC RID: 97500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CDC")]
		[Address(RVA = "0x100D660", Offset = "0x100C260", VA = "0x18100D660")]
		private static void _HandleMessage(List<RoguelikeRelicPushMsg> msgList)
		{
		}

		// Token: 0x06017CDD RID: 97501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CDD")]
		[Address(RVA = "0x100D580", Offset = "0x100C180", VA = "0x18100D580")]
		public static void HandleMessage(List<RoguelikeRelicPushMsg> msgList)
		{
		}

		// Token: 0x0401CC10 RID: 117776
		[Token(Token = "0x401CC10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC11 RID: 117777
		[Token(Token = "0x401CC11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
