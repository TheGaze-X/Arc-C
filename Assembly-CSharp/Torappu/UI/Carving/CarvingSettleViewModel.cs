using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x020060C1 RID: 24769
	[Token(Token = "0x20060C1")]
	public class CarvingSettleViewModel : IHotfixable
	{
		// Token: 0x06023CDD RID: 146653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CDD")]
		[Address(RVA = "0x1E7D660", Offset = "0x1E7C260", VA = "0x181E7D660")]
		public void LoadData(CarvingSettleDialog.Option input)
		{
		}

		// Token: 0x06023CDE RID: 146654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CDE")]
		[Address(RVA = "0x1E7D8F0", Offset = "0x1E7C4F0", VA = "0x181E7D8F0")]
		public CarvingSettleViewModel()
		{
		}

		// Token: 0x04031A64 RID: 203364
		[Token(Token = "0x4031A64")]
		[FieldOffset(Offset = "0x10")]
		public string challengeName;

		// Token: 0x04031A65 RID: 203365
		[Token(Token = "0x4031A65")]
		[FieldOffset(Offset = "0x18")]
		public int score;

		// Token: 0x04031A66 RID: 203366
		[Token(Token = "0x4031A66")]
		[FieldOffset(Offset = "0x1C")]
		public int newRound;

		// Token: 0x04031A67 RID: 203367
		[Token(Token = "0x4031A67")]
		[FieldOffset(Offset = "0x20")]
		public bool hasNewRecord;

		// Token: 0x04031A68 RID: 203368
		[Token(Token = "0x4031A68")]
		[FieldOffset(Offset = "0x21")]
		public bool hasNewRecordReward;

		// Token: 0x04031A69 RID: 203369
		[Token(Token = "0x4031A69")]
		[FieldOffset(Offset = "0x24")]
		public int newRecordReward;

		// Token: 0x04031A6A RID: 203370
		[Token(Token = "0x4031A6A")]
		[FieldOffset(Offset = "0x28")]
		public bool isComplete;

		// Token: 0x04031A6B RID: 203371
		[Token(Token = "0x4031A6B")]
		[FieldOffset(Offset = "0x29")]
		public bool hasFirstPassReward;

		// Token: 0x04031A6C RID: 203372
		[Token(Token = "0x4031A6C")]
		[FieldOffset(Offset = "0x2C")]
		public int firstPassReward;

		// Token: 0x04031A6D RID: 203373
		[Token(Token = "0x4031A6D")]
		[FieldOffset(Offset = "0x30")]
		public int mileStonePointBefore;

		// Token: 0x04031A6E RID: 203374
		[Token(Token = "0x4031A6E")]
		[FieldOffset(Offset = "0x34")]
		public int mileStonePointAfter;

		// Token: 0x04031A6F RID: 203375
		[Token(Token = "0x4031A6F")]
		[FieldOffset(Offset = "0x38")]
		public CarvingMileStoneInfo mileStoneInfoBefore;

		// Token: 0x04031A70 RID: 203376
		[Token(Token = "0x4031A70")]
		[FieldOffset(Offset = "0x50")]
		public CarvingMileStoneInfo mileStoneInfoAfter;

		// Token: 0x04031A71 RID: 203377
		[Token(Token = "0x4031A71")]
		[FieldOffset(Offset = "0x68")]
		public List<Act35SideData.Act35SideMileStoneData> mileStoneList;

		// Token: 0x04031A72 RID: 203378
		[Token(Token = "0x4031A72")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031A73 RID: 203379
		[Token(Token = "0x4031A73")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
