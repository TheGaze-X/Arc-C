using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200770C RID: 30476
	[Token(Token = "0x200770C")]
	public class Act1VHalfIdleCharLevelUpgradeLevelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602AD00 RID: 175360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD00")]
		[Address(RVA = "0x26967D0", Offset = "0x26953D0", VA = "0x1826967D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602AD01 RID: 175361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD01")]
		[Address(RVA = "0x2696430", Offset = "0x2695030", VA = "0x182696430")]
		public void Render(Act1VHalfIdleCharUpgradeViewModel viewModel, Act1VHalfIdleCharLevelUpgradeNotFullView.ShowStatus showStatus, bool isInit)
		{
		}

		// Token: 0x0602AD02 RID: 175362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD02")]
		[Address(RVA = "0x2696B90", Offset = "0x2695790", VA = "0x182696B90")]
		private void _OnIncreaseBtnClicked()
		{
		}

		// Token: 0x0602AD03 RID: 175363 RVA: 0x000DA250 File Offset: 0x000D8450
		[Token(Token = "0x602AD03")]
		[Address(RVA = "0x2696C80", Offset = "0x2695880", VA = "0x182696C80")]
		private bool _OnIncreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0602AD04 RID: 175364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD04")]
		[Address(RVA = "0x26969B0", Offset = "0x26955B0", VA = "0x1826969B0")]
		private void _OnDecreaseBtnClicked()
		{
		}

		// Token: 0x0602AD05 RID: 175365 RVA: 0x000DA268 File Offset: 0x000D8468
		[Token(Token = "0x602AD05")]
		[Address(RVA = "0x2696AA0", Offset = "0x26956A0", VA = "0x182696AA0")]
		private bool _OnDecreaseBtnLongPressed()
		{
			return default(bool);
		}

		// Token: 0x0602AD06 RID: 175366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD06")]
		[Address(RVA = "0x2696390", Offset = "0x2694F90", VA = "0x182696390")]
		public void OnBtnMinClicked()
		{
		}

		// Token: 0x0602AD07 RID: 175367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD07")]
		[Address(RVA = "0x26962F0", Offset = "0x2694EF0", VA = "0x1826962F0")]
		public void OnBtnMaxClicked()
		{
		}

		// Token: 0x0602AD08 RID: 175368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AD08")]
		[Address(RVA = "0x2696D70", Offset = "0x2695970", VA = "0x182696D70")]
		public Act1VHalfIdleCharLevelUpgradeLevelView()
		{
		}

		// Token: 0x0403DB25 RID: 252709
		[Token(Token = "0x403DB25")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgEvolveBefore;

		// Token: 0x0403DB26 RID: 252710
		[Token(Token = "0x403DB26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgEvolveAfter;

		// Token: 0x0403DB27 RID: 252711
		[Token(Token = "0x403DB27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textLevelBefore;

		// Token: 0x0403DB28 RID: 252712
		[Token(Token = "0x403DB28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLevelAfter;

		// Token: 0x0403DB29 RID: 252713
		[Token(Token = "0x403DB29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UILongPressButtonEx _btnIncrease;

		// Token: 0x0403DB2A RID: 252714
		[Token(Token = "0x403DB2A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UILongPressButtonEx _btnDecrease;

		// Token: 0x0403DB2B RID: 252715
		[Token(Token = "0x403DB2B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _pnlUpgradeLight;

		// Token: 0x0403DB2C RID: 252716
		[Token(Token = "0x403DB2C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _upgradeLightDuration;

		// Token: 0x0403DB2D RID: 252717
		[Token(Token = "0x403DB2D")]
		[FieldOffset(Offset = "0x54")]
		private bool m_inited;

		// Token: 0x0403DB2E RID: 252718
		[Token(Token = "0x403DB2E")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DB2F RID: 252719
		[Token(Token = "0x403DB2F")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedEliteId;

		// Token: 0x0403DB30 RID: 252720
		[Token(Token = "0x403DB30")]
		[FieldOffset(Offset = "0x6C")]
		private int m_cachedUpgradeLevelSeqNum;

		// Token: 0x0403DB31 RID: 252721
		[Token(Token = "0x403DB31")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_levelUpgradeTween;

		// Token: 0x0403DB32 RID: 252722
		[Token(Token = "0x403DB32")]
		[FieldOffset(Offset = "0x78")]
		private Act1VHalfIdleCharLevelUpgradeNotFullView.ShowStatus m_cachedShowStatus;

		// Token: 0x0403DB33 RID: 252723
		[Token(Token = "0x403DB33")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DB34 RID: 252724
		[Token(Token = "0x403DB34")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403DB35 RID: 252725
		[Token(Token = "0x403DB35")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnClicked;

		// Token: 0x0403DB36 RID: 252726
		[Token(Token = "0x403DB36")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnLongPressed;

		// Token: 0x0403DB37 RID: 252727
		[Token(Token = "0x403DB37")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnClicked;

		// Token: 0x0403DB38 RID: 252728
		[Token(Token = "0x403DB38")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnLongPressed;

		// Token: 0x0403DB39 RID: 252729
		[Token(Token = "0x403DB39")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnMinClicked;

		// Token: 0x0403DB3A RID: 252730
		[Token(Token = "0x403DB3A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnMaxClicked;

		// Token: 0x0403DB3B RID: 252731
		[Token(Token = "0x403DB3B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
