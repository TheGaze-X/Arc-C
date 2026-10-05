using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002489 RID: 9353
	[Token(Token = "0x2002489")]
	public class Thorn2CardTalent : CardHoldTalent
	{
		// Token: 0x0600F093 RID: 61587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F093")]
		[Address(RVA = "0x67D520", Offset = "0x67C120", VA = "0x18067D520", Slot = "21")]
		public override void AssignData(TalentData data, Unit owner, UnitDataFlowConfig.Delta modifier)
		{
		}

		// Token: 0x0600F094 RID: 61588 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F094")]
		[Address(RVA = "0x67D6A0", Offset = "0x67C2A0", VA = "0x18067D6A0", Slot = "33")]
		public override CardHoldTalent.CardHoldDataModifier CreateHoldDataModifier(Character character)
		{
			return null;
		}

		// Token: 0x0600F095 RID: 61589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F095")]
		[Address(RVA = "0x67D610", Offset = "0x67C210", VA = "0x18067D610", Slot = "34")]
		public override UICardEffectHolder.CardEffectPlugin CreateCardEffectPlugin(Character character, CardHoldTalent.CardHoldDataModifier modifier)
		{
			return null;
		}

		// Token: 0x0600F096 RID: 61590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F096")]
		[Address(RVA = "0x67D770", Offset = "0x67C370", VA = "0x18067D770")]
		public Thorn2CardTalent()
		{
		}

		// Token: 0x0600F097 RID: 61591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F097")]
		[Address(RVA = "0x671580", Offset = "0x670180", VA = "0x180671580")]
		private void <>xLuaBaseProxy_AssignData(TalentData P0, Unit P1, UnitDataFlowConfig.Delta P2)
		{
		}

		// Token: 0x04010A08 RID: 68104
		[Token(Token = "0x4010A08")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _passableCnt;

		// Token: 0x04010A09 RID: 68105
		[Token(Token = "0x4010A09")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private MotionMode _motion;

		// Token: 0x04010A0A RID: 68106
		[Token(Token = "0x4010A0A")]
		[FieldOffset(Offset = "0x60")]
		private int m_passableCnt;

		// Token: 0x04010A0B RID: 68107
		[Token(Token = "0x4010A0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AssignData;

		// Token: 0x04010A0C RID: 68108
		[Token(Token = "0x4010A0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateHoldDataModifier;

		// Token: 0x04010A0D RID: 68109
		[Token(Token = "0x4010A0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateCardEffectPlugin;

		// Token: 0x04010A0E RID: 68110
		[Token(Token = "0x4010A0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200248A RID: 9354
		[Token(Token = "0x200248A")]
		private class Thorn2CardModifier : CardHoldTalent.CardHoldDataModifier
		{
			// Token: 0x0600F098 RID: 61592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F098")]
			[Address(RVA = "0x67D2B0", Offset = "0x67BEB0", VA = "0x18067D2B0")]
			public Thorn2CardModifier(int passableCnt, MotionMode motion, Character unit)
			{
			}

			// Token: 0x0600F099 RID: 61593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F099")]
			[Address(RVA = "0x67B130", Offset = "0x679D30", VA = "0x18067B130", Slot = "5")]
			public override void OnTick(Deck.Card card, FP deltaTime)
			{
			}

			// Token: 0x0600F09A RID: 61594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F09A")]
			[Address(RVA = "0x67B1B0", Offset = "0x679DB0", VA = "0x18067B1B0")]
			public void PreproccesssTileInfo()
			{
			}

			// Token: 0x0600F09B RID: 61595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F09B")]
			[Address(RVA = "0x67BC80", Offset = "0x67A880", VA = "0x18067BC80")]
			private void _CheckTileValidRow(int height, int width)
			{
			}

			// Token: 0x0600F09C RID: 61596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F09C")]
			[Address(RVA = "0x67B860", Offset = "0x67A460", VA = "0x18067B860")]
			private void _CheckTileValidCol(int height, int width)
			{
			}

			// Token: 0x0600F09D RID: 61597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600F09D")]
			[Address(RVA = "0x67C0A0", Offset = "0x67ACA0", VA = "0x18067C0A0")]
			private void _SetTilesCollider()
			{
			}

			// Token: 0x04010A0F RID: 68111
			[Token(Token = "0x4010A0F")]
			[FieldOffset(Offset = "0x10")]
			private int m_passableCnt;

			// Token: 0x04010A10 RID: 68112
			[Token(Token = "0x4010A10")]
			[FieldOffset(Offset = "0x14")]
			private MotionMode m_motion;

			// Token: 0x04010A11 RID: 68113
			[Token(Token = "0x4010A11")]
			[FieldOffset(Offset = "0x18")]
			private Character m_owner;

			// Token: 0x04010A12 RID: 68114
			[Token(Token = "0x4010A12")]
			[FieldOffset(Offset = "0x20")]
			private Thorn2CardTalent.Thorn2CardModifier.TileStatus[,] m_passableCntMapsRow;

			// Token: 0x04010A13 RID: 68115
			[Token(Token = "0x4010A13")]
			[FieldOffset(Offset = "0x28")]
			private Thorn2CardTalent.Thorn2CardModifier.TileStatus[,] m_passableCntMapsCol;

			// Token: 0x04010A14 RID: 68116
			[Token(Token = "0x4010A14")]
			[FieldOffset(Offset = "0x30")]
			public List<Tile> m_tilesRow;

			// Token: 0x04010A15 RID: 68117
			[Token(Token = "0x4010A15")]
			[FieldOffset(Offset = "0x38")]
			public List<Tile> m_tilesCol;

			// Token: 0x04010A16 RID: 68118
			[Token(Token = "0x4010A16")]
			[FieldOffset(Offset = "0x40")]
			private Dictionary<Vector2, Vector2> m_collidersRow;

			// Token: 0x04010A17 RID: 68119
			[Token(Token = "0x4010A17")]
			[FieldOffset(Offset = "0x48")]
			private Dictionary<Vector2, Vector2> m_collidersCol;

			// Token: 0x04010A18 RID: 68120
			[Token(Token = "0x4010A18")]
			[FieldOffset(Offset = "0x50")]
			private CharacterSharedTileAuraAbility.ChoseTileDatas cardTileData;

			// Token: 0x04010A19 RID: 68121
			[Token(Token = "0x4010A19")]
			[FieldOffset(Offset = "0x58")]
			private List<Tile> m_tempTile;

			// Token: 0x04010A1A RID: 68122
			[Token(Token = "0x4010A1A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04010A1B RID: 68123
			[Token(Token = "0x4010A1B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnTick;

			// Token: 0x04010A1C RID: 68124
			[Token(Token = "0x4010A1C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_PreproccesssTileInfo;

			// Token: 0x04010A1D RID: 68125
			[Token(Token = "0x4010A1D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__CheckTileValidRow;

			// Token: 0x04010A1E RID: 68126
			[Token(Token = "0x4010A1E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__CheckTileValidCol;

			// Token: 0x04010A1F RID: 68127
			[Token(Token = "0x4010A1F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__SetTilesCollider;

			// Token: 0x0200248B RID: 9355
			[Token(Token = "0x200248B")]
			public enum TileStatus
			{
				// Token: 0x04010A21 RID: 68129
				[Token(Token = "0x4010A21")]
				NONE,
				// Token: 0x04010A22 RID: 68130
				[Token(Token = "0x4010A22")]
				VALID,
				// Token: 0x04010A23 RID: 68131
				[Token(Token = "0x4010A23")]
				INVALID
			}
		}
	}
}
