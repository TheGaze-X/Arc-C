using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A67 RID: 27239
	[Token(Token = "0x2006A67")]
	public class StageMixStoryOverallGroupItemLastVisitedPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BC7 RID: 23495
		// (get) Token: 0x06026ED5 RID: 159445 RVA: 0x000CCC48 File Offset: 0x000CAE48
		[Token(Token = "0x17005BC7")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026ED5")]
			[Address(RVA = "0x2222FC0", Offset = "0x2221BC0", VA = "0x182222FC0", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026ED6 RID: 159446 RVA: 0x000CCC60 File Offset: 0x000CAE60
		[Token(Token = "0x6026ED6")]
		[Address(RVA = "0x2222E30", Offset = "0x2221A30", VA = "0x182222E30", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026ED7 RID: 159447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ED7")]
		[Address(RVA = "0x2222EC0", Offset = "0x2221AC0", VA = "0x182222EC0", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026ED8 RID: 159448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ED8")]
		[Address(RVA = "0x2222F20", Offset = "0x2221B20", VA = "0x182222F20")]
		public StageMixStoryOverallGroupItemLastVisitedPlugin()
		{
		}

		// Token: 0x04037109 RID: 225545
		[Token(Token = "0x4037109")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x0403710A RID: 225546
		[Token(Token = "0x403710A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403710B RID: 225547
		[Token(Token = "0x403710B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403710C RID: 225548
		[Token(Token = "0x403710C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
