using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007645 RID: 30277
	[Token(Token = "0x2007645")]
	public class CarConfirmRequest
	{
		// Token: 0x0602A9A7 RID: 174503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarConfirmRequest()
		{
		}

		// Token: 0x0403D578 RID: 251256
		[Token(Token = "0x403D578")]
		[FieldOffset(Offset = "0x10")]
		public PlayerCartInfo.Cart car;
	}
}
