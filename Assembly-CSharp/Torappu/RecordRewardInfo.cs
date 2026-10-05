using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013CA RID: 5066
	[Token(Token = "0x20013CA")]
	[Serializable]
	public class RecordRewardInfo
	{
		// Token: 0x060073BA RID: 29626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073BA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RecordRewardInfo()
		{
		}

		// Token: 0x040070AC RID: 28844
		[Token(Token = "0x40070AC")]
		[FieldOffset(Offset = "0x10")]
		public string bindStageId;

		// Token: 0x040070AD RID: 28845
		[Token(Token = "0x40070AD")]
		[FieldOffset(Offset = "0x18")]
		public RecordRewardStageDiff stageDiff1;

		// Token: 0x040070AE RID: 28846
		[Token(Token = "0x40070AE")]
		[FieldOffset(Offset = "0x1C")]
		public StageDiffGroup stageDiff;

		// Token: 0x040070AF RID: 28847
		[Token(Token = "0x40070AF")]
		[FieldOffset(Offset = "0x20")]
		public string picRes;

		// Token: 0x040070B0 RID: 28848
		[Token(Token = "0x40070B0")]
		[FieldOffset(Offset = "0x28")]
		public string textPath;

		// Token: 0x040070B1 RID: 28849
		[Token(Token = "0x40070B1")]
		[FieldOffset(Offset = "0x30")]
		public string textDesc;

		// Token: 0x040070B2 RID: 28850
		[Token(Token = "0x40070B2")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle[] recordReward;
	}
}
