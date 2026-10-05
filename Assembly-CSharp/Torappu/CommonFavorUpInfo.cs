using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E78 RID: 3704
	[Token(Token = "0x2000E78")]
	public class CommonFavorUpInfo
	{
		// Token: 0x06006B42 RID: 27458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B42")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CommonFavorUpInfo()
		{
		}

		// Token: 0x04004E07 RID: 19975
		[Token(Token = "0x4004E07")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04004E08 RID: 19976
		[Token(Token = "0x4004E08")]
		[FieldOffset(Offset = "0x18")]
		public long displayStartTime;

		// Token: 0x04004E09 RID: 19977
		[Token(Token = "0x4004E09")]
		[FieldOffset(Offset = "0x20")]
		public long displayEndTime;
	}
}
