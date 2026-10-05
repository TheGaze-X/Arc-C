using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064B4 RID: 25780
	[Token(Token = "0x20064B4")]
	public class AutoChessBattleEffectChoosePanel : AutoChessBattleUIPanelBase
	{
		// Token: 0x060250F5 RID: 151797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250F5")]
		[Address(RVA = "0x1FE0AE0", Offset = "0x1FDF6E0", VA = "0x181FE0AE0", Slot = "7")]
		public override void OnValueChanged(AutoChessBattleUIViewModelProperty property)
		{
		}

		// Token: 0x060250F6 RID: 151798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250F6")]
		[Address(RVA = "0x1FE0CD0", Offset = "0x1FDF8D0", VA = "0x181FE0CD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060250F7 RID: 151799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250F7")]
		[Address(RVA = "0x1FE0FA0", Offset = "0x1FDFBA0", VA = "0x181FE0FA0")]
		private void _RenderEffectChoose(AutoChessBattleEffectChooseViewModel model, bool isFirstShow)
		{
		}

		// Token: 0x060250F8 RID: 151800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250F8")]
		[Address(RVA = "0x1FE0DC0", Offset = "0x1FDF9C0", VA = "0x181FE0DC0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x060250F9 RID: 151801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60250F9")]
		[Address(RVA = "0x1FE13A0", Offset = "0x1FDFFA0", VA = "0x181FE13A0")]
		public AutoChessBattleEffectChoosePanel()
		{
		}

		// Token: 0x04033E35 RID: 212533
		[Token(Token = "0x4033E35")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04033E36 RID: 212534
		[Token(Token = "0x4033E36")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x04033E37 RID: 212535
		[Token(Token = "0x4033E37")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Animation")]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04033E38 RID: 212536
		[Token(Token = "0x4033E38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Title")]
		private Text _phaseNameText;

		// Token: 0x04033E39 RID: 212537
		[Token(Token = "0x4033E39")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Title")]
		private Text _phaseDescText;

		// Token: 0x04033E3A RID: 212538
		[Token(Token = "0x4033E3A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Title")]
		private Text _phaseTipText;

		// Token: 0x04033E3B RID: 212539
		[Token(Token = "0x4033E3B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Title")]
		private Graphic[] _coloredGrpahics;

		// Token: 0x04033E3C RID: 212540
		[Token(Token = "0x4033E3C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Drafting")]
		private AutoChessBattleEffectChooseDraftView _draftView;

		// Token: 0x04033E3D RID: 212541
		[Token(Token = "0x4033E3D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tip")]
		private AutoChessBattleSpPrepareTopTipView _tipView;

		// Token: 0x04033E3E RID: 212542
		[Token(Token = "0x4033E3E")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_enterAnimTween;

		// Token: 0x04033E3F RID: 212543
		[Token(Token = "0x4033E3F")]
		[FieldOffset(Offset = "0x78")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x04033E40 RID: 212544
		[Token(Token = "0x4033E40")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x04033E41 RID: 212545
		[Token(Token = "0x4033E41")]
		[FieldOffset(Offset = "0x81")]
		private bool m_prevShow;

		// Token: 0x04033E42 RID: 212546
		[Token(Token = "0x4033E42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04033E43 RID: 212547
		[Token(Token = "0x4033E43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033E44 RID: 212548
		[Token(Token = "0x4033E44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderEffectChoose;

		// Token: 0x04033E45 RID: 212549
		[Token(Token = "0x4033E45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04033E46 RID: 212550
		[Token(Token = "0x4033E46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
