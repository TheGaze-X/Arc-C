using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B0E RID: 15118
	[Token(Token = "0x2003B0E")]
	public class RoguelikeGotCharCandleBuffToastHandler : RoguelikeGotCharBuffToastHandlerBase
	{
		// Token: 0x06017CF7 RID: 97527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CF7")]
		[Address(RVA = "0x100BF10", Offset = "0x100AB10", VA = "0x18100BF10", Slot = "4")]
		public override void ShowBuffToast(string topicId, RoguelikeTopicDetail topicData, List<string> charNames, string buffId)
		{
		}

		// Token: 0x06017CF8 RID: 97528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CF8")]
		[Address(RVA = "0x100BD20", Offset = "0x100A920", VA = "0x18100BD20", Slot = "5")]
		protected override string BuildCharBuffString(List<string> charNames)
		{
			return null;
		}

		// Token: 0x06017CF9 RID: 97529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CF9")]
		[Address(RVA = "0x100C110", Offset = "0x100AD10", VA = "0x18100C110")]
		public RoguelikeGotCharCandleBuffToastHandler()
		{
		}

		// Token: 0x06017CFA RID: 97530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CFA")]
		[Address(RVA = "0x100C100", Offset = "0x100AD00", VA = "0x18100C100")]
		private string <>xLuaBaseProxy_BuildCharBuffString(List<string> P0)
		{
			return null;
		}

		// Token: 0x0401CC2A RID: 117802
		[Token(Token = "0x401CC2A")]
		private const int MULTI_CHAR_COUNT = 2;

		// Token: 0x0401CC2B RID: 117803
		[Token(Token = "0x401CC2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowBuffToast;

		// Token: 0x0401CC2C RID: 117804
		[Token(Token = "0x401CC2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BuildCharBuffString;

		// Token: 0x0401CC2D RID: 117805
		[Token(Token = "0x401CC2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
