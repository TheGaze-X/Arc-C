using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007553 RID: 30035
	[Token(Token = "0x2007553")]
	public class Act24sideBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0602A4D7 RID: 173271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A4D7")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act24sideBattleFinishResponse()
		{
		}

		// Token: 0x0403CD2F RID: 249135
		[Token(Token = "0x403CD2F")]
		[FieldOffset(Offset = "0xA0")]
		public List<ItemBundle> meldingRewards;

		// Token: 0x0403CD30 RID: 249136
		[Token(Token = "0x403CD30")]
		[FieldOffset(Offset = "0xA8")]
		public List<ItemBundle> firstMeldingRewards;

		// Token: 0x0403CD31 RID: 249137
		[Token(Token = "0x403CD31")]
		[FieldOffset(Offset = "0xB0")]
		public List<ItemBundle> mealMeldingRewards;
	}
}
