using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059AA RID: 22954
	[Token(Token = "0x20059AA")]
	public class CrisisV2MapBagView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021759 RID: 137049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021759")]
		[Address(RVA = "0x1BC66C0", Offset = "0x1BC52C0", VA = "0x181BC66C0")]
		private void _SetPos(Vector2 pos, Vector2 bagSize)
		{
		}

		// Token: 0x0602175A RID: 137050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602175A")]
		[Address(RVA = "0x1BC52F0", Offset = "0x1BC3EF0", VA = "0x181BC52F0")]
		public void Init(Vector2 bagPos, Vector2 bagSize)
		{
		}

		// Token: 0x0602175B RID: 137051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602175B")]
		[Address(RVA = "0x1BC54D0", Offset = "0x1BC40D0", VA = "0x181BC54D0")]
		public void Render(CrisisV2MapBagModel bagModel, CrisisV2MapModel mapModel, bool isVisisble, bool isHighLight)
		{
		}

		// Token: 0x0602175C RID: 137052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602175C")]
		[Address(RVA = "0x1BC5D00", Offset = "0x1BC4900", VA = "0x181BC5D00")]
		private void _PlayFocusAnimIfNecessary(bool isBagFocus, int interactId)
		{
		}

		// Token: 0x0602175D RID: 137053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602175D")]
		[Address(RVA = "0x1BC6020", Offset = "0x1BC4C20", VA = "0x181BC6020")]
		private void _Render(CrisisV2MapBagModel bagModel, CrisisV2MapBagStatus bagStatus, CrisisV2Progress nodeProgress)
		{
		}

		// Token: 0x0602175E RID: 137054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602175E")]
		[Address(RVA = "0x1BC5E90", Offset = "0x1BC4A90", VA = "0x181BC5E90")]
		private void _RegisterTutorialGoIfNeed(string bagKey, string titleKey, string detailKey)
		{
		}

		// Token: 0x0602175F RID: 137055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602175F")]
		[Address(RVA = "0x1BC5930", Offset = "0x1BC4530", VA = "0x181BC5930")]
		private void _EnsureHighLightSwitchTween()
		{
		}

		// Token: 0x06021760 RID: 137056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021760")]
		[Address(RVA = "0x1BC5A20", Offset = "0x1BC4620", VA = "0x181BC5A20")]
		private void _PlayBreathLightTween(bool isPlay)
		{
		}

		// Token: 0x06021761 RID: 137057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021761")]
		[Address(RVA = "0x1BC5050", Offset = "0x1BC3C50", VA = "0x181BC5050")]
		public void EventOnBagClick()
		{
		}

		// Token: 0x06021762 RID: 137058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021762")]
		[Address(RVA = "0x1BC51A0", Offset = "0x1BC3DA0", VA = "0x181BC51A0")]
		public void EventOnOpenBagDetail()
		{
		}

		// Token: 0x06021763 RID: 137059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021763")]
		[Address(RVA = "0x1BC6790", Offset = "0x1BC5390", VA = "0x181BC6790")]
		public CrisisV2MapBagView()
		{
		}

		// Token: 0x0402DABE RID: 187070
		[Token(Token = "0x402DABE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _bagProgressBgToggle;

		// Token: 0x0402DABF RID: 187071
		[Token(Token = "0x402DABF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _dimensionBgToggle;

		// Token: 0x0402DAC0 RID: 187072
		[Token(Token = "0x402DAC0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _nodeScoreBgToggle;

		// Token: 0x0402DAC1 RID: 187073
		[Token(Token = "0x402DAC1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _bagScoreBgToggle;

		// Token: 0x0402DAC2 RID: 187074
		[Token(Token = "0x402DAC2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _bagScoreGo;

		// Token: 0x0402DAC3 RID: 187075
		[Token(Token = "0x402DAC3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textNodeScoreCurrent;

		// Token: 0x0402DAC4 RID: 187076
		[Token(Token = "0x402DAC4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textNodeScoreTotal;

		// Token: 0x0402DAC5 RID: 187077
		[Token(Token = "0x402DAC5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textBagScore;

		// Token: 0x0402DAC6 RID: 187078
		[Token(Token = "0x402DAC6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _colorUnselectScore;

		// Token: 0x0402DAC7 RID: 187079
		[Token(Token = "0x402DAC7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color _colorSelectCurrentScore;

		// Token: 0x0402DAC8 RID: 187080
		[Token(Token = "0x402DAC8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _colorSelectTotalScore;

		// Token: 0x0402DAC9 RID: 187081
		[Token(Token = "0x402DAC9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _colorSelectBagScore;

		// Token: 0x0402DACA RID: 187082
		[Token(Token = "0x402DACA")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _colorFullBagScore;

		// Token: 0x0402DACB RID: 187083
		[Token(Token = "0x402DACB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402DACC RID: 187084
		[Token(Token = "0x402DACC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _colorUnselectDesc;

		// Token: 0x0402DACD RID: 187085
		[Token(Token = "0x402DACD")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Color _colorSelectDesc;

		// Token: 0x0402DACE RID: 187086
		[Token(Token = "0x402DACE")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _completedIconGo;

		// Token: 0x0402DACF RID: 187087
		[Token(Token = "0x402DACF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Slider _sliderProgerss;

		// Token: 0x0402DAD0 RID: 187088
		[Token(Token = "0x402DAD0")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _sliderTweenDuration;

		// Token: 0x0402DAD1 RID: 187089
		[Token(Token = "0x402DAD1")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402DAD2 RID: 187090
		[Token(Token = "0x402DAD2")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float _unreachAlpha;

		// Token: 0x0402DAD3 RID: 187091
		[Token(Token = "0x402DAD3")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _unreachMaskGo;

		// Token: 0x0402DAD4 RID: 187092
		[Token(Token = "0x402DAD4")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private UIAtlasImage _imgDimension;

		// Token: 0x0402DAD5 RID: 187093
		[Token(Token = "0x402DAD5")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAtlasObject _dimensionAtlas;

		// Token: 0x0402DAD6 RID: 187094
		[Token(Token = "0x402DAD6")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0402DAD7 RID: 187095
		[Token(Token = "0x402DAD7")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private UIAnimationLocation _animFocus;

		// Token: 0x0402DAD8 RID: 187096
		[Token(Token = "0x402DAD8")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _panelTitle;

		// Token: 0x0402DAD9 RID: 187097
		[Token(Token = "0x402DAD9")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private GameObject _panelBag;

		// Token: 0x0402DADA RID: 187098
		[Token(Token = "0x402DADA")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private GameObject _panelDetail;

		// Token: 0x0402DADB RID: 187099
		[Token(Token = "0x402DADB")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private CanvasGroup _highlightSwitchGroup;

		// Token: 0x0402DADC RID: 187100
		[Token(Token = "0x402DADC")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private CanvasGroup _highlightBreathGroup;

		// Token: 0x0402DADD RID: 187101
		[Token(Token = "0x402DADD")]
		[FieldOffset(Offset = "0x158")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DADE RID: 187102
		[Token(Token = "0x402DADE")]
		[FieldOffset(Offset = "0x168")]
		private CrisisV2MapBagModel m_bagModel;

		// Token: 0x0402DADF RID: 187103
		[Token(Token = "0x402DADF")]
		[FieldOffset(Offset = "0x170")]
		private AnimationSwitchTween m_animSwitch;

		// Token: 0x0402DAE0 RID: 187104
		[Token(Token = "0x402DAE0")]
		[FieldOffset(Offset = "0x178")]
		private Tween m_focusTween;

		// Token: 0x0402DAE1 RID: 187105
		[Token(Token = "0x402DAE1")]
		[FieldOffset(Offset = "0x180")]
		private int m_cacheInteractId;

		// Token: 0x0402DAE2 RID: 187106
		[Token(Token = "0x402DAE2")]
		[FieldOffset(Offset = "0x188")]
		private FadeSwitchTween m_highlightSwitchTween;

		// Token: 0x0402DAE3 RID: 187107
		[Token(Token = "0x402DAE3")]
		[FieldOffset(Offset = "0x190")]
		private Tween m_highlightBreathLightTween;

		// Token: 0x0402DAE4 RID: 187108
		[Token(Token = "0x402DAE4")]
		[FieldOffset(Offset = "0x198")]
		private Tween m_sliderTween;

		// Token: 0x0402DAE5 RID: 187109
		[Token(Token = "0x402DAE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0402DAE6 RID: 187110
		[Token(Token = "0x402DAE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402DAE7 RID: 187111
		[Token(Token = "0x402DAE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DAE8 RID: 187112
		[Token(Token = "0x402DAE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayFocusAnimIfNecessary;

		// Token: 0x0402DAE9 RID: 187113
		[Token(Token = "0x402DAE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402DAEA RID: 187114
		[Token(Token = "0x402DAEA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGoIfNeed;

		// Token: 0x0402DAEB RID: 187115
		[Token(Token = "0x402DAEB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EnsureHighLightSwitchTween;

		// Token: 0x0402DAEC RID: 187116
		[Token(Token = "0x402DAEC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayBreathLightTween;

		// Token: 0x0402DAED RID: 187117
		[Token(Token = "0x402DAED")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBagClick;

		// Token: 0x0402DAEE RID: 187118
		[Token(Token = "0x402DAEE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnOpenBagDetail;

		// Token: 0x0402DAEF RID: 187119
		[Token(Token = "0x402DAEF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
