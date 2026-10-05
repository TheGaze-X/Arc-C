using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A6C RID: 27244
	[Token(Token = "0x2006A6C")]
	public class StageMixStoryOverallGroupItemTrackPointPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BCC RID: 23500
		// (get) Token: 0x06026EE9 RID: 159465 RVA: 0x000CCD08 File Offset: 0x000CAF08
		[Token(Token = "0x17005BCC")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026EE9")]
			[Address(RVA = "0x2223B10", Offset = "0x2222710", VA = "0x182223B10", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026EEA RID: 159466 RVA: 0x000CCD20 File Offset: 0x000CAF20
		[Token(Token = "0x6026EEA")]
		[Address(RVA = "0x22238B0", Offset = "0x22224B0", VA = "0x1822238B0", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EEB RID: 159467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EEB")]
		[Address(RVA = "0x2223940", Offset = "0x2222540", VA = "0x182223940", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EEC RID: 159468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EEC")]
		[Address(RVA = "0x2223A70", Offset = "0x2222670", VA = "0x182223A70")]
		public StageMixStoryOverallGroupItemTrackPointPlugin()
		{
		}

		// Token: 0x04037121 RID: 225569
		[Token(Token = "0x4037121")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _trackPointHolder;

		// Token: 0x04037122 RID: 225570
		[Token(Token = "0x4037122")]
		[FieldOffset(Offset = "0x20")]
		private GameObject m_trackPointInstance;

		// Token: 0x04037123 RID: 225571
		[Token(Token = "0x4037123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x04037124 RID: 225572
		[Token(Token = "0x4037124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x04037125 RID: 225573
		[Token(Token = "0x4037125")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037126 RID: 225574
		[Token(Token = "0x4037126")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
