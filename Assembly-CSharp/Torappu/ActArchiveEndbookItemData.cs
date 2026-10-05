using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C36 RID: 3126
	[Token(Token = "0x2000C36")]
	public class ActArchiveEndbookItemData
	{
		// Token: 0x06006914 RID: 26900 RVA: 0x00030BD0 File Offset: 0x0002EDD0
		[Token(Token = "0x6006914")]
		[Address(RVA = "0x1FF8AF0", Offset = "0x1FF76F0", VA = "0x181FF8AF0")]
		public bool ShouldSerializeenrollId()
		{
			return default(bool);
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		[Token(Token = "0x6006915")]
		[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
		public bool ShouldSerializeisLast()
		{
			return default(bool);
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006916")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveEndbookItemData()
		{
		}

		// Token: 0x04003FEB RID: 16363
		[Token(Token = "0x4003FEB")]
		[FieldOffset(Offset = "0x10")]
		public string endBookId;

		// Token: 0x04003FEC RID: 16364
		[Token(Token = "0x4003FEC")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04003FED RID: 16365
		[Token(Token = "0x4003FED")]
		[FieldOffset(Offset = "0x20")]
		public string enrollId;

		// Token: 0x04003FEE RID: 16366
		[Token(Token = "0x4003FEE")]
		[FieldOffset(Offset = "0x28")]
		public bool isLast;

		// Token: 0x04003FEF RID: 16367
		[Token(Token = "0x4003FEF")]
		[FieldOffset(Offset = "0x30")]
		public string endbookName;

		// Token: 0x04003FF0 RID: 16368
		[Token(Token = "0x4003FF0")]
		[FieldOffset(Offset = "0x38")]
		public string unlockDesc;

		// Token: 0x04003FF1 RID: 16369
		[Token(Token = "0x4003FF1")]
		[FieldOffset(Offset = "0x40")]
		public string textId;
	}
}
