using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200734A RID: 29514
	[Token(Token = "0x200734A")]
	public class Act42D0NormalBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x06029BBF RID: 170943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BBF")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06029BC0 RID: 170944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BC0")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06029BC1 RID: 170945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BC1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06029BC2 RID: 170946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BC2")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06029BC3 RID: 170947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BC3")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public Act42D0NormalBattleFinishResponse()
		{
		}

		// Token: 0x0403BBC8 RID: 244680
		[Token(Token = "0x403BBC8")]
		[FieldOffset(Offset = "0x68")]
		public string stageId;

		// Token: 0x0403BBC9 RID: 244681
		[Token(Token = "0x403BBC9")]
		[FieldOffset(Offset = "0x70")]
		public int ratingLv;

		// Token: 0x0403BBCA RID: 244682
		[Token(Token = "0x403BBCA")]
		[FieldOffset(Offset = "0x74")]
		public bool isNew;

		// Token: 0x0403BBCB RID: 244683
		[Token(Token = "0x403BBCB")]
		[FieldOffset(Offset = "0x78")]
		public int milestoneGot;

		// Token: 0x0403BBCC RID: 244684
		[Token(Token = "0x403BBCC")]
		[FieldOffset(Offset = "0x7C")]
		public int milestoneAfter;

		// Token: 0x0403BBCD RID: 244685
		[Token(Token = "0x403BBCD")]
		[FieldOffset(Offset = "0x80")]
		public List<string> buffs;

		// Token: 0x0403BBCE RID: 244686
		[Token(Token = "0x403BBCE")]
		[FieldOffset(Offset = "0x88")]
		public long finishTs;
	}
}
