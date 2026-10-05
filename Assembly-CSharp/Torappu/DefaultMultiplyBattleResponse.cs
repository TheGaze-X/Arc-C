using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000712 RID: 1810
	[Token(Token = "0x2000712")]
	public class DefaultMultiplyBattleResponse : CommonFinishBattleResponse
	{
		// Token: 0x0600637F RID: 25471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600637F")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06006380 RID: 25472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006380")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06006381 RID: 25473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006381")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06006382 RID: 25474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006382")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006383")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public DefaultMultiplyBattleResponse()
		{
		}

		// Token: 0x04002F53 RID: 12115
		[Token(Token = "0x4002F53")]
		[FieldOffset(Offset = "0x68")]
		public string battleId;
	}
}
