using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B0A RID: 15114
	[Token(Token = "0x2003B0A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeGotCharBuffTrigger
	{
		// Token: 0x06017CE9 RID: 97513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CE9")]
		[Address(RVA = "0x100B7B0", Offset = "0x100A3B0", VA = "0x18100B7B0")]
		private static void _HandleSingleMessage(RoguelikeGotCharBuffPushMsg msg)
		{
		}

		// Token: 0x06017CEA RID: 97514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CEA")]
		[Address(RVA = "0x100B4B0", Offset = "0x100A0B0", VA = "0x18100B4B0")]
		private static RoguelikeGotCharBuffToastHandlerBase _CreateHandler(string topicId, string buffId)
		{
			return null;
		}

		// Token: 0x06017CEB RID: 97515 RVA: 0x000985C8 File Offset: 0x000967C8
		[Token(Token = "0x6017CEB")]
		[Address(RVA = "0x100B400", Offset = "0x100A000", VA = "0x18100B400")]
		private static bool _CheckIsCandleBuff(string topicId, string buffId)
		{
			return default(bool);
		}

		// Token: 0x06017CEC RID: 97516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CEC")]
		[Address(RVA = "0x100B700", Offset = "0x100A300", VA = "0x18100B700")]
		private static void _HandleMessage(List<RoguelikeGotCharBuffPushMsg> msgList)
		{
		}

		// Token: 0x06017CED RID: 97517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CED")]
		[Address(RVA = "0x100B320", Offset = "0x1009F20", VA = "0x18100B320")]
		public static void HandleMessage(List<RoguelikeGotCharBuffPushMsg> msgList)
		{
		}

		// Token: 0x0401CC1E RID: 117790
		[Token(Token = "0x401CC1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC1F RID: 117791
		[Token(Token = "0x401CC1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__CreateHandler;

		// Token: 0x0401CC20 RID: 117792
		[Token(Token = "0x401CC20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckIsCandleBuff;

		// Token: 0x0401CC21 RID: 117793
		[Token(Token = "0x401CC21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC22 RID: 117794
		[Token(Token = "0x401CC22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
