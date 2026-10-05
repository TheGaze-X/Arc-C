using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200089E RID: 2206
	[Token(Token = "0x200089E")]
	public class GetGPGoodListResponse : PlayerDeltaResponse, IShopGetResposne
	{
		// Token: 0x0600653D RID: 25917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600653D")]
		[Address(RVA = "0x1EEA440", Offset = "0x1EE9040", VA = "0x181EEA440")]
		public GetGPGoodListResponse()
		{
		}

		// Token: 0x04003259 RID: 12889
		[Token(Token = "0x4003259")]
		[FieldOffset(Offset = "0x28")]
		public PeriodicityGroup weeklyGroup;

		// Token: 0x0400325A RID: 12890
		[Token(Token = "0x400325A")]
		[FieldOffset(Offset = "0x30")]
		public PeriodicityGroup monthlyGroup;

		// Token: 0x0400325B RID: 12891
		[Token(Token = "0x400325B")]
		[FieldOffset(Offset = "0x38")]
		public List<MonthlySubItem> monthlySub;

		// Token: 0x0400325C RID: 12892
		[Token(Token = "0x400325C")]
		[FieldOffset(Offset = "0x40")]
		public List<LevelGPItem> levelGP;

		// Token: 0x0400325D RID: 12893
		[Token(Token = "0x400325D")]
		[FieldOffset(Offset = "0x48")]
		public List<NormalGPItem> oneTimeGP;

		// Token: 0x0400325E RID: 12894
		[Token(Token = "0x400325E")]
		[FieldOffset(Offset = "0x50")]
		public List<ChooseGPItem> chooseGroup;

		// Token: 0x0400325F RID: 12895
		[Token(Token = "0x400325F")]
		[FieldOffset(Offset = "0x58")]
		public List<CondTrigGPItem> condtionTriggerGroup;

		// Token: 0x04003260 RID: 12896
		[Token(Token = "0x4003260")]
		[FieldOffset(Offset = "0x60")]
		public List<ChooseCondTrigGPItem> conditionChooseGroup;
	}
}
