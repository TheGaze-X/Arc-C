using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002272 RID: 8818
	[Token(Token = "0x2002272")]
	public class RandomTileGlobalBuff : AbstractBindingTileGlobalBuff
	{
		// Token: 0x0600DDD6 RID: 56790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDD6")]
		[Address(RVA = "0x363CC90", Offset = "0x363B890", VA = "0x18363CC90", Slot = "17")]
		protected override List<GridPosition> SelectTiles(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DDD7 RID: 56791 RVA: 0x00050E20 File Offset: 0x0004F020
		[Token(Token = "0x600DDD7")]
		[Address(RVA = "0x363CD80", Offset = "0x363B980", VA = "0x18363CD80", Slot = "19")]
		public virtual bool TryAddBindingTiles(List<Tile> tiles)
		{
			return default(bool);
		}

		// Token: 0x0600DDD8 RID: 56792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDD8")]
		[Address(RVA = "0x363D460", Offset = "0x363C060", VA = "0x18363D460")]
		private List<GridPosition> _SelectTilesByManhattanDistanceFromCenter(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DDD9 RID: 56793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DDD9")]
		[Address(RVA = "0x363D160", Offset = "0x363BD60", VA = "0x18363D160")]
		private List<GridPosition> _SelectTilesByEqualWeight(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DDDA RID: 56794 RVA: 0x00050E38 File Offset: 0x0004F038
		[Token(Token = "0x600DDDA")]
		[Address(RVA = "0x363D0B0", Offset = "0x363BCB0", VA = "0x18363D0B0")]
		private bool _CheckValidMap()
		{
			return default(bool);
		}

		// Token: 0x0600DDDB RID: 56795 RVA: 0x00050E50 File Offset: 0x0004F050
		[Token(Token = "0x600DDDB")]
		[Address(RVA = "0x363CC00", Offset = "0x363B800", VA = "0x18363CC00", Slot = "20")]
		protected virtual bool FilterTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600DDDC RID: 56796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DDDC")]
		[Address(RVA = "0x363DA50", Offset = "0x363C650", VA = "0x18363DA50")]
		public RandomTileGlobalBuff()
		{
		}

		// Token: 0x0400F085 RID: 61573
		[Token(Token = "0x400F085")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		[Group("BindingTile")]
		protected BuildableType _buildableType;

		// Token: 0x0400F086 RID: 61574
		[Token(Token = "0x400F086")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		[Group("BindingTile")]
		private RandomTileGlobalBuff.RandomWeightType _weightType;

		// Token: 0x0400F087 RID: 61575
		[Token(Token = "0x400F087")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SelectTiles;

		// Token: 0x0400F088 RID: 61576
		[Token(Token = "0x400F088")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryAddBindingTiles;

		// Token: 0x0400F089 RID: 61577
		[Token(Token = "0x400F089")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__SelectTilesByManhattanDistanceFromCenter;

		// Token: 0x0400F08A RID: 61578
		[Token(Token = "0x400F08A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SelectTilesByEqualWeight;

		// Token: 0x0400F08B RID: 61579
		[Token(Token = "0x400F08B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckValidMap;

		// Token: 0x0400F08C RID: 61580
		[Token(Token = "0x400F08C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FilterTile;

		// Token: 0x0400F08D RID: 61581
		[Token(Token = "0x400F08D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002273 RID: 8819
		[Token(Token = "0x2002273")]
		private enum RandomWeightType
		{
			// Token: 0x0400F08F RID: 61583
			[Token(Token = "0x400F08F")]
			MANHATTAN_DISTANCE_FROM_CENTER,
			// Token: 0x0400F090 RID: 61584
			[Token(Token = "0x400F090")]
			EQUAL_WEIGHT
		}
	}
}
