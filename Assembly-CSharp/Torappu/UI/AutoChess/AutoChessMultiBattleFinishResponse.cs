using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200626B RID: 25195
	[Token(Token = "0x200626B")]
	public class AutoChessMultiBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x06024582 RID: 148866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024582")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06024583 RID: 148867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024583")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06024584 RID: 148868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024584")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06024585 RID: 148869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024585")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06024586 RID: 148870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024586")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public AutoChessMultiBattleFinishResponse()
		{
		}
	}
}
