using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200502E RID: 20526
	[Token(Token = "0x200502E")]
	public class EnemyDuelPrepareEntranceShowView : DataBinder<EnemyDuelPrepareEntranceShowProperty>, IHotfixable
	{
		// Token: 0x0601E720 RID: 124704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E720")]
		[Address(RVA = "0x1826090", Offset = "0x1824C90", VA = "0x181826090", Slot = "7")]
		public override void OnValueChanged(EnemyDuelPrepareEntranceShowProperty property)
		{
		}

		// Token: 0x0601E721 RID: 124705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E721")]
		[Address(RVA = "0x18262E0", Offset = "0x1824EE0", VA = "0x1818262E0")]
		private void _AdjustViewsCount(int expectedCount)
		{
		}

		// Token: 0x0601E722 RID: 124706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E722")]
		[Address(RVA = "0x18264F0", Offset = "0x18250F0", VA = "0x1818264F0")]
		public EnemyDuelPrepareEntranceShowView()
		{
		}

		// Token: 0x04028BED RID: 166893
		[Token(Token = "0x4028BED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private EnemyDuelPrepareEntranceShowPlayerView _playerViewPrefab;

		// Token: 0x04028BEE RID: 166894
		[Token(Token = "0x4028BEE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _playerViewContainers;

		// Token: 0x04028BEF RID: 166895
		[Token(Token = "0x4028BEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _maxPlayerCount;

		// Token: 0x04028BF0 RID: 166896
		[Token(Token = "0x4028BF0")]
		[FieldOffset(Offset = "0x38")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028BF1 RID: 166897
		[Token(Token = "0x4028BF1")]
		[FieldOffset(Offset = "0x48")]
		private List<EnemyDuelPrepareEntranceShowPlayerView> m_playerViews;

		// Token: 0x04028BF2 RID: 166898
		[Token(Token = "0x4028BF2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028BF3 RID: 166899
		[Token(Token = "0x4028BF3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__AdjustViewsCount;

		// Token: 0x04028BF4 RID: 166900
		[Token(Token = "0x4028BF4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
