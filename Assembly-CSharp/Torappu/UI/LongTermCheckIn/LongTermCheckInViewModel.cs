using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.LongTermCheckIn
{
	// Token: 0x020049C7 RID: 18887
	[Token(Token = "0x20049C7")]
	public class LongTermCheckInViewModel
	{
		// Token: 0x0601C722 RID: 116514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C722")]
		[Address(RVA = "0x15E6610", Offset = "0x15E5210", VA = "0x1815E6610")]
		public void LoadData(bool showLast)
		{
		}

		// Token: 0x0601C723 RID: 116515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C723")]
		[Address(RVA = "0x15E68A0", Offset = "0x15E54A0", VA = "0x1815E68A0")]
		public LongTermCheckInViewModel()
		{
		}

		// Token: 0x0402546E RID: 152686
		[Token(Token = "0x402546E")]
		[FieldOffset(Offset = "0x10")]
		public int currentIndex;

		// Token: 0x0402546F RID: 152687
		[Token(Token = "0x402546F")]
		[FieldOffset(Offset = "0x14")]
		public int totalCount;

		// Token: 0x04025470 RID: 152688
		[Token(Token = "0x4025470")]
		[FieldOffset(Offset = "0x18")]
		public List<LongTermCheckInGroupViewModel> modelList;
	}
}
