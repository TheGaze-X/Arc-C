using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B7F RID: 27519
	[Token(Token = "0x2006B7F")]
	public class EndbookEndModelComparer : IComparer<KeyValuePair<string, ArchiveEndbookEndModel>>, IHotfixable
	{
		// Token: 0x06027512 RID: 161042 RVA: 0x000CDFF8 File Offset: 0x000CC1F8
		[Token(Token = "0x6027512")]
		[Address(RVA = "0x2289B60", Offset = "0x2288760", VA = "0x182289B60", Slot = "4")]
		public int Compare(KeyValuePair<string, ArchiveEndbookEndModel> x, KeyValuePair<string, ArchiveEndbookEndModel> y)
		{
			return 0;
		}

		// Token: 0x06027513 RID: 161043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027513")]
		[Address(RVA = "0x2289C40", Offset = "0x2288840", VA = "0x182289C40")]
		public EndbookEndModelComparer()
		{
		}

		// Token: 0x04037B00 RID: 228096
		[Token(Token = "0x4037B00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x04037B01 RID: 228097
		[Token(Token = "0x4037B01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
