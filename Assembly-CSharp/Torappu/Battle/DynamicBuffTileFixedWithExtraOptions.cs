using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200239B RID: 9115
	[Token(Token = "0x200239B")]
	public class DynamicBuffTileFixedWithExtraOptions : DynamicBuffTileFixed
	{
		// Token: 0x0600E72D RID: 59181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E72D")]
		[Address(RVA = "0x5CFAB0", Offset = "0x5CE6B0", VA = "0x1805CFAB0", Slot = "22")]
		protected override void PreprocessTileOptions(ref Tile.Options tileOptions)
		{
		}

		// Token: 0x0600E72E RID: 59182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E72E")]
		[Address(RVA = "0x5CFB80", Offset = "0x5CE780", VA = "0x1805CFB80")]
		public DynamicBuffTileFixedWithExtraOptions()
		{
		}

		// Token: 0x0600E72F RID: 59183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E72F")]
		[Address(RVA = "0x5CFB20", Offset = "0x5CE720", VA = "0x1805CFB20")]
		private void <>xLuaBaseProxy_PreprocessTileOptions(ref Tile.Options P0)
		{
		}

		// Token: 0x0400FE9D RID: 65181
		[Token(Token = "0x400FE9D")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private AdvancedBuildableMask _advancedBuildableMask;

		// Token: 0x0400FE9E RID: 65182
		[Token(Token = "0x400FE9E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PreprocessTileOptions;

		// Token: 0x0400FE9F RID: 65183
		[Token(Token = "0x400FE9F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
