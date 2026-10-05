using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060EA RID: 24810
	[Token(Token = "0x20060EA")]
	public class CampaignCommonMissionViewModel : IHotfixable
	{
		// Token: 0x06023DC5 RID: 146885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC5")]
		[Address(RVA = "0x1E6F880", Offset = "0x1E6E480", VA = "0x181E6F880")]
		public void LoadData(string missionId, string rotateStageId)
		{
		}

		// Token: 0x06023DC6 RID: 146886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC6")]
		[Address(RVA = "0x1E6FE30", Offset = "0x1E6EA30", VA = "0x181E6FE30")]
		public CampaignCommonMissionViewModel()
		{
		}

		// Token: 0x04031BC5 RID: 203717
		[Token(Token = "0x4031BC5")]
		private const int NORMAL_CAMPAIGN_PARAM_INDEX = 0;

		// Token: 0x04031BC6 RID: 203718
		[Token(Token = "0x4031BC6")]
		private const int SMALL_SCALE_CAMPAIGN_PARAM_INDEX = 1;

		// Token: 0x04031BC7 RID: 203719
		[Token(Token = "0x4031BC7")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x04031BC8 RID: 203720
		[Token(Token = "0x4031BC8")]
		[FieldOffset(Offset = "0x18")]
		public string description;

		// Token: 0x04031BC9 RID: 203721
		[Token(Token = "0x4031BC9")]
		[FieldOffset(Offset = "0x20")]
		public int value;

		// Token: 0x04031BCA RID: 203722
		[Token(Token = "0x4031BCA")]
		[FieldOffset(Offset = "0x24")]
		public int target;

		// Token: 0x04031BCB RID: 203723
		[Token(Token = "0x4031BCB")]
		[FieldOffset(Offset = "0x28")]
		public int breakFeeAdd;

		// Token: 0x04031BCC RID: 203724
		[Token(Token = "0x4031BCC")]
		[FieldOffset(Offset = "0x2C")]
		public bool isUnlocked;

		// Token: 0x04031BCD RID: 203725
		[Token(Token = "0x4031BCD")]
		[FieldOffset(Offset = "0x30")]
		public string unlockText;

		// Token: 0x04031BCE RID: 203726
		[Token(Token = "0x4031BCE")]
		[FieldOffset(Offset = "0x38")]
		public bool isFullfilled;

		// Token: 0x04031BCF RID: 203727
		[Token(Token = "0x4031BCF")]
		[FieldOffset(Offset = "0x39")]
		public bool isFinished;

		// Token: 0x04031BD0 RID: 203728
		[Token(Token = "0x4031BD0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031BD1 RID: 203729
		[Token(Token = "0x4031BD1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
