using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B06 RID: 15110
	[Token(Token = "0x2003B06")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeGotSquadBuffTrigger
	{
		// Token: 0x06017CDF RID: 97503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CDF")]
		[Address(RVA = "0x100C4F0", Offset = "0x100B0F0", VA = "0x18100C4F0")]
		private static string _BuildSquadBuffString(List<RoguelikeSquadBuffModel> squadBuffList)
		{
			return null;
		}

		// Token: 0x06017CE0 RID: 97504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE0")]
		[Address(RVA = "0x100C750", Offset = "0x100B350", VA = "0x18100C750")]
		private static void _HandleSingleMessage(RoguelikeGotSquadBuffPushMsg msg)
		{
		}

		// Token: 0x06017CE1 RID: 97505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE1")]
		[Address(RVA = "0x100C6A0", Offset = "0x100B2A0", VA = "0x18100C6A0")]
		private static void _HandleMessage(List<RoguelikeGotSquadBuffPushMsg> msgList)
		{
		}

		// Token: 0x06017CE2 RID: 97506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE2")]
		[Address(RVA = "0x100C410", Offset = "0x100B010", VA = "0x18100C410")]
		public static void HandleMessage(List<RoguelikeGotSquadBuffPushMsg> msgList)
		{
		}

		// Token: 0x0401CC13 RID: 117779
		[Token(Token = "0x401CC13")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__BuildSquadBuffString;

		// Token: 0x0401CC14 RID: 117780
		[Token(Token = "0x401CC14")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC15 RID: 117781
		[Token(Token = "0x401CC15")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC16 RID: 117782
		[Token(Token = "0x401CC16")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
