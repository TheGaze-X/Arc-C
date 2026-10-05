using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AF1 RID: 10993
	[Token(Token = "0x2002AF1")]
	public class SpawnTokenOnTileByIDAbility : AbstractSpawnTokenOnTileAbility
	{
		// Token: 0x17002842 RID: 10306
		// (get) Token: 0x060125B9 RID: 75193 RVA: 0x000706C8 File Offset: 0x0006E8C8
		[Token(Token = "0x17002842")]
		private bool addBuffsIfOverlay
		{
			[Token(Token = "0x60125B9")]
			[Address(RVA = "0xA75D60", Offset = "0xA74960", VA = "0x180A75D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060125BA RID: 75194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125BA")]
		[Address(RVA = "0xA756D0", Offset = "0xA742D0", VA = "0x180A756D0", Slot = "111")]
		protected override void DoSpawnOnTile(Tile tile)
		{
		}

		// Token: 0x060125BB RID: 75195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125BB")]
		[Address(RVA = "0xA75BE0", Offset = "0xA747E0", VA = "0x180A75BE0", Slot = "49")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x060125BC RID: 75196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125BC")]
		[Address(RVA = "0xA75CB0", Offset = "0xA748B0", VA = "0x180A75CB0")]
		public SpawnTokenOnTileByIDAbility()
		{
		}

		// Token: 0x060125BD RID: 75197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60125BD")]
		[Address(RVA = "0xA56960", Offset = "0xA55560", VA = "0x180A56960")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x04014C0F RID: 85007
		[Token(Token = "0x4014C0F")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[Group("CastOnTile")]
		private string _tokenId;

		// Token: 0x04014C10 RID: 85008
		[Token(Token = "0x4014C10")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private bool _addBuffsIfOverlay;

		// Token: 0x04014C11 RID: 85009
		[Token(Token = "0x4014C11")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		[Inspect("addBuffsIfOverlay")]
		private BuffData[] _buffsToExistToken;

		// Token: 0x04014C12 RID: 85010
		[Token(Token = "0x4014C12")]
		[FieldOffset(Offset = "0x228")]
		[SerializeField]
		private bool _addBuffsToSpawnedToken;

		// Token: 0x04014C13 RID: 85011
		[Token(Token = "0x4014C13")]
		[FieldOffset(Offset = "0x230")]
		[SerializeField]
		private BuffData[] _buffsToToken;

		// Token: 0x04014C14 RID: 85012
		[Token(Token = "0x4014C14")]
		[FieldOffset(Offset = "0x238")]
		[SerializeField]
		private bool _refreshTokenCardCooldown;

		// Token: 0x04014C15 RID: 85013
		[Token(Token = "0x4014C15")]
		[FieldOffset(Offset = "0x239")]
		[SerializeField]
		private bool _useOwnerHost;

		// Token: 0x04014C16 RID: 85014
		[Token(Token = "0x4014C16")]
		[FieldOffset(Offset = "0x23A")]
		[SerializeField]
		private bool _useOwnerDirection;

		// Token: 0x04014C17 RID: 85015
		[Token(Token = "0x4014C17")]
		[FieldOffset(Offset = "0x23B")]
		[SerializeField]
		private bool _checkTokenMaxDeployCnt;

		// Token: 0x04014C18 RID: 85016
		[Token(Token = "0x4014C18")]
		[FieldOffset(Offset = "0x23C")]
		[SerializeField]
		private bool _forceSpawn;

		// Token: 0x04014C19 RID: 85017
		[Token(Token = "0x4014C19")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_addBuffsIfOverlay;

		// Token: 0x04014C1A RID: 85018
		[Token(Token = "0x4014C1A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSpawnOnTile;

		// Token: 0x04014C1B RID: 85019
		[Token(Token = "0x4014C1B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x04014C1C RID: 85020
		[Token(Token = "0x4014C1C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
