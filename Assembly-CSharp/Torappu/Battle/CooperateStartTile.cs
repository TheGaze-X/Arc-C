using System;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002391 RID: 9105
	[Token(Token = "0x2002391")]
	public class CooperateStartTile : DynamicBuffTileFixed, IUpdateable
	{
		// Token: 0x0600E703 RID: 59139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E703")]
		[Address(RVA = "0x5BB040", Offset = "0x5B9C40", VA = "0x1805BB040", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E704 RID: 59140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E704")]
		[Address(RVA = "0x5BB470", Offset = "0x5BA070", VA = "0x1805BB470", Slot = "52")]
		public void OnFixedUpdate(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600E705 RID: 59141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E705")]
		[Address(RVA = "0x5BB5C0", Offset = "0x5BA1C0", VA = "0x1805BB5C0")]
		private void _OnPlayerDying(object arg)
		{
		}

		// Token: 0x0600E706 RID: 59142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E706")]
		[Address(RVA = "0x5BB890", Offset = "0x5BA490", VA = "0x1805BB890")]
		private void _OnPlayerRevive(object arg)
		{
		}

		// Token: 0x0600E707 RID: 59143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E707")]
		[Address(RVA = "0x5BB4D0", Offset = "0x5BA0D0", VA = "0x1805BB4D0")]
		private void _GetModeAlive()
		{
		}

		// Token: 0x0600E708 RID: 59144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E708")]
		[Address(RVA = "0x5BB980", Offset = "0x5BA580", VA = "0x1805BB980")]
		public CooperateStartTile()
		{
		}

		// Token: 0x0600E709 RID: 59145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E709")]
		[Address(RVA = "0x50CDC0", Offset = "0x50B9C0", VA = "0x18050CDC0")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0400FE6E RID: 65134
		[Token(Token = "0x400FE6E")]
		private const string DEFAULT_EFFECT_DIRECT = "down";

		// Token: 0x0400FE6F RID: 65135
		[Token(Token = "0x400FE6F")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private string _directEffectKey;

		// Token: 0x0400FE70 RID: 65136
		[Token(Token = "0x400FE70")]
		[FieldOffset(Offset = "0x1F0")]
		private PlayerSide m_tilePlayerSide;

		// Token: 0x0400FE71 RID: 65137
		[Token(Token = "0x400FE71")]
		[FieldOffset(Offset = "0x1F4")]
		private PlayerSide m_curPlayerSide;

		// Token: 0x0400FE72 RID: 65138
		[Token(Token = "0x400FE72")]
		[FieldOffset(Offset = "0x1F8")]
		private GameModeFactory.CooperateGameMode m_gameMode;

		// Token: 0x0400FE73 RID: 65139
		[Token(Token = "0x400FE73")]
		[FieldOffset(Offset = "0x200")]
		private SharedConsts.Direction m_direct;

		// Token: 0x0400FE74 RID: 65140
		[Token(Token = "0x400FE74")]
		[FieldOffset(Offset = "0x208")]
		private ObjectPtr<Effect> m_tileEffect;

		// Token: 0x0400FE75 RID: 65141
		[Token(Token = "0x400FE75")]
		[FieldOffset(Offset = "0x218")]
		private bool m_isPlayerDead;

		// Token: 0x0400FE76 RID: 65142
		[Token(Token = "0x400FE76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FE77 RID: 65143
		[Token(Token = "0x400FE77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400FE78 RID: 65144
		[Token(Token = "0x400FE78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnPlayerDying;

		// Token: 0x0400FE79 RID: 65145
		[Token(Token = "0x400FE79")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnPlayerRevive;

		// Token: 0x0400FE7A RID: 65146
		[Token(Token = "0x400FE7A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetModeAlive;

		// Token: 0x0400FE7B RID: 65147
		[Token(Token = "0x400FE7B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002392 RID: 9106
		[Token(Token = "0x2002392")]
		private enum TileState
		{
			// Token: 0x0400FE7D RID: 65149
			[Token(Token = "0x400FE7D")]
			NORMAL,
			// Token: 0x0400FE7E RID: 65150
			[Token(Token = "0x400FE7E")]
			MATE_DEAD
		}
	}
}
