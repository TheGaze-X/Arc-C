using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B21 RID: 15137
	[Token(Token = "0x2003B21")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeEvilTempleLostTrigger
	{
		// Token: 0x06017D19 RID: 97561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D19")]
		[Address(RVA = "0x1014D50", Offset = "0x1013950", VA = "0x181014D50")]
		private static void _HandleMessage(List<RoguelikeEvilTempleLostHpPushMsg> msgList)
		{
		}

		// Token: 0x06017D1A RID: 97562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D1A")]
		[Address(RVA = "0x1014C70", Offset = "0x1013870", VA = "0x181014C70")]
		public static void HandleMessage(List<RoguelikeEvilTempleLostHpPushMsg> msgList)
		{
		}

		// Token: 0x0401CC53 RID: 117843
		[Token(Token = "0x401CC53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC54 RID: 117844
		[Token(Token = "0x401CC54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
