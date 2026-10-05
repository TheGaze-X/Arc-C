using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E48 RID: 3656
	[Token(Token = "0x2000E48")]
	public class ActMultiV3TitleData
	{
		// Token: 0x06006B16 RID: 27414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B16")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3TitleData()
		{
		}

		// Token: 0x04004C27 RID: 19495
		[Token(Token = "0x4004C27")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x04004C28 RID: 19496
		[Token(Token = "0x4004C28")]
		[FieldOffset(Offset = "0x18")]
		public string titleDesc;

		// Token: 0x04004C29 RID: 19497
		[Token(Token = "0x4004C29")]
		[FieldOffset(Offset = "0x20")]
		public bool isBack;
	}
}
