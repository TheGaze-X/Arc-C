using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007640 RID: 30272
	[Token(Token = "0x2007640")]
	public class ExhibitionVersus
	{
		// Token: 0x0602A9A2 RID: 174498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExhibitionVersus()
		{
		}

		// Token: 0x0403D571 RID: 251249
		[Token(Token = "0x403D571")]
		[FieldOffset(Offset = "0x10")]
		public ExhibitionShowItem[][] versusInfo;

		// Token: 0x0403D572 RID: 251250
		[Token(Token = "0x403D572")]
		[FieldOffset(Offset = "0x18")]
		public int current;
	}
}
