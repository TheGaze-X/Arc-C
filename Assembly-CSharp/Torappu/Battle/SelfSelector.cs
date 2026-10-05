using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002529 RID: 9513
	[Token(Token = "0x2002529")]
	public class SelfSelector : TargetSelector
	{
		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x0600F585 RID: 62853 RVA: 0x0005B3C8 File Offset: 0x000595C8
		[Token(Token = "0x1700201E")]
		protected int maxTargetNum
		{
			[Token(Token = "0x600F585")]
			[Address(RVA = "0x6DB540", Offset = "0x6DA140", VA = "0x1806DB540")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600F586 RID: 62854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F586")]
		[Address(RVA = "0x6DB310", Offset = "0x6D9F10", VA = "0x1806DB310", Slot = "13")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F587 RID: 62855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F587")]
		[Address(RVA = "0x6DB430", Offset = "0x6DA030", VA = "0x1806DB430", Slot = "20")]
		public override List<Tile> FindTiles(Vector2 pos)
		{
			return null;
		}

		// Token: 0x0600F588 RID: 62856 RVA: 0x0005B3E0 File Offset: 0x000595E0
		[Token(Token = "0x600F588")]
		[Address(RVA = "0x6DB140", Offset = "0x6D9D40", VA = "0x1806DB140", Slot = "14")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F589 RID: 62857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F589")]
		[Address(RVA = "0x6DB4A0", Offset = "0x6DA0A0", VA = "0x1806DB4A0")]
		public SelfSelector()
		{
		}

		// Token: 0x04011032 RID: 69682
		[Token(Token = "0x4011032")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_maxTargetNum;

		// Token: 0x04011033 RID: 69683
		[Token(Token = "0x4011033")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04011034 RID: 69684
		[Token(Token = "0x4011034")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04011035 RID: 69685
		[Token(Token = "0x4011035")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04011036 RID: 69686
		[Token(Token = "0x4011036")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
