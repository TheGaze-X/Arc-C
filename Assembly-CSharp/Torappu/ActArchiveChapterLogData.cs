using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C3A RID: 3130
	[Token(Token = "0x2000C3A")]
	[Serializable]
	public class ActArchiveChapterLogData
	{
		// Token: 0x0600691A RID: 26906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveChapterLogData()
		{
		}

		// Token: 0x04003FF8 RID: 16376
		[Token(Token = "0x4003FF8")]
		[FieldOffset(Offset = "0x10")]
		public string chapterName;

		// Token: 0x04003FF9 RID: 16377
		[Token(Token = "0x4003FF9")]
		[FieldOffset(Offset = "0x18")]
		public string displayId;

		// Token: 0x04003FFA RID: 16378
		[Token(Token = "0x4003FFA")]
		[FieldOffset(Offset = "0x20")]
		public string unlockDes;

		// Token: 0x04003FFB RID: 16379
		[Token(Token = "0x4003FFB")]
		[FieldOffset(Offset = "0x28")]
		public HashSet<string> logs;

		// Token: 0x04003FFC RID: 16380
		[Token(Token = "0x4003FFC")]
		[FieldOffset(Offset = "0x30")]
		public Act17sideData.ChapterIconType chapterIcon;
	}
}
