using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A08 RID: 10760
	[Token(Token = "0x2002A08")]
	public class UIBattleLegionIntermissionTipsPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011DA0 RID: 73120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DA0")]
		[Address(RVA = "0x9BBF60", Offset = "0x9BAB60", VA = "0x1809BBF60")]
		public void UpdateGameInfo()
		{
		}

		// Token: 0x06011DA1 RID: 73121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DA1")]
		[Address(RVA = "0x9BBE90", Offset = "0x9BAA90", VA = "0x1809BBE90")]
		public void OnCurWaveWillFinish(float showTime, int goldForWaveEnd)
		{
		}

		// Token: 0x06011DA2 RID: 73122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DA2")]
		[Address(RVA = "0x9BC210", Offset = "0x9BAE10", VA = "0x1809BC210")]
		private void _Show()
		{
		}

		// Token: 0x06011DA3 RID: 73123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DA3")]
		[Address(RVA = "0x9BC070", Offset = "0x9BAC70", VA = "0x1809BC070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06011DA4 RID: 73124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DA4")]
		[Address(RVA = "0x9BC190", Offset = "0x9BAD90", VA = "0x1809BC190")]
		private void _PlayRestTipsTween()
		{
		}

		// Token: 0x06011DA5 RID: 73125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011DA5")]
		[Address(RVA = "0x9BC3F0", Offset = "0x9BAFF0", VA = "0x1809BC3F0")]
		public UIBattleLegionIntermissionTipsPanel()
		{
		}

		// Token: 0x04014121 RID: 82209
		[Token(Token = "0x4014121")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _objRestPart;

		// Token: 0x04014122 RID: 82210
		[Token(Token = "0x4014122")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasRestSlider;

		// Token: 0x04014123 RID: 82211
		[Token(Token = "0x4014123")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasRestLine;

		// Token: 0x04014124 RID: 82212
		[Token(Token = "0x4014124")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasRestTips;

		// Token: 0x04014125 RID: 82213
		[Token(Token = "0x4014125")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _transRestLine;

		// Token: 0x04014126 RID: 82214
		[Token(Token = "0x4014126")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Slider _sliderResetTime;

		// Token: 0x04014127 RID: 82215
		[Token(Token = "0x4014127")]
		[FieldOffset(Offset = "0x48")]
		private float m_restSliderChangeTime;

		// Token: 0x04014128 RID: 82216
		[Token(Token = "0x4014128")]
		[FieldOffset(Offset = "0x50")]
		private UIBattleLegionIntermissionTipsPanel.IntermissionPanelRestShowTween m_RestTween;

		// Token: 0x04014129 RID: 82217
		[Token(Token = "0x4014129")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0401412A RID: 82218
		[Token(Token = "0x401412A")]
		[FieldOffset(Offset = "0x5C")]
		private float m_prepareTimeForNextWave;

		// Token: 0x0401412B RID: 82219
		[Token(Token = "0x401412B")]
		[FieldOffset(Offset = "0x60")]
		private float m_maxPrepareTime;

		// Token: 0x0401412C RID: 82220
		[Token(Token = "0x401412C")]
		[FieldOffset(Offset = "0x64")]
		private bool m_preparingForNextWave;

		// Token: 0x0401412D RID: 82221
		[Token(Token = "0x401412D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateGameInfo;

		// Token: 0x0401412E RID: 82222
		[Token(Token = "0x401412E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCurWaveWillFinish;

		// Token: 0x0401412F RID: 82223
		[Token(Token = "0x401412F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Show;

		// Token: 0x04014130 RID: 82224
		[Token(Token = "0x4014130")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04014131 RID: 82225
		[Token(Token = "0x4014131")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayRestTipsTween;

		// Token: 0x04014132 RID: 82226
		[Token(Token = "0x4014132")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A09 RID: 10761
		[Token(Token = "0x2002A09")]
		private class IntermissionPanelRestShowTween : IHotfixable
		{
			// Token: 0x06011DA6 RID: 73126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DA6")]
			[Address(RVA = "0x9ACF50", Offset = "0x9ABB50", VA = "0x1809ACF50")]
			public IntermissionPanelRestShowTween(UIBattleLegionIntermissionTipsPanel closure)
			{
			}

			// Token: 0x06011DA7 RID: 73127 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DA7")]
			[Address(RVA = "0x9AC720", Offset = "0x9AB320", VA = "0x1809AC720")]
			public void PlayTween()
			{
			}

			// Token: 0x06011DA8 RID: 73128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011DA8")]
			[Address(RVA = "0x9ACCA0", Offset = "0x9AB8A0", VA = "0x1809ACCA0")]
			public void ResetToState(bool isShow)
			{
			}

			// Token: 0x04014133 RID: 82227
			[Token(Token = "0x4014133")]
			[FieldOffset(Offset = "0x10")]
			private UIBattleLegionIntermissionTipsPanel m_closure;

			// Token: 0x04014134 RID: 82228
			[Token(Token = "0x4014134")]
			[FieldOffset(Offset = "0x18")]
			private UISwitchTween.TweenWrapper m_tween;

			// Token: 0x04014135 RID: 82229
			[Token(Token = "0x4014135")]
			private const float REST_SLIDER_START_TIME = 1.08f;

			// Token: 0x04014136 RID: 82230
			[Token(Token = "0x4014136")]
			private const float REST_SLIDER_SHOW_DUR = 0.28f;

			// Token: 0x04014137 RID: 82231
			[Token(Token = "0x4014137")]
			private const float REST_TIPS_START_TIME = 0.6f;

			// Token: 0x04014138 RID: 82232
			[Token(Token = "0x4014138")]
			private const float REST_TIPS_SHOW_DUR = 0.4f;

			// Token: 0x04014139 RID: 82233
			[Token(Token = "0x4014139")]
			private const float REST_LINE_START_FADE_TIME = 3.92f;

			// Token: 0x0401413A RID: 82234
			[Token(Token = "0x401413A")]
			private const float REST_LINE_FADE_DUR = 0.8f;

			// Token: 0x0401413B RID: 82235
			[Token(Token = "0x401413B")]
			private const float REST_LINE_MOVE_DUR = 4.6f;

			// Token: 0x0401413C RID: 82236
			[Token(Token = "0x401413C")]
			private const float REST_TIPS_START_FADE_TIME = 4.4f;

			// Token: 0x0401413D RID: 82237
			[Token(Token = "0x401413D")]
			private const float REST_TIPS_FADE_DUR = 0.56f;

			// Token: 0x0401413E RID: 82238
			[Token(Token = "0x401413E")]
			private const float REST_SLIDER_VALUE_START_DELAY = 1.2f;

			// Token: 0x0401413F RID: 82239
			[Token(Token = "0x401413F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 REST_TIPS_LINE_START_POS;

			// Token: 0x04014140 RID: 82240
			[Token(Token = "0x4014140")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 REST_TIPS_LINE_END_POS;

			// Token: 0x04014141 RID: 82241
			[Token(Token = "0x4014141")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04014142 RID: 82242
			[Token(Token = "0x4014142")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayTween;

			// Token: 0x04014143 RID: 82243
			[Token(Token = "0x4014143")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
