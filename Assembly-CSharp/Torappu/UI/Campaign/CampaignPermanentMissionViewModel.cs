using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E9 RID: 24809
	[Token(Token = "0x20060E9")]
	public class CampaignPermanentMissionViewModel : IHotfixable
	{
		// Token: 0x06023DC3 RID: 146883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC3")]
		[Address(RVA = "0x1E77350", Offset = "0x1E75F50", VA = "0x181E77350")]
		public void LoadData(string stageId)
		{
		}

		// Token: 0x06023DC4 RID: 146884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC4")]
		[Address(RVA = "0x1E777F0", Offset = "0x1E763F0", VA = "0x181E777F0")]
		public CampaignPermanentMissionViewModel()
		{
		}

		// Token: 0x04031BB9 RID: 203705
		[Token(Token = "0x4031BB9")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04031BBA RID: 203706
		[Token(Token = "0x4031BBA")]
		[FieldOffset(Offset = "0x18")]
		public string code;

		// Token: 0x04031BBB RID: 203707
		[Token(Token = "0x4031BBB")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04031BBC RID: 203708
		[Token(Token = "0x4031BBC")]
		[FieldOffset(Offset = "0x28")]
		public int value;

		// Token: 0x04031BBD RID: 203709
		[Token(Token = "0x4031BBD")]
		[FieldOffset(Offset = "0x2C")]
		public int target;

		// Token: 0x04031BBE RID: 203710
		[Token(Token = "0x4031BBE")]
		[FieldOffset(Offset = "0x30")]
		public int remainBreakFeeAdd;

		// Token: 0x04031BBF RID: 203711
		[Token(Token = "0x4031BBF")]
		[FieldOffset(Offset = "0x34")]
		public int totalBreakFeeAdd;

		// Token: 0x04031BC0 RID: 203712
		[Token(Token = "0x4031BC0")]
		[FieldOffset(Offset = "0x38")]
		public bool isUnlocked;

		// Token: 0x04031BC1 RID: 203713
		[Token(Token = "0x4031BC1")]
		[FieldOffset(Offset = "0x40")]
		public string unlockText;

		// Token: 0x04031BC2 RID: 203714
		[Token(Token = "0x4031BC2")]
		[FieldOffset(Offset = "0x48")]
		public bool isFinished;

		// Token: 0x04031BC3 RID: 203715
		[Token(Token = "0x4031BC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031BC4 RID: 203716
		[Token(Token = "0x4031BC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
