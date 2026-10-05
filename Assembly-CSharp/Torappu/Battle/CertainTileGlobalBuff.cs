using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002268 RID: 8808
	[Token(Token = "0x2002268")]
	public class CertainTileGlobalBuff : AbstractBindingTileGlobalBuff
	{
		// Token: 0x0600DD82 RID: 56706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD82")]
		[Address(RVA = "0x362DA20", Offset = "0x362C620", VA = "0x18362DA20", Slot = "11")]
		public override void OnInit(LevelData.GlobalBuffData data)
		{
		}

		// Token: 0x0600DD83 RID: 56707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DD83")]
		[Address(RVA = "0x362DAE0", Offset = "0x362C6E0", VA = "0x18362DAE0", Slot = "17")]
		protected override List<GridPosition> SelectTiles(bool excludeBorderTiles = false)
		{
			return null;
		}

		// Token: 0x0600DD84 RID: 56708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD84")]
		[Address(RVA = "0x362DCD0", Offset = "0x362C8D0", VA = "0x18362DCD0")]
		public CertainTileGlobalBuff()
		{
		}

		// Token: 0x0600DD85 RID: 56709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD85")]
		[Address(RVA = "0x362D9B0", Offset = "0x362C5B0", VA = "0x18362D9B0")]
		private void <>xLuaBaseProxy_OnInit(LevelData.GlobalBuffData P0)
		{
		}

		// Token: 0x0400EFFA RID: 61434
		[Token(Token = "0x400EFFA")]
		[FieldOffset(Offset = "0x168")]
		private string m_tileKey;

		// Token: 0x0400EFFB RID: 61435
		[Token(Token = "0x400EFFB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400EFFC RID: 61436
		[Token(Token = "0x400EFFC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SelectTiles;

		// Token: 0x0400EFFD RID: 61437
		[Token(Token = "0x400EFFD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
