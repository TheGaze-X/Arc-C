using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BB2 RID: 19378
	[Token(Token = "0x2004BB2")]
	public class HomeMailArchiveDetailViewModel : IHotfixable
	{
		// Token: 0x0601D217 RID: 119319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D217")]
		[Address(RVA = "0x169C740", Offset = "0x169B340", VA = "0x18169C740")]
		public HomeMailArchiveItemViewModel GetSelectedViewModel()
		{
			return null;
		}

		// Token: 0x0601D218 RID: 119320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D218")]
		[Address(RVA = "0x169C7B0", Offset = "0x169B3B0", VA = "0x18169C7B0")]
		public HomeMailArchiveDetailViewModel()
		{
		}

		// Token: 0x040263A4 RID: 156580
		[Token(Token = "0x40263A4")]
		[FieldOffset(Offset = "0x10")]
		public List<HomeMailArchiveItemViewModel> itemList;

		// Token: 0x040263A5 RID: 156581
		[Token(Token = "0x40263A5")]
		[FieldOffset(Offset = "0x18")]
		public int selectIndex;

		// Token: 0x040263A6 RID: 156582
		[Token(Token = "0x40263A6")]
		[FieldOffset(Offset = "0x1C")]
		public int enterSeq;

		// Token: 0x040263A7 RID: 156583
		[Token(Token = "0x40263A7")]
		[FieldOffset(Offset = "0x20")]
		public int nextSeq;

		// Token: 0x040263A8 RID: 156584
		[Token(Token = "0x40263A8")]
		[FieldOffset(Offset = "0x24")]
		public int prevSeq;

		// Token: 0x040263A9 RID: 156585
		[Token(Token = "0x40263A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSelectedViewModel;

		// Token: 0x040263AA RID: 156586
		[Token(Token = "0x40263AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
