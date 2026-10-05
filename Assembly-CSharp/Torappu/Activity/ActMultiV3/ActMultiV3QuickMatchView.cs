using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FAA RID: 28586
	[Token(Token = "0x2006FAA")]
	public class ActMultiV3QuickMatchView : DataBinder<ActMultiV3QuickMatchProp>
	{
		// Token: 0x0602899F RID: 166303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602899F")]
		[Address(RVA = "0x23E9790", Offset = "0x23E8390", VA = "0x1823E9790", Slot = "7")]
		public override void OnValueChanged(ActMultiV3QuickMatchProp property)
		{
		}

		// Token: 0x060289A0 RID: 166304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289A0")]
		[Address(RVA = "0x23EA7F0", Offset = "0x23E93F0", VA = "0x1823EA7F0")]
		private void _PlayInverseEffectAnimIfNeed(ActMultiV3QuickMatchModel matchModel)
		{
		}

		// Token: 0x060289A1 RID: 166305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289A1")]
		[Address(RVA = "0x23EA620", Offset = "0x23E9220", VA = "0x1823EA620")]
		private void _PlayEnterAnimIfNeed(ActMultiV3QuickMatchModel matchModel)
		{
		}

		// Token: 0x060289A2 RID: 166306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289A2")]
		[Address(RVA = "0x23E9FA0", Offset = "0x23E8BA0", VA = "0x1823E9FA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060289A3 RID: 166307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289A3")]
		[Address(RVA = "0x23EAA50", Offset = "0x23E9650", VA = "0x1823EAA50")]
		private void _RegisterTutorialGo()
		{
		}

		// Token: 0x060289A4 RID: 166308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289A4")]
		[Address(RVA = "0x23E9F10", Offset = "0x23E8B10", VA = "0x1823E9F10")]
		private void _EventOnInverseToggleClick()
		{
		}

		// Token: 0x060289A5 RID: 166309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60289A5")]
		[Address(RVA = "0x23EAB60", Offset = "0x23E9760", VA = "0x1823EAB60")]
		public ActMultiV3QuickMatchView()
		{
		}

		// Token: 0x04039D31 RID: 236849
		[Token(Token = "0x4039D31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _modeList;

		// Token: 0x04039D32 RID: 236850
		[Token(Token = "0x4039D32")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _matchPosList;

		// Token: 0x04039D33 RID: 236851
		[Token(Token = "0x4039D33")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _btnStartNormalGO;

		// Token: 0x04039D34 RID: 236852
		[Token(Token = "0x4039D34")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _btnStartDisableGO;

		// Token: 0x04039D35 RID: 236853
		[Token(Token = "0x4039D35")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnMatchPosGO;

		// Token: 0x04039D36 RID: 236854
		[Token(Token = "0x4039D36")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _guidebookGO;

		// Token: 0x04039D37 RID: 236855
		[Token(Token = "0x4039D37")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _matchPosListPanel;

		// Token: 0x04039D38 RID: 236856
		[Token(Token = "0x4039D38")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _matchPosDescGO;

		// Token: 0x04039D39 RID: 236857
		[Token(Token = "0x4039D39")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textPosDesc;

		// Token: 0x04039D3A RID: 236858
		[Token(Token = "0x4039D3A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textCurrMatchPos;

		// Token: 0x04039D3B RID: 236859
		[Token(Token = "0x4039D3B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textInverseDesc;

		// Token: 0x04039D3C RID: 236860
		[Token(Token = "0x4039D3C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _inverseDescHandler;

		// Token: 0x04039D3D RID: 236861
		[Token(Token = "0x4039D3D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _imgCurrMatchIcon;

		// Token: 0x04039D3E RID: 236862
		[Token(Token = "0x4039D3E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _posPanelFadeDuration;

		// Token: 0x04039D3F RID: 236863
		[Token(Token = "0x4039D3F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActMultiV3InverseToggleView _inverseTogglePrefab;

		// Token: 0x04039D40 RID: 236864
		[Token(Token = "0x4039D40")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform _inverseToggleContainer;

		// Token: 0x04039D41 RID: 236865
		[Token(Token = "0x4039D41")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x04039D42 RID: 236866
		[Token(Token = "0x4039D42")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _animModeListSwitch;

		// Token: 0x04039D43 RID: 236867
		[Token(Token = "0x4039D43")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAnimationLocation _animBtnSelectPosSwitch;

		// Token: 0x04039D44 RID: 236868
		[Token(Token = "0x4039D44")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _animInverseModeEnter;

		// Token: 0x04039D45 RID: 236869
		[Token(Token = "0x4039D45")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup _inverseEffectHandler;

		// Token: 0x04039D46 RID: 236870
		[Token(Token = "0x4039D46")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _inverseEffectFadeDuration;

		// Token: 0x04039D47 RID: 236871
		[Token(Token = "0x4039D47")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Group("Billboard")]
		private PageCameraRenderTextureHolder _renderTextureHolder;

		// Token: 0x04039D48 RID: 236872
		[Token(Token = "0x4039D48")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Billboard")]
		private UIMeshImage[] _billboardMeshImages;

		// Token: 0x04039D49 RID: 236873
		[Token(Token = "0x4039D49")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Group("Billboard")]
		private RectTransform _billboardCanvasRoot;

		// Token: 0x04039D4A RID: 236874
		[Token(Token = "0x4039D4A")]
		[FieldOffset(Offset = "0x108")]
		private bool m_hasInited;

		// Token: 0x04039D4B RID: 236875
		[Token(Token = "0x4039D4B")]
		[FieldOffset(Offset = "0x110")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039D4C RID: 236876
		[Token(Token = "0x4039D4C")]
		[FieldOffset(Offset = "0x120")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039D4D RID: 236877
		[Token(Token = "0x4039D4D")]
		[FieldOffset(Offset = "0x130")]
		private ActMultiV3QuickMatchModel m_matchModel;

		// Token: 0x04039D4E RID: 236878
		[Token(Token = "0x4039D4E")]
		[FieldOffset(Offset = "0x138")]
		private ActMultiV3QuickMatchView.ModeListAdapter m_modeListAdapter;

		// Token: 0x04039D4F RID: 236879
		[Token(Token = "0x4039D4F")]
		[FieldOffset(Offset = "0x140")]
		private ActMultiV3QuickMatchView.MatchPosList m_matchPosListAdapter;

		// Token: 0x04039D50 RID: 236880
		[Token(Token = "0x4039D50")]
		[FieldOffset(Offset = "0x148")]
		private FadeSwitchTween m_posListPanelTween;

		// Token: 0x04039D51 RID: 236881
		[Token(Token = "0x4039D51")]
		[FieldOffset(Offset = "0x150")]
		private AnimationSwitchTween m_btnSelectPosTween;

		// Token: 0x04039D52 RID: 236882
		[Token(Token = "0x4039D52")]
		[FieldOffset(Offset = "0x158")]
		private ActMultiV3InverseToggleView m_inverseToggleView;

		// Token: 0x04039D53 RID: 236883
		[Token(Token = "0x4039D53")]
		[FieldOffset(Offset = "0x160")]
		private int m_cacheEnterSeqNum;

		// Token: 0x04039D54 RID: 236884
		[Token(Token = "0x4039D54")]
		[FieldOffset(Offset = "0x168")]
		private Tween m_enterTween;

		// Token: 0x04039D55 RID: 236885
		[Token(Token = "0x4039D55")]
		[FieldOffset(Offset = "0x170")]
		private AnimationSwitchTween m_modeListTween;

		// Token: 0x04039D56 RID: 236886
		[Token(Token = "0x4039D56")]
		[FieldOffset(Offset = "0x178")]
		private FadeSwitchTween m_inverseEffectTween;

		// Token: 0x04039D57 RID: 236887
		[Token(Token = "0x4039D57")]
		[FieldOffset(Offset = "0x180")]
		private FadeSwitchTween m_inverseDescTween;

		// Token: 0x04039D58 RID: 236888
		[Token(Token = "0x4039D58")]
		[FieldOffset(Offset = "0x188")]
		private Tween m_inverseEffectEnterTween;

		// Token: 0x04039D59 RID: 236889
		[Token(Token = "0x4039D59")]
		[FieldOffset(Offset = "0x190")]
		private string m_cachedActId;

		// Token: 0x04039D5A RID: 236890
		[Token(Token = "0x4039D5A")]
		[FieldOffset(Offset = "0x198")]
		private GameObject m_matchAnimObj;

		// Token: 0x04039D5B RID: 236891
		[Token(Token = "0x4039D5B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039D5C RID: 236892
		[Token(Token = "0x4039D5C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayInverseEffectAnimIfNeed;

		// Token: 0x04039D5D RID: 236893
		[Token(Token = "0x4039D5D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayEnterAnimIfNeed;

		// Token: 0x04039D5E RID: 236894
		[Token(Token = "0x4039D5E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039D5F RID: 236895
		[Token(Token = "0x4039D5F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGo;

		// Token: 0x04039D60 RID: 236896
		[Token(Token = "0x4039D60")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnInverseToggleClick;

		// Token: 0x04039D61 RID: 236897
		[Token(Token = "0x4039D61")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006FAB RID: 28587
		[Token(Token = "0x2006FAB")]
		private class MatchPosList : SimpleLayoutAdapter
		{
			// Token: 0x060289A6 RID: 166310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60289A6")]
			[Address(RVA = "0x24032C0", Offset = "0x2401EC0", VA = "0x1824032C0")]
			public MatchPosList(ActMultiV3QuickMatchView closure)
			{
			}

			// Token: 0x17005FD2 RID: 24530
			// (get) Token: 0x060289A7 RID: 166311 RVA: 0x000D25E8 File Offset: 0x000D07E8
			[Token(Token = "0x17005FD2")]
			public override int count
			{
				[Token(Token = "0x60289A7")]
				[Address(RVA = "0x2403340", Offset = "0x2401F40", VA = "0x182403340", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060289A8 RID: 166312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60289A8")]
			[Address(RVA = "0x24030C0", Offset = "0x2401CC0", VA = "0x1824030C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039D62 RID: 236898
			[Token(Token = "0x4039D62")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3QuickMatchView m_closure;

			// Token: 0x04039D63 RID: 236899
			[Token(Token = "0x4039D63")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039D64 RID: 236900
			[Token(Token = "0x4039D64")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039D65 RID: 236901
			[Token(Token = "0x4039D65")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006FAC RID: 28588
		[Token(Token = "0x2006FAC")]
		private class ModeListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060289A9 RID: 166313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60289A9")]
			[Address(RVA = "0x2403700", Offset = "0x2402300", VA = "0x182403700")]
			public ModeListAdapter(ActMultiV3QuickMatchView closure)
			{
			}

			// Token: 0x17005FD3 RID: 24531
			// (get) Token: 0x060289AA RID: 166314 RVA: 0x000D2600 File Offset: 0x000D0800
			[Token(Token = "0x17005FD3")]
			public override int count
			{
				[Token(Token = "0x60289AA")]
				[Address(RVA = "0x2403780", Offset = "0x2402380", VA = "0x182403780", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060289AB RID: 166315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60289AB")]
			[Address(RVA = "0x2403540", Offset = "0x2402140", VA = "0x182403540", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04039D66 RID: 236902
			[Token(Token = "0x4039D66")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3QuickMatchView m_closure;

			// Token: 0x04039D67 RID: 236903
			[Token(Token = "0x4039D67")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04039D68 RID: 236904
			[Token(Token = "0x4039D68")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039D69 RID: 236905
			[Token(Token = "0x4039D69")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
