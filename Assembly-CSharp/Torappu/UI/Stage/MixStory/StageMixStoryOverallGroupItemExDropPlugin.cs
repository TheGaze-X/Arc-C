using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A66 RID: 27238
	[Token(Token = "0x2006A66")]
	public class StageMixStoryOverallGroupItemExDropPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BC6 RID: 23494
		// (get) Token: 0x06026ED1 RID: 159441 RVA: 0x000CCC18 File Offset: 0x000CAE18
		[Token(Token = "0x17005BC6")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026ED1")]
			[Address(RVA = "0x2222DD0", Offset = "0x22219D0", VA = "0x182222DD0", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026ED2 RID: 159442 RVA: 0x000CCC30 File Offset: 0x000CAE30
		[Token(Token = "0x6026ED2")]
		[Address(RVA = "0x2222AF0", Offset = "0x22216F0", VA = "0x182222AF0", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026ED3 RID: 159443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ED3")]
		[Address(RVA = "0x2222B90", Offset = "0x2221790", VA = "0x182222B90", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026ED4 RID: 159444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026ED4")]
		[Address(RVA = "0x2222D30", Offset = "0x2221930", VA = "0x182222D30")]
		public StageMixStoryOverallGroupItemExDropPlugin()
		{
		}

		// Token: 0x04037103 RID: 225539
		[Token(Token = "0x4037103")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _exDropColor;

		// Token: 0x04037104 RID: 225540
		[Token(Token = "0x4037104")]
		[FieldOffset(Offset = "0x20")]
		private string m_cachedExDropGroupId;

		// Token: 0x04037105 RID: 225541
		[Token(Token = "0x4037105")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x04037106 RID: 225542
		[Token(Token = "0x4037106")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037107 RID: 225543
		[Token(Token = "0x4037107")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037108 RID: 225544
		[Token(Token = "0x4037108")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
