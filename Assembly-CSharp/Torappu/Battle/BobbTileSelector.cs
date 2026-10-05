using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002543 RID: 9539
	[Token(Token = "0x2002543")]
	public class BobbTileSelector : TargetRelatedTileSelector
	{
		// Token: 0x0600F61F RID: 63007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F61F")]
		[Address(RVA = "0x6D1030", Offset = "0x6CFC30", VA = "0x1806D1030", Slot = "42")]
		protected override List<Tile> _GetRelatedTile(ReusableList<Entity> targets)
		{
			return null;
		}

		// Token: 0x0600F620 RID: 63008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F620")]
		[Address(RVA = "0x6D12F0", Offset = "0x6CFEF0", VA = "0x1806D12F0")]
		public BobbTileSelector()
		{
		}

		// Token: 0x040110F4 RID: 69876
		[Token(Token = "0x40110F4")]
		[FieldOffset(Offset = "0x180")]
		private List<Tile> m_candidates;

		// Token: 0x040110F5 RID: 69877
		[Token(Token = "0x40110F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetRelatedTile;

		// Token: 0x040110F6 RID: 69878
		[Token(Token = "0x40110F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
