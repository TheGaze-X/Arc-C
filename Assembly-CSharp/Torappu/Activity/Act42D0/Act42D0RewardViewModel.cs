using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073B6 RID: 29622
	[Token(Token = "0x20073B6")]
	public class Act42D0RewardViewModel : IHotfixable
	{
		// Token: 0x06029DB7 RID: 171447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB7")]
		[Address(RVA = "0x2575470", Offset = "0x2574070", VA = "0x182575470")]
		public void LoadData(string activityId)
		{
		}

		// Token: 0x06029DB8 RID: 171448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB8")]
		[Address(RVA = "0x2576090", Offset = "0x2574C90", VA = "0x182576090")]
		public void UpdatePlayerData(string actId)
		{
		}

		// Token: 0x06029DB9 RID: 171449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029DB9")]
		[Address(RVA = "0x25753F0", Offset = "0x2573FF0", VA = "0x1825753F0")]
		public Act42D0RewardAreaViewModel GetSelectedAreaViewModel()
		{
			return null;
		}

		// Token: 0x06029DBA RID: 171450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DBA")]
		[Address(RVA = "0x2576520", Offset = "0x2575120", VA = "0x182576520")]
		public Act42D0RewardViewModel()
		{
		}

		// Token: 0x0403BFC9 RID: 245705
		[Token(Token = "0x403BFC9")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act42D0RewardAreaViewModel> areas;

		// Token: 0x0403BFCA RID: 245706
		[Token(Token = "0x403BFCA")]
		[FieldOffset(Offset = "0x18")]
		public string selectedAreaId;

		// Token: 0x0403BFCB RID: 245707
		[Token(Token = "0x403BFCB")]
		[FieldOffset(Offset = "0x20")]
		public int ratingMaxCount;

		// Token: 0x0403BFCC RID: 245708
		[Token(Token = "0x403BFCC")]
		[FieldOffset(Offset = "0x28")]
		public string actId;

		// Token: 0x0403BFCD RID: 245709
		[Token(Token = "0x403BFCD")]
		[FieldOffset(Offset = "0x30")]
		public string itemId;

		// Token: 0x0403BFCE RID: 245710
		[Token(Token = "0x403BFCE")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x0403BFCF RID: 245711
		[Token(Token = "0x403BFCF")]
		[FieldOffset(Offset = "0x40")]
		public string itemName;

		// Token: 0x0403BFD0 RID: 245712
		[Token(Token = "0x403BFD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403BFD1 RID: 245713
		[Token(Token = "0x403BFD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x0403BFD2 RID: 245714
		[Token(Token = "0x403BFD2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetSelectedAreaViewModel;

		// Token: 0x0403BFD3 RID: 245715
		[Token(Token = "0x403BFD3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
