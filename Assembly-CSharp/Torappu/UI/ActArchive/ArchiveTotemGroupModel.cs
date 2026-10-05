using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C4D RID: 27725
	[Token(Token = "0x2006C4D")]
	public class ArchiveTotemGroupModel
	{
		// Token: 0x0602792C RID: 162092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602792C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArchiveTotemGroupModel()
		{
		}

		// Token: 0x040381F5 RID: 229877
		[Token(Token = "0x40381F5")]
		public const int ITEM_COUNT_LIMIT = 5;

		// Token: 0x040381F6 RID: 229878
		[Token(Token = "0x40381F6")]
		[FieldOffset(Offset = "0x10")]
		public bool isFlag;

		// Token: 0x040381F7 RID: 229879
		[Token(Token = "0x40381F7")]
		[FieldOffset(Offset = "0x14")]
		public ActArchiveTotemType flag;

		// Token: 0x040381F8 RID: 229880
		[Token(Token = "0x40381F8")]
		[FieldOffset(Offset = "0x18")]
		public List<TotemItemModel> items;
	}
}
