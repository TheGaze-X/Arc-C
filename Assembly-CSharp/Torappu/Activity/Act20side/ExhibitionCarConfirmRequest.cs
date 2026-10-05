using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007647 RID: 30279
	[Token(Token = "0x2007647")]
	public class ExhibitionCarConfirmRequest
	{
		// Token: 0x0602A9A9 RID: 174505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExhibitionCarConfirmRequest()
		{
		}

		// Token: 0x0403D579 RID: 251257
		[Token(Token = "0x403D579")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D57A RID: 251258
		[Token(Token = "0x403D57A")]
		[FieldOffset(Offset = "0x18")]
		public PlayerCartInfo.Cart car;
	}
}
