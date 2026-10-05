using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007D6 RID: 2006
	[Token(Token = "0x20007D6")]
	public class RecalRuneBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x0600645E RID: 25694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600645E")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x0600645F RID: 25695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600645F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06006460 RID: 25696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006460")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06006461 RID: 25697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006461")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06006462 RID: 25698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006462")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RecalRuneBattleFinishResponse()
		{
		}

		// Token: 0x040030ED RID: 12525
		[Token(Token = "0x40030ED")]
		[FieldOffset(Offset = "0x68")]
		public string seasonId;

		// Token: 0x040030EE RID: 12526
		[Token(Token = "0x40030EE")]
		[FieldOffset(Offset = "0x70")]
		public string stageId;

		// Token: 0x040030EF RID: 12527
		[Token(Token = "0x40030EF")]
		[FieldOffset(Offset = "0x78")]
		public int state;

		// Token: 0x040030F0 RID: 12528
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x7C")]
		public int score;

		// Token: 0x040030F1 RID: 12529
		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x80")]
		public bool newRecord;

		// Token: 0x040030F2 RID: 12530
		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x88")]
		public List<string> runes;

		// Token: 0x040030F3 RID: 12531
		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0x90")]
		public int hp;

		// Token: 0x040030F4 RID: 12532
		[Token(Token = "0x40030F4")]
		[FieldOffset(Offset = "0x98")]
		public long ts;
	}
}
