using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x020059A9 RID: 22953
	[Token(Token = "0x20059A9")]
	public class CrisisV2MapBagTitleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021754 RID: 137044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021754")]
		[Address(RVA = "0x1BC4F10", Offset = "0x1BC3B10", VA = "0x181BC4F10")]
		private void _SetPos(Vector2 pos, Vector2 size)
		{
		}

		// Token: 0x06021755 RID: 137045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021755")]
		[Address(RVA = "0x1BC4850", Offset = "0x1BC3450", VA = "0x181BC4850")]
		public void Init(Vector2 bagPos, Vector2 bagSize)
		{
		}

		// Token: 0x06021756 RID: 137046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021756")]
		[Address(RVA = "0x1BC4A30", Offset = "0x1BC3630", VA = "0x181BC4A30")]
		public void Render(CrisisV2MapBagModel bagModel, CrisisV2MapBagStatus bagStatus, CrisisV2Progress nodeProgress, bool isVisible)
		{
		}

		// Token: 0x06021757 RID: 137047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021757")]
		[Address(RVA = "0x1BC4700", Offset = "0x1BC3300", VA = "0x181BC4700")]
		public void EventOnBtnBagClick()
		{
		}

		// Token: 0x06021758 RID: 137048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021758")]
		[Address(RVA = "0x1BC4FE0", Offset = "0x1BC3BE0", VA = "0x181BC4FE0")]
		public CrisisV2MapBagTitleView()
		{
		}

		// Token: 0x0402DAA0 RID: 187040
		[Token(Token = "0x402DAA0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _bagProgressBgToggle;

		// Token: 0x0402DAA1 RID: 187041
		[Token(Token = "0x402DAA1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _nodeScoreBgToggle;

		// Token: 0x0402DAA2 RID: 187042
		[Token(Token = "0x402DAA2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _bagScoreBgToggle;

		// Token: 0x0402DAA3 RID: 187043
		[Token(Token = "0x402DAA3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bagScoreGo;

		// Token: 0x0402DAA4 RID: 187044
		[Token(Token = "0x402DAA4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textNodeScoreCurrent;

		// Token: 0x0402DAA5 RID: 187045
		[Token(Token = "0x402DAA5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textNodeScoreTotal;

		// Token: 0x0402DAA6 RID: 187046
		[Token(Token = "0x402DAA6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textBagScore;

		// Token: 0x0402DAA7 RID: 187047
		[Token(Token = "0x402DAA7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorUnselectScore;

		// Token: 0x0402DAA8 RID: 187048
		[Token(Token = "0x402DAA8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorSelectCurrentScore;

		// Token: 0x0402DAA9 RID: 187049
		[Token(Token = "0x402DAA9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _colorSelectTotalScore;

		// Token: 0x0402DAAA RID: 187050
		[Token(Token = "0x402DAAA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _colorSelectBagScore;

		// Token: 0x0402DAAB RID: 187051
		[Token(Token = "0x402DAAB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Color _colorFullBagScore;

		// Token: 0x0402DAAC RID: 187052
		[Token(Token = "0x402DAAC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0402DAAD RID: 187053
		[Token(Token = "0x402DAAD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorUnselectDesc;

		// Token: 0x0402DAAE RID: 187054
		[Token(Token = "0x402DAAE")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorSelectDesc;

		// Token: 0x0402DAAF RID: 187055
		[Token(Token = "0x402DAAF")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _completedIconGo;

		// Token: 0x0402DAB0 RID: 187056
		[Token(Token = "0x402DAB0")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Slider _sliderProgerss;

		// Token: 0x0402DAB1 RID: 187057
		[Token(Token = "0x402DAB1")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private float _sliderTweenDuration;

		// Token: 0x0402DAB2 RID: 187058
		[Token(Token = "0x402DAB2")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0402DAB3 RID: 187059
		[Token(Token = "0x402DAB3")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float _unreachAlpha;

		// Token: 0x0402DAB4 RID: 187060
		[Token(Token = "0x402DAB4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private UIAnimationLocation _animSwitch;

		// Token: 0x0402DAB5 RID: 187061
		[Token(Token = "0x402DAB5")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402DAB6 RID: 187062
		[Token(Token = "0x402DAB6")]
		[FieldOffset(Offset = "0x110")]
		private CrisisV2MapBagModel m_bagModel;

		// Token: 0x0402DAB7 RID: 187063
		[Token(Token = "0x402DAB7")]
		[FieldOffset(Offset = "0x118")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x0402DAB8 RID: 187064
		[Token(Token = "0x402DAB8")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_sliderTween;

		// Token: 0x0402DAB9 RID: 187065
		[Token(Token = "0x402DAB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetPos;

		// Token: 0x0402DABA RID: 187066
		[Token(Token = "0x402DABA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402DABB RID: 187067
		[Token(Token = "0x402DABB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402DABC RID: 187068
		[Token(Token = "0x402DABC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnBagClick;

		// Token: 0x0402DABD RID: 187069
		[Token(Token = "0x402DABD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
