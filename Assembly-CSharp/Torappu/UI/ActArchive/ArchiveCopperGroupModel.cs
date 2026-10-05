using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B5A RID: 27482
	[Token(Token = "0x2006B5A")]
	public class ArchiveCopperGroupModel
	{
		// Token: 0x06027456 RID: 160854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027456")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ArchiveCopperGroupModel()
		{
		}

		// Token: 0x0403798F RID: 227727
		[Token(Token = "0x403798F")]
		public const int ITEM_COUNT_LIMIT = 5;

		// Token: 0x04037990 RID: 227728
		[Token(Token = "0x4037990")]
		[FieldOffset(Offset = "0x10")]
		public ArchiveCopperGroupModel.GroupType groupType;

		// Token: 0x04037991 RID: 227729
		[Token(Token = "0x4037991")]
		[FieldOffset(Offset = "0x18")]
		public string archiveId;

		// Token: 0x04037992 RID: 227730
		[Token(Token = "0x4037992")]
		[FieldOffset(Offset = "0x20")]
		public string titleIconId;

		// Token: 0x04037993 RID: 227731
		[Token(Token = "0x4037993")]
		[FieldOffset(Offset = "0x28")]
		public List<CopperItemModel> items;

		// Token: 0x02006B5B RID: 27483
		[Token(Token = "0x2006B5B")]
		public enum GroupType
		{
			// Token: 0x04037995 RID: 227733
			[Token(Token = "0x4037995")]
			TITLE,
			// Token: 0x04037996 RID: 227734
			[Token(Token = "0x4037996")]
			ALL_FLAG,
			// Token: 0x04037997 RID: 227735
			[Token(Token = "0x4037997")]
			DEFAULT
		}
	}
}
