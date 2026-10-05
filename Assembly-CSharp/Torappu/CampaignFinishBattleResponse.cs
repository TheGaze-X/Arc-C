using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	public class CampaignFinishBattleResponse : CommonFinishBattleResponse
	{
		// Token: 0x060062FA RID: 25338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FA")]
		[Address(RVA = "0x1DE9940", Offset = "0x1DE8540", VA = "0x181DE9940", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x060062FB RID: 25339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FB")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x060062FC RID: 25340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FC")]
		[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x060062FD RID: 25341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062FD")]
		[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x060062FE RID: 25342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062FE")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public CampaignFinishBattleResponse()
		{
		}

		// Token: 0x04002E9D RID: 11933
		[Token(Token = "0x4002E9D")]
		[FieldOffset(Offset = "0x68")]
		public int currentFeeBefore;

		// Token: 0x04002E9E RID: 11934
		[Token(Token = "0x4002E9E")]
		[FieldOffset(Offset = "0x6C")]
		public int currentFeeAfter;

		// Token: 0x04002E9F RID: 11935
		[Token(Token = "0x4002E9F")]
		[FieldOffset(Offset = "0x70")]
		public string[] unlockStages;

		// Token: 0x04002EA0 RID: 11936
		[Token(Token = "0x4002EA0")]
		[FieldOffset(Offset = "0x78")]
		public List<ServiceAlertStruct> alert;
	}
}
