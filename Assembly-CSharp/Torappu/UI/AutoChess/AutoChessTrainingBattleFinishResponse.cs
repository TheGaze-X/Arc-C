using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200626E RID: 25198
	[Token(Token = "0x200626E")]
	public class AutoChessTrainingBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x0602458A RID: 148874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602458A")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x0602458B RID: 148875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602458B")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x0602458C RID: 148876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602458C")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x0602458D RID: 148877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602458D")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x0602458E RID: 148878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602458E")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public AutoChessTrainingBattleFinishResponse()
		{
		}
	}
}
