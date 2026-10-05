using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023A3 RID: 9123
	[Token(Token = "0x20023A3")]
	public abstract class InteractableTile : Tile
	{
		// Token: 0x17001D11 RID: 7441
		// (get) Token: 0x0600E776 RID: 59254 RVA: 0x00054540 File Offset: 0x00052740
		[Token(Token = "0x17001D11")]
		public override bool triggerable
		{
			[Token(Token = "0x600E776")]
			[Address(RVA = "0x5D52F0", Offset = "0x5D3EF0", VA = "0x1805D52F0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600E777 RID: 59255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E777")]
		[Address(RVA = "0x5D50E0", Offset = "0x5D3CE0", VA = "0x1805D50E0", Slot = "21")]
		public override void Init(TileData tileData, GridPosition pos)
		{
		}

		// Token: 0x0600E778 RID: 59256 RVA: 0x00054558 File Offset: 0x00052758
		[Token(Token = "0x600E778")]
		[Address(RVA = "0x5D51D0", Offset = "0x5D3DD0", VA = "0x1805D51D0")]
		public bool Interact()
		{
			return default(bool);
		}

		// Token: 0x0600E779 RID: 59257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E779")]
		[Address(RVA = "0x5D5290", Offset = "0x5D3E90", VA = "0x1805D5290")]
		protected InteractableTile()
		{
		}

		// Token: 0x0600E77A RID: 59258 RVA: 0x00054570 File Offset: 0x00052770
		[Token(Token = "0x600E77A")]
		[Address(RVA = "0x5D08E0", Offset = "0x5CF4E0", VA = "0x1805D08E0")]
		private bool <>xLuaBaseProxy_get_triggerable()
		{
			return default(bool);
		}

		// Token: 0x0600E77B RID: 59259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E77B")]
		[Address(RVA = "0x5B8930", Offset = "0x5B7530", VA = "0x1805B8930")]
		private void <>xLuaBaseProxy_Init(TileData P0, GridPosition P1)
		{
		}

		// Token: 0x0400FEEF RID: 65263
		[Token(Token = "0x400FEEF")]
		[FieldOffset(Offset = "0x128")]
		private int m_triggerCost;

		// Token: 0x0400FEF0 RID: 65264
		[Token(Token = "0x400FEF0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_triggerable;

		// Token: 0x0400FEF1 RID: 65265
		[Token(Token = "0x400FEF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FEF2 RID: 65266
		[Token(Token = "0x400FEF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Interact;

		// Token: 0x0400FEF3 RID: 65267
		[Token(Token = "0x400FEF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
