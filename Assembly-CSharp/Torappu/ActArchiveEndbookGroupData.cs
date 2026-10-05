using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C35 RID: 3125
	[Token(Token = "0x2000C35")]
	public class ActArchiveEndbookGroupData
	{
		// Token: 0x06006913 RID: 26899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006913")]
		[Address(RVA = "0x1FF8A60", Offset = "0x1FF7660", VA = "0x181FF8A60")]
		public ActArchiveEndbookGroupData()
		{
		}

		// Token: 0x04003FE1 RID: 16353
		[Token(Token = "0x4003FE1")]
		[FieldOffset(Offset = "0x10")]
		public string endId;

		// Token: 0x04003FE2 RID: 16354
		[Token(Token = "0x4003FE2")]
		[FieldOffset(Offset = "0x18")]
		public string endingId;

		// Token: 0x04003FE3 RID: 16355
		[Token(Token = "0x4003FE3")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x04003FE4 RID: 16356
		[Token(Token = "0x4003FE4")]
		[FieldOffset(Offset = "0x28")]
		public string title;

		// Token: 0x04003FE5 RID: 16357
		[Token(Token = "0x4003FE5")]
		[FieldOffset(Offset = "0x30")]
		public string cgId;

		// Token: 0x04003FE6 RID: 16358
		[Token(Token = "0x4003FE6")]
		[FieldOffset(Offset = "0x38")]
		public string backBlurId;

		// Token: 0x04003FE7 RID: 16359
		[Token(Token = "0x4003FE7")]
		[FieldOffset(Offset = "0x40")]
		public string cardId;

		// Token: 0x04003FE8 RID: 16360
		[Token(Token = "0x4003FE8")]
		[FieldOffset(Offset = "0x48")]
		public bool hasAvg;

		// Token: 0x04003FE9 RID: 16361
		[Token(Token = "0x4003FE9")]
		[FieldOffset(Offset = "0x50")]
		public string avgId;

		// Token: 0x04003FEA RID: 16362
		[Token(Token = "0x4003FEA")]
		[FieldOffset(Offset = "0x58")]
		public List<ActArchiveEndbookItemData> clientEndbookItemDatas;
	}
}
