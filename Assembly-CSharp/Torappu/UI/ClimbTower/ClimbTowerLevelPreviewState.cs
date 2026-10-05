using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D0C RID: 23820
	[Token(Token = "0x2005D0C")]
	public class ClimbTowerLevelPreviewState : PopupFloatState
	{
		// Token: 0x060227EF RID: 141295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227EF")]
		[Address(RVA = "0x1D0B880", Offset = "0x1D0A480", VA = "0x181D0B880")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060227F0 RID: 141296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227F0")]
		[Address(RVA = "0x1D0AC70", Offset = "0x1D09870", VA = "0x181D0AC70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x060227F1 RID: 141297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F1")]
		[Address(RVA = "0x1D0B090", Offset = "0x1D09C90", VA = "0x181D0B090", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x060227F2 RID: 141298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227F2")]
		[Address(RVA = "0x1D0B6B0", Offset = "0x1D0A2B0", VA = "0x181D0B6B0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x060227F3 RID: 141299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F3")]
		[Address(RVA = "0x1D0B990", Offset = "0x1D0A590", VA = "0x181D0B990")]
		private void _OnJumpToEnemyHandBook(IStateBean stateBean)
		{
		}

		// Token: 0x060227F4 RID: 141300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F4")]
		[Address(RVA = "0x1D0BB10", Offset = "0x1D0A710", VA = "0x181D0BB10")]
		private void _OnJumpToRewardDetailView(IStateBean stateBean)
		{
		}

		// Token: 0x060227F5 RID: 141301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F5")]
		[Address(RVA = "0x1D0AF50", Offset = "0x1D09B50", VA = "0x181D0AF50")]
		public void OnBtnUpClicked()
		{
		}

		// Token: 0x060227F6 RID: 141302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F6")]
		[Address(RVA = "0x1D0AE10", Offset = "0x1D09A10", VA = "0x181D0AE10")]
		public void OnBtnDownClicked()
		{
		}

		// Token: 0x060227F7 RID: 141303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F7")]
		[Address(RVA = "0x1D0ACD0", Offset = "0x1D098D0", VA = "0x181D0ACD0")]
		public void OnBossInfoClicked()
		{
		}

		// Token: 0x060227F8 RID: 141304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F8")]
		[Address(RVA = "0x1D0B4A0", Offset = "0x1D0A0A0", VA = "0x181D0B4A0")]
		public void OnJumpToEnemyHandbook(List<EnemyHandBookEverViewModel> enemyList, int enemyListIdx)
		{
		}

		// Token: 0x060227F9 RID: 141305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227F9")]
		[Address(RVA = "0x1D0B5E0", Offset = "0x1D0A1E0", VA = "0x181D0B5E0")]
		public void OnJumpToRewardDetailView()
		{
		}

		// Token: 0x060227FA RID: 141306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227FA")]
		[Address(RVA = "0x1D0BCB0", Offset = "0x1D0A8B0", VA = "0x181D0BCB0")]
		public ClimbTowerLevelPreviewState()
		{
		}

		// Token: 0x060227FC RID: 141308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60227FC")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x060227FD RID: 141309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60227FD")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0402F68F RID: 194191
		[Token(Token = "0x402F68F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ClimbTowerLevelPreviewView _levelPreviewView;

		// Token: 0x0402F690 RID: 194192
		[Token(Token = "0x402F690")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x0402F691 RID: 194193
		[Token(Token = "0x402F691")]
		[FieldOffset(Offset = "0x80")]
		private ClimbTowerLevelPreviewState.ClimbTowerLevelPreviewStateBean m_stateBean;

		// Token: 0x0402F692 RID: 194194
		[Token(Token = "0x402F692")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0402F693 RID: 194195
		[Token(Token = "0x402F693")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F694 RID: 194196
		[Token(Token = "0x402F694")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402F695 RID: 194197
		[Token(Token = "0x402F695")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402F696 RID: 194198
		[Token(Token = "0x402F696")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402F697 RID: 194199
		[Token(Token = "0x402F697")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnJumpToEnemyHandBook;

		// Token: 0x0402F698 RID: 194200
		[Token(Token = "0x402F698")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnJumpToRewardDetailView;

		// Token: 0x0402F699 RID: 194201
		[Token(Token = "0x402F699")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnBtnUpClicked;

		// Token: 0x0402F69A RID: 194202
		[Token(Token = "0x402F69A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnDownClicked;

		// Token: 0x0402F69B RID: 194203
		[Token(Token = "0x402F69B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBossInfoClicked;

		// Token: 0x0402F69C RID: 194204
		[Token(Token = "0x402F69C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnJumpToEnemyHandbook;

		// Token: 0x0402F69D RID: 194205
		[Token(Token = "0x402F69D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnJumpToRewardDetailView;

		// Token: 0x0402F69E RID: 194206
		[Token(Token = "0x402F69E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005D0D RID: 23821
		[Token(Token = "0x2005D0D")]
		public class ClimbTowerLevelPreviewStateBean : IStateBean, IHotfixable
		{
			// Token: 0x060227FE RID: 141310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60227FE")]
			[Address(RVA = "0x1D0ABD0", Offset = "0x1D097D0", VA = "0x181D0ABD0")]
			public ClimbTowerLevelPreviewStateBean()
			{
			}

			// Token: 0x0402F69F RID: 194207
			[Token(Token = "0x402F69F")]
			[FieldOffset(Offset = "0x10")]
			public ClimbTowerLevelPreviewProperty property;

			// Token: 0x0402F6A0 RID: 194208
			[Token(Token = "0x402F6A0")]
			[FieldOffset(Offset = "0x18")]
			public List<EnemyHandBookEverViewModel> enemyList;

			// Token: 0x0402F6A1 RID: 194209
			[Token(Token = "0x402F6A1")]
			[FieldOffset(Offset = "0x20")]
			public int enemyListIdx;

			// Token: 0x0402F6A2 RID: 194210
			[Token(Token = "0x402F6A2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
