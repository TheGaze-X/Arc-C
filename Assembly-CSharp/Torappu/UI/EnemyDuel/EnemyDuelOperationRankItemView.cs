using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02005007 RID: 20487
	[Token(Token = "0x2005007")]
	public class EnemyDuelOperationRankItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E673 RID: 124531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E673")]
		[Address(RVA = "0x1819730", Offset = "0x1818330", VA = "0x181819730")]
		public void Render(OperationRoundRankItemModel model)
		{
		}

		// Token: 0x0601E674 RID: 124532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E674")]
		[Address(RVA = "0x181A720", Offset = "0x1819320", VA = "0x18181A720")]
		private void _RenderPlayer(OperationRoundRankItemModel model)
		{
		}

		// Token: 0x0601E675 RID: 124533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E675")]
		[Address(RVA = "0x181A2F0", Offset = "0x1818EF0", VA = "0x18181A2F0")]
		private void _RenderOut(OperationRoundRankItemModel model)
		{
		}

		// Token: 0x0601E676 RID: 124534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E676")]
		[Address(RVA = "0x1819DC0", Offset = "0x18189C0", VA = "0x181819DC0")]
		private void _RenderDefault(OperationRoundRankItemModel model)
		{
		}

		// Token: 0x0601E677 RID: 124535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E677")]
		[Address(RVA = "0x1819C30", Offset = "0x1818830", VA = "0x181819C30")]
		private void _RenderAvatar(OperationRoundRankItemModel model)
		{
		}

		// Token: 0x0601E678 RID: 124536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E678")]
		[Address(RVA = "0x18199D0", Offset = "0x18185D0", VA = "0x1818199D0")]
		private void _PlayMoneyTween(Text moneyText, int startNum, int endNum)
		{
		}

		// Token: 0x0601E679 RID: 124537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E679")]
		[Address(RVA = "0x181AC90", Offset = "0x1819890", VA = "0x18181AC90")]
		public EnemyDuelOperationRankItemView()
		{
		}

		// Token: 0x04028A8A RID: 166538
		[Token(Token = "0x4028A8A")]
		private const string NO_CHANGE_TEXT = "/";

		// Token: 0x04028A8B RID: 166539
		[Token(Token = "0x4028A8B")]
		private const float MONEY_TWEEN_START_TIME = 0.3f;

		// Token: 0x04028A8C RID: 166540
		[Token(Token = "0x4028A8C")]
		private const float MONEY_TWEEN_DURATION = 2f;

		// Token: 0x04028A8D RID: 166541
		[Token(Token = "0x4028A8D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Rank Color")]
		private Color _defaultRankCol;

		// Token: 0x04028A8E RID: 166542
		[Token(Token = "0x4028A8E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Rank Color")]
		private Color _playerRankCol;

		// Token: 0x04028A8F RID: 166543
		[Token(Token = "0x4028A8F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Name Color")]
		private Color _defaultNameCol;

		// Token: 0x04028A90 RID: 166544
		[Token(Token = "0x4028A90")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Name Color")]
		private Color _playerNameCol;

		// Token: 0x04028A91 RID: 166545
		[Token(Token = "0x4028A91")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Name Color")]
		private Color _outNameCol;

		// Token: 0x04028A92 RID: 166546
		[Token(Token = "0x4028A92")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Money Color")]
		private Color _loseMoneyCol;

		// Token: 0x04028A93 RID: 166547
		[Token(Token = "0x4028A93")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Money Color")]
		private Color _outMoneyCol;

		// Token: 0x04028A94 RID: 166548
		[Token(Token = "0x4028A94")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Money Color")]
		private Color _losePlayerMoneyCol;

		// Token: 0x04028A95 RID: 166549
		[Token(Token = "0x4028A95")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Money Color")]
		private Color _winDefaultMoneyCol;

		// Token: 0x04028A96 RID: 166550
		[Token(Token = "0x4028A96")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Money Color")]
		private Color _winPlayerMoneyCol;

		// Token: 0x04028A97 RID: 166551
		[Token(Token = "0x4028A97")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ThreeStateToggle _bgToggle;

		// Token: 0x04028A98 RID: 166552
		[Token(Token = "0x4028A98")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private TwoStateToggle _outToggle;

		// Token: 0x04028A99 RID: 166553
		[Token(Token = "0x4028A99")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _winCnt;

		// Token: 0x04028A9A RID: 166554
		[Token(Token = "0x4028A9A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _winStreakPanel;

		// Token: 0x04028A9B RID: 166555
		[Token(Token = "0x4028A9B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x04028A9C RID: 166556
		[Token(Token = "0x4028A9C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _rank;

		// Token: 0x04028A9D RID: 166557
		[Token(Token = "0x4028A9D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _name;

		// Token: 0x04028A9E RID: 166558
		[Token(Token = "0x4028A9E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _moneyChange;

		// Token: 0x04028A9F RID: 166559
		[Token(Token = "0x4028A9F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Text _currMoney;

		// Token: 0x04028AA0 RID: 166560
		[Token(Token = "0x4028AA0")]
		[FieldOffset(Offset = "0x100")]
		private Tween m_arrowTween;

		// Token: 0x04028AA1 RID: 166561
		[Token(Token = "0x4028AA1")]
		[FieldOffset(Offset = "0x108")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028AA2 RID: 166562
		[Token(Token = "0x4028AA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028AA3 RID: 166563
		[Token(Token = "0x4028AA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderPlayer;

		// Token: 0x04028AA4 RID: 166564
		[Token(Token = "0x4028AA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderOut;

		// Token: 0x04028AA5 RID: 166565
		[Token(Token = "0x4028AA5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderDefault;

		// Token: 0x04028AA6 RID: 166566
		[Token(Token = "0x4028AA6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderAvatar;

		// Token: 0x04028AA7 RID: 166567
		[Token(Token = "0x4028AA7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayMoneyTween;

		// Token: 0x04028AA8 RID: 166568
		[Token(Token = "0x4028AA8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
