using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006504 RID: 25860
	[Token(Token = "0x2006504")]
	public class AutoChessBattleShopUpgradeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060252A5 RID: 152229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A5")]
		[Address(RVA = "0x201C770", Offset = "0x201B370", VA = "0x18201C770")]
		public void RenderView(AutoChessBattleShopViewModel model)
		{
		}

		// Token: 0x060252A6 RID: 152230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A6")]
		[Address(RVA = "0x201CFF0", Offset = "0x201BBF0", VA = "0x18201CFF0")]
		private void _PlayUpgradeAnim()
		{
		}

		// Token: 0x060252A7 RID: 152231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A7")]
		[Address(RVA = "0x201CF90", Offset = "0x201BB90", VA = "0x18201CF90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060252A8 RID: 152232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A8")]
		[Address(RVA = "0x201C670", Offset = "0x201B270", VA = "0x18201C670")]
		public void EventOnFirstClick()
		{
		}

		// Token: 0x060252A9 RID: 152233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252A9")]
		[Address(RVA = "0x201D190", Offset = "0x201BD90", VA = "0x18201D190")]
		public AutoChessBattleShopUpgradeView()
		{
		}

		// Token: 0x040341EA RID: 213482
		[Token(Token = "0x40341EA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PrefabWidget _cost;

		// Token: 0x040341EB RID: 213483
		[Token(Token = "0x40341EB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ThreeStateToggle _stageToggle;

		// Token: 0x040341EC RID: 213484
		[Token(Token = "0x40341EC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text[] _curLvlLabels;

		// Token: 0x040341ED RID: 213485
		[Token(Token = "0x40341ED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _nextLvlLabel;

		// Token: 0x040341EE RID: 213486
		[Token(Token = "0x40341EE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _checkInAnim;

		// Token: 0x040341EF RID: 213487
		[Token(Token = "0x40341EF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _checkOutAnim;

		// Token: 0x040341F0 RID: 213488
		[Token(Token = "0x40341F0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _upgradeAnim;

		// Token: 0x040341F1 RID: 213489
		[Token(Token = "0x40341F1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private TwoPhaseButtonWidget _btnClick;

		// Token: 0x040341F2 RID: 213490
		[Token(Token = "0x40341F2")]
		[FieldOffset(Offset = "0x70")]
		private int m_currLevel;

		// Token: 0x040341F3 RID: 213491
		[Token(Token = "0x40341F3")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040341F4 RID: 213492
		[Token(Token = "0x40341F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040341F5 RID: 213493
		[Token(Token = "0x40341F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PlayUpgradeAnim;

		// Token: 0x040341F6 RID: 213494
		[Token(Token = "0x40341F6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040341F7 RID: 213495
		[Token(Token = "0x40341F7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnFirstClick;

		// Token: 0x040341F8 RID: 213496
		[Token(Token = "0x40341F8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
