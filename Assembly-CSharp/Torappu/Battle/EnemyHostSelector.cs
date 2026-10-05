using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200250C RID: 9484
	[Token(Token = "0x200250C")]
	public class EnemyHostSelector : TargetSelector
	{
		// Token: 0x0600F45F RID: 62559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F45F")]
		[Address(RVA = "0x6BC7C0", Offset = "0x6BB3C0", VA = "0x1806BC7C0", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F460 RID: 62560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F460")]
		[Address(RVA = "0x6BCB30", Offset = "0x6BB730", VA = "0x1806BCB30", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F461 RID: 62561 RVA: 0x0005A3F0 File Offset: 0x000585F0
		[Token(Token = "0x600F461")]
		[Address(RVA = "0x6BC5E0", Offset = "0x6BB1E0", VA = "0x1806BC5E0", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F462 RID: 62562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F462")]
		[Address(RVA = "0x6BCBA0", Offset = "0x6BB7A0", VA = "0x1806BCBA0")]
		public EnemyHostSelector()
		{
		}

		// Token: 0x04010E9F RID: 69279
		[Token(Token = "0x4010E9F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010EA0 RID: 69280
		[Token(Token = "0x4010EA0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010EA1 RID: 69281
		[Token(Token = "0x4010EA1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010EA2 RID: 69282
		[Token(Token = "0x4010EA2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
