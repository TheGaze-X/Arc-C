using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF0 RID: 10992
	[Token(Token = "0x2002AF0")]
	public class SpawnTokenOnTileAbility : AbstractSpawnTokenOnTileAbility
	{
		// Token: 0x17002841 RID: 10305
		// (get) Token: 0x060125B1 RID: 75185 RVA: 0x000706B0 File Offset: 0x0006E8B0
		[Token(Token = "0x17002841")]
		public bool spawnSelf
		{
			[Token(Token = "0x60125B1")]
			[Address(RVA = "0xA75670", Offset = "0xA74270", VA = "0x180A75670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060125B2 RID: 75186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B2")]
		[Address(RVA = "0xA74F00", Offset = "0xA73B00", VA = "0x180A74F00", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060125B3 RID: 75187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B3")]
		[Address(RVA = "0xA74FD0", Offset = "0xA73BD0", VA = "0x180A74FD0", Slot = "111")]
		protected override void DoSpawnOnTile(Tile tile)
		{
		}

		// Token: 0x060125B4 RID: 75188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B4")]
		[Address(RVA = "0xA75310", Offset = "0xA73F10", VA = "0x180A75310")]
		private void _ConvertToBattleCharacterData()
		{
		}

		// Token: 0x060125B5 RID: 75189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B5")]
		[Address(RVA = "0xA75260", Offset = "0xA73E60", VA = "0x180A75260", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060125B6 RID: 75190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B6")]
		[Address(RVA = "0xA75550", Offset = "0xA74150", VA = "0x180A75550")]
		public SpawnTokenOnTileAbility()
		{
		}

		// Token: 0x060125B7 RID: 75191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B7")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125B8 RID: 75192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125B8")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04014BFF RID: 84991
		[Token(Token = "0x4014BFF")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _spawnSelf;

		// Token: 0x04014C00 RID: 84992
		[Token(Token = "0x4014C00")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		[Group("CastOnTile")]
		[Inspect("spawnSelf", false)]
		private AdvancedCharacterInst _tokenToSpawn;

		// Token: 0x04014C01 RID: 84993
		[Token(Token = "0x4014C01")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Group("CastOnTile")]
		private bool _checkBuildableType;

		// Token: 0x04014C02 RID: 84994
		[Token(Token = "0x4014C02")]
		[FieldOffset(Offset = "0x221")]
		[SerializeField]
		private bool _addBuffsToSpawnedToken;

		// Token: 0x04014C03 RID: 84995
		[Token(Token = "0x4014C03")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private BuffData[] _buffsToToken;

		// Token: 0x04014C04 RID: 84996
		[Token(Token = "0x4014C04")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private bool _specifySide;

		// Token: 0x04014C05 RID: 84997
		[Token(Token = "0x4014C05")]
		[FieldOffset(Offset = "0x234")]
		[SerializeField]
		private SideType _sideType;

		// Token: 0x04014C06 RID: 84998
		[Token(Token = "0x4014C06")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private List<string> _tileBlackList;

		// Token: 0x04014C07 RID: 84999
		[Token(Token = "0x4014C07")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		private bool _forceSpawn;

		// Token: 0x04014C08 RID: 85000
		[Token(Token = "0x4014C08")]
		[FieldOffset(Offset = "0x248")]
		private BattleCharacterData m_tokenData;

		// Token: 0x04014C09 RID: 85001
		[Token(Token = "0x4014C09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_spawnSelf;

		// Token: 0x04014C0A RID: 85002
		[Token(Token = "0x4014C0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C0B RID: 85003
		[Token(Token = "0x4014C0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSpawnOnTile;

		// Token: 0x04014C0C RID: 85004
		[Token(Token = "0x4014C0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ConvertToBattleCharacterData;

		// Token: 0x04014C0D RID: 85005
		[Token(Token = "0x4014C0D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014C0E RID: 85006
		[Token(Token = "0x4014C0E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
