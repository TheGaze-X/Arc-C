using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020042A3 RID: 17059
	[Token(Token = "0x20042A3")]
	public class SandboxV2DungeonMiscLogisticsEffectItemComparer : IComparer<KeyValuePair<string, SandboxV2DungeonMiscLogisticsEffectItemViewModel>>, IHotfixable
	{
		// Token: 0x0601A450 RID: 107600 RVA: 0x000A0A40 File Offset: 0x0009EC40
		[Token(Token = "0x601A450")]
		[Address(RVA = "0x1330560", Offset = "0x132F160", VA = "0x181330560", Slot = "4")]
		public int Compare(KeyValuePair<string, SandboxV2DungeonMiscLogisticsEffectItemViewModel> x, KeyValuePair<string, SandboxV2DungeonMiscLogisticsEffectItemViewModel> y)
		{
			return 0;
		}

		// Token: 0x0601A451 RID: 107601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A451")]
		[Address(RVA = "0x1330630", Offset = "0x132F230", VA = "0x181330630")]
		public SandboxV2DungeonMiscLogisticsEffectItemComparer()
		{
		}

		// Token: 0x04021453 RID: 136275
		[Token(Token = "0x4021453")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x04021454 RID: 136276
		[Token(Token = "0x4021454")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
