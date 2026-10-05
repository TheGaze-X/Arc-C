using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200239C RID: 9116
	[Token(Token = "0x200239C")]
	public class DynamicBuffTileWithExtraOptions : DynamicBuffTile
	{
		// Token: 0x0600E730 RID: 59184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E730")]
		[Address(RVA = "0x5CFFE0", Offset = "0x5CEBE0", VA = "0x1805CFFE0", Slot = "22")]
		protected override void PreprocessTileOptions(ref Tile.Options tileOptions)
		{
		}

		// Token: 0x0600E731 RID: 59185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E731")]
		[Address(RVA = "0x5D0050", Offset = "0x5CEC50", VA = "0x1805D0050")]
		public DynamicBuffTileWithExtraOptions()
		{
		}

		// Token: 0x0600E732 RID: 59186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E732")]
		[Address(RVA = "0x5CFB20", Offset = "0x5CE720", VA = "0x1805CFB20")]
		private void <>xLuaBaseProxy_PreprocessTileOptions(ref Tile.Options P0)
		{
		}

		// Token: 0x0400FEA0 RID: 65184
		[Token(Token = "0x400FEA0")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private AdvancedBuildableMask _advancedBuildableMask;

		// Token: 0x0400FEA1 RID: 65185
		[Token(Token = "0x400FEA1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PreprocessTileOptions;

		// Token: 0x0400FEA2 RID: 65186
		[Token(Token = "0x400FEA2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
