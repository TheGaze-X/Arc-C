using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006AA2 RID: 27298
	[Token(Token = "0x2006AA2")]
	public class StageMixStoryStorySetTitleIconView : StageMixStoryStorySetCommonIconView
	{
		// Token: 0x060270CB RID: 159947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270CB")]
		[Address(RVA = "0x2245600", Offset = "0x2244200", VA = "0x182245600", Slot = "4")]
		protected override string _GetIconId(StageStorylineStorySetViewModel storySet)
		{
			return null;
		}

		// Token: 0x060270CC RID: 159948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60270CC")]
		[Address(RVA = "0x2245680", Offset = "0x2244280", VA = "0x182245680", Slot = "5")]
		protected override string _LoadSpritePath(ILoadAsset assets, string iconId)
		{
			return null;
		}

		// Token: 0x060270CD RID: 159949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60270CD")]
		[Address(RVA = "0x2245720", Offset = "0x2244320", VA = "0x182245720")]
		public StageMixStoryStorySetTitleIconView()
		{
		}

		// Token: 0x04037432 RID: 226354
		[Token(Token = "0x4037432")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetIconId;

		// Token: 0x04037433 RID: 226355
		[Token(Token = "0x4037433")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadSpritePath;

		// Token: 0x04037434 RID: 226356
		[Token(Token = "0x4037434")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
