using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002324 RID: 8996
	[Token(Token = "0x2002324")]
	public class GameCityBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E340 RID: 58176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E340")]
		[Address(RVA = "0x571400", Offset = "0x570000", VA = "0x180571400", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E341 RID: 58177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E341")]
		[Address(RVA = "0x571790", Offset = "0x570390", VA = "0x180571790", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E342 RID: 58178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E342")]
		[Address(RVA = "0x571F80", Offset = "0x570B80", VA = "0x180571F80")]
		private void _UpdateCarBuff(FP deltaTime)
		{
		}

		// Token: 0x0600E343 RID: 58179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E343")]
		[Address(RVA = "0x571C90", Offset = "0x570890", VA = "0x180571C90")]
		private void _SpawnTokenRandom()
		{
		}

		// Token: 0x0600E344 RID: 58180 RVA: 0x00052500 File Offset: 0x00050700
		[Token(Token = "0x600E344")]
		[Address(RVA = "0x571900", Offset = "0x570500", VA = "0x180571900")]
		private bool _CheckTileValid(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E345 RID: 58181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E345")]
		[Address(RVA = "0x572070", Offset = "0x570C70", VA = "0x180572070")]
		public GameCityBattleManager()
		{
		}

		// Token: 0x0600E347 RID: 58183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E347")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E348 RID: 58184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E348")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F989 RID: 63881
		[Token(Token = "0x400F989")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _carBuffInterval;

		// Token: 0x0400F98A RID: 63882
		[Token(Token = "0x400F98A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _enemyId;

		// Token: 0x0400F98B RID: 63883
		[Token(Token = "0x400F98B")]
		[FieldOffset(Offset = "0x38")]
		private GameModeFactory.GameCityGameMode m_gameMode;

		// Token: 0x0400F98C RID: 63884
		[Token(Token = "0x400F98C")]
		[FieldOffset(Offset = "0x40")]
		private FP m_carBuffInterval;

		// Token: 0x0400F98D RID: 63885
		[Token(Token = "0x400F98D")]
		[FieldOffset(Offset = "0x48")]
		private string m_enemyId;

		// Token: 0x0400F98E RID: 63886
		[Token(Token = "0x400F98E")]
		[FieldOffset(Offset = "0x50")]
		private LevelData.EnemyData m_enemyData;

		// Token: 0x0400F98F RID: 63887
		[Token(Token = "0x400F98F")]
		[FieldOffset(Offset = "0x58")]
		private PeriodicTimer m_timer;

		// Token: 0x0400F990 RID: 63888
		[Token(Token = "0x400F990")]
		[FieldOffset(Offset = "0x60")]
		private List<Tile> m_tiles;

		// Token: 0x0400F991 RID: 63889
		[Token(Token = "0x400F991")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F992 RID: 63890
		[Token(Token = "0x400F992")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F993 RID: 63891
		[Token(Token = "0x400F993")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateCarBuff;

		// Token: 0x0400F994 RID: 63892
		[Token(Token = "0x400F994")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SpawnTokenRandom;

		// Token: 0x0400F995 RID: 63893
		[Token(Token = "0x400F995")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckTileValid;

		// Token: 0x0400F996 RID: 63894
		[Token(Token = "0x400F996")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
