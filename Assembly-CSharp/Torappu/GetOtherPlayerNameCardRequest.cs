using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000733")]
	public class GetOtherPlayerNameCardRequest
	{
		// Token: 0x0600639D RID: 25501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetOtherPlayerNameCardRequest()
		{
		}

		// Token: 0x04002FA3 RID: 12195
		[Token(Token = "0x4002FA3")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x04002FA4 RID: 12196
		[Token(Token = "0x4002FA4")]
		[FieldOffset(Offset = "0x18")]
		public string src;
	}
}
