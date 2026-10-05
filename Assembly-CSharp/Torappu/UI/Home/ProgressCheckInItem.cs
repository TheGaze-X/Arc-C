using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B66 RID: 19302
	[Token(Token = "0x2004B66")]
	public struct ProgressCheckInItem
	{
		// Token: 0x0601D0E3 RID: 119011 RVA: 0x000AA250 File Offset: 0x000A8450
		[Token(Token = "0x601D0E3")]
		[Address(RVA = "0x16AE5D0", Offset = "0x16AD1D0", VA = "0x1816AE5D0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x040261D1 RID: 156113
		[Token(Token = "0x40261D1")]
		[FieldOffset(Offset = "0x0")]
		public int checkInDay;

		// Token: 0x040261D2 RID: 156114
		[Token(Token = "0x40261D2")]
		[FieldOffset(Offset = "0x8")]
		public List<ISharedItemModel> rewards;
	}
}
