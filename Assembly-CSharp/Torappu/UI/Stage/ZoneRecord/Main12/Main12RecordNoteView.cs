using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A16 RID: 27158
	[Token(Token = "0x2006A16")]
	public class Main12RecordNoteView : DataBinder<Main12ZoneRecordViewProperty>
	{
		// Token: 0x17005BA0 RID: 23456
		// (get) Token: 0x06026D2D RID: 159021 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D2E RID: 159022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA0")]
		public Action onPrevBtnClick
		{
			[Token(Token = "0x6026D2D")]
			[Address(RVA = "0x21F8830", Offset = "0x21F7430", VA = "0x1821F8830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026D2E")]
			[Address(RVA = "0x21F8A10", Offset = "0x21F7610", VA = "0x1821F8A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x06026D2F RID: 159023 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D30 RID: 159024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA1")]
		public Action onNextBtnClick
		{
			[Token(Token = "0x6026D2F")]
			[Address(RVA = "0x21F87D0", Offset = "0x21F73D0", VA = "0x1821F87D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026D30")]
			[Address(RVA = "0x21F8990", Offset = "0x21F7590", VA = "0x1821F8990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x06026D31 RID: 159025 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D32 RID: 159026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA2")]
		public Action onClaimAllRewardClick
		{
			[Token(Token = "0x6026D31")]
			[Address(RVA = "0x21F8770", Offset = "0x21F7370", VA = "0x1821F8770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026D32")]
			[Address(RVA = "0x21F8910", Offset = "0x21F7510", VA = "0x1821F8910")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x06026D33 RID: 159027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06026D34 RID: 159028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005BA3")]
		public Main12ZoneRecordController controller
		{
			[Token(Token = "0x6026D33")]
			[Address(RVA = "0x21F8710", Offset = "0x21F7310", VA = "0x1821F8710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6026D34")]
			[Address(RVA = "0x21F8890", Offset = "0x21F7490", VA = "0x1821F8890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06026D35 RID: 159029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D35")]
		[Address(RVA = "0x21F7C00", Offset = "0x21F6800", VA = "0x1821F7C00")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06026D36 RID: 159030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D36")]
		[Address(RVA = "0x21F81E0", Offset = "0x21F6DE0", VA = "0x1821F81E0")]
		private void _Render()
		{
		}

		// Token: 0x06026D37 RID: 159031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D37")]
		[Address(RVA = "0x21F7FE0", Offset = "0x21F6BE0", VA = "0x1821F7FE0")]
		private void _RenderPreNextBtnPart()
		{
		}

		// Token: 0x06026D38 RID: 159032 RVA: 0x000CC780 File Offset: 0x000CA980
		[Token(Token = "0x6026D38")]
		[Address(RVA = "0x21F84E0", Offset = "0x21F70E0", VA = "0x1821F84E0")]
		private float _UpdatePageBtnAlpha(ZoneRecordViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x06026D39 RID: 159033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D39")]
		[Address(RVA = "0x21F8580", Offset = "0x21F7180", VA = "0x1821F8580")]
		private void _UpdatePageBtnGlow(Main12RecordNoteView.RecordNotePageBtnGlowTweenWrapper tween, ZoneRecordViewModel viewModel)
		{
		}

		// Token: 0x06026D3A RID: 159034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D3A")]
		[Address(RVA = "0x21F8390", Offset = "0x21F6F90", VA = "0x1821F8390")]
		private void _ResetBeforeCloseNote()
		{
		}

		// Token: 0x06026D3B RID: 159035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D3B")]
		[Address(RVA = "0x21F78D0", Offset = "0x21F64D0", VA = "0x1821F78D0", Slot = "7")]
		public override void OnValueChanged(Main12ZoneRecordViewProperty property)
		{
		}

		// Token: 0x06026D3C RID: 159036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D3C")]
		[Address(RVA = "0x21F77C0", Offset = "0x21F63C0", VA = "0x1821F77C0")]
		public void EventOnPrevBtnClick()
		{
		}

		// Token: 0x06026D3D RID: 159037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D3D")]
		[Address(RVA = "0x21F76B0", Offset = "0x21F62B0", VA = "0x1821F76B0")]
		public void EventOnNextBtnClick()
		{
		}

		// Token: 0x06026D3E RID: 159038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D3E")]
		[Address(RVA = "0x21F86A0", Offset = "0x21F72A0", VA = "0x1821F86A0")]
		public Main12RecordNoteView()
		{
		}

		// Token: 0x04036DD2 RID: 224722
		[Token(Token = "0x4036DD2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Main12RecordNoteContentView _contentView;

		// Token: 0x04036DD3 RID: 224723
		[Token(Token = "0x4036DD3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasContent;

		// Token: 0x04036DD4 RID: 224724
		[Token(Token = "0x4036DD4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _dotsLayout;

		// Token: 0x04036DD5 RID: 224725
		[Token(Token = "0x4036DD5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _objPrevBtn;

		// Token: 0x04036DD6 RID: 224726
		[Token(Token = "0x4036DD6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _objNextBtn;

		// Token: 0x04036DD7 RID: 224727
		[Token(Token = "0x4036DD7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasPrevBtn;

		// Token: 0x04036DD8 RID: 224728
		[Token(Token = "0x4036DD8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasNextBtn;

		// Token: 0x04036DD9 RID: 224729
		[Token(Token = "0x4036DD9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasBtnPrevGlow;

		// Token: 0x04036DDA RID: 224730
		[Token(Token = "0x4036DDA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _canvasBtnNextGlow;

		// Token: 0x04036DDB RID: 224731
		[Token(Token = "0x4036DDB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _rectRewardPartParent;

		// Token: 0x04036DDC RID: 224732
		[Token(Token = "0x4036DDC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ZoneRecordRewardContentView _rewardContentPrefab;

		// Token: 0x04036DDD RID: 224733
		[Token(Token = "0x4036DDD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasContentFade1;

		// Token: 0x04036DDE RID: 224734
		[Token(Token = "0x4036DDE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasContentFade2;

		// Token: 0x04036DDF RID: 224735
		[Token(Token = "0x4036DDF")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04036DE0 RID: 224736
		[Token(Token = "0x4036DE0")]
		[FieldOffset(Offset = "0x90")]
		private Main12RecordNoteView.Main12RecordNoteDotListAdapter m_dotListAdapter;

		// Token: 0x04036DE1 RID: 224737
		[Token(Token = "0x4036DE1")]
		[FieldOffset(Offset = "0x98")]
		private string m_selectingRecordId;

		// Token: 0x04036DE2 RID: 224738
		[Token(Token = "0x4036DE2")]
		[FieldOffset(Offset = "0xA0")]
		private ZoneRecordGroupViewModel m_cachedViewModel;

		// Token: 0x04036DE3 RID: 224739
		[Token(Token = "0x4036DE3")]
		[FieldOffset(Offset = "0xA8")]
		private Main12RecordNoteView.RecordNotePageBtnGlowTweenWrapper m_pagePrevBtnGlowTween;

		// Token: 0x04036DE4 RID: 224740
		[Token(Token = "0x4036DE4")]
		[FieldOffset(Offset = "0xB0")]
		private Main12RecordNoteView.RecordNotePageBtnGlowTweenWrapper m_pageNextBtnGlowTween;

		// Token: 0x04036DE5 RID: 224741
		[Token(Token = "0x4036DE5")]
		[FieldOffset(Offset = "0xB8")]
		private ZoneRecordRewardContentView m_rewardContentView;

		// Token: 0x04036DE6 RID: 224742
		[Token(Token = "0x4036DE6")]
		[FieldOffset(Offset = "0xC0")]
		private FadeSwitchTween m_noteContentFadeTween;

		// Token: 0x04036DE7 RID: 224743
		[Token(Token = "0x4036DE7")]
		[FieldOffset(Offset = "0xC8")]
		private FadeSwitchTween m_noteContentArrowFadeTween;

		// Token: 0x04036DE8 RID: 224744
		[Token(Token = "0x4036DE8")]
		[FieldOffset(Offset = "0xD0")]
		private int m_cachedIndex;

		// Token: 0x04036DE9 RID: 224745
		[Token(Token = "0x4036DE9")]
		private const float PAGE_BTN_CANT_CLICK_ALPHA = 0.5f;

		// Token: 0x04036DEA RID: 224746
		[Token(Token = "0x4036DEA")]
		private const float PAGE_BTN_CAN_CLICK_ALPHA = 1f;

		// Token: 0x04036DEB RID: 224747
		[Token(Token = "0x4036DEB")]
		private const float CONTENT_FADE_DUR = 0.3f;

		// Token: 0x04036DF0 RID: 224752
		[Token(Token = "0x4036DF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onPrevBtnClick;

		// Token: 0x04036DF1 RID: 224753
		[Token(Token = "0x4036DF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onPrevBtnClick;

		// Token: 0x04036DF2 RID: 224754
		[Token(Token = "0x4036DF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onNextBtnClick;

		// Token: 0x04036DF3 RID: 224755
		[Token(Token = "0x4036DF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onNextBtnClick;

		// Token: 0x04036DF4 RID: 224756
		[Token(Token = "0x4036DF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onClaimAllRewardClick;

		// Token: 0x04036DF5 RID: 224757
		[Token(Token = "0x4036DF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onClaimAllRewardClick;

		// Token: 0x04036DF6 RID: 224758
		[Token(Token = "0x4036DF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04036DF7 RID: 224759
		[Token(Token = "0x4036DF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04036DF8 RID: 224760
		[Token(Token = "0x4036DF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04036DF9 RID: 224761
		[Token(Token = "0x4036DF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04036DFA RID: 224762
		[Token(Token = "0x4036DFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderPreNextBtnPart;

		// Token: 0x04036DFB RID: 224763
		[Token(Token = "0x4036DFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdatePageBtnAlpha;

		// Token: 0x04036DFC RID: 224764
		[Token(Token = "0x4036DFC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdatePageBtnGlow;

		// Token: 0x04036DFD RID: 224765
		[Token(Token = "0x4036DFD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetBeforeCloseNote;

		// Token: 0x04036DFE RID: 224766
		[Token(Token = "0x4036DFE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04036DFF RID: 224767
		[Token(Token = "0x4036DFF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnPrevBtnClick;

		// Token: 0x04036E00 RID: 224768
		[Token(Token = "0x4036E00")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnNextBtnClick;

		// Token: 0x04036E01 RID: 224769
		[Token(Token = "0x4036E01")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006A17 RID: 27159
		[Token(Token = "0x2006A17")]
		private class Main12RecordNoteDotListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06026D3F RID: 159039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D3F")]
			[Address(RVA = "0x21F68F0", Offset = "0x21F54F0", VA = "0x1821F68F0")]
			public Main12RecordNoteDotListAdapter(Main12RecordNoteView closure)
			{
			}

			// Token: 0x17005BA4 RID: 23460
			// (get) Token: 0x06026D40 RID: 159040 RVA: 0x000CC798 File Offset: 0x000CA998
			[Token(Token = "0x17005BA4")]
			public override int count
			{
				[Token(Token = "0x6026D40")]
				[Address(RVA = "0x21F6970", Offset = "0x21F5570", VA = "0x1821F6970", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06026D41 RID: 159041 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6026D41")]
			[Address(RVA = "0x21F6700", Offset = "0x21F5300", VA = "0x1821F6700", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04036E02 RID: 224770
			[Token(Token = "0x4036E02")]
			[FieldOffset(Offset = "0x20")]
			private Main12RecordNoteView m_closure;

			// Token: 0x04036E03 RID: 224771
			[Token(Token = "0x4036E03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04036E04 RID: 224772
			[Token(Token = "0x4036E04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04036E05 RID: 224773
			[Token(Token = "0x4036E05")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006A18 RID: 27160
		[Token(Token = "0x2006A18")]
		private class RecordNotePageBtnGlowTweenWrapper : IHotfixable
		{
			// Token: 0x06026D42 RID: 159042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D42")]
			[Address(RVA = "0x21FD1E0", Offset = "0x21FBDE0", VA = "0x1821FD1E0")]
			public void SetCanvasGroup(CanvasGroup canvas)
			{
			}

			// Token: 0x06026D43 RID: 159043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D43")]
			[Address(RVA = "0x21FD260", Offset = "0x21FBE60", VA = "0x1821FD260")]
			public void SetTween()
			{
			}

			// Token: 0x06026D44 RID: 159044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D44")]
			[Address(RVA = "0x21FD160", Offset = "0x21FBD60", VA = "0x1821FD160")]
			public void KillTween()
			{
			}

			// Token: 0x06026D45 RID: 159045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6026D45")]
			[Address(RVA = "0x21FD500", Offset = "0x21FC100", VA = "0x1821FD500")]
			public RecordNotePageBtnGlowTweenWrapper()
			{
			}

			// Token: 0x04036E06 RID: 224774
			[Token(Token = "0x4036E06")]
			[FieldOffset(Offset = "0x10")]
			private CanvasGroup m_glowCanvasGroup;

			// Token: 0x04036E07 RID: 224775
			[Token(Token = "0x4036E07")]
			[FieldOffset(Offset = "0x18")]
			private Sequence m_tween;

			// Token: 0x04036E08 RID: 224776
			[Token(Token = "0x4036E08")]
			private const float SELECT_GLOW_TWEEN_DUR = 1f;

			// Token: 0x04036E09 RID: 224777
			[Token(Token = "0x4036E09")]
			private const float SELECT_GLOW_END_ALPHA = 0.6f;

			// Token: 0x04036E0A RID: 224778
			[Token(Token = "0x4036E0A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetCanvasGroup;

			// Token: 0x04036E0B RID: 224779
			[Token(Token = "0x4036E0B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetTween;

			// Token: 0x04036E0C RID: 224780
			[Token(Token = "0x4036E0C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_KillTween;

			// Token: 0x04036E0D RID: 224781
			[Token(Token = "0x4036E0D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
