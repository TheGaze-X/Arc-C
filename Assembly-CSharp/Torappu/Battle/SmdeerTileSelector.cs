using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002549 RID: 9545
	[Token(Token = "0x2002549")]
	public class SmdeerTileSelector : TargetRelatedTileSelector
	{
		// Token: 0x0600F650 RID: 63056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F650")]
		[Address(RVA = "0x6DD7F0", Offset = "0x6DC3F0", VA = "0x1806DD7F0", Slot = "42")]
		protected override List<Tile> _GetRelatedTile(ReusableList<Entity> targets)
		{
			return null;
		}

		// Token: 0x0600F651 RID: 63057 RVA: 0x0005BAD0 File Offset: 0x00059CD0
		[Token(Token = "0x600F651")]
		[Address(RVA = "0x6DD990", Offset = "0x6DC590", VA = "0x1806DD990")]
		private bool _TryGetTile(Entity target, out Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600F652 RID: 63058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F652")]
		[Address(RVA = "0x6DDBC0", Offset = "0x6DC7C0", VA = "0x1806DDBC0")]
		public SmdeerTileSelector()
		{
		}

		// Token: 0x04011142 RID: 69954
		[Token(Token = "0x4011142")]
		[FieldOffset(Offset = "0x180")]
		private List<Tile> m_candidates;

		// Token: 0x04011143 RID: 69955
		[Token(Token = "0x4011143")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__GetRelatedTile;

		// Token: 0x04011144 RID: 69956
		[Token(Token = "0x4011144")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryGetTile;

		// Token: 0x04011145 RID: 69957
		[Token(Token = "0x4011145")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
