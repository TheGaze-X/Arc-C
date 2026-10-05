using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002347 RID: 9031
	[Token(Token = "0x2002347")]
	public class RandomTileSelectorManager : PeriodicTriggerManager
	{
		// Token: 0x0600E473 RID: 58483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E473")]
		[Address(RVA = "0x5A4C50", Offset = "0x5A3850", VA = "0x1805A4C50", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E474 RID: 58484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E474")]
		[Address(RVA = "0x5A4B10", Offset = "0x5A3710", VA = "0x1805A4B10", Slot = "19")]
		public override void FilterTargets()
		{
		}

		// Token: 0x0600E475 RID: 58485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E475")]
		[Address(RVA = "0x5A4F70", Offset = "0x5A3B70", VA = "0x1805A4F70")]
		public RandomTileSelectorManager()
		{
		}

		// Token: 0x0600E476 RID: 58486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E476")]
		[Address(RVA = "0x5A4F60", Offset = "0x5A3B60", VA = "0x1805A4F60")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E477 RID: 58487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E477")]
		[Address(RVA = "0x570D20", Offset = "0x56F920", VA = "0x180570D20")]
		private void <>xLuaBaseProxy_FilterTargets()
		{
		}

		// Token: 0x0400FBA6 RID: 64422
		[Token(Token = "0x400FBA6")]
		[FieldOffset(Offset = "0xA8")]
		private List<RandomTileSelectorManager.WeightedTile> m_weightedTiles;

		// Token: 0x0400FBA7 RID: 64423
		[Token(Token = "0x400FBA7")]
		[FieldOffset(Offset = "0xB0")]
		private float m_weightChangedWhenPick;

		// Token: 0x0400FBA8 RID: 64424
		[Token(Token = "0x400FBA8")]
		private const string WEIGHT_CHANGED = "weight_changed";

		// Token: 0x0400FBA9 RID: 64425
		[Token(Token = "0x400FBA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FBAA RID: 64426
		[Token(Token = "0x400FBAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FilterTargets;

		// Token: 0x0400FBAB RID: 64427
		[Token(Token = "0x400FBAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002348 RID: 9032
		[Token(Token = "0x2002348")]
		public class WeightedTile : IItemWithWeight
		{
			// Token: 0x17001C9A RID: 7322
			// (get) Token: 0x0600E478 RID: 58488 RVA: 0x00052AA0 File Offset: 0x00050CA0
			// (set) Token: 0x0600E479 RID: 58489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C9A")]
			public float weightValue
			{
				[Token(Token = "0x600E478")]
				[Address(RVA = "0x5B4650", Offset = "0x5B3250", VA = "0x1805B4650", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600E479")]
				[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0600E47A RID: 58490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E47A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public WeightedTile()
			{
			}

			// Token: 0x0400FBAC RID: 64428
			[Token(Token = "0x400FBAC")]
			[FieldOffset(Offset = "0x10")]
			public Tile tile;
		}
	}
}
