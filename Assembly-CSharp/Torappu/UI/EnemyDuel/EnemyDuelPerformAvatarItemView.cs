using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004FFC RID: 20476
	[Token(Token = "0x2004FFC")]
	public class EnemyDuelPerformAvatarItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E64C RID: 124492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E64C")]
		[Address(RVA = "0x181ACF0", Offset = "0x18198F0", VA = "0x18181ACF0")]
		public void Render(string actId, EnemyDuelBattleCharItemViewModel viewModel, bool showStreak)
		{
		}

		// Token: 0x0601E64D RID: 124493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E64D")]
		[Address(RVA = "0x181B010", Offset = "0x1819C10", VA = "0x18181B010")]
		public EnemyDuelPerformAvatarItemView()
		{
		}

		// Token: 0x04028A20 RID: 166432
		[Token(Token = "0x4028A20")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _avatar;

		// Token: 0x04028A21 RID: 166433
		[Token(Token = "0x4028A21")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelf;

		// Token: 0x04028A22 RID: 166434
		[Token(Token = "0x4028A22")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelAllinSelf;

		// Token: 0x04028A23 RID: 166435
		[Token(Token = "0x4028A23")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAllin;

		// Token: 0x04028A24 RID: 166436
		[Token(Token = "0x4028A24")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelWinLeft;

		// Token: 0x04028A25 RID: 166437
		[Token(Token = "0x4028A25")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelWinRight;

		// Token: 0x04028A26 RID: 166438
		[Token(Token = "0x4028A26")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _streakLeft;

		// Token: 0x04028A27 RID: 166439
		[Token(Token = "0x4028A27")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _streakRight;

		// Token: 0x04028A28 RID: 166440
		[Token(Token = "0x4028A28")]
		[FieldOffset(Offset = "0x58")]
		private bool m_cachedIsNpc;

		// Token: 0x04028A29 RID: 166441
		[Token(Token = "0x4028A29")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedAvatarId;

		// Token: 0x04028A2A RID: 166442
		[Token(Token = "0x4028A2A")]
		[FieldOffset(Offset = "0x68")]
		private PlayerAvatarQuery m_cachedAvatarQuery;

		// Token: 0x04028A2B RID: 166443
		[Token(Token = "0x4028A2B")]
		[FieldOffset(Offset = "0x80")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028A2C RID: 166444
		[Token(Token = "0x4028A2C")]
		[FieldOffset(Offset = "0x90")]
		private ILoadAsset m_assetLoader;

		// Token: 0x04028A2D RID: 166445
		[Token(Token = "0x4028A2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04028A2E RID: 166446
		[Token(Token = "0x4028A2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
