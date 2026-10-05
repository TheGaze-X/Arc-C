using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200250E RID: 9486
	[Token(Token = "0x200250E")]
	public class EnemyTokenSelector : TargetSelector
	{
		// Token: 0x0600F471 RID: 62577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F471")]
		[Address(RVA = "0x6BD600", Offset = "0x6BC200", VA = "0x1806BD600", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F472 RID: 62578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F472")]
		[Address(RVA = "0x6BDAF0", Offset = "0x6BC6F0", VA = "0x1806BDAF0", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F473 RID: 62579 RVA: 0x0005A4E0 File Offset: 0x000586E0
		[Token(Token = "0x600F473")]
		[Address(RVA = "0x6BD460", Offset = "0x6BC060", VA = "0x1806BD460", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F474 RID: 62580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F474")]
		[Address(RVA = "0x6BDB60", Offset = "0x6BC760", VA = "0x1806BDB60")]
		public EnemyTokenSelector()
		{
		}

		// Token: 0x04010EB2 RID: 69298
		[Token(Token = "0x4010EB2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010EB3 RID: 69299
		[Token(Token = "0x4010EB3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010EB4 RID: 69300
		[Token(Token = "0x4010EB4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010EB5 RID: 69301
		[Token(Token = "0x4010EB5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
