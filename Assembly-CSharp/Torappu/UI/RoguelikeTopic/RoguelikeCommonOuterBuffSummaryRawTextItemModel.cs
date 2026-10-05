using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004518 RID: 17688
	[Token(Token = "0x2004518")]
	public class RoguelikeCommonOuterBuffSummaryRawTextItemModel : IHotfixable
	{
		// Token: 0x0601AFA1 RID: 110497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AFA1")]
		[Address(RVA = "0x1422860", Offset = "0x1421460", VA = "0x181422860")]
		public RoguelikeCommonOuterBuffSummaryRawTextItemModel()
		{
		}

		// Token: 0x04022A2D RID: 141869
		[Token(Token = "0x4022A2D")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04022A2E RID: 141870
		[Token(Token = "0x4022A2E")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x04022A2F RID: 141871
		[Token(Token = "0x4022A2F")]
		[FieldOffset(Offset = "0x20")]
		public bool isActive;

		// Token: 0x04022A30 RID: 141872
		[Token(Token = "0x4022A30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
