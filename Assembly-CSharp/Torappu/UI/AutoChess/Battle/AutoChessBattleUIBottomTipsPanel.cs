using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x0200648D RID: 25741
	[Token(Token = "0x200648D")]
	public class AutoChessBattleUIBottomTipsPanel : AutoChessBattleUIPanelBase
	{
		// Token: 0x06025062 RID: 151650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025062")]
		[Address(RVA = "0x1FE5920", Offset = "0x1FE4520", VA = "0x181FE5920", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x06025063 RID: 151651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025063")]
		[Address(RVA = "0x1FE5EE0", Offset = "0x1FE4AE0", VA = "0x181FE5EE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025064 RID: 151652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025064")]
		[Address(RVA = "0x1FE6080", Offset = "0x1FE4C80", VA = "0x181FE6080")]
		private void _RenderWithShowType(AutoChessBattleUIBottomTipsShowType showType)
		{
		}

		// Token: 0x06025065 RID: 151653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025065")]
		[Address(RVA = "0x1FE5E20", Offset = "0x1FE4A20", VA = "0x181FE5E20")]
		private void _DealWithShopOpenAnim(bool prevIsShow, bool currIsShow, bool shopOpen)
		{
		}

		// Token: 0x06025066 RID: 151654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025066")]
		[Address(RVA = "0x1FE6260", Offset = "0x1FE4E60", VA = "0x181FE6260")]
		public AutoChessBattleUIBottomTipsPanel()
		{
		}

		// Token: 0x04033D31 RID: 212273
		[Token(Token = "0x4033D31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04033D32 RID: 212274
		[Token(Token = "0x4033D32")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgBkg;

		// Token: 0x04033D33 RID: 212275
		[Token(Token = "0x4033D33")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgIcon;

		// Token: 0x04033D34 RID: 212276
		[Token(Token = "0x4033D34")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtTip;

		// Token: 0x04033D35 RID: 212277
		[Token(Token = "0x4033D35")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _shopOpenAnimLocation;

		// Token: 0x04033D36 RID: 212278
		[Token(Token = "0x4033D36")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AutoChessBattleUIBottomTipsPanel.TipConfig[] _tipConfigs;

		// Token: 0x04033D37 RID: 212279
		[Token(Token = "0x4033D37")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04033D38 RID: 212280
		[Token(Token = "0x4033D38")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x04033D39 RID: 212281
		[Token(Token = "0x4033D39")]
		[FieldOffset(Offset = "0x68")]
		private AnimationSwitchTween m_animationSwitchTween;

		// Token: 0x04033D3A RID: 212282
		[Token(Token = "0x4033D3A")]
		[FieldOffset(Offset = "0x70")]
		private AutoChessBattleUIBottomTipsShowType m_cachedShowType;

		// Token: 0x04033D3B RID: 212283
		[Token(Token = "0x4033D3B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033D3C RID: 212284
		[Token(Token = "0x4033D3C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033D3D RID: 212285
		[Token(Token = "0x4033D3D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderWithShowType;

		// Token: 0x04033D3E RID: 212286
		[Token(Token = "0x4033D3E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealWithShopOpenAnim;

		// Token: 0x04033D3F RID: 212287
		[Token(Token = "0x4033D3F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200648E RID: 25742
		[Token(Token = "0x200648E")]
		[Serializable]
		private struct TipConfig
		{
			// Token: 0x04033D40 RID: 212288
			[Token(Token = "0x4033D40")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessBattleUIBottomTipsShowType showType;

			// Token: 0x04033D41 RID: 212289
			[Token(Token = "0x4033D41")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;

			// Token: 0x04033D42 RID: 212290
			[Token(Token = "0x4033D42")]
			[FieldOffset(Offset = "0x10")]
			public Color bgColor;

			// Token: 0x04033D43 RID: 212291
			[Token(Token = "0x4033D43")]
			[FieldOffset(Offset = "0x20")]
			public string txtKey;
		}
	}
}
