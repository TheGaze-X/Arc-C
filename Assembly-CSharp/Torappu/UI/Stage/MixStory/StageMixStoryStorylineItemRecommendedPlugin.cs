using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A70 RID: 27248
	[Token(Token = "0x2006A70")]
	public class StageMixStoryStorylineItemRecommendedPlugin : StageMixStoryStorylineItemPlugin
	{
		// Token: 0x06026EF6 RID: 159478 RVA: 0x000CCD68 File Offset: 0x000CAF68
		[Token(Token = "0x6026EF6")]
		[Address(RVA = "0x2224750", Offset = "0x2223350", VA = "0x182224750", Slot = "6")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EF7 RID: 159479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EF7")]
		[Address(RVA = "0x22247F0", Offset = "0x22233F0", VA = "0x1822247F0", Slot = "7")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EF8 RID: 159480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EF8")]
		[Address(RVA = "0x2224850", Offset = "0x2223450", VA = "0x182224850")]
		public StageMixStoryStorylineItemRecommendedPlugin()
		{
		}

		// Token: 0x04037130 RID: 225584
		[Token(Token = "0x4037130")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037131 RID: 225585
		[Token(Token = "0x4037131")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037132 RID: 225586
		[Token(Token = "0x4037132")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
