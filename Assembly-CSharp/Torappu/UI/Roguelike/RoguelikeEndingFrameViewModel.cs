using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005374 RID: 21364
	[Token(Token = "0x2005374")]
	public abstract class RoguelikeEndingFrameViewModel : IHotfixable
	{
		// Token: 0x0601F7D2 RID: 128978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7D2")]
		[Address(RVA = "0x1923160", Offset = "0x1921D60", VA = "0x181923160")]
		protected RoguelikeEndingFrameViewModel()
		{
		}

		// Token: 0x0402A5ED RID: 173549
		[Token(Token = "0x402A5ED")]
		[FieldOffset(Offset = "0x10")]
		public string topicId;

		// Token: 0x0402A5EE RID: 173550
		[Token(Token = "0x402A5EE")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDetail topicDetail;

		// Token: 0x0402A5EF RID: 173551
		[Token(Token = "0x402A5EF")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicCustomizeData topicCustomize;

		// Token: 0x0402A5F0 RID: 173552
		[Token(Token = "0x402A5F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
