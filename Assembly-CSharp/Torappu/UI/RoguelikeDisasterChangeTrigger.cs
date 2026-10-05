using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B16 RID: 15126
	[Token(Token = "0x2003B16")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeDisasterChangeTrigger
	{
		// Token: 0x06017D08 RID: 97544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D08")]
		[Address(RVA = "0x1013F90", Offset = "0x1012B90", VA = "0x181013F90")]
		public static void HandleMessage(List<RoguelikeDisasterChangePushMsg> msgList)
		{
		}

		// Token: 0x06017D09 RID: 97545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D09")]
		[Address(RVA = "0x1014070", Offset = "0x1012C70", VA = "0x181014070")]
		private static void _HandleMessage(List<RoguelikeDisasterChangePushMsg> msgList)
		{
		}

		// Token: 0x06017D0A RID: 97546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D0A")]
		[Address(RVA = "0x1014250", Offset = "0x1012E50", VA = "0x181014250")]
		private static void _HandleSingleMessage(RoguelikeDisasterChangePushMsg msg)
		{
		}

		// Token: 0x0401CC3F RID: 117823
		[Token(Token = "0x401CC3F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0401CC40 RID: 117824
		[Token(Token = "0x401CC40")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC41 RID: 117825
		[Token(Token = "0x401CC41")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;
	}
}
