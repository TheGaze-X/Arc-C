using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B1A RID: 27418
	[Token(Token = "0x2006B1A")]
	public class BuffItemModelComparer : IComparer<KeyValuePair<string, BuffItemModel>>, IHotfixable
	{
		// Token: 0x0602732C RID: 160556 RVA: 0x000CDA40 File Offset: 0x000CBC40
		[Token(Token = "0x602732C")]
		[Address(RVA = "0x2274D30", Offset = "0x2273930", VA = "0x182274D30", Slot = "4")]
		public int Compare(KeyValuePair<string, BuffItemModel> x, KeyValuePair<string, BuffItemModel> y)
		{
			return 0;
		}

		// Token: 0x0602732D RID: 160557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602732D")]
		[Address(RVA = "0x2274E10", Offset = "0x2273A10", VA = "0x182274E10")]
		public BuffItemModelComparer()
		{
		}

		// Token: 0x04037757 RID: 227159
		[Token(Token = "0x4037757")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x04037758 RID: 227160
		[Token(Token = "0x4037758")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
