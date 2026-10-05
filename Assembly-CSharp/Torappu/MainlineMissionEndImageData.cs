using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001112 RID: 4370
	[Token(Token = "0x2001112")]
	public class MainlineMissionEndImageData
	{
		// Token: 0x06006ED6 RID: 28374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006ED6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MainlineMissionEndImageData()
		{
		}

		// Token: 0x04005DA9 RID: 23977
		[Token(Token = "0x4005DA9")]
		[FieldOffset(Offset = "0x10")]
		public string imageId;

		// Token: 0x04005DAA RID: 23978
		[Token(Token = "0x4005DAA")]
		[FieldOffset(Offset = "0x18")]
		public int priority;
	}
}
