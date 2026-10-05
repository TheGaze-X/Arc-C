using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002269 RID: 8809
	[Token(Token = "0x2002269")]
	public class CertainTileWithExtraRangeGlobalBuff : CertainTileGlobalBuff
	{
		// Token: 0x0600DD86 RID: 56710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD86")]
		[Address(RVA = "0x362DD30", Offset = "0x362C930", VA = "0x18362DD30", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD87 RID: 56711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DD87")]
		[Address(RVA = "0x362DF50", Offset = "0x362CB50", VA = "0x18362DF50", Slot = "17")]
		protected override List<GridPosition> SelectTiles(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DD88 RID: 56712 RVA: 0x00050D00 File Offset: 0x0004EF00
		[Token(Token = "0x600DD88")]
		[Address(RVA = "0x362E430", Offset = "0x362D030", VA = "0x18362E430")]
		private bool _CheckExtraPosValid(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600DD89 RID: 56713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD89")]
		[Address(RVA = "0x362E520", Offset = "0x362D120", VA = "0x18362E520")]
		public CertainTileWithExtraRangeGlobalBuff()
		{
		}

		// Token: 0x0600DD8A RID: 56714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD8A")]
		[Address(RVA = "0x362E410", Offset = "0x362D010", VA = "0x18362E410")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0600DD8B RID: 56715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DD8B")]
		[Address(RVA = "0x362E420", Offset = "0x362D020", VA = "0x18362E420")]
		private List<GridPosition> <>xLuaBaseProxy_SelectTiles(bool P0)
		{
			return null;
		}

		// Token: 0x0400EFFE RID: 61438
		[Token(Token = "0x400EFFE")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Group("BindingTile")]
		private CertainTileWithExtraRangeGlobalBuff.ExtraRangeID _extraRangeID;

		// Token: 0x0400EFFF RID: 61439
		[Token(Token = "0x400EFFF")]
		[FieldOffset(Offset = "0x174")]
		[SerializeField]
		[Group("BindingTile")]
		private bool _excludeCenterTile;

		// Token: 0x0400F000 RID: 61440
		[Token(Token = "0x400F000")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		[Group("BindingTile")]
		private string _centerTileEffect;

		// Token: 0x0400F001 RID: 61441
		[Token(Token = "0x400F001")]
		[FieldOffset(Offset = "0x180")]
		private List<GridPosition> m_centers;

		// Token: 0x0400F002 RID: 61442
		[Token(Token = "0x400F002")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400F003 RID: 61443
		[Token(Token = "0x400F003")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectTiles;

		// Token: 0x0400F004 RID: 61444
		[Token(Token = "0x400F004")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckExtraPosValid;

		// Token: 0x0400F005 RID: 61445
		[Token(Token = "0x400F005")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200226A RID: 8810
		[Token(Token = "0x200226A")]
		private enum ExtraRangeID
		{
			// Token: 0x0400F007 RID: 61447
			[Token(Token = "0x400F007")]
			X_4
		}
	}
}
