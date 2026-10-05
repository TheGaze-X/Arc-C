using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F51 RID: 3921
	[Token(Token = "0x2000F51")]
	[Serializable]
	public class ChapterData
	{
		// Token: 0x06006C5F RID: 27743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C5F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChapterData()
		{
		}

		// Token: 0x0400535D RID: 21341
		[Token(Token = "0x400535D")]
		[FieldOffset(Offset = "0x10")]
		public string chapterId;

		// Token: 0x0400535E RID: 21342
		[Token(Token = "0x400535E")]
		[FieldOffset(Offset = "0x18")]
		public string chapterName;

		// Token: 0x0400535F RID: 21343
		[Token(Token = "0x400535F")]
		[FieldOffset(Offset = "0x20")]
		public string chapterName2;

		// Token: 0x04005360 RID: 21344
		[Token(Token = "0x4005360")]
		[FieldOffset(Offset = "0x28")]
		public int chapterIndex;

		// Token: 0x04005361 RID: 21345
		[Token(Token = "0x4005361")]
		[FieldOffset(Offset = "0x30")]
		public string preposedChapterId;

		// Token: 0x04005362 RID: 21346
		[Token(Token = "0x4005362")]
		[FieldOffset(Offset = "0x38")]
		public string startZoneId;

		// Token: 0x04005363 RID: 21347
		[Token(Token = "0x4005363")]
		[FieldOffset(Offset = "0x40")]
		public string endZoneId;

		// Token: 0x04005364 RID: 21348
		[Token(Token = "0x4005364")]
		[FieldOffset(Offset = "0x48")]
		public string chapterEndStageId;
	}
}
