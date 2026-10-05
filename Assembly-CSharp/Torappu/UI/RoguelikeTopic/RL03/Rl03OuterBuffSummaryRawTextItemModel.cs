using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E4 RID: 17892
	[Token(Token = "0x20045E4")]
	public class Rl03OuterBuffSummaryRawTextItemModel : IHotfixable
	{
		// Token: 0x0601B340 RID: 111424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B340")]
		[Address(RVA = "0x1469D00", Offset = "0x1468900", VA = "0x181469D00")]
		public Rl03OuterBuffSummaryRawTextItemModel()
		{
		}

		// Token: 0x04023108 RID: 143624
		[Token(Token = "0x4023108")]
		[FieldOffset(Offset = "0x10")]
		public string nodeId;

		// Token: 0x04023109 RID: 143625
		[Token(Token = "0x4023109")]
		[FieldOffset(Offset = "0x18")]
		public string desc;

		// Token: 0x0402310A RID: 143626
		[Token(Token = "0x402310A")]
		[FieldOffset(Offset = "0x20")]
		public bool isActive;

		// Token: 0x0402310B RID: 143627
		[Token(Token = "0x402310B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
