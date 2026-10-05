using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200238D RID: 9101
	[Token(Token = "0x200238D")]
	public class BuffTile : Tile, IBuffSource
	{
		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x0600E6CF RID: 59087 RVA: 0x00054180 File Offset: 0x00052380
		[Token(Token = "0x17001CFB")]
		protected virtual bool traceBuffUids
		{
			[Token(Token = "0x600E6CF")]
			[Address(RVA = "0x5B8CB0", Offset = "0x5B78B0", VA = "0x1805B8CB0", Slot = "42")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x0600E6D0 RID: 59088 RVA: 0x00054198 File Offset: 0x00052398
		[Token(Token = "0x17001CFC")]
		protected SideType sourceSide
		{
			[Token(Token = "0x600E6D0")]
			[Address(RVA = "0x5B8C40", Offset = "0x5B7840", VA = "0x1805B8C40")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x0600E6D1 RID: 59089 RVA: 0x000541B0 File Offset: 0x000523B0
		[Token(Token = "0x17001CFD")]
		protected bool applyToCharacter
		{
			[Token(Token = "0x600E6D1")]
			[Address(RVA = "0x5B8B40", Offset = "0x5B7740", VA = "0x1805B8B40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x0600E6D2 RID: 59090 RVA: 0x000541C8 File Offset: 0x000523C8
		[Token(Token = "0x17001CFE")]
		protected bool applyToEnemy
		{
			[Token(Token = "0x600E6D2")]
			[Address(RVA = "0x5B8BC0", Offset = "0x5B77C0", VA = "0x1805B8BC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E6D3 RID: 59091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D3")]
		[Address(RVA = "0x5B7FB0", Offset = "0x5B6BB0", VA = "0x1805B7FB0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E6D4 RID: 59092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D4")]
		[Address(RVA = "0x5B7F00", Offset = "0x5B6B00", VA = "0x1805B7F00", Slot = "43")]
		public virtual void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600E6D5 RID: 59093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D5")]
		[Address(RVA = "0x5B8140", Offset = "0x5B6D40", VA = "0x1805B8140", Slot = "26")]
		protected override void OnCharacterEnter(Character newChar, Character oldChar)
		{
		}

		// Token: 0x0600E6D6 RID: 59094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D6")]
		[Address(RVA = "0x5B8230", Offset = "0x5B6E30", VA = "0x1805B8230", Slot = "27")]
		protected override void OnCharacterLeave(Character character)
		{
		}

		// Token: 0x0600E6D7 RID: 59095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D7")]
		[Address(RVA = "0x5B86D0", Offset = "0x5B72D0", VA = "0x1805B86D0", Slot = "28")]
		public override void OnRallyPointLikeReborn(Unit unit)
		{
		}

		// Token: 0x0600E6D8 RID: 59096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D8")]
		[Address(RVA = "0x5B8790", Offset = "0x5B7390", VA = "0x1805B8790", Slot = "30")]
		public override void OnTokenCategoryChanged(Token token)
		{
		}

		// Token: 0x0600E6D9 RID: 59097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6D9")]
		[Address(RVA = "0x5B82E0", Offset = "0x5B6EE0", VA = "0x1805B82E0", Slot = "31")]
		protected override void OnEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E6DA RID: 59098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6DA")]
		[Address(RVA = "0x5B84D0", Offset = "0x5B70D0", VA = "0x1805B84D0", Slot = "32")]
		protected override void OnEnemyLeave(Enemy enemy)
		{
		}

		// Token: 0x0600E6DB RID: 59099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6DB")]
		[Address(RVA = "0x5B7820", Offset = "0x5B6420", VA = "0x1805B7820")]
		private void ApplyBuffs(Entity target, List<uint> buffUids)
		{
		}

		// Token: 0x0600E6DC RID: 59100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6DC")]
		[Address(RVA = "0x5B7BC0", Offset = "0x5B67C0", VA = "0x1805B7BC0")]
		protected void ClearBuffs(Entity target, List<uint> buffUids)
		{
		}

		// Token: 0x0600E6DD RID: 59101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E6DD")]
		[Address(RVA = "0x5B7CF0", Offset = "0x5B68F0", VA = "0x1805B7CF0")]
		protected List<uint> EnsureEnemyBuffList(Entity enemy, Dictionary<ObjectPtr<Entity>, List<uint>> buffUidDict)
		{
			return null;
		}

		// Token: 0x0600E6DE RID: 59102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6DE")]
		[Address(RVA = "0x5B8850", Offset = "0x5B7450", VA = "0x1805B8850", Slot = "44")]
		protected virtual void PreloadBuffAssets()
		{
		}

		// Token: 0x0600E6DF RID: 59103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6DF")]
		[Address(RVA = "0x5B8650", Offset = "0x5B7250", VA = "0x1805B8650", Slot = "45")]
		public virtual void OnInvalidEnemyEnter(Enemy enemy)
		{
		}

		// Token: 0x0600E6E0 RID: 59104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E0")]
		[Address(RVA = "0x5B85A0", Offset = "0x5B71A0", VA = "0x1805B85A0", Slot = "46")]
		public virtual void OnEnemyValid(Enemy enemy)
		{
		}

		// Token: 0x0600E6E1 RID: 59105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E1")]
		[Address(RVA = "0x5B8420", Offset = "0x5B7020", VA = "0x1805B8420", Slot = "47")]
		public virtual void OnEnemyInvalid(Enemy enemy)
		{
		}

		// Token: 0x0600E6E2 RID: 59106 RVA: 0x000541E0 File Offset: 0x000523E0
		[Token(Token = "0x600E6E2")]
		[Address(RVA = "0x5B79D0", Offset = "0x5B65D0", VA = "0x1805B79D0")]
		protected bool CheckTargetInBlackList(Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E6E3 RID: 59107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E3")]
		[Address(RVA = "0x5B8A30", Offset = "0x5B7630", VA = "0x1805B8A30")]
		public BuffTile()
		{
		}

		// Token: 0x0600E6E5 RID: 59109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E5")]
		[Address(RVA = "0x5B8930", Offset = "0x5B7530", VA = "0x1805B8930")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0600E6E6 RID: 59110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E6")]
		[Address(RVA = "0x5B8940", Offset = "0x5B7540", VA = "0x1805B8940")]
		private void <>xLuaBaseProxy_OnCharacterEnter(Character P0, Character P1)
		{
		}

		// Token: 0x0600E6E7 RID: 59111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E7")]
		[Address(RVA = "0x5B8950", Offset = "0x5B7550", VA = "0x1805B8950")]
		private void <>xLuaBaseProxy_OnCharacterLeave(Character P0)
		{
		}

		// Token: 0x0600E6E8 RID: 59112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E8")]
		[Address(RVA = "0x5B8980", Offset = "0x5B7580", VA = "0x1805B8980")]
		private void <>xLuaBaseProxy_OnRallyPointLikeReborn(Unit P0)
		{
		}

		// Token: 0x0600E6E9 RID: 59113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6E9")]
		[Address(RVA = "0x5B8990", Offset = "0x5B7590", VA = "0x1805B8990")]
		private void <>xLuaBaseProxy_OnTokenCategoryChanged(Token P0)
		{
		}

		// Token: 0x0600E6EA RID: 59114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6EA")]
		[Address(RVA = "0x5B8960", Offset = "0x5B7560", VA = "0x1805B8960")]
		private void <>xLuaBaseProxy_OnEnemyEnter(Enemy P0)
		{
		}

		// Token: 0x0600E6EB RID: 59115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E6EB")]
		[Address(RVA = "0x5B8970", Offset = "0x5B7570", VA = "0x1805B8970")]
		private void <>xLuaBaseProxy_OnEnemyLeave(Enemy P0)
		{
		}

		// Token: 0x0400FE29 RID: 65065
		[Token(Token = "0x400FE29")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<uint> EMPTY_IDS;

		// Token: 0x0400FE2A RID: 65066
		[Token(Token = "0x400FE2A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x0400FE2B RID: 65067
		[Token(Token = "0x400FE2B")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private SideType _sourceSide;

		// Token: 0x0400FE2C RID: 65068
		[Token(Token = "0x400FE2C")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		protected BuffData[] _buffs;

		// Token: 0x0400FE2D RID: 65069
		[Token(Token = "0x400FE2D")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private bool _clearBuffsWhenLeft;

		// Token: 0x0400FE2E RID: 65070
		[Token(Token = "0x400FE2E")]
		[FieldOffset(Offset = "0x1A0")]
		protected List<uint> m_charBuffUids;

		// Token: 0x0400FE2F RID: 65071
		[Token(Token = "0x400FE2F")]
		[FieldOffset(Offset = "0x1A8")]
		private Dictionary<ObjectPtr<Entity>, List<uint>> m_enemyBuffUids;

		// Token: 0x0400FE30 RID: 65072
		[Token(Token = "0x400FE30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_traceBuffUids;

		// Token: 0x0400FE31 RID: 65073
		[Token(Token = "0x400FE31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_sourceSide;

		// Token: 0x0400FE32 RID: 65074
		[Token(Token = "0x400FE32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_applyToCharacter;

		// Token: 0x0400FE33 RID: 65075
		[Token(Token = "0x400FE33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_applyToEnemy;

		// Token: 0x0400FE34 RID: 65076
		[Token(Token = "0x400FE34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FE35 RID: 65077
		[Token(Token = "0x400FE35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400FE36 RID: 65078
		[Token(Token = "0x400FE36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCharacterEnter;

		// Token: 0x0400FE37 RID: 65079
		[Token(Token = "0x400FE37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCharacterLeave;

		// Token: 0x0400FE38 RID: 65080
		[Token(Token = "0x400FE38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRallyPointLikeReborn;

		// Token: 0x0400FE39 RID: 65081
		[Token(Token = "0x400FE39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTokenCategoryChanged;

		// Token: 0x0400FE3A RID: 65082
		[Token(Token = "0x400FE3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnemyEnter;

		// Token: 0x0400FE3B RID: 65083
		[Token(Token = "0x400FE3B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnemyLeave;

		// Token: 0x0400FE3C RID: 65084
		[Token(Token = "0x400FE3C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ApplyBuffs;

		// Token: 0x0400FE3D RID: 65085
		[Token(Token = "0x400FE3D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ClearBuffs;

		// Token: 0x0400FE3E RID: 65086
		[Token(Token = "0x400FE3E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EnsureEnemyBuffList;

		// Token: 0x0400FE3F RID: 65087
		[Token(Token = "0x400FE3F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_PreloadBuffAssets;

		// Token: 0x0400FE40 RID: 65088
		[Token(Token = "0x400FE40")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnInvalidEnemyEnter;

		// Token: 0x0400FE41 RID: 65089
		[Token(Token = "0x400FE41")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_OnEnemyValid;

		// Token: 0x0400FE42 RID: 65090
		[Token(Token = "0x400FE42")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnEnemyInvalid;

		// Token: 0x0400FE43 RID: 65091
		[Token(Token = "0x400FE43")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CheckTargetInBlackList;

		// Token: 0x0400FE44 RID: 65092
		[Token(Token = "0x400FE44")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
