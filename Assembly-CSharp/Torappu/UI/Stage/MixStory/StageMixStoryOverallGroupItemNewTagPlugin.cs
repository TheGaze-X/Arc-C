using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A68 RID: 27240
	[Token(Token = "0x2006A68")]
	public class StageMixStoryOverallGroupItemNewTagPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BC8 RID: 23496
		// (get) Token: 0x06026ED9 RID: 159449 RVA: 0x000CCC78 File Offset: 0x000CAE78
		[Token(Token = "0x17005BC8")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026ED9")]
			[Address(RVA = "0x22231C0", Offset = "0x2221DC0", VA = "0x1822231C0", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026EDA RID: 159450 RVA: 0x000CCC90 File Offset: 0x000CAE90
		[Token(Token = "0x6026EDA")]
		[Address(RVA = "0x2223020", Offset = "0x2221C20", VA = "0x182223020", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EDB RID: 159451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EDB")]
		[Address(RVA = "0x22230C0", Offset = "0x2221CC0", VA = "0x1822230C0", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EDC RID: 159452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EDC")]
		[Address(RVA = "0x2223120", Offset = "0x2221D20", VA = "0x182223120")]
		public StageMixStoryOverallGroupItemNewTagPlugin()
		{
		}

		// Token: 0x0403710D RID: 225549
		[Token(Token = "0x403710D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x0403710E RID: 225550
		[Token(Token = "0x403710E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403710F RID: 225551
		[Token(Token = "0x403710F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037110 RID: 225552
		[Token(Token = "0x4037110")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
