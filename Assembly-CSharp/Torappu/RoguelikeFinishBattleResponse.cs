using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000815 RID: 2069
	[Token(Token = "0x2000815")]
	public class RoguelikeFinishBattleResponse : CommonFinishBattleResponse
	{
		// Token: 0x060064A1 RID: 25761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x060064A2 RID: 25762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A2")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x060064A3 RID: 25763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A3")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x060064A4 RID: 25764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60064A4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x060064A5 RID: 25765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064A5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeFinishBattleResponse()
		{
		}
	}
}
