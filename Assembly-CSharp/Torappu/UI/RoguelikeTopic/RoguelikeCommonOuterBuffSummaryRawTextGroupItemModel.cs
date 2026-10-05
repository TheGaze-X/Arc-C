using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004519 RID: 17689
	[Token(Token = "0x2004519")]
	public class RoguelikeCommonOuterBuffSummaryRawTextGroupItemModel : IHotfixable
	{
		// Token: 0x0601AFA2 RID: 110498 RVA: 0x000A3C68 File Offset: 0x000A1E68
		[Token(Token = "0x601AFA2")]
		[Address(RVA = "0x1422230", Offset = "0x1420E30", VA = "0x181422230")]
		public int GetUnlockNodeCount()
		{
			return 0;
		}

		// Token: 0x0601AFA3 RID: 110499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFA3")]
		[Address(RVA = "0x1422310", Offset = "0x1420F10", VA = "0x181422310")]
		public RoguelikeCommonOuterBuffSummaryRawTextGroupItemModel()
		{
		}

		// Token: 0x04022A31 RID: 141873
		[Token(Token = "0x4022A31")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeCommonOuterBuffSummaryRawTextItemModel> nodeList;

		// Token: 0x04022A32 RID: 141874
		[Token(Token = "0x4022A32")]
		[FieldOffset(Offset = "0x18")]
		public string iconId;

		// Token: 0x04022A33 RID: 141875
		[Token(Token = "0x4022A33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetUnlockNodeCount;

		// Token: 0x04022A34 RID: 141876
		[Token(Token = "0x4022A34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
