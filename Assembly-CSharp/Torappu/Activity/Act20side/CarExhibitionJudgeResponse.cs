using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x02007642 RID: 30274
	[Token(Token = "0x2007642")]
	public class CarExhibitionJudgeResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A9A4 RID: 174500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A4")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public CarExhibitionJudgeResponse()
		{
		}

		// Token: 0x0403D574 RID: 251252
		[Token(Token = "0x403D574")]
		[FieldOffset(Offset = "0x28")]
		public ExhibitionVersus versus;
	}
}
