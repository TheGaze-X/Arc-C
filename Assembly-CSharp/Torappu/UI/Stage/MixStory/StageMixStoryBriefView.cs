using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A8A RID: 27274
	[Token(Token = "0x2006A8A")]
	public class StageMixStoryBriefView : DataBinder<ZoneGroupViewProperty>
	{
		// Token: 0x06027062 RID: 159842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027062")]
		[Address(RVA = "0x223ECC0", Offset = "0x223D8C0", VA = "0x18223ECC0")]
		public void ResetViews()
		{
		}

		// Token: 0x06027063 RID: 159843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027063")]
		[Address(RVA = "0x223E660", Offset = "0x223D260", VA = "0x18223E660")]
		public void OnGalleryEntryClick()
		{
		}

		// Token: 0x06027064 RID: 159844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027064")]
		[Address(RVA = "0x223E700", Offset = "0x223D300", VA = "0x18223E700", Slot = "7")]
		public override void OnValueChanged(ZoneGroupViewProperty property)
		{
		}

		// Token: 0x06027065 RID: 159845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027065")]
		[Address(RVA = "0x223ED90", Offset = "0x223D990", VA = "0x18223ED90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027066 RID: 159846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027066")]
		[Address(RVA = "0x223EF30", Offset = "0x223DB30", VA = "0x18223EF30")]
		private void _RenderBrief(StageStorylineStorySetViewModel selectedBrief)
		{
		}

		// Token: 0x06027067 RID: 159847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027067")]
		[Address(RVA = "0x223FAF0", Offset = "0x223E6F0", VA = "0x18223FAF0")]
		private void _RenderCGGalleryEntry(StageStorylineStorySetViewModel selectedBrief)
		{
		}

		// Token: 0x06027068 RID: 159848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027068")]
		[Address(RVA = "0x223FC50", Offset = "0x223E850", VA = "0x18223FC50")]
		public StageMixStoryBriefView()
		{
		}

		// Token: 0x0403734D RID: 226125
		[Token(Token = "0x403734D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StageMixStoryBriefLineView _lineView;

		// Token: 0x0403734E RID: 226126
		[Token(Token = "0x403734E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _switchAnimation;

		// Token: 0x0403734F RID: 226127
		[Token(Token = "0x403734F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _bkgImage;

		// Token: 0x04037350 RID: 226128
		[Token(Token = "0x4037350")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _titleImage;

		// Token: 0x04037351 RID: 226129
		[Token(Token = "0x4037351")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _cgGalleryEntry;

		// Token: 0x04037352 RID: 226130
		[Token(Token = "0x4037352")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UICommonTrackPoint _cgGalleryTrackPoint;

		// Token: 0x04037353 RID: 226131
		[Token(Token = "0x4037353")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _mainlinePart;

		// Token: 0x04037354 RID: 226132
		[Token(Token = "0x4037354")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StageMixStoryBriefMainlineView _mainlineView;

		// Token: 0x04037355 RID: 226133
		[Token(Token = "0x4037355")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _ssPart;

		// Token: 0x04037356 RID: 226134
		[Token(Token = "0x4037356")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private StageMixStoryBriefSSView _ssView;

		// Token: 0x04037357 RID: 226135
		[Token(Token = "0x4037357")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _collectPart;

		// Token: 0x04037358 RID: 226136
		[Token(Token = "0x4037358")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private StageMixStoryBriefCollectView _collectView;

		// Token: 0x04037359 RID: 226137
		[Token(Token = "0x4037359")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403735A RID: 226138
		[Token(Token = "0x403735A")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_finder;

		// Token: 0x0403735B RID: 226139
		[Token(Token = "0x403735B")]
		[FieldOffset(Offset = "0xA0")]
		private ILoadAsset m_iLoadAsset;

		// Token: 0x0403735C RID: 226140
		[Token(Token = "0x403735C")]
		[FieldOffset(Offset = "0xA8")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0403735D RID: 226141
		[Token(Token = "0x403735D")]
		[FieldOffset(Offset = "0xB0")]
		private TrackPointViewProperty m_cgGalleryTrackPointProperty;

		// Token: 0x0403735E RID: 226142
		[Token(Token = "0x403735E")]
		[FieldOffset(Offset = "0xB8")]
		private StageStorylineStorySetViewModel m_cachedSelectedBrief;

		// Token: 0x0403735F RID: 226143
		[Token(Token = "0x403735F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ResetViews;

		// Token: 0x04037360 RID: 226144
		[Token(Token = "0x4037360")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnGalleryEntryClick;

		// Token: 0x04037361 RID: 226145
		[Token(Token = "0x4037361")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037362 RID: 226146
		[Token(Token = "0x4037362")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037363 RID: 226147
		[Token(Token = "0x4037363")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderBrief;

		// Token: 0x04037364 RID: 226148
		[Token(Token = "0x4037364")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderCGGalleryEntry;

		// Token: 0x04037365 RID: 226149
		[Token(Token = "0x4037365")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A8B RID: 27275
		[Token(Token = "0x2006A8B")]
		private class CGGalleryTrackpoint : ITrackPointModel, IHotfixable
		{
			// Token: 0x06027069 RID: 159849 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027069")]
			[Address(RVA = "0x22374E0", Offset = "0x22360E0", VA = "0x1822374E0", Slot = "4")]
			public void UpdateState(object param)
			{
			}

			// Token: 0x17005C35 RID: 23605
			// (get) Token: 0x0602706A RID: 159850 RVA: 0x000CD4D0 File Offset: 0x000CB6D0
			// (set) Token: 0x0602706B RID: 159851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C35")]
			public bool isShow
			{
				[Token(Token = "0x602706A")]
				[Address(RVA = "0x22376A0", Offset = "0x22362A0", VA = "0x1822376A0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602706B")]
				[Address(RVA = "0x2237700", Offset = "0x2236300", VA = "0x182237700")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0602706C RID: 159852 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602706C")]
			[Address(RVA = "0x2237640", Offset = "0x2236240", VA = "0x182237640")]
			public CGGalleryTrackpoint()
			{
			}

			// Token: 0x04037367 RID: 226151
			[Token(Token = "0x4037367")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateState;

			// Token: 0x04037368 RID: 226152
			[Token(Token = "0x4037368")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_isShow;

			// Token: 0x04037369 RID: 226153
			[Token(Token = "0x4037369")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_isShow;

			// Token: 0x0403736A RID: 226154
			[Token(Token = "0x403736A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
