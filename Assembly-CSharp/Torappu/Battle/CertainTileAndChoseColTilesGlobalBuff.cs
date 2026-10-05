using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002267 RID: 8807
	[Token(Token = "0x2002267")]
	public class CertainTileAndChoseColTilesGlobalBuff : AbstractBindingTileGlobalBuff
	{
		// Token: 0x0600DD7E RID: 56702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD7E")]
		[Address(RVA = "0x362D5D0", Offset = "0x362C1D0", VA = "0x18362D5D0", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD7F RID: 56703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DD7F")]
		[Address(RVA = "0x362D690", Offset = "0x362C290", VA = "0x18362D690", Slot = "17")]
		protected override List<GridPosition> SelectTiles(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DD80 RID: 56704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD80")]
		[Address(RVA = "0x362D9C0", Offset = "0x362C5C0", VA = "0x18362D9C0")]
		public CertainTileAndChoseColTilesGlobalBuff()
		{
		}

		// Token: 0x0600DD81 RID: 56705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD81")]
		[Address(RVA = "0x362D9B0", Offset = "0x362C5B0", VA = "0x18362D9B0")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0400EFF3 RID: 61427
		[Token(Token = "0x400EFF3")]
		private const string SEQUENCE_SELECT = "sequence_select";

		// Token: 0x0400EFF4 RID: 61428
		[Token(Token = "0x400EFF4")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private List<string> _tileKey;

		// Token: 0x0400EFF5 RID: 61429
		[Token(Token = "0x400EFF5")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private bool _sequenceSelect;

		// Token: 0x0400EFF6 RID: 61430
		[Token(Token = "0x400EFF6")]
		[FieldOffset(Offset = "0x171")]
		private bool m_sequenceSelect;

		// Token: 0x0400EFF7 RID: 61431
		[Token(Token = "0x400EFF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400EFF8 RID: 61432
		[Token(Token = "0x400EFF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectTiles;

		// Token: 0x0400EFF9 RID: 61433
		[Token(Token = "0x400EFF9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
