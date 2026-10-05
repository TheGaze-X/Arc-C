using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A6B RID: 27243
	[Token(Token = "0x2006A6B")]
	public class StageMixStoryOverallGroupItemRecommendedPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BCB RID: 23499
		// (get) Token: 0x06026EE5 RID: 159461 RVA: 0x000CCCD8 File Offset: 0x000CAED8
		[Token(Token = "0x17005BCB")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026EE5")]
			[Address(RVA = "0x2223850", Offset = "0x2222450", VA = "0x182223850", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026EE6 RID: 159462 RVA: 0x000CCCF0 File Offset: 0x000CAEF0
		[Token(Token = "0x6026EE6")]
		[Address(RVA = "0x22236B0", Offset = "0x22222B0", VA = "0x1822236B0", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EE7 RID: 159463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EE7")]
		[Address(RVA = "0x2223750", Offset = "0x2222350", VA = "0x182223750", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EE8 RID: 159464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EE8")]
		[Address(RVA = "0x22237B0", Offset = "0x22223B0", VA = "0x1822237B0")]
		public StageMixStoryOverallGroupItemRecommendedPlugin()
		{
		}

		// Token: 0x0403711D RID: 225565
		[Token(Token = "0x403711D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x0403711E RID: 225566
		[Token(Token = "0x403711E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403711F RID: 225567
		[Token(Token = "0x403711F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037120 RID: 225568
		[Token(Token = "0x4037120")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
