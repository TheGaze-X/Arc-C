using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045E3 RID: 17891
	[Token(Token = "0x20045E3")]
	public class Rl03OuterBuffSummaryMergedItemModel : IHotfixable
	{
		// Token: 0x170040CA RID: 16586
		// (get) Token: 0x0601B33D RID: 111421 RVA: 0x000A49B8 File Offset: 0x000A2BB8
		[Token(Token = "0x170040CA")]
		public bool isLocked
		{
			[Token(Token = "0x601B33D")]
			[Address(RVA = "0x14695D0", Offset = "0x14681D0", VA = "0x1814695D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601B33E RID: 111422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B33E")]
		[Address(RVA = "0x14694E0", Offset = "0x14680E0", VA = "0x1814694E0")]
		public string GetId()
		{
			return null;
		}

		// Token: 0x0601B33F RID: 111423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B33F")]
		[Address(RVA = "0x1469570", Offset = "0x1468170", VA = "0x181469570")]
		public Rl03OuterBuffSummaryMergedItemModel()
		{
		}

		// Token: 0x04023103 RID: 143619
		[Token(Token = "0x4023103")]
		[FieldOffset(Offset = "0x10")]
		public int viewIndex;

		// Token: 0x04023104 RID: 143620
		[Token(Token = "0x4023104")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDisplayItem displayItem;

		// Token: 0x04023105 RID: 143621
		[Token(Token = "0x4023105")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04023106 RID: 143622
		[Token(Token = "0x4023106")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetId;

		// Token: 0x04023107 RID: 143623
		[Token(Token = "0x4023107")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
