using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007643 RID: 30275
	[Token(Token = "0x2007643")]
	public class CarExhibitionPickRequest
	{
		// Token: 0x0602A9A5 RID: 174501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CarExhibitionPickRequest()
		{
		}

		// Token: 0x0403D575 RID: 251253
		[Token(Token = "0x403D575")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x0403D576 RID: 251254
		[Token(Token = "0x403D576")]
		[FieldOffset(Offset = "0x18")]
		public int picked;
	}
}
