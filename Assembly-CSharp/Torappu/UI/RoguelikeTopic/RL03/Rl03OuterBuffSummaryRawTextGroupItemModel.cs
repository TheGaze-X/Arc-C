using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E5 RID: 17893
	[Token(Token = "0x20045E5")]
	public class Rl03OuterBuffSummaryRawTextGroupItemModel : IHotfixable
	{
		// Token: 0x0601B341 RID: 111425 RVA: 0x000A49D0 File Offset: 0x000A2BD0
		[Token(Token = "0x601B341")]
		[Address(RVA = "0x14696A0", Offset = "0x14682A0", VA = "0x1814696A0")]
		public int GetUnlockNodeCount()
		{
			return 0;
		}

		// Token: 0x0601B342 RID: 111426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B342")]
		[Address(RVA = "0x1469780", Offset = "0x1468380", VA = "0x181469780")]
		public Rl03OuterBuffSummaryRawTextGroupItemModel()
		{
		}

		// Token: 0x0402310C RID: 143628
		[Token(Token = "0x402310C")]
		[FieldOffset(Offset = "0x10")]
		public List<Rl03OuterBuffSummaryRawTextItemModel> nodeList;

		// Token: 0x0402310D RID: 143629
		[Token(Token = "0x402310D")]
		[FieldOffset(Offset = "0x18")]
		public bool useLevelMark;

		// Token: 0x0402310E RID: 143630
		[Token(Token = "0x402310E")]
		[FieldOffset(Offset = "0x20")]
		public string iconId;

		// Token: 0x0402310F RID: 143631
		[Token(Token = "0x402310F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetUnlockNodeCount;

		// Token: 0x04023110 RID: 143632
		[Token(Token = "0x4023110")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
