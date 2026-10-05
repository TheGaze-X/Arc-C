using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006ED8 RID: 28376
	[Token(Token = "0x2006ED8")]
	public class ActMultiV3GuideBattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x06028556 RID: 165206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028556")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06028557 RID: 165207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028557")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x06028558 RID: 165208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028558")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x06028559 RID: 165209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028559")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x0602855A RID: 165210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602855A")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public ActMultiV3GuideBattleFinishResponse()
		{
		}

		// Token: 0x04039550 RID: 234832
		[Token(Token = "0x4039550")]
		[FieldOffset(Offset = "0x68")]
		public BattleFinishRspData data;
	}
}
