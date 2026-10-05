using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RecalRune
{
	// Token: 0x020047B5 RID: 18357
	[Token(Token = "0x20047B5")]
	public class RecalRuneStageRunePackRuneItem : RecalRuneStageRunePackItemBase
	{
		// Token: 0x1700421E RID: 16926
		// (get) Token: 0x0601BCB6 RID: 113846 RVA: 0x000A64A0 File Offset: 0x000A46A0
		[Token(Token = "0x1700421E")]
		public override float preferredWidth
		{
			[Token(Token = "0x601BCB6")]
			[Address(RVA = "0x15322A0", Offset = "0x1530EA0", VA = "0x1815322A0", Slot = "13")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700421F RID: 16927
		// (get) Token: 0x0601BCB7 RID: 113847 RVA: 0x000A64B8 File Offset: 0x000A46B8
		[Token(Token = "0x1700421F")]
		public override float preferredHeight
		{
			[Token(Token = "0x601BCB7")]
			[Address(RVA = "0x1532200", Offset = "0x1530E00", VA = "0x181532200", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0601BCB8 RID: 113848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCB8")]
		[Address(RVA = "0x1531670", Offset = "0x1530270", VA = "0x181531670")]
		public void OnClickEvent()
		{
		}

		// Token: 0x0601BCB9 RID: 113849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCB9")]
		[Address(RVA = "0x1531790", Offset = "0x1530390", VA = "0x181531790", Slot = "15")]
		public override void Render(IRecalRunePack pack)
		{
		}

		// Token: 0x0601BCBA RID: 113850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCBA")]
		[Address(RVA = "0x15319C0", Offset = "0x15305C0", VA = "0x1815319C0", Slot = "16")]
		public override void SetFocus(bool isFocused)
		{
		}

		// Token: 0x0601BCBB RID: 113851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCBB")]
		[Address(RVA = "0x1531C30", Offset = "0x1530830", VA = "0x181531C30")]
		private void _InitFocusStatusIfNot()
		{
		}

		// Token: 0x0601BCBC RID: 113852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCBC")]
		[Address(RVA = "0x1531DF0", Offset = "0x15309F0", VA = "0x181531DF0")]
		private void _TweenFocusState(float focusStayDur)
		{
		}

		// Token: 0x0601BCBD RID: 113853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCBD")]
		[Address(RVA = "0x15320E0", Offset = "0x1530CE0", VA = "0x1815320E0")]
		private void _TweenUnFocusState()
		{
		}

		// Token: 0x0601BCBE RID: 113854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCBE")]
		[Address(RVA = "0x1531D20", Offset = "0x1530920", VA = "0x181531D20")]
		private void _ShowOuterGlow(bool show)
		{
		}

		// Token: 0x0601BCBF RID: 113855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCBF")]
		[Address(RVA = "0x1531B90", Offset = "0x1530790", VA = "0x181531B90")]
		private void _ClearFocusTween()
		{
		}

		// Token: 0x0601BCC0 RID: 113856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCC0")]
		[Address(RVA = "0x1532160", Offset = "0x1530D60", VA = "0x181532160")]
		public RecalRuneStageRunePackRuneItem()
		{
		}

		// Token: 0x0601BCC1 RID: 113857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BCC1")]
		[Address(RVA = "0x15312F0", Offset = "0x152FEF0", VA = "0x1815312F0")]
		private void <>xLuaBaseProxy_SetFocus(bool P0)
		{
		}

		// Token: 0x04024265 RID: 148069
		[Token(Token = "0x4024265")]
		private const float FOCUS_STAY_DUR = 1.5f;

		// Token: 0x04024266 RID: 148070
		[Token(Token = "0x4024266")]
		private const float OUTER_GLOW_FOCUS_FADE_IN_DUR = 0.16f;

		// Token: 0x04024267 RID: 148071
		[Token(Token = "0x4024267")]
		private const float OUTER_GLOW_FOCUS_FADE_OUT_DUR = 0.8f;

		// Token: 0x04024268 RID: 148072
		[Token(Token = "0x4024268")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _evenVariant;

		// Token: 0x04024269 RID: 148073
		[Token(Token = "0x4024269")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _fixedVariant;

		// Token: 0x0402426A RID: 148074
		[Token(Token = "0x402426A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _essentialExclusiveVariant;

		// Token: 0x0402426B RID: 148075
		[Token(Token = "0x402426B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rewardingVariant;

		// Token: 0x0402426C RID: 148076
		[Token(Token = "0x402426C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _scoreText;

		// Token: 0x0402426D RID: 148077
		[Token(Token = "0x402426D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _descText;

		// Token: 0x0402426E RID: 148078
		[Token(Token = "0x402426E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _textPadding;

		// Token: 0x0402426F RID: 148079
		[Token(Token = "0x402426F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x04024270 RID: 148080
		[Token(Token = "0x4024270")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _focusGroup;

		// Token: 0x04024271 RID: 148081
		[Token(Token = "0x4024271")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_finder;

		// Token: 0x04024272 RID: 148082
		[Token(Token = "0x4024272")]
		[FieldOffset(Offset = "0x70")]
		private TextGenerator m_textGenerator;

		// Token: 0x04024273 RID: 148083
		[Token(Token = "0x4024273")]
		[FieldOffset(Offset = "0x78")]
		private RecalRuneStageRuneItemViewModel m_cachedItem;

		// Token: 0x04024274 RID: 148084
		[Token(Token = "0x4024274")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedDescription;

		// Token: 0x04024275 RID: 148085
		[Token(Token = "0x4024275")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isFocusInited;

		// Token: 0x04024276 RID: 148086
		[Token(Token = "0x4024276")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_focusTween;

		// Token: 0x04024277 RID: 148087
		[Token(Token = "0x4024277")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_focusOuterGlowTween;

		// Token: 0x04024278 RID: 148088
		[Token(Token = "0x4024278")]
		[NonSerialized]
		private const float FOCUS_BY_CLICK_SELF = 0.4f;

		// Token: 0x04024279 RID: 148089
		[Token(Token = "0x4024279")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_preferredWidth;

		// Token: 0x0402427A RID: 148090
		[Token(Token = "0x402427A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_preferredHeight;

		// Token: 0x0402427B RID: 148091
		[Token(Token = "0x402427B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickEvent;

		// Token: 0x0402427C RID: 148092
		[Token(Token = "0x402427C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402427D RID: 148093
		[Token(Token = "0x402427D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetFocus;

		// Token: 0x0402427E RID: 148094
		[Token(Token = "0x402427E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitFocusStatusIfNot;

		// Token: 0x0402427F RID: 148095
		[Token(Token = "0x402427F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TweenFocusState;

		// Token: 0x04024280 RID: 148096
		[Token(Token = "0x4024280")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TweenUnFocusState;

		// Token: 0x04024281 RID: 148097
		[Token(Token = "0x4024281")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowOuterGlow;

		// Token: 0x04024282 RID: 148098
		[Token(Token = "0x4024282")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearFocusTween;

		// Token: 0x04024283 RID: 148099
		[Token(Token = "0x4024283")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
