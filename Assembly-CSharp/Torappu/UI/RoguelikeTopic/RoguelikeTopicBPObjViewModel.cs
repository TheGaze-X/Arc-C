using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200456F RID: 17775
	[Token(Token = "0x200456F")]
	public class RoguelikeTopicBPObjViewModel : IHotfixable
	{
		// Token: 0x0601B13A RID: 110906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B13A")]
		[Address(RVA = "0x14319E0", Offset = "0x14305E0", VA = "0x1814319E0")]
		public RoguelikeTopicBPObjViewModel()
		{
		}

		// Token: 0x04022CE9 RID: 142569
		[Token(Token = "0x4022CE9")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x04022CEA RID: 142570
		[Token(Token = "0x4022CEA")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicBP roguelikeTopicBp;

		// Token: 0x04022CEB RID: 142571
		[Token(Token = "0x4022CEB")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicBattlePassStyle style;

		// Token: 0x04022CEC RID: 142572
		[Token(Token = "0x4022CEC")]
		[FieldOffset(Offset = "0x28")]
		public bool isGot;

		// Token: 0x04022CED RID: 142573
		[Token(Token = "0x4022CED")]
		[FieldOffset(Offset = "0x29")]
		public bool isValid;

		// Token: 0x04022CEE RID: 142574
		[Token(Token = "0x4022CEE")]
		[FieldOffset(Offset = "0x2A")]
		public bool isLastValid;

		// Token: 0x04022CEF RID: 142575
		[Token(Token = "0x4022CEF")]
		[FieldOffset(Offset = "0x2B")]
		public bool withinLimit;

		// Token: 0x04022CF0 RID: 142576
		[Token(Token = "0x4022CF0")]
		[FieldOffset(Offset = "0x2C")]
		public bool isFirstItem;

		// Token: 0x04022CF1 RID: 142577
		[Token(Token = "0x4022CF1")]
		[FieldOffset(Offset = "0x2D")]
		public bool isLastItem;

		// Token: 0x04022CF2 RID: 142578
		[Token(Token = "0x4022CF2")]
		[FieldOffset(Offset = "0x2E")]
		public bool isLastWithinLimit;

		// Token: 0x04022CF3 RID: 142579
		[Token(Token = "0x4022CF3")]
		[FieldOffset(Offset = "0x2F")]
		public bool isFutureNode;

		// Token: 0x04022CF4 RID: 142580
		[Token(Token = "0x4022CF4")]
		[FieldOffset(Offset = "0x30")]
		public bool isEndNode;

		// Token: 0x04022CF5 RID: 142581
		[Token(Token = "0x4022CF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
