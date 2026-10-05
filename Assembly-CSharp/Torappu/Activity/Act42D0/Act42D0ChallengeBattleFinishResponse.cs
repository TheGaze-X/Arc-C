using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200734D RID: 29517
	[Token(Token = "0x200734D")]
	public class Act42D0ChallengeBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x06029BC7 RID: 170951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BC7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06029BC8 RID: 170952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BC8")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06029BC9 RID: 170953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BC9")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06029BCA RID: 170954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BCA")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06029BCB RID: 170955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BCB")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act42D0ChallengeBattleFinishResponse()
		{
		}

		// Token: 0x0403BBD1 RID: 244689
		[Token(Token = "0x403BBD1")]
		[FieldOffset(Offset = "0x68")]
		public string stageId;

		// Token: 0x0403BBD2 RID: 244690
		[Token(Token = "0x403BBD2")]
		[FieldOffset(Offset = "0x70")]
		public int progress;

		// Token: 0x0403BBD3 RID: 244691
		[Token(Token = "0x403BBD3")]
		[FieldOffset(Offset = "0x74")]
		public bool isNew;

		// Token: 0x0403BBD4 RID: 244692
		[Token(Token = "0x403BBD4")]
		[FieldOffset(Offset = "0x78")]
		public int milestoneGot;

		// Token: 0x0403BBD5 RID: 244693
		[Token(Token = "0x403BBD5")]
		[FieldOffset(Offset = "0x7C")]
		public int milestoneAfter;

		// Token: 0x0403BBD6 RID: 244694
		[Token(Token = "0x403BBD6")]
		[FieldOffset(Offset = "0x80")]
		public long finishTs;
	}
}
