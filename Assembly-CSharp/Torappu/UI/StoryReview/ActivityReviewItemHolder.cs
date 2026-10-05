using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004900 RID: 18688
	[Token(Token = "0x2004900")]
	public class ActivityReviewItemHolder : IHotfixable
	{
		// Token: 0x0601C30F RID: 115471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C30F")]
		[Address(RVA = "0x15AB590", Offset = "0x15AA190", VA = "0x1815AB590")]
		public ActivityReviewItemHolder()
		{
		}

		// Token: 0x04024D8D RID: 150925
		[Token(Token = "0x4024D8D")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewActivityItemView itemView;

		// Token: 0x04024D8E RID: 150926
		[Token(Token = "0x4024D8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
