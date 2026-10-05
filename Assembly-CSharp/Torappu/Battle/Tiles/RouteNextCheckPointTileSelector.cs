using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Tiles
{
	// Token: 0x02002A01 RID: 10753
	[Token(Token = "0x2002A01")]
	public class RouteNextCheckPointTileSelector : TargetSelector
	{
		// Token: 0x06011D6C RID: 73068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D6C")]
		[Address(RVA = "0x9B5970", Offset = "0x9B4570", VA = "0x1809B5970", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x06011D6D RID: 73069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D6D")]
		[Address(RVA = "0x9B5A10", Offset = "0x9B4610", VA = "0x1809B5A10", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x06011D6E RID: 73070 RVA: 0x0006D338 File Offset: 0x0006B538
		[Token(Token = "0x6011D6E")]
		[Address(RVA = "0x9B5900", Offset = "0x9B4500", VA = "0x1809B5900", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x06011D6F RID: 73071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D6F")]
		[Address(RVA = "0x9B5C50", Offset = "0x9B4850", VA = "0x1809B5C50")]
		public RouteNextCheckPointTileSelector()
		{
		}

		// Token: 0x040140AC RID: 82092
		[Token(Token = "0x40140AC")]
		[FieldOffset(Offset = "0x30")]
		private List<Tile> m_castTiles;

		// Token: 0x040140AD RID: 82093
		[Token(Token = "0x40140AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x040140AE RID: 82094
		[Token(Token = "0x40140AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x040140AF RID: 82095
		[Token(Token = "0x40140AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040140B0 RID: 82096
		[Token(Token = "0x40140B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
