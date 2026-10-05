using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C0C RID: 27660
	[Token(Token = "0x2006C0C")]
	public class RelicItemModelComparer : IComparer<KeyValuePair<string, RelicItemModel>>, IHotfixable
	{
		// Token: 0x060277E8 RID: 161768 RVA: 0x000CE898 File Offset: 0x000CCA98
		[Token(Token = "0x60277E8")]
		[Address(RVA = "0x22BAE40", Offset = "0x22B9A40", VA = "0x1822BAE40", Slot = "4")]
		public int Compare(KeyValuePair<string, RelicItemModel> x, KeyValuePair<string, RelicItemModel> y)
		{
			return 0;
		}

		// Token: 0x060277E9 RID: 161769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60277E9")]
		[Address(RVA = "0x22BAF20", Offset = "0x22B9B20", VA = "0x1822BAF20")]
		public RelicItemModelComparer()
		{
		}

		// Token: 0x04037FCE RID: 229326
		[Token(Token = "0x4037FCE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x04037FCF RID: 229327
		[Token(Token = "0x4037FCF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
