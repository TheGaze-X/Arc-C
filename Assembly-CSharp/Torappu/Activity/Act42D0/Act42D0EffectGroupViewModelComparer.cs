using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200737D RID: 29565
	[Token(Token = "0x200737D")]
	public class Act42D0EffectGroupViewModelComparer : IComparer<KeyValuePair<string, Act42D0EffectGroupViewModel>>, IHotfixable
	{
		// Token: 0x06029CD2 RID: 171218 RVA: 0x000D6980 File Offset: 0x000D4B80
		[Token(Token = "0x6029CD2")]
		[Address(RVA = "0x2559040", Offset = "0x2557C40", VA = "0x182559040", Slot = "4")]
		public int Compare(KeyValuePair<string, Act42D0EffectGroupViewModel> x, KeyValuePair<string, Act42D0EffectGroupViewModel> y)
		{
			return 0;
		}

		// Token: 0x06029CD3 RID: 171219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029CD3")]
		[Address(RVA = "0x2559110", Offset = "0x2557D10", VA = "0x182559110")]
		public Act42D0EffectGroupViewModelComparer()
		{
		}

		// Token: 0x0403BDB9 RID: 245177
		[Token(Token = "0x403BDB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x0403BDBA RID: 245178
		[Token(Token = "0x403BDBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
