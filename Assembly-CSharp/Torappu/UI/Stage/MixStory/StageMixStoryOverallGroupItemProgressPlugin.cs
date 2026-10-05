using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A6A RID: 27242
	[Token(Token = "0x2006A6A")]
	public class StageMixStoryOverallGroupItemProgressPlugin : StageMixStoryOverallGroupItemPlugin
	{
		// Token: 0x17005BCA RID: 23498
		// (get) Token: 0x06026EE1 RID: 159457 RVA: 0x000CCCA8 File Offset: 0x000CAEA8
		[Token(Token = "0x17005BCA")]
		public override StageMixStoryOverallView.OverallDisplayFeature presentingFeature
		{
			[Token(Token = "0x6026EE1")]
			[Address(RVA = "0x2223650", Offset = "0x2222250", VA = "0x182223650", Slot = "7")]
			get
			{
				return StageMixStoryOverallView.OverallDisplayFeature.NONE;
			}
		}

		// Token: 0x06026EE2 RID: 159458 RVA: 0x000CCCC0 File Offset: 0x000CAEC0
		[Token(Token = "0x6026EE2")]
		[Address(RVA = "0x2223280", Offset = "0x2221E80", VA = "0x182223280", Slot = "8")]
		public override bool IsValid(StageStorylineStorySetViewModel model)
		{
			return default(bool);
		}

		// Token: 0x06026EE3 RID: 159459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EE3")]
		[Address(RVA = "0x2223370", Offset = "0x2221F70", VA = "0x182223370", Slot = "9")]
		public override void Render(StageStorylineStorySetViewModel model)
		{
		}

		// Token: 0x06026EE4 RID: 159460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026EE4")]
		[Address(RVA = "0x22235B0", Offset = "0x22221B0", VA = "0x1822235B0")]
		public StageMixStoryOverallGroupItemProgressPlugin()
		{
		}

		// Token: 0x04037112 RID: 225554
		[Token(Token = "0x4037112")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _stageProgressPanel;

		// Token: 0x04037113 RID: 225555
		[Token(Token = "0x4037113")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _storyProgressPanel;

		// Token: 0x04037114 RID: 225556
		[Token(Token = "0x4037114")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x04037115 RID: 225557
		[Token(Token = "0x4037115")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _completeAnimation;

		// Token: 0x04037116 RID: 225558
		[Token(Token = "0x4037116")]
		[FieldOffset(Offset = "0x40")]
		private AnimationWrapper m_completeAnimationWrapper;

		// Token: 0x04037117 RID: 225559
		[Token(Token = "0x4037117")]
		[FieldOffset(Offset = "0x48")]
		private string m_completeAnimationName;

		// Token: 0x04037118 RID: 225560
		[Token(Token = "0x4037118")]
		[FieldOffset(Offset = "0x50")]
		private float m_completeAnimationLength;

		// Token: 0x04037119 RID: 225561
		[Token(Token = "0x4037119")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_presentingFeature;

		// Token: 0x0403711A RID: 225562
		[Token(Token = "0x403711A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x0403711B RID: 225563
		[Token(Token = "0x403711B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403711C RID: 225564
		[Token(Token = "0x403711C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
