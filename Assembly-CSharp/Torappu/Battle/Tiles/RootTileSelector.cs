using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Tiles
{
	// Token: 0x02002A00 RID: 10752
	[Token(Token = "0x2002A00")]
	public class RootTileSelector : TargetSelector
	{
		// Token: 0x06011D68 RID: 73064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D68")]
		[Address(RVA = "0x9B3FD0", Offset = "0x9B2BD0", VA = "0x1809B3FD0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x06011D69 RID: 73065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D69")]
		[Address(RVA = "0x9B4070", Offset = "0x9B2C70", VA = "0x1809B4070", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x06011D6A RID: 73066 RVA: 0x0006D320 File Offset: 0x0006B520
		[Token(Token = "0x6011D6A")]
		[Address(RVA = "0x9B3F60", Offset = "0x9B2B60", VA = "0x1809B3F60", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x06011D6B RID: 73067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D6B")]
		[Address(RVA = "0x9B41B0", Offset = "0x9B2DB0", VA = "0x1809B41B0")]
		public RootTileSelector()
		{
		}

		// Token: 0x040140A8 RID: 82088
		[Token(Token = "0x40140A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x040140A9 RID: 82089
		[Token(Token = "0x40140A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x040140AA RID: 82090
		[Token(Token = "0x40140AA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x040140AB RID: 82091
		[Token(Token = "0x40140AB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
