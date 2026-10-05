using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004572 RID: 17778
	[Token(Token = "0x2004572")]
	public class RoguelikeTopicBPGrandPrizeViewModel : IHotfixable
	{
		// Token: 0x0601B13D RID: 110909 RVA: 0x000A43D0 File Offset: 0x000A25D0
		[Token(Token = "0x601B13D")]
		[Address(RVA = "0x1431820", Offset = "0x1430420", VA = "0x181431820")]
		public bool ChangeSelectPos(int step)
		{
			return default(bool);
		}

		// Token: 0x0601B13E RID: 110910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B13E")]
		[Address(RVA = "0x14318D0", Offset = "0x14304D0", VA = "0x1814318D0")]
		public RoguelikeTopicBPGrandPrizeViewModel()
		{
		}

		// Token: 0x04022CFE RID: 142590
		[Token(Token = "0x4022CFE")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeTopicBPPrizeViewModel> grandPrizeViewModelList;

		// Token: 0x04022CFF RID: 142591
		[Token(Token = "0x4022CFF")]
		[FieldOffset(Offset = "0x18")]
		public int selectPos;

		// Token: 0x04022D00 RID: 142592
		[Token(Token = "0x4022D00")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x04022D01 RID: 142593
		[Token(Token = "0x4022D01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ChangeSelectPos;

		// Token: 0x04022D02 RID: 142594
		[Token(Token = "0x4022D02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
