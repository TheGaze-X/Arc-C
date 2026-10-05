using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public class HandBookAddonStageBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x060063DC RID: 25564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DC")]
		[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063DD")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DE")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60063DF")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E0")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public HandBookAddonStageBattleFinishResponse()
		{
		}

		// Token: 0x04002FFC RID: 12284
		[Token(Token = "0x4002FFC")]
		[FieldOffset(Offset = "0x68")]
		public List<CommonFinishBattleResponse.RewardModel> firstRewards;
	}
}
