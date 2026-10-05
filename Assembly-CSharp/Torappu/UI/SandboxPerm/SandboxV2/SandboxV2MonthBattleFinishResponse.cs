using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004416 RID: 17430
	[Token(Token = "0x2004416")]
	public class SandboxV2MonthBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x0601A9E4 RID: 109028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9E4")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x0601A9E5 RID: 109029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9E5")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x0601A9E6 RID: 109030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9E6")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x0601A9E7 RID: 109031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9E7")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x0601A9E8 RID: 109032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9E8")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public SandboxV2MonthBattleFinishResponse()
		{
		}

		// Token: 0x04021EE7 RID: 138983
		[Token(Token = "0x4021EE7")]
		[FieldOffset(Offset = "0x68")]
		public bool success;

		// Token: 0x04021EE8 RID: 138984
		[Token(Token = "0x4021EE8")]
		[FieldOffset(Offset = "0x70")]
		public List<int> enemyRushCount;

		// Token: 0x04021EE9 RID: 138985
		[Token(Token = "0x4021EE9")]
		[FieldOffset(Offset = "0x78")]
		public bool firstPass;
	}
}
