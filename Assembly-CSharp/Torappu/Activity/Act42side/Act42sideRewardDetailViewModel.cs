using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007304 RID: 29444
	[Token(Token = "0x2007304")]
	public class Act42sideRewardDetailViewModel : IHotfixable
	{
		// Token: 0x06029A6D RID: 170605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A6D")]
		[Address(RVA = "0x251A7F0", Offset = "0x25193F0", VA = "0x18251A7F0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x06029A6E RID: 170606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A6E")]
		[Address(RVA = "0x251AC50", Offset = "0x2519850", VA = "0x18251AC50")]
		public Act42sideRewardDetailViewModel()
		{
		}

		// Token: 0x0403B94F RID: 244047
		[Token(Token = "0x403B94F")]
		[FieldOffset(Offset = "0x10")]
		public List<Act42sideRewardDetailItemViewModel> items;

		// Token: 0x0403B950 RID: 244048
		[Token(Token = "0x403B950")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403B951 RID: 244049
		[Token(Token = "0x403B951")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
