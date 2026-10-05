using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004903 RID: 18691
	[Token(Token = "0x2004903")]
	public class ActivityReviewDetailItemHolder : IHotfixable
	{
		// Token: 0x0601C316 RID: 115478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C316")]
		[Address(RVA = "0x15AAF60", Offset = "0x15A9B60", VA = "0x1815AAF60")]
		public ActivityReviewDetailItemHolder()
		{
		}

		// Token: 0x04024D99 RID: 150937
		[Token(Token = "0x4024D99")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewActivityDetailItemView itemView;

		// Token: 0x04024D9A RID: 150938
		[Token(Token = "0x4024D9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
