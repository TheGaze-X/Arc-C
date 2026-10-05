using System;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200238F RID: 9103
	[Token(Token = "0x200238F")]
	public class CooperateEndTile : DynamicBuffTileFixed, IUpdateable
	{
		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x0600E6F9 RID: 59129 RVA: 0x00054240 File Offset: 0x00052440
		[Token(Token = "0x17001D00")]
		public override int modeIndex
		{
			[Token(Token = "0x600E6F9")]
			[Address(RVA = "0x5BAF80", Offset = "0x5B9B80", VA = "0x1805BAF80", Slot = "48")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x0600E6FA RID: 59130 RVA: 0x00054258 File Offset: 0x00052458
		[Token(Token = "0x17001D01")]
		public PlayerSide tilePlayerSide
		{
			[Token(Token = "0x600E6FA")]
			[Address(RVA = "0x5BAFE0", Offset = "0x5B9BE0", VA = "0x1805BAFE0")]
			get
			{
				return PlayerSide.DEFAULT;
			}
		}

		// Token: 0x0600E6FB RID: 59131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6FB")]
		[Address(RVA = "0x5BA3F0", Offset = "0x5B8FF0", VA = "0x1805BA3F0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E6FC RID: 59132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6FC")]
		[Address(RVA = "0x5BA8F0", Offset = "0x5B94F0", VA = "0x1805BA8F0", Slot = "52")]
		public void OnFixedUpdate(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600E6FD RID: 59133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6FD")]
		[Address(RVA = "0x5BA960", Offset = "0x5B9560", VA = "0x1805BA960")]
		private void _GetModeAlive()
		{
		}

		// Token: 0x0600E6FE RID: 59134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6FE")]
		[Address(RVA = "0x5BAA90", Offset = "0x5B9690", VA = "0x1805BAA90")]
		private void _OnPlayerDying(object arg)
		{
		}

		// Token: 0x0600E6FF RID: 59135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6FF")]
		[Address(RVA = "0x5BAD60", Offset = "0x5B9960", VA = "0x1805BAD60")]
		private void _OnPlayerRevive(object arg)
		{
		}

		// Token: 0x0600E700 RID: 59136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E700")]
		[Address(RVA = "0x5BAEF0", Offset = "0x5B9AF0", VA = "0x1805BAEF0")]
		public CooperateEndTile()
		{
		}

		// Token: 0x0600E701 RID: 59137 RVA: 0x00054270 File Offset: 0x00052470
		[Token(Token = "0x600E701")]
		[Address(RVA = "0x5BA950", Offset = "0x5B9550", VA = "0x1805BA950")]
		private int <>xLuaBaseProxy_get_modeIndex()
		{
			return 0;
		}

		// Token: 0x0600E702 RID: 59138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E702")]
		[Address(RVA = "0x50CDC0", Offset = "0x50B9C0", VA = "0x18050CDC0")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0400FE59 RID: 65113
		[Token(Token = "0x400FE59")]
		private const string DEFAULT_EFFECT_DIRECT = "down";

		// Token: 0x0400FE5A RID: 65114
		[Token(Token = "0x400FE5A")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private string _directEffectKey;

		// Token: 0x0400FE5B RID: 65115
		[Token(Token = "0x400FE5B")]
		[FieldOffset(Offset = "0x1F0")]
		private PlayerSide m_curPlayerSide;

		// Token: 0x0400FE5C RID: 65116
		[Token(Token = "0x400FE5C")]
		[FieldOffset(Offset = "0x1F4")]
		private PlayerSide m_tilePlayerSide;

		// Token: 0x0400FE5D RID: 65117
		[Token(Token = "0x400FE5D")]
		[FieldOffset(Offset = "0x1F8")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0400FE5E RID: 65118
		[Token(Token = "0x400FE5E")]
		[FieldOffset(Offset = "0x200")]
		private SharedConsts.Direction m_direct;

		// Token: 0x0400FE5F RID: 65119
		[Token(Token = "0x400FE5F")]
		[FieldOffset(Offset = "0x208")]
		private ObjectPtr<Effect> m_tileEffect;

		// Token: 0x0400FE60 RID: 65120
		[Token(Token = "0x400FE60")]
		[FieldOffset(Offset = "0x218")]
		private bool m_isPlayerDead;

		// Token: 0x0400FE61 RID: 65121
		[Token(Token = "0x400FE61")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_modeIndex;

		// Token: 0x0400FE62 RID: 65122
		[Token(Token = "0x400FE62")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_tilePlayerSide;

		// Token: 0x0400FE63 RID: 65123
		[Token(Token = "0x400FE63")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FE64 RID: 65124
		[Token(Token = "0x400FE64")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400FE65 RID: 65125
		[Token(Token = "0x400FE65")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetModeAlive;

		// Token: 0x0400FE66 RID: 65126
		[Token(Token = "0x400FE66")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPlayerDying;

		// Token: 0x0400FE67 RID: 65127
		[Token(Token = "0x400FE67")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnPlayerRevive;

		// Token: 0x0400FE68 RID: 65128
		[Token(Token = "0x400FE68")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002390 RID: 9104
		[Token(Token = "0x2002390")]
		private enum TileState
		{
			// Token: 0x0400FE6A RID: 65130
			[Token(Token = "0x400FE6A")]
			SHARED,
			// Token: 0x0400FE6B RID: 65131
			[Token(Token = "0x400FE6B")]
			MY_SIDE,
			// Token: 0x0400FE6C RID: 65132
			[Token(Token = "0x400FE6C")]
			MATE_SIDE,
			// Token: 0x0400FE6D RID: 65133
			[Token(Token = "0x400FE6D")]
			DEAD
		}
	}
}
