using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006EB RID: 1771
	[Token(Token = "0x20006EB")]
	public class CrisisV2BattleFinishResponse : CommonFinishBattleResponse
	{
		// Token: 0x0600633D RID: 25405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600633D")]
		[Address(RVA = "0x10D1D30", Offset = "0x10D0930", VA = "0x1810D1D30", Slot = "6")]
		public override void GetGoldAndExpScale(out float goldScale, out float expScale)
		{
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633E")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "7")]
		public override List<CommonFinishBattleResponse.RewardModel> GetFirstRewards()
		{
			return null;
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600633F")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "9")]
		public override string[] GetUnlockStages()
		{
			return null;
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006340")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "10")]
		public override List<ServiceAlertStruct> GetAlert()
		{
			return null;
		}

		// Token: 0x06006341 RID: 25409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006341")]
		[Address(RVA = "0x1EE83E0", Offset = "0x1EE6FE0", VA = "0x181EE83E0")]
		public CrisisV2BattleFinishResponse()
		{
		}

		// Token: 0x04002F03 RID: 12035
		[Token(Token = "0x4002F03")]
		[FieldOffset(Offset = "0x68")]
		public string mapId;

		// Token: 0x04002F04 RID: 12036
		[Token(Token = "0x4002F04")]
		[FieldOffset(Offset = "0x70")]
		public List<int> scoreRecord;

		// Token: 0x04002F05 RID: 12037
		[Token(Token = "0x4002F05")]
		[FieldOffset(Offset = "0x78")]
		public List<int> scoreCurrent;

		// Token: 0x04002F06 RID: 12038
		[Token(Token = "0x4002F06")]
		[FieldOffset(Offset = "0x80")]
		public bool isNewRecord;

		// Token: 0x04002F07 RID: 12039
		[Token(Token = "0x4002F07")]
		[FieldOffset(Offset = "0x88")]
		public List<string> commentNew;

		// Token: 0x04002F08 RID: 12040
		[Token(Token = "0x4002F08")]
		[FieldOffset(Offset = "0x90")]
		public List<string> commentOld;

		// Token: 0x04002F09 RID: 12041
		[Token(Token = "0x4002F09")]
		[FieldOffset(Offset = "0x98")]
		public List<int> runeCount;

		// Token: 0x04002F0A RID: 12042
		[Token(Token = "0x4002F0A")]
		[FieldOffset(Offset = "0xA0")]
		public long ts;

		// Token: 0x04002F0B RID: 12043
		[Token(Token = "0x4002F0B")]
		[FieldOffset(Offset = "0xA8")]
		public List<string> runeIds;
	}
}
