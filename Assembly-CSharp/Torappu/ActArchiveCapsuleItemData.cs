using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C23 RID: 3107
	[Token(Token = "0x2000C23")]
	public class ActArchiveCapsuleItemData
	{
		// Token: 0x06006902 RID: 26882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006902")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveCapsuleItemData()
		{
		}

		// Token: 0x04003FA5 RID: 16293
		[Token(Token = "0x4003FA5")]
		[FieldOffset(Offset = "0x10")]
		public string capsuleId;

		// Token: 0x04003FA6 RID: 16294
		[Token(Token = "0x4003FA6")]
		[FieldOffset(Offset = "0x18")]
		public int capsuleSortId;

		// Token: 0x04003FA7 RID: 16295
		[Token(Token = "0x4003FA7")]
		[FieldOffset(Offset = "0x20")]
		public string englishName;

		// Token: 0x04003FA8 RID: 16296
		[Token(Token = "0x4003FA8")]
		[FieldOffset(Offset = "0x28")]
		public string enrollId;
	}
}
