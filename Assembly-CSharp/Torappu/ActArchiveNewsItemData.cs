using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C3E RID: 3134
	[Token(Token = "0x2000C3E")]
	public class ActArchiveNewsItemData
	{
		// Token: 0x0600691E RID: 26910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600691E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveNewsItemData()
		{
		}

		// Token: 0x04004001 RID: 16385
		[Token(Token = "0x4004001")]
		[FieldOffset(Offset = "0x10")]
		public string newsId;

		// Token: 0x04004002 RID: 16386
		[Token(Token = "0x4004002")]
		[FieldOffset(Offset = "0x18")]
		public int newsSortId;
	}
}
