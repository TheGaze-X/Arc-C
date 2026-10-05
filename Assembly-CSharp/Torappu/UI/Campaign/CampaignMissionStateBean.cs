using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060EB RID: 24811
	[Token(Token = "0x20060EB")]
	public class CampaignMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023DC7 RID: 146887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC7")]
		[Address(RVA = "0x1E715F0", Offset = "0x1E701F0", VA = "0x181E715F0")]
		public void LoadData()
		{
		}

		// Token: 0x06023DC8 RID: 146888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC8")]
		[Address(RVA = "0x1E71B10", Offset = "0x1E70710", VA = "0x181E71B10")]
		private void _LoadPermanet()
		{
		}

		// Token: 0x06023DC9 RID: 146889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DC9")]
		[Address(RVA = "0x1E71780", Offset = "0x1E70380", VA = "0x181E71780")]
		private void _LoadCommon()
		{
		}

		// Token: 0x06023DCA RID: 146890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DCA")]
		[Address(RVA = "0x1E71E20", Offset = "0x1E70A20", VA = "0x181E71E20")]
		public CampaignMissionStateBean()
		{
		}

		// Token: 0x04031BD2 RID: 203730
		[Token(Token = "0x4031BD2")]
		[FieldOffset(Offset = "0x10")]
		public CampaignMissionStateBean.Input input;

		// Token: 0x04031BD3 RID: 203731
		[Token(Token = "0x4031BD3")]
		[FieldOffset(Offset = "0x20")]
		public string rotateStageId;

		// Token: 0x04031BD4 RID: 203732
		[Token(Token = "0x4031BD4")]
		[FieldOffset(Offset = "0x28")]
		public int currentFee;

		// Token: 0x04031BD5 RID: 203733
		[Token(Token = "0x4031BD5")]
		[FieldOffset(Offset = "0x2C")]
		public int totalFee;

		// Token: 0x04031BD6 RID: 203734
		[Token(Token = "0x4031BD6")]
		[FieldOffset(Offset = "0x30")]
		public string countDownText;

		// Token: 0x04031BD7 RID: 203735
		[Token(Token = "0x4031BD7")]
		[FieldOffset(Offset = "0x38")]
		public bool isShowCommonMissionRedirectButton;

		// Token: 0x04031BD8 RID: 203736
		[Token(Token = "0x4031BD8")]
		[FieldOffset(Offset = "0x40")]
		public List<CampaignPermanentMissionViewModel> permanentMissions;

		// Token: 0x04031BD9 RID: 203737
		[Token(Token = "0x4031BD9")]
		[FieldOffset(Offset = "0x48")]
		public List<CampaignCommonMissionViewModel> commonMissions;

		// Token: 0x04031BDA RID: 203738
		[Token(Token = "0x4031BDA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031BDB RID: 203739
		[Token(Token = "0x4031BDB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadPermanet;

		// Token: 0x04031BDC RID: 203740
		[Token(Token = "0x4031BDC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadCommon;

		// Token: 0x04031BDD RID: 203741
		[Token(Token = "0x4031BDD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020060EC RID: 24812
		[Token(Token = "0x20060EC")]
		public struct Input
		{
			// Token: 0x04031BDE RID: 203742
			[Token(Token = "0x4031BDE")]
			[FieldOffset(Offset = "0x0")]
			public Action<string> onJumpToPermanentStage;

			// Token: 0x04031BDF RID: 203743
			[Token(Token = "0x4031BDF")]
			[FieldOffset(Offset = "0x8")]
			public Action<string> onJumpToRotateStage;
		}
	}
}
