using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006718 RID: 26392
	[Token(Token = "0x2006718")]
	public class HandBookV2ForceFavorViewModel
	{
		// Token: 0x170059AC RID: 22956
		// (get) Token: 0x06025DE6 RID: 155110 RVA: 0x000C93F0 File Offset: 0x000C75F0
		[Token(Token = "0x170059AC")]
		public int favorAvg
		{
			[Token(Token = "0x6025DE6")]
			[Address(RVA = "0x20D36B0", Offset = "0x20D22B0", VA = "0x1820D36B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025DE7 RID: 155111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025DE7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2ForceFavorViewModel()
		{
		}

		// Token: 0x04035432 RID: 218162
		[Token(Token = "0x4035432")]
		[FieldOffset(Offset = "0x10")]
		public int charCount;

		// Token: 0x04035433 RID: 218163
		[Token(Token = "0x4035433")]
		[FieldOffset(Offset = "0x14")]
		public int charOwn;

		// Token: 0x04035434 RID: 218164
		[Token(Token = "0x4035434")]
		[FieldOffset(Offset = "0x18")]
		public int favorSum;
	}
}
