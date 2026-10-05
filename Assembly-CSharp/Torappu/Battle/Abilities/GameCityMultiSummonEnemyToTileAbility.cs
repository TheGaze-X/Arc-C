using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF3 RID: 10995
	[Token(Token = "0x2002AF3")]
	public class GameCityMultiSummonEnemyToTileAbility : SummonEnemyToTileAbility
	{
		// Token: 0x17002843 RID: 10307
		// (get) Token: 0x060125C5 RID: 75205 RVA: 0x000706E0 File Offset: 0x0006E8E0
		[Token(Token = "0x17002843")]
		protected override bool notSpawnWhenCastEnd
		{
			[Token(Token = "0x60125C5")]
			[Address(RVA = "0xA73CD0", Offset = "0xA728D0", VA = "0x180A73CD0", Slot = "108")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060125C6 RID: 75206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C6")]
		[Address(RVA = "0xA73500", Offset = "0xA72100", VA = "0x180A73500", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060125C7 RID: 75207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C7")]
		[Address(RVA = "0xA73620", Offset = "0xA72220", VA = "0x180A73620")]
		private void _DoSummonEnemies()
		{
		}

		// Token: 0x060125C8 RID: 75208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C8")]
		[Address(RVA = "0xA73B00", Offset = "0xA72700", VA = "0x180A73B00")]
		public GameCityMultiSummonEnemyToTileAbility()
		{
		}

		// Token: 0x060125C9 RID: 75209 RVA: 0x000706F8 File Offset: 0x0006E8F8
		[Token(Token = "0x60125C9")]
		[Address(RVA = "0xA735C0", Offset = "0xA721C0", VA = "0x180A735C0")]
		private bool <>xLuaBaseProxy_get_notSpawnWhenCastEnd()
		{
			return default(bool);
		}

		// Token: 0x060125CA RID: 75210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125CA")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x04014C23 RID: 85027
		[Token(Token = "0x4014C23")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Multi")]
		private int _spawnCnt;

		// Token: 0x04014C24 RID: 85028
		[Token(Token = "0x4014C24")]
		[FieldOffset(Offset = "0x26C")]
		[SerializeField]
		[Group("Multi")]
		private float _delayTime;

		// Token: 0x04014C25 RID: 85029
		[Token(Token = "0x4014C25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_notSpawnWhenCastEnd;

		// Token: 0x04014C26 RID: 85030
		[Token(Token = "0x4014C26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014C27 RID: 85031
		[Token(Token = "0x4014C27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoSummonEnemies;

		// Token: 0x04014C28 RID: 85032
		[Token(Token = "0x4014C28")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
