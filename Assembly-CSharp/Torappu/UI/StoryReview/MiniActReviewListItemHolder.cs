using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C1 RID: 18625
	[Token(Token = "0x20048C1")]
	public class MiniActReviewListItemHolder : IHotfixable
	{
		// Token: 0x0601C18C RID: 115084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C18C")]
		[Address(RVA = "0x1596520", Offset = "0x1595120", VA = "0x181596520")]
		public MiniActReviewListItemHolder()
		{
		}

		// Token: 0x04024B82 RID: 150402
		[Token(Token = "0x4024B82")]
		[FieldOffset(Offset = "0x10")]
		public StoryReviewActivityItemView itemView;

		// Token: 0x04024B83 RID: 150403
		[Token(Token = "0x4024B83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
