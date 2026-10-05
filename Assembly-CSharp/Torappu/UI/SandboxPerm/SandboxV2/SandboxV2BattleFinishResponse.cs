using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200440F RID: 17423
	[Token(Token = "0x200440F")]
	public class SandboxV2BattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x0601A9D1 RID: 109009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9D1")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x0601A9D2 RID: 109010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9D2")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x0601A9D3 RID: 109011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9D3")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x0601A9D4 RID: 109012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A9D4")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x0601A9D5 RID: 109013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A9D5")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public SandboxV2BattleFinishResponse()
		{
		}

		// Token: 0x04021ECF RID: 138959
		[Token(Token = "0x4021ECF")]
		[FieldOffset(Offset = "0x68")]
		public bool success;

		// Token: 0x04021ED0 RID: 138960
		[Token(Token = "0x4021ED0")]
		[FieldOffset(Offset = "0x69")]
		public bool isEnemyRush;

		// Token: 0x04021ED1 RID: 138961
		[Token(Token = "0x4021ED1")]
		[FieldOffset(Offset = "0x70")]
		public List<int> enemyRushCount;

		// Token: 0x04021ED2 RID: 138962
		[Token(Token = "0x4021ED2")]
		[FieldOffset(Offset = "0x78")]
		public new List<SandboxV2CommonRewardItem> rewards;

		// Token: 0x04021ED3 RID: 138963
		[Token(Token = "0x4021ED3")]
		[FieldOffset(Offset = "0x80")]
		public List<SandboxV2CommonRewardItem> randomRewards;
	}
}
