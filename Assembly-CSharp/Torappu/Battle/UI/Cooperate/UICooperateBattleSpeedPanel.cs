using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.Cooperate;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033D2 RID: 13266
	[Token(Token = "0x20033D2")]
	public class UICooperateBattleSpeedPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x060152BF RID: 86719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152BF")]
		[Address(RVA = "0xDA0660", Offset = "0xD9F260", VA = "0x180DA0660")]
		public void UpdateSpeedHint()
		{
		}

		// Token: 0x060152C0 RID: 86720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C0")]
		[Address(RVA = "0xD9FF90", Offset = "0xD9EB90", VA = "0x180D9FF90")]
		public void InitIfNot()
		{
		}

		// Token: 0x060152C1 RID: 86721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C1")]
		[Address(RVA = "0xDA00F0", Offset = "0xD9ECF0", VA = "0x180DA00F0")]
		public void SetSpeedColor(bool speedUp, bool mateSpeedUp)
		{
		}

		// Token: 0x060152C2 RID: 86722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C2")]
		[Address(RVA = "0xDA0C20", Offset = "0xD9F820", VA = "0x180DA0C20")]
		private void _OnMeEnterSpeedUp()
		{
		}

		// Token: 0x060152C3 RID: 86723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C3")]
		[Address(RVA = "0xDA0F90", Offset = "0xD9FB90", VA = "0x180DA0F90")]
		private void _OnMeLightOn()
		{
		}

		// Token: 0x060152C4 RID: 86724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C4")]
		[Address(RVA = "0xDA0D60", Offset = "0xD9F960", VA = "0x180DA0D60")]
		private void _OnMeExitSpeedUp()
		{
		}

		// Token: 0x060152C5 RID: 86725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C5")]
		[Address(RVA = "0xDA0EA0", Offset = "0xD9FAA0", VA = "0x180DA0EA0")]
		private void _OnMeLightOff()
		{
		}

		// Token: 0x060152C6 RID: 86726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C6")]
		[Address(RVA = "0xDA0750", Offset = "0xD9F350", VA = "0x180DA0750")]
		private void _OnMateEnterSpeedUp()
		{
		}

		// Token: 0x060152C7 RID: 86727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C7")]
		[Address(RVA = "0xDA0AD0", Offset = "0xD9F6D0", VA = "0x180DA0AD0")]
		private void _OnMateLightOn()
		{
		}

		// Token: 0x060152C8 RID: 86728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C8")]
		[Address(RVA = "0xDA0890", Offset = "0xD9F490", VA = "0x180DA0890")]
		private void _OnMateExitSpeedUp()
		{
		}

		// Token: 0x060152C9 RID: 86729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152C9")]
		[Address(RVA = "0xDA09D0", Offset = "0xD9F5D0", VA = "0x180DA09D0")]
		private void _OnMateLightOff()
		{
		}

		// Token: 0x060152CA RID: 86730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152CA")]
		[Address(RVA = "0xDA1220", Offset = "0xD9FE20", VA = "0x180DA1220")]
		private void _UpdateLightStatus()
		{
		}

		// Token: 0x060152CB RID: 86731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152CB")]
		[Address(RVA = "0xDA10E0", Offset = "0xD9FCE0", VA = "0x180DA10E0")]
		private void _ShowHintByOnline(object arg)
		{
		}

		// Token: 0x060152CC RID: 86732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152CC")]
		[Address(RVA = "0xDA06E0", Offset = "0xD9F2E0", VA = "0x180DA06E0")]
		private void _HideHintWhenDie(object arg)
		{
		}

		// Token: 0x060152CD RID: 86733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152CD")]
		[Address(RVA = "0xDA11A0", Offset = "0xD9FDA0", VA = "0x180DA11A0")]
		private void _ShowHintWhenRevive(object arg)
		{
		}

		// Token: 0x060152CE RID: 86734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60152CE")]
		[Address(RVA = "0xDA1690", Offset = "0xDA0290", VA = "0x180DA1690")]
		public UICooperateBattleSpeedPanel()
		{
		}

		// Token: 0x04019433 RID: 103475
		[Token(Token = "0x4019433")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _mateLightShow;

		// Token: 0x04019434 RID: 103476
		[Token(Token = "0x4019434")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _meLightShow;

		// Token: 0x04019435 RID: 103477
		[Token(Token = "0x4019435")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _mateLightHide;

		// Token: 0x04019436 RID: 103478
		[Token(Token = "0x4019436")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _meLightHide;

		// Token: 0x04019437 RID: 103479
		[Token(Token = "0x4019437")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _mateSelect;

		// Token: 0x04019438 RID: 103480
		[Token(Token = "0x4019438")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("anim")]
		private UIAnimationLocation _meSelect;

		// Token: 0x04019439 RID: 103481
		[Token(Token = "0x4019439")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _playerSpeedUp;

		// Token: 0x0401943A RID: 103482
		[Token(Token = "0x401943A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _mateSpeedUp;

		// Token: 0x0401943B RID: 103483
		[Token(Token = "0x401943B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _hint;

		// Token: 0x0401943C RID: 103484
		[Token(Token = "0x401943C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _speedImage;

		// Token: 0x0401943D RID: 103485
		[Token(Token = "0x401943D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Sprite _speedUp1x;

		// Token: 0x0401943E RID: 103486
		[Token(Token = "0x401943E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Sprite _speedUp2x;

		// Token: 0x0401943F RID: 103487
		[Token(Token = "0x401943F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _lightFadeDuration;

		// Token: 0x04019440 RID: 103488
		[Token(Token = "0x4019440")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_cacheSpeedUp;

		// Token: 0x04019441 RID: 103489
		[Token(Token = "0x4019441")]
		[FieldOffset(Offset = "0xAD")]
		private bool m_cacheMateSpeedUp;

		// Token: 0x04019442 RID: 103490
		[Token(Token = "0x4019442")]
		[FieldOffset(Offset = "0xAE")]
		private bool m_myLightOn;

		// Token: 0x04019443 RID: 103491
		[Token(Token = "0x4019443")]
		[FieldOffset(Offset = "0xAF")]
		private bool m_mateLightOn;

		// Token: 0x04019444 RID: 103492
		[Token(Token = "0x4019444")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_hintState;

		// Token: 0x04019445 RID: 103493
		[Token(Token = "0x4019445")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_myTweenSelect;

		// Token: 0x04019446 RID: 103494
		[Token(Token = "0x4019446")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_myTweenLight;

		// Token: 0x04019447 RID: 103495
		[Token(Token = "0x4019447")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_mateTweenSelect;

		// Token: 0x04019448 RID: 103496
		[Token(Token = "0x4019448")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_mateTweenLight;

		// Token: 0x04019449 RID: 103497
		[Token(Token = "0x4019449")]
		[FieldOffset(Offset = "0xD8")]
		private OnLineType m_mateOnline;

		// Token: 0x0401944A RID: 103498
		[Token(Token = "0x401944A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateSpeedHint;

		// Token: 0x0401944B RID: 103499
		[Token(Token = "0x401944B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitIfNot;

		// Token: 0x0401944C RID: 103500
		[Token(Token = "0x401944C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSpeedColor;

		// Token: 0x0401944D RID: 103501
		[Token(Token = "0x401944D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnMeEnterSpeedUp;

		// Token: 0x0401944E RID: 103502
		[Token(Token = "0x401944E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnMeLightOn;

		// Token: 0x0401944F RID: 103503
		[Token(Token = "0x401944F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnMeExitSpeedUp;

		// Token: 0x04019450 RID: 103504
		[Token(Token = "0x4019450")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnMeLightOff;

		// Token: 0x04019451 RID: 103505
		[Token(Token = "0x4019451")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMateEnterSpeedUp;

		// Token: 0x04019452 RID: 103506
		[Token(Token = "0x4019452")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMateLightOn;

		// Token: 0x04019453 RID: 103507
		[Token(Token = "0x4019453")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnMateExitSpeedUp;

		// Token: 0x04019454 RID: 103508
		[Token(Token = "0x4019454")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnMateLightOff;

		// Token: 0x04019455 RID: 103509
		[Token(Token = "0x4019455")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateLightStatus;

		// Token: 0x04019456 RID: 103510
		[Token(Token = "0x4019456")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowHintByOnline;

		// Token: 0x04019457 RID: 103511
		[Token(Token = "0x4019457")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__HideHintWhenDie;

		// Token: 0x04019458 RID: 103512
		[Token(Token = "0x4019458")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__ShowHintWhenRevive;

		// Token: 0x04019459 RID: 103513
		[Token(Token = "0x4019459")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
