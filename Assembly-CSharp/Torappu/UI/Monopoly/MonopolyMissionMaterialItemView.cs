using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004808 RID: 18440
	[Token(Token = "0x2004808")]
	public class MonopolyMissionMaterialItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BE28 RID: 114216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE28")]
		[Address(RVA = "0x1545DA0", Offset = "0x15449A0", VA = "0x181545DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BE29 RID: 114217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE29")]
		[Address(RVA = "0x15450D0", Offset = "0x1543CD0", VA = "0x1815450D0")]
		public void RenderCombo(bool fastMode)
		{
		}

		// Token: 0x0601BE2A RID: 114218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE2A")]
		[Address(RVA = "0x15456D0", Offset = "0x15442D0", VA = "0x1815456D0")]
		public void RenderProgress(MonopolyMissionMaterialViewModel materialItemViewModel, bool isNewMissionWhenGameAction, bool fastMode)
		{
		}

		// Token: 0x0601BE2B RID: 114219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE2B")]
		[Address(RVA = "0x1545240", Offset = "0x1543E40", VA = "0x181545240")]
		public void RenderCompleteStatus(MonopolyMissionMaterialViewModel materialItemViewModel, bool isNewMissionWhenGameAction)
		{
		}

		// Token: 0x0601BE2C RID: 114220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE2C")]
		[Address(RVA = "0x15455D0", Offset = "0x15441D0", VA = "0x1815455D0")]
		public void RenderPreviewTag(MonopolyMissionViewModel missionViewModel, bool isGameAction, bool fastMode)
		{
		}

		// Token: 0x0601BE2D RID: 114221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE2D")]
		[Address(RVA = "0x1545330", Offset = "0x1543F30", VA = "0x181545330")]
		public void RenderPreviewProgress(MonopolyMissionMaterialViewModel materialItemViewModel, MonopolyMissionViewModel missionViewModel, bool fastMode)
		{
		}

		// Token: 0x0601BE2E RID: 114222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE2E")]
		[Address(RVA = "0x1545AF0", Offset = "0x15446F0", VA = "0x181545AF0")]
		public void Render(MonopolyMissionMaterialViewModel materialItemViewModel)
		{
		}

		// Token: 0x0601BE2F RID: 114223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE2F")]
		[Address(RVA = "0x1545F60", Offset = "0x1544B60", VA = "0x181545F60")]
		public MonopolyMissionMaterialItemView()
		{
		}

		// Token: 0x04024547 RID: 148807
		[Token(Token = "0x4024547")]
		private const string TOTAL_SCORE_FORMAT = "/{0}";

		// Token: 0x04024548 RID: 148808
		[Token(Token = "0x4024548")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgMaterialIcon;

		// Token: 0x04024549 RID: 148809
		[Token(Token = "0x4024549")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurrCount;

		// Token: 0x0402454A RID: 148810
		[Token(Token = "0x402454A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textTotalCount;

		// Token: 0x0402454B RID: 148811
		[Token(Token = "0x402454B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlCombo;

		// Token: 0x0402454C RID: 148812
		[Token(Token = "0x402454C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _pnlPreview;

		// Token: 0x0402454D RID: 148813
		[Token(Token = "0x402454D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _canvasGroupPreview;

		// Token: 0x0402454E RID: 148814
		[Token(Token = "0x402454E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2 _pnlPreviewShowPos;

		// Token: 0x0402454F RID: 148815
		[Token(Token = "0x402454F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2 _pnlPreviewHidePos;

		// Token: 0x04024550 RID: 148816
		[Token(Token = "0x4024550")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _pnlPreviewShowDuration;

		// Token: 0x04024551 RID: 148817
		[Token(Token = "0x4024551")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textPreviewCount;

		// Token: 0x04024552 RID: 148818
		[Token(Token = "0x4024552")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Slider _previewCountProgressBar;

		// Token: 0x04024553 RID: 148819
		[Token(Token = "0x4024553")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider _currCountProgressBar;

		// Token: 0x04024554 RID: 148820
		[Token(Token = "0x4024554")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _progressBarTweenDuration;

		// Token: 0x04024555 RID: 148821
		[Token(Token = "0x4024555")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animCombo;

		// Token: 0x04024556 RID: 148822
		[Token(Token = "0x4024556")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _animResourceGain;

		// Token: 0x04024557 RID: 148823
		[Token(Token = "0x4024557")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _pnlComplete;

		// Token: 0x04024558 RID: 148824
		[Token(Token = "0x4024558")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_inited;

		// Token: 0x04024559 RID: 148825
		[Token(Token = "0x4024559")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedResourceId;

		// Token: 0x0402455A RID: 148826
		[Token(Token = "0x402455A")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedCurrCount;

		// Token: 0x0402455B RID: 148827
		[Token(Token = "0x402455B")]
		[FieldOffset(Offset = "0xBC")]
		private int m_cachedTotalCount;

		// Token: 0x0402455C RID: 148828
		[Token(Token = "0x402455C")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402455D RID: 148829
		[Token(Token = "0x402455D")]
		[FieldOffset(Offset = "0xD0")]
		private UISwitchTween m_pnlPreviewShowTween;

		// Token: 0x0402455E RID: 148830
		[Token(Token = "0x402455E")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_previewProgressTween;

		// Token: 0x0402455F RID: 148831
		[Token(Token = "0x402455F")]
		[FieldOffset(Offset = "0xE0")]
		private Tween m_comboTween;

		// Token: 0x04024560 RID: 148832
		[Token(Token = "0x4024560")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_progressTween;

		// Token: 0x04024561 RID: 148833
		[Token(Token = "0x4024561")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024562 RID: 148834
		[Token(Token = "0x4024562")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderCombo;

		// Token: 0x04024563 RID: 148835
		[Token(Token = "0x4024563")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderProgress;

		// Token: 0x04024564 RID: 148836
		[Token(Token = "0x4024564")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderCompleteStatus;

		// Token: 0x04024565 RID: 148837
		[Token(Token = "0x4024565")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderPreviewTag;

		// Token: 0x04024566 RID: 148838
		[Token(Token = "0x4024566")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderPreviewProgress;

		// Token: 0x04024567 RID: 148839
		[Token(Token = "0x4024567")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024568 RID: 148840
		[Token(Token = "0x4024568")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
