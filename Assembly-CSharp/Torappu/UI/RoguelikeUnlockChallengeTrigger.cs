using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B12 RID: 15122
	[Token(Token = "0x2003B12")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeUnlockChallengeTrigger
	{
		// Token: 0x06017D00 RID: 97536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D00")]
		[Address(RVA = "0x100DCF0", Offset = "0x100C8F0", VA = "0x18100DCF0")]
		private static void _HandleSingleMessage(RoguelikeUnlockChallengePushMsg msg)
		{
		}

		// Token: 0x06017D01 RID: 97537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D01")]
		[Address(RVA = "0x100DC40", Offset = "0x100C840", VA = "0x18100DC40")]
		private static void _HandleMessage(List<RoguelikeUnlockChallengePushMsg> msgList)
		{
		}

		// Token: 0x06017D02 RID: 97538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D02")]
		[Address(RVA = "0x100DB60", Offset = "0x100C760", VA = "0x18100DB60")]
		public static void HandleMessage(List<RoguelikeUnlockChallengePushMsg> msgList)
		{
		}

		// Token: 0x0401CC35 RID: 117813
		[Token(Token = "0x401CC35")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC36 RID: 117814
		[Token(Token = "0x401CC36")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC37 RID: 117815
		[Token(Token = "0x401CC37")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
