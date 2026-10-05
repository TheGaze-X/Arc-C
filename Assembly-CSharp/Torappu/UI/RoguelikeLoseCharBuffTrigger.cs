using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B08 RID: 15112
	[Token(Token = "0x2003B08")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeLoseCharBuffTrigger
	{
		// Token: 0x06017CE4 RID: 97508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CE4")]
		[Address(RVA = "0x100CCD0", Offset = "0x100B8D0", VA = "0x18100CCD0")]
		private static string _BuildCharBuffString(List<string> charList)
		{
			return null;
		}

		// Token: 0x06017CE5 RID: 97509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE5")]
		[Address(RVA = "0x100CF10", Offset = "0x100BB10", VA = "0x18100CF10")]
		private static void _HandleSingleMessage(RoguelikeLoseCharBuffPushMsg msg)
		{
		}

		// Token: 0x06017CE6 RID: 97510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE6")]
		[Address(RVA = "0x100CE60", Offset = "0x100BA60", VA = "0x18100CE60")]
		private static void _HandleMessage(List<RoguelikeLoseCharBuffPushMsg> msgList)
		{
		}

		// Token: 0x06017CE7 RID: 97511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE7")]
		[Address(RVA = "0x100CBF0", Offset = "0x100B7F0", VA = "0x18100CBF0")]
		public static void HandleMessage(List<RoguelikeLoseCharBuffPushMsg> msgList)
		{
		}

		// Token: 0x0401CC18 RID: 117784
		[Token(Token = "0x401CC18")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__BuildCharBuffString;

		// Token: 0x0401CC19 RID: 117785
		[Token(Token = "0x401CC19")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC1A RID: 117786
		[Token(Token = "0x401CC1A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC1B RID: 117787
		[Token(Token = "0x401CC1B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
