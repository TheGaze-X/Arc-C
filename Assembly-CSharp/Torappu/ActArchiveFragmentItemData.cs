using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C38 RID: 3128
	[Token(Token = "0x2000C38")]
	public class ActArchiveFragmentItemData
	{
		// Token: 0x06006918 RID: 26904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006918")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveFragmentItemData()
		{
		}

		// Token: 0x04003FF3 RID: 16371
		[Token(Token = "0x4003FF3")]
		[FieldOffset(Offset = "0x10")]
		public string fragmentId;

		// Token: 0x04003FF4 RID: 16372
		[Token(Token = "0x4003FF4")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04003FF5 RID: 16373
		[Token(Token = "0x4003FF5")]
		[FieldOffset(Offset = "0x20")]
		public string enrollConditionId;
	}
}
