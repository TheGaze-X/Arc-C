using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004570 RID: 17776
	[Token(Token = "0x2004570")]
	public class RoguelikeTopicBPTopViewModel : IHotfixable
	{
		// Token: 0x0601B13B RID: 110907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B13B")]
		[Address(RVA = "0x1431EE0", Offset = "0x1430AE0", VA = "0x181431EE0")]
		public RoguelikeTopicBPTopViewModel()
		{
		}

		// Token: 0x04022CF6 RID: 142582
		[Token(Token = "0x4022CF6")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04022CF7 RID: 142583
		[Token(Token = "0x4022CF7")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicBattlePassStyle style;

		// Token: 0x04022CF8 RID: 142584
		[Token(Token = "0x4022CF8")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicBP curBpData;

		// Token: 0x04022CF9 RID: 142585
		[Token(Token = "0x4022CF9")]
		[FieldOffset(Offset = "0x28")]
		public int bpLimitPoint;

		// Token: 0x04022CFA RID: 142586
		[Token(Token = "0x4022CFA")]
		[FieldOffset(Offset = "0x2C")]
		public int curBpPoint;

		// Token: 0x04022CFB RID: 142587
		[Token(Token = "0x4022CFB")]
		[FieldOffset(Offset = "0x30")]
		public long nextUpdateTime;

		// Token: 0x04022CFC RID: 142588
		[Token(Token = "0x4022CFC")]
		[FieldOffset(Offset = "0x38")]
		public bool bpPurchaseAvailable;

		// Token: 0x04022CFD RID: 142589
		[Token(Token = "0x4022CFD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
