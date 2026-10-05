using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B0D RID: 15117
	[Token(Token = "0x2003B0D")]
	public class RoguelikeGotCharCommonBuffToastHandler : RoguelikeGotCharBuffToastHandlerBase
	{
		// Token: 0x06017CF5 RID: 97525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CF5")]
		[Address(RVA = "0x100C1B0", Offset = "0x100ADB0", VA = "0x18100C1B0", Slot = "4")]
		public override void ShowBuffToast(string topicId, RoguelikeTopicDetail topicData, List<string> charNames, string buffId)
		{
		}

		// Token: 0x06017CF6 RID: 97526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CF6")]
		[Address(RVA = "0x100C370", Offset = "0x100AF70", VA = "0x18100C370")]
		public RoguelikeGotCharCommonBuffToastHandler()
		{
		}

		// Token: 0x0401CC28 RID: 117800
		[Token(Token = "0x401CC28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowBuffToast;

		// Token: 0x0401CC29 RID: 117801
		[Token(Token = "0x401CC29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
