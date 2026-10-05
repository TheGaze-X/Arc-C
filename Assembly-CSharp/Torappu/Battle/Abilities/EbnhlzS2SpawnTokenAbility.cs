using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF2 RID: 10994
	[Token(Token = "0x2002AF2")]
	public class EbnhlzS2SpawnTokenAbility : SpawnTokenOnTileByIDAbility
	{
		// Token: 0x060125BE RID: 75198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125BE")]
		[Address(RVA = "0xA73160", Offset = "0xA71D60", VA = "0x180A73160", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060125BF RID: 75199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125BF")]
		[Address(RVA = "0xA73390", Offset = "0xA71F90", VA = "0x180A73390", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060125C0 RID: 75200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C0")]
		[Address(RVA = "0xA73220", Offset = "0xA71E20", VA = "0x180A73220", Slot = "111")]
		protected override void DoSpawnOnTile(Tile tile)
		{
		}

		// Token: 0x060125C1 RID: 75201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C1")]
		[Address(RVA = "0xA73410", Offset = "0xA72010", VA = "0x180A73410")]
		public EbnhlzS2SpawnTokenAbility()
		{
		}

		// Token: 0x060125C2 RID: 75202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C2")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060125C3 RID: 75203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C3")]
		[Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060125C4 RID: 75204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125C4")]
		[Address(RVA = "0xA73400", Offset = "0xA72000", VA = "0x180A73400")]
		private void <>xLuaBaseProxy_DoSpawnOnTile(Tile P0)
		{
		}

		// Token: 0x04014C1D RID: 85021
		[Token(Token = "0x4014C1D")]
		[FieldOffset(Offset = "0x240")]
		[SerializeField]
		[Group("ChargeAttack")]
		private string _abilityName;

		// Token: 0x04014C1E RID: 85022
		[Token(Token = "0x4014C1E")]
		[FieldOffset(Offset = "0x248")]
		private int m_castCounter;

		// Token: 0x04014C1F RID: 85023
		[Token(Token = "0x4014C1F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014C20 RID: 85024
		[Token(Token = "0x4014C20")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014C21 RID: 85025
		[Token(Token = "0x4014C21")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSpawnOnTile;

		// Token: 0x04014C22 RID: 85026
		[Token(Token = "0x4014C22")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
