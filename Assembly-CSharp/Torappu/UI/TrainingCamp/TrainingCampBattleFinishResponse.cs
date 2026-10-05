using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TrainingCamp
{
	// Token: 0x02003D19 RID: 15641
	[Token(Token = "0x2003D19")]
	public class TrainingCampBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x06018623 RID: 99875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018623")]
		[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06018624 RID: 99876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018624")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06018625 RID: 99877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018625")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06018626 RID: 99878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018626")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06018627 RID: 99879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018627")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public TrainingCampBattleFinishResponse()
		{
		}

		// Token: 0x0401DD10 RID: 122128
		[Token(Token = "0x401DD10")]
		[FieldOffset(Offset = "0x68")]
		public List<CommonFinishBattleResponse.RewardModel> firstRewards;
	}
}
