using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059AB RID: 22955
	[Token(Token = "0x20059AB")]
	public class CrisisV2MapButtonView : DataBinder<CrisisV2MapProp>
	{
		// Token: 0x06021764 RID: 137060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021764")]
		[Address(RVA = "0x1BC6B60", Offset = "0x1BC5760", VA = "0x181BC6B60", Slot = "7")]
		public override void OnValueChanged(CrisisV2MapProp property)
		{
		}

		// Token: 0x06021765 RID: 137061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021765")]
		[Address(RVA = "0x1BC7580", Offset = "0x1BC6180", VA = "0x181BC7580")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021766 RID: 137062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021766")]
		[Address(RVA = "0x1BC7990", Offset = "0x1BC6590", VA = "0x181BC7990")]
		private void _UpdateViewToggle(CrisisV2MapModel mapModel)
		{
		}

		// Token: 0x06021767 RID: 137063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021767")]
		[Address(RVA = "0x1BC6800", Offset = "0x1BC5400", VA = "0x181BC6800")]
		public void EventOnBtnClearAll()
		{
		}

		// Token: 0x06021768 RID: 137064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021768")]
		[Address(RVA = "0x1BC6920", Offset = "0x1BC5520", VA = "0x181BC6920")]
		public void EventOnBtnSwitchView()
		{
		}

		// Token: 0x06021769 RID: 137065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021769")]
		[Address(RVA = "0x1BC6A40", Offset = "0x1BC5640", VA = "0x181BC6A40")]
		public void EventOnOpenMissionState()
		{
		}

		// Token: 0x0602176A RID: 137066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602176A")]
		[Address(RVA = "0x1BC6AD0", Offset = "0x1BC56D0", VA = "0x181BC6AD0")]
		public void EventOnOpenStageDetailState()
		{
		}

		// Token: 0x0602176B RID: 137067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602176B")]
		[Address(RVA = "0x1BC69B0", Offset = "0x1BC55B0", VA = "0x181BC69B0")]
		public void EventOnOpenAchieve()
		{
		}

		// Token: 0x0602176C RID: 137068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602176C")]
		[Address(RVA = "0x1BC6890", Offset = "0x1BC5490", VA = "0x181BC6890")]
		public void EventOnBtnDimension()
		{
		}

		// Token: 0x0602176D RID: 137069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602176D")]
		[Address(RVA = "0x1BC7B30", Offset = "0x1BC6730", VA = "0x181BC7B30")]
		public CrisisV2MapButtonView()
		{
		}

		// Token: 0x0402DAF0 RID: 187120
		[Token(Token = "0x402DAF0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgAreaBg;

		// Token: 0x0402DAF1 RID: 187121
		[Token(Token = "0x402DAF1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textCurrentScore;

		// Token: 0x0402DAF2 RID: 187122
		[Token(Token = "0x402DAF2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animViewToggle;

		// Token: 0x0402DAF3 RID: 187123
		[Token(Token = "0x402DAF3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _viewToggleGo;

		// Token: 0x0402DAF4 RID: 187124
		[Token(Token = "0x402DAF4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _tempMapHintGo;

		// Token: 0x0402DAF5 RID: 187125
		[Token(Token = "0x402DAF5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textTempMapHint;

		// Token: 0x0402DAF6 RID: 187126
		[Token(Token = "0x402DAF6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _btnStartNormalBgGo;

		// Token: 0x0402DAF7 RID: 187127
		[Token(Token = "0x402DAF7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnStartHardBgGo;

		// Token: 0x0402DAF8 RID: 187128
		[Token(Token = "0x402DAF8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _hardCoverBgGo;

		// Token: 0x0402DAF9 RID: 187129
		[Token(Token = "0x402DAF9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgScoreHalftone;

		// Token: 0x0402DAFA RID: 187130
		[Token(Token = "0x402DAFA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorNormalScoreHalftone;

		// Token: 0x0402DAFB RID: 187131
		[Token(Token = "0x402DAFB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorHardScoreHalftone;

		// Token: 0x0402DAFC RID: 187132
		[Token(Token = "0x402DAFC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _btnRecordGo;

		// Token: 0x0402DAFD RID: 187133
		[Token(Token = "0x402DAFD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _displayRecordGo;

		// Token: 0x0402DAFE RID: 187134
		[Token(Token = "0x402DAFE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text[] _textHighestScoreList;

		// Token: 0x0402DAFF RID: 187135
		[Token(Token = "0x402DAFF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _missionCompletePartGo;

		// Token: 0x0402DB00 RID: 187136
		[Token(Token = "0x402DB00")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _missionNormalPartGo;

		// Token: 0x0402DB01 RID: 187137
		[Token(Token = "0x402DB01")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _missionClaimedPartGo;

		// Token: 0x0402DB02 RID: 187138
		[Token(Token = "0x402DB02")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textMissionProgress;

		// Token: 0x0402DB03 RID: 187139
		[Token(Token = "0x402DB03")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _dailyMissionHintGo;

		// Token: 0x0402DB04 RID: 187140
		[Token(Token = "0x402DB04")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _textMissionExpire;

		// Token: 0x0402DB05 RID: 187141
		[Token(Token = "0x402DB05")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CrisisV2DiagramView _diagramPrefab;

		// Token: 0x0402DB06 RID: 187142
		[Token(Token = "0x402DB06")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform _diagramContainer;

		// Token: 0x0402DB07 RID: 187143
		[Token(Token = "0x402DB07")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x0402DB08 RID: 187144
		[Token(Token = "0x402DB08")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _blackMask;

		// Token: 0x0402DB09 RID: 187145
		[Token(Token = "0x402DB09")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private CanvasGroup _scrollTopMask;

		// Token: 0x0402DB0A RID: 187146
		[Token(Token = "0x402DB0A")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup _mapButtonView;

		// Token: 0x0402DB0B RID: 187147
		[Token(Token = "0x402DB0B")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private CanvasGroup _dimensionListCanvasGroup;

		// Token: 0x0402DB0C RID: 187148
		[Token(Token = "0x402DB0C")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private SimpleLayoutContent _dimensionList;

		// Token: 0x0402DB0D RID: 187149
		[Token(Token = "0x402DB0D")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _dimensionTweenDuration;

		// Token: 0x0402DB0E RID: 187150
		[Token(Token = "0x402DB0E")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UICommonPageEffectHolder _effectHolder;

		// Token: 0x0402DB0F RID: 187151
		[Token(Token = "0x402DB0F")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private UIDynImage _imgStagePreview;

		// Token: 0x0402DB10 RID: 187152
		[Token(Token = "0x402DB10")]
		[FieldOffset(Offset = "0x138")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402DB11 RID: 187153
		[Token(Token = "0x402DB11")]
		[FieldOffset(Offset = "0x148")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DB12 RID: 187154
		[Token(Token = "0x402DB12")]
		[FieldOffset(Offset = "0x158")]
		private string m_cachedAreaBgId;

		// Token: 0x0402DB13 RID: 187155
		[Token(Token = "0x402DB13")]
		[FieldOffset(Offset = "0x160")]
		private AnimationSwitchTween m_toggleSwitchTween;

		// Token: 0x0402DB14 RID: 187156
		[Token(Token = "0x402DB14")]
		[FieldOffset(Offset = "0x168")]
		private bool m_hasInited;

		// Token: 0x0402DB15 RID: 187157
		[Token(Token = "0x402DB15")]
		[FieldOffset(Offset = "0x170")]
		private CrisisV2DiagramView m_diagramView;

		// Token: 0x0402DB16 RID: 187158
		[Token(Token = "0x402DB16")]
		[FieldOffset(Offset = "0x178")]
		private FadeSwitchTween m_buttonViewSwitchTween;

		// Token: 0x0402DB17 RID: 187159
		[Token(Token = "0x402DB17")]
		[FieldOffset(Offset = "0x180")]
		private FadeSwitchTween m_highlightMaskSwitchTween;

		// Token: 0x0402DB18 RID: 187160
		[Token(Token = "0x402DB18")]
		[FieldOffset(Offset = "0x188")]
		private FadeSwitchTween m_dimensionSwitchTween;

		// Token: 0x0402DB19 RID: 187161
		[Token(Token = "0x402DB19")]
		[FieldOffset(Offset = "0x190")]
		private FadeSwitchTween m_scrollTopMaskSwitchTween;

		// Token: 0x0402DB1A RID: 187162
		[Token(Token = "0x402DB1A")]
		[FieldOffset(Offset = "0x198")]
		private CrisisV2MapButtonView.DimensionListAdapter m_dimensionAdapter;

		// Token: 0x0402DB1B RID: 187163
		[Token(Token = "0x402DB1B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DB1C RID: 187164
		[Token(Token = "0x402DB1C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402DB1D RID: 187165
		[Token(Token = "0x402DB1D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateViewToggle;

		// Token: 0x0402DB1E RID: 187166
		[Token(Token = "0x402DB1E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnClearAll;

		// Token: 0x0402DB1F RID: 187167
		[Token(Token = "0x402DB1F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnSwitchView;

		// Token: 0x0402DB20 RID: 187168
		[Token(Token = "0x402DB20")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnOpenMissionState;

		// Token: 0x0402DB21 RID: 187169
		[Token(Token = "0x402DB21")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnOpenStageDetailState;

		// Token: 0x0402DB22 RID: 187170
		[Token(Token = "0x402DB22")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnOpenAchieve;

		// Token: 0x0402DB23 RID: 187171
		[Token(Token = "0x402DB23")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBtnDimension;

		// Token: 0x0402DB24 RID: 187172
		[Token(Token = "0x402DB24")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020059AC RID: 22956
		[Token(Token = "0x20059AC")]
		private class DimensionListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004EAE RID: 20142
			// (get) Token: 0x0602176E RID: 137070 RVA: 0x000BA5B8 File Offset: 0x000B87B8
			[Token(Token = "0x17004EAE")]
			public override int count
			{
				[Token(Token = "0x602176E")]
				[Address(RVA = "0x1BD00C0", Offset = "0x1BCECC0", VA = "0x181BD00C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602176F RID: 137071 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602176F")]
			[Address(RVA = "0x1BCFD00", Offset = "0x1BCE900", VA = "0x181BCFD00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06021770 RID: 137072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021770")]
			[Address(RVA = "0x1BCFFE0", Offset = "0x1BCEBE0", VA = "0x181BCFFE0")]
			public void SetScoreList(List<int> currentScoreList)
			{
			}

			// Token: 0x06021771 RID: 137073 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021771")]
			[Address(RVA = "0x1BD0060", Offset = "0x1BCEC60", VA = "0x181BD0060")]
			public DimensionListAdapter()
			{
			}

			// Token: 0x0402DB25 RID: 187173
			[Token(Token = "0x402DB25")]
			[FieldOffset(Offset = "0x20")]
			private CrisisV2MapButtonView m_closure;

			// Token: 0x0402DB26 RID: 187174
			[Token(Token = "0x402DB26")]
			[FieldOffset(Offset = "0x28")]
			private List<int> m_currentScoreList;

			// Token: 0x0402DB27 RID: 187175
			[Token(Token = "0x402DB27")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402DB28 RID: 187176
			[Token(Token = "0x402DB28")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402DB29 RID: 187177
			[Token(Token = "0x402DB29")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetScoreList;

			// Token: 0x0402DB2A RID: 187178
			[Token(Token = "0x402DB2A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
