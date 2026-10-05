using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007549 RID: 30025
	[Token(Token = "0x2007549")]
	public class Act24SideEatResponse : PlayerDeltaResponse
	{
		// Token: 0x0602A4CC RID: 173260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4CC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act24SideEatResponse()
		{
		}

		// Token: 0x0403CD1E RID: 249118
		[Token(Token = "0x403CD1E")]
		[FieldOffset(Offset = "0x28")]
		public Act24SideEatResponse.EndingAction status;

		// Token: 0x0200754A RID: 30026
		[Token(Token = "0x200754A")]
		public enum EndingAction
		{
			// Token: 0x0403CD20 RID: 249120
			[Token(Token = "0x403CD20")]
			SUCCESS,
			// Token: 0x0403CD21 RID: 249121
			[Token(Token = "0x403CD21")]
			LACK_COST,
			// Token: 0x0403CD22 RID: 249122
			[Token(Token = "0x403CD22")]
			AP_FULL
		}
	}
}
