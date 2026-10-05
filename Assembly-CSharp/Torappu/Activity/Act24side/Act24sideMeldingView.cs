using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075B7 RID: 30135
	[Token(Token = "0x20075B7")]
	public class Act24sideMeldingView : DataBinder<Act24sideMeldingProperty>
	{
		// Token: 0x0602A689 RID: 173705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A689")]
		[Address(RVA = "0x26184A0", Offset = "0x26170A0", VA = "0x1826184A0", Slot = "7")]
		public override void OnValueChanged(Act24sideMeldingProperty property)
		{
		}

		// Token: 0x0602A68A RID: 173706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A68A")]
		[Address(RVA = "0x2618260", Offset = "0x2616E60", VA = "0x182618260")]
		public void InitView(UIPage page)
		{
		}

		// Token: 0x0602A68B RID: 173707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A68B")]
		[Address(RVA = "0x2618B80", Offset = "0x2617780", VA = "0x182618B80")]
		public void TryScrollGachaBoxToRemainCountRarePart()
		{
		}

		// Token: 0x0602A68C RID: 173708 RVA: 0x000D8480 File Offset: 0x000D6680
		[Token(Token = "0x602A68C")]
		[Address(RVA = "0x2618AE0", Offset = "0x26176E0", VA = "0x182618AE0")]
		public float TryPlayMeldingSucSequnce(string gachaBoxId, List<Act24sideMeldingProgressChangeInfo> changeInfoList)
		{
			return 0f;
		}

		// Token: 0x0602A68D RID: 173709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A68D")]
		[Address(RVA = "0x2618A50", Offset = "0x2617650", VA = "0x182618A50")]
		public void TryPauseInputProgressTweening()
		{
		}

		// Token: 0x0602A68E RID: 173710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A68E")]
		[Address(RVA = "0x2617A60", Offset = "0x2616660", VA = "0x182617A60")]
		public void ClearMeldingSucSeq()
		{
		}

		// Token: 0x0602A68F RID: 173711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A68F")]
		[Address(RVA = "0x2618EC0", Offset = "0x2617AC0", VA = "0x182618EC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A690 RID: 173712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A690")]
		[Address(RVA = "0x26196F0", Offset = "0x26182F0", VA = "0x1826196F0")]
		private void _PlaySwitchGachaBoxAnim(bool isFirst, bool isFastMode)
		{
		}

		// Token: 0x0602A691 RID: 173713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A691")]
		[Address(RVA = "0x2618D60", Offset = "0x2617960", VA = "0x182618D60")]
		private void _InitGachaBoxes()
		{
		}

		// Token: 0x0602A692 RID: 173714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A692")]
		[Address(RVA = "0x2619840", Offset = "0x2618440", VA = "0x182619840")]
		private void _RenderGachaBoxes()
		{
		}

		// Token: 0x0602A693 RID: 173715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A693")]
		[Address(RVA = "0x261A000", Offset = "0x2618C00", VA = "0x18261A000")]
		private void _TryScrollGachasToProperLine()
		{
		}

		// Token: 0x0602A694 RID: 173716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A694")]
		[Address(RVA = "0x2619500", Offset = "0x2618100", VA = "0x182619500")]
		private void _PlayGachaBoxAndSlotSwitchAnim(bool isShow, bool isFastMode)
		{
		}

		// Token: 0x0602A695 RID: 173717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A695")]
		[Address(RVA = "0x2619610", Offset = "0x2618210", VA = "0x182619610")]
		private void _PlayInputMeldingProgressSwitchAnim(bool isFastMode)
		{
		}

		// Token: 0x0602A696 RID: 173718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A696")]
		[Address(RVA = "0x2618CF0", Offset = "0x26178F0", VA = "0x182618CF0")]
		private void _ClearInputCache()
		{
		}

		// Token: 0x0602A697 RID: 173719 RVA: 0x000D8498 File Offset: 0x000D6698
		[Token(Token = "0x602A697")]
		[Address(RVA = "0x2619A10", Offset = "0x2618610", VA = "0x182619A10")]
		private float _TryPlayMeldingSucProgressSeq(string gachaId, List<Act24sideMeldingProgressChangeInfo> changeInfoList)
		{
			return 0f;
		}

		// Token: 0x0602A698 RID: 173720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A698")]
		[Address(RVA = "0x2619990", Offset = "0x2618590", VA = "0x182619990")]
		private void _SetQuickInputBlockShow(bool show)
		{
		}

		// Token: 0x0602A699 RID: 173721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A699")]
		[Address(RVA = "0x26181C0", Offset = "0x2616DC0", VA = "0x1826181C0")]
		public void EventOnSwitchGachaPool()
		{
		}

		// Token: 0x0602A69A RID: 173722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A69A")]
		[Address(RVA = "0x2617F30", Offset = "0x2616B30", VA = "0x182617F30")]
		public void EventOnFastInput()
		{
		}

		// Token: 0x0602A69B RID: 173723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A69B")]
		[Address(RVA = "0x2617E90", Offset = "0x2616A90", VA = "0x182617E90")]
		public void EventOnClearAllInput()
		{
		}

		// Token: 0x0602A69C RID: 173724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A69C")]
		[Address(RVA = "0x2617DA0", Offset = "0x26169A0", VA = "0x182617DA0")]
		public void EventOnChoiceDetailShow()
		{
		}

		// Token: 0x0602A69D RID: 173725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A69D")]
		[Address(RVA = "0x2617CB0", Offset = "0x26168B0", VA = "0x182617CB0")]
		public void EventOnChoiceDetailHide()
		{
		}

		// Token: 0x0602A69E RID: 173726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A69E")]
		[Address(RVA = "0x2618030", Offset = "0x2616C30", VA = "0x182618030")]
		public void EventOnMeldClick()
		{
		}

		// Token: 0x0602A69F RID: 173727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A69F")]
		[Address(RVA = "0x2618130", Offset = "0x2616D30", VA = "0x182618130")]
		public void EventOnQuickInputClick()
		{
		}

		// Token: 0x0602A6A0 RID: 173728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A6A0")]
		[Address(RVA = "0x261A1D0", Offset = "0x2618DD0", VA = "0x18261A1D0")]
		public Act24sideMeldingView()
		{
		}

		// Token: 0x0403D05F RID: 249951
		[Token(Token = "0x403D05F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("gacha")]
		private List<Act24sideMeldingGoodGroupView> _gachaGroupList;

		// Token: 0x0403D060 RID: 249952
		[Token(Token = "0x403D060")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("choice")]
		private CanvasGroup _contentDetailCanvas;

		// Token: 0x0403D061 RID: 249953
		[Token(Token = "0x403D061")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("choice")]
		private RectTransform _transContentDetail;

		// Token: 0x0403D062 RID: 249954
		[Token(Token = "0x403D062")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("choice")]
		private Vector2 _contentDetailHidePos;

		// Token: 0x0403D063 RID: 249955
		[Token(Token = "0x403D063")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("choice")]
		private Vector2 _contentDetailShowPos;

		// Token: 0x0403D064 RID: 249956
		[Token(Token = "0x403D064")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("choice")]
		private SimpleLayoutContent _layoutContentMeldingDetail;

		// Token: 0x0403D065 RID: 249957
		[Token(Token = "0x403D065")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("choice")]
		private SimpleLayoutContent _layoutContentMeldingSimple;

		// Token: 0x0403D066 RID: 249958
		[Token(Token = "0x403D066")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("melding Only for Act24side")]
		private CanvasGroup _canvasMeldingBtnGray;

		// Token: 0x0403D067 RID: 249959
		[Token(Token = "0x403D067")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("melding Only for Act24side")]
		private CanvasGroup _canvasMeldingBtnNormal;

		// Token: 0x0403D068 RID: 249960
		[Token(Token = "0x403D068")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("melding")]
		private UIAnimationLocation _animMeldingBtnSwitch;

		// Token: 0x0403D069 RID: 249961
		[Token(Token = "0x403D069")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("melding")]
		private Slider _sliderMeldingProgress;

		// Token: 0x0403D06A RID: 249962
		[Token(Token = "0x403D06A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("melding")]
		private GameObject _objFastInputBtn;

		// Token: 0x0403D06B RID: 249963
		[Token(Token = "0x403D06B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("melding")]
		private GameObject _objClearAllInputBtn;

		// Token: 0x0403D06C RID: 249964
		[Token(Token = "0x403D06C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("melding")]
		private GameObject _objBlockerQuickInput;

		// Token: 0x0403D06D RID: 249965
		[Token(Token = "0x403D06D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("effect Only for Act24side")]
		private UICommonPageEffectHolder _effectMeldingGlowingHolder;

		// Token: 0x0403D06E RID: 249966
		[Token(Token = "0x403D06E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("effect Only for Act24side")]
		private UICommonPageEffectHolder _effectMeldingTailHolder;

		// Token: 0x0403D06F RID: 249967
		[Token(Token = "0x403D06F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("effect")]
		private UIParticle _effectMeldingGlowing;

		// Token: 0x0403D070 RID: 249968
		[Token(Token = "0x403D070")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("effect")]
		private UIParticle _effectMeldingTail;

		// Token: 0x0403D071 RID: 249969
		[Token(Token = "0x403D071")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("effect")]
		private GameObject _effectMeldingTailObj;

		// Token: 0x0403D072 RID: 249970
		[Token(Token = "0x403D072")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Act24sideMeldingSwitchTweenAbstractHolder _switchTweenHolder;

		// Token: 0x0403D073 RID: 249971
		[Token(Token = "0x403D073")]
		[FieldOffset(Offset = "0xC8")]
		private Act24sideMeldingViewModel m_model;

		// Token: 0x0403D074 RID: 249972
		[Token(Token = "0x403D074")]
		[FieldOffset(Offset = "0xD0")]
		private Act24sideMeldingView.MeldingDetailAdapter m_meldingDetailAdapter;

		// Token: 0x0403D075 RID: 249973
		[Token(Token = "0x403D075")]
		[FieldOffset(Offset = "0xD8")]
		private Act24sideMeldingView.MeldingSimpleAdapter m_meldingSimpleAdapter;

		// Token: 0x0403D076 RID: 249974
		[Token(Token = "0x403D076")]
		[FieldOffset(Offset = "0xE0")]
		private UISwitchTween m_meldingBtnSwitchTween;

		// Token: 0x0403D077 RID: 249975
		[Token(Token = "0x403D077")]
		[FieldOffset(Offset = "0xE8")]
		private bool m_hasInited;

		// Token: 0x0403D078 RID: 249976
		[Token(Token = "0x403D078")]
		[FieldOffset(Offset = "0xE9")]
		private bool m_isChoosing;

		// Token: 0x0403D079 RID: 249977
		[Token(Token = "0x403D079")]
		[FieldOffset(Offset = "0xF0")]
		private string m_cachedCurGachaBoxId;

		// Token: 0x0403D07A RID: 249978
		[Token(Token = "0x403D07A")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_isGachaGroup1Scrolled;

		// Token: 0x0403D07B RID: 249979
		[Token(Token = "0x403D07B")]
		[FieldOffset(Offset = "0xF9")]
		private bool m_isGachaGroup2Scrolled;

		// Token: 0x0403D07C RID: 249980
		[Token(Token = "0x403D07C")]
		[FieldOffset(Offset = "0x100")]
		private FadeTranslationSwitchTween m_contentDetailTween;

		// Token: 0x0403D07D RID: 249981
		[Token(Token = "0x403D07D")]
		[FieldOffset(Offset = "0x108")]
		private bool m_isSwitchBoxAnimFastMode;

		// Token: 0x0403D07E RID: 249982
		[Token(Token = "0x403D07E")]
		[FieldOffset(Offset = "0x110")]
		private UIStateFinder m_finder;

		// Token: 0x0403D07F RID: 249983
		[Token(Token = "0x403D07F")]
		[FieldOffset(Offset = "0x120")]
		private bool m_isMeldingInputProgressAnimFastMode;

		// Token: 0x0403D080 RID: 249984
		[Token(Token = "0x403D080")]
		[FieldOffset(Offset = "0x124")]
		private int m_cachedInputMeldingPrice;

		// Token: 0x0403D081 RID: 249985
		[Token(Token = "0x403D081")]
		[FieldOffset(Offset = "0x128")]
		private Sequence m_cachedMeldingSucTween;

		// Token: 0x0403D082 RID: 249986
		[Token(Token = "0x403D082")]
		[FieldOffset(Offset = "0x130")]
		private Sequence m_cachedMeldingSucGlowingTween;

		// Token: 0x0403D083 RID: 249987
		[Token(Token = "0x403D083")]
		[FieldOffset(Offset = "0x138")]
		private List<UISwitchTween.TweenWrapper> m_progressSlotLightTweenList;

		// Token: 0x0403D084 RID: 249988
		[Token(Token = "0x403D084")]
		[FieldOffset(Offset = "0x140")]
		private FadeSwitchTween m_meldBtnGrayTween;

		// Token: 0x0403D085 RID: 249989
		[Token(Token = "0x403D085")]
		[FieldOffset(Offset = "0x148")]
		private FadeSwitchTween m_meldBtnNormalTween;

		// Token: 0x0403D086 RID: 249990
		[Token(Token = "0x403D086")]
		[FieldOffset(Offset = "0x150")]
		private UIPage m_page;

		// Token: 0x0403D087 RID: 249991
		[Token(Token = "0x403D087")]
		private const float MELDING_SUC_GLOWING_ANIM_DUR = 0.3f;

		// Token: 0x0403D088 RID: 249992
		[Token(Token = "0x403D088")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403D089 RID: 249993
		[Token(Token = "0x403D089")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitView;

		// Token: 0x0403D08A RID: 249994
		[Token(Token = "0x403D08A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryScrollGachaBoxToRemainCountRarePart;

		// Token: 0x0403D08B RID: 249995
		[Token(Token = "0x403D08B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryPlayMeldingSucSequnce;

		// Token: 0x0403D08C RID: 249996
		[Token(Token = "0x403D08C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryPauseInputProgressTweening;

		// Token: 0x0403D08D RID: 249997
		[Token(Token = "0x403D08D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ClearMeldingSucSeq;

		// Token: 0x0403D08E RID: 249998
		[Token(Token = "0x403D08E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D08F RID: 249999
		[Token(Token = "0x403D08F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlaySwitchGachaBoxAnim;

		// Token: 0x0403D090 RID: 250000
		[Token(Token = "0x403D090")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitGachaBoxes;

		// Token: 0x0403D091 RID: 250001
		[Token(Token = "0x403D091")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderGachaBoxes;

		// Token: 0x0403D092 RID: 250002
		[Token(Token = "0x403D092")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryScrollGachasToProperLine;

		// Token: 0x0403D093 RID: 250003
		[Token(Token = "0x403D093")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__PlayGachaBoxAndSlotSwitchAnim;

		// Token: 0x0403D094 RID: 250004
		[Token(Token = "0x403D094")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayInputMeldingProgressSwitchAnim;

		// Token: 0x0403D095 RID: 250005
		[Token(Token = "0x403D095")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ClearInputCache;

		// Token: 0x0403D096 RID: 250006
		[Token(Token = "0x403D096")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__TryPlayMeldingSucProgressSeq;

		// Token: 0x0403D097 RID: 250007
		[Token(Token = "0x403D097")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetQuickInputBlockShow;

		// Token: 0x0403D098 RID: 250008
		[Token(Token = "0x403D098")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_EventOnSwitchGachaPool;

		// Token: 0x0403D099 RID: 250009
		[Token(Token = "0x403D099")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnFastInput;

		// Token: 0x0403D09A RID: 250010
		[Token(Token = "0x403D09A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnClearAllInput;

		// Token: 0x0403D09B RID: 250011
		[Token(Token = "0x403D09B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnChoiceDetailShow;

		// Token: 0x0403D09C RID: 250012
		[Token(Token = "0x403D09C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnChoiceDetailHide;

		// Token: 0x0403D09D RID: 250013
		[Token(Token = "0x403D09D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnMeldClick;

		// Token: 0x0403D09E RID: 250014
		[Token(Token = "0x403D09E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnQuickInputClick;

		// Token: 0x0403D09F RID: 250015
		[Token(Token = "0x403D09F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075B8 RID: 30136
		[Token(Token = "0x20075B8")]
		private class MeldingDetailAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A6A3 RID: 173731 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A6A3")]
			[Address(RVA = "0x261C760", Offset = "0x261B360", VA = "0x18261C760")]
			public MeldingDetailAdapter(Act24sideMeldingView closure)
			{
			}

			// Token: 0x170063BE RID: 25534
			// (get) Token: 0x0602A6A4 RID: 173732 RVA: 0x000D84B0 File Offset: 0x000D66B0
			[Token(Token = "0x170063BE")]
			public override int count
			{
				[Token(Token = "0x602A6A4")]
				[Address(RVA = "0x261C7E0", Offset = "0x261B3E0", VA = "0x18261C7E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A6A5 RID: 173733 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A6A5")]
			[Address(RVA = "0x261C590", Offset = "0x261B190", VA = "0x18261C590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D0A0 RID: 250016
			[Token(Token = "0x403D0A0")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideMeldingView m_closure;

			// Token: 0x0403D0A1 RID: 250017
			[Token(Token = "0x403D0A1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D0A2 RID: 250018
			[Token(Token = "0x403D0A2")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D0A3 RID: 250019
			[Token(Token = "0x403D0A3")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020075B9 RID: 30137
		[Token(Token = "0x20075B9")]
		private class MeldingSimpleAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A6A6 RID: 173734 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A6A6")]
			[Address(RVA = "0x261DDA0", Offset = "0x261C9A0", VA = "0x18261DDA0")]
			public MeldingSimpleAdapter(Act24sideMeldingView closure)
			{
			}

			// Token: 0x170063BF RID: 25535
			// (get) Token: 0x0602A6A7 RID: 173735 RVA: 0x000D84C8 File Offset: 0x000D66C8
			[Token(Token = "0x170063BF")]
			public override int count
			{
				[Token(Token = "0x602A6A7")]
				[Address(RVA = "0x261DE20", Offset = "0x261CA20", VA = "0x18261DE20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A6A8 RID: 173736 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A6A8")]
			[Address(RVA = "0x261DB90", Offset = "0x261C790", VA = "0x18261DB90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D0A4 RID: 250020
			[Token(Token = "0x403D0A4")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideMeldingView m_closure;

			// Token: 0x0403D0A5 RID: 250021
			[Token(Token = "0x403D0A5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D0A6 RID: 250022
			[Token(Token = "0x403D0A6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D0A7 RID: 250023
			[Token(Token = "0x403D0A7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
