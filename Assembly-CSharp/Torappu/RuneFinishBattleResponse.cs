using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000834 RID: 2100
	[Token(Token = "0x2000834")]
	public class RuneFinishBattleResponse : CommonFinishBattleResponse
	{
		// Token: 0x060064C8 RID: 25800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064C8")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x060064C9 RID: 25801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064C9")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x060064CA RID: 25802 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064CA")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x060064CB RID: 25803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064CB")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x060064CC RID: 25804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064CC")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RuneFinishBattleResponse()
		{
		}

		// Token: 0x04003138 RID: 12600
		[Token(Token = "0x4003138")]
		[FieldOffset(Offset = "0x68")]
		public int score;

		// Token: 0x04003139 RID: 12601
		[Token(Token = "0x4003139")]
		[FieldOffset(Offset = "0x6C")]
		public int from;

		// Token: 0x0400313A RID: 12602
		[Token(Token = "0x400313A")]
		[FieldOffset(Offset = "0x70")]
		public int to;
	}
}
