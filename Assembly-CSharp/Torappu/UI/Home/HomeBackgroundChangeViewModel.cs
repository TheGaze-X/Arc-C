using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B5C RID: 19292
	[Token(Token = "0x2004B5C")]
	public class HomeBackgroundChangeViewModel
	{
		// Token: 0x0601D0C6 RID: 118982 RVA: 0x000AA1D8 File Offset: 0x000A83D8
		[Token(Token = "0x601D0C6")]
		[Address(RVA = "0x16689B0", Offset = "0x16675B0", VA = "0x1816689B0")]
		public int GetTempSelectItemIndex()
		{
			return 0;
		}

		// Token: 0x0601D0C7 RID: 118983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D0C7")]
		[Address(RVA = "0x1668AF0", Offset = "0x16676F0", VA = "0x181668AF0")]
		public HomeBackgroundChangeViewModel()
		{
		}

		// Token: 0x0402619C RID: 156060
		[Token(Token = "0x402619C")]
		[FieldOffset(Offset = "0x10")]
		public List<HomeBackgroundItemModel> itemViewModelList;

		// Token: 0x0402619D RID: 156061
		[Token(Token = "0x402619D")]
		[FieldOffset(Offset = "0x18")]
		public HomeBackgroundItemModel selectedBg;

		// Token: 0x0402619E RID: 156062
		[Token(Token = "0x402619E")]
		[FieldOffset(Offset = "0x20")]
		public bool isHideIllustFlag;

		// Token: 0x0402619F RID: 156063
		[Token(Token = "0x402619F")]
		[FieldOffset(Offset = "0x21")]
		public bool canChangePos;

		// Token: 0x040261A0 RID: 156064
		[Token(Token = "0x40261A0")]
		[FieldOffset(Offset = "0x24")]
		public int enterSequenceNum;

		// Token: 0x040261A1 RID: 156065
		[Token(Token = "0x40261A1")]
		[FieldOffset(Offset = "0x28")]
		public int routedSequenceNum;
	}
}
