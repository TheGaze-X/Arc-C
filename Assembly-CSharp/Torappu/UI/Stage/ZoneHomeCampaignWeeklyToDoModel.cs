using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067E5 RID: 26597
	[Token(Token = "0x20067E5")]
	public class ZoneHomeCampaignWeeklyToDoModel : ZoneHomeToDoItemModel
	{
		// Token: 0x06026206 RID: 156166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026206")]
		[Address(RVA = "0x2142C20", Offset = "0x2141820", VA = "0x182142C20")]
		public static ZoneHomeCampaignWeeklyToDoModel LoadData()
		{
			return null;
		}

		// Token: 0x06026207 RID: 156167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026207")]
		[Address(RVA = "0x21431C0", Offset = "0x2141DC0", VA = "0x1821431C0")]
		private static ZoneHomeCampaignWeeklyToDoModel.FeeModel _TryLoadFeeModel()
		{
			return null;
		}

		// Token: 0x06026208 RID: 156168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026208")]
		[Address(RVA = "0x2142E00", Offset = "0x2141A00", VA = "0x182142E00")]
		private static ZoneHomeCampaignWeeklyToDoModel.BreakRewardModel _TryLoadBreakRewardModel()
		{
			return null;
		}

		// Token: 0x06026209 RID: 156169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026209")]
		[Address(RVA = "0x2143400", Offset = "0x2142000", VA = "0x182143400")]
		public ZoneHomeCampaignWeeklyToDoModel()
		{
		}

		// Token: 0x04035B0F RID: 219919
		[Token(Token = "0x4035B0F")]
		[FieldOffset(Offset = "0x38")]
		public ZoneHomeCampaignWeeklyToDoModel.FeeModel feeModel;

		// Token: 0x04035B10 RID: 219920
		[Token(Token = "0x4035B10")]
		[FieldOffset(Offset = "0x40")]
		public ZoneHomeCampaignWeeklyToDoModel.BreakRewardModel breakRewardModel;

		// Token: 0x04035B11 RID: 219921
		[Token(Token = "0x4035B11")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04035B12 RID: 219922
		[Token(Token = "0x4035B12")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__TryLoadFeeModel;

		// Token: 0x04035B13 RID: 219923
		[Token(Token = "0x4035B13")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__TryLoadBreakRewardModel;

		// Token: 0x04035B14 RID: 219924
		[Token(Token = "0x4035B14")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020067E6 RID: 26598
		[Token(Token = "0x20067E6")]
		public class FeeModel
		{
			// Token: 0x0602620A RID: 156170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602620A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FeeModel()
			{
			}

			// Token: 0x04035B15 RID: 219925
			[Token(Token = "0x4035B15")]
			[FieldOffset(Offset = "0x10")]
			public string rotateStageId;

			// Token: 0x04035B16 RID: 219926
			[Token(Token = "0x4035B16")]
			[FieldOffset(Offset = "0x18")]
			public bool isRotateStageUnlocked;

			// Token: 0x04035B17 RID: 219927
			[Token(Token = "0x4035B17")]
			[FieldOffset(Offset = "0x1C")]
			public int currentFee;

			// Token: 0x04035B18 RID: 219928
			[Token(Token = "0x4035B18")]
			[FieldOffset(Offset = "0x20")]
			public int totalFee;

			// Token: 0x04035B19 RID: 219929
			[Token(Token = "0x4035B19")]
			[FieldOffset(Offset = "0x24")]
			public float progress;

			// Token: 0x04035B1A RID: 219930
			[Token(Token = "0x4035B1A")]
			[FieldOffset(Offset = "0x28")]
			public long endTs;
		}

		// Token: 0x020067E7 RID: 26599
		[Token(Token = "0x20067E7")]
		public class BreakRewardModel
		{
			// Token: 0x0602620B RID: 156171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602620B")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public BreakRewardModel()
			{
			}

			// Token: 0x04035B1B RID: 219931
			[Token(Token = "0x4035B1B")]
			[FieldOffset(Offset = "0x10")]
			public bool showPermTitle;

			// Token: 0x04035B1C RID: 219932
			[Token(Token = "0x4035B1C")]
			[FieldOffset(Offset = "0x18")]
			public string stageId;

			// Token: 0x04035B1D RID: 219933
			[Token(Token = "0x4035B1D")]
			[FieldOffset(Offset = "0x20")]
			public string stageName;

			// Token: 0x04035B1E RID: 219934
			[Token(Token = "0x4035B1E")]
			[FieldOffset(Offset = "0x28")]
			public List<int> rewardStatus;

			// Token: 0x04035B1F RID: 219935
			[Token(Token = "0x4035B1F")]
			[FieldOffset(Offset = "0x30")]
			public long endTs;
		}
	}
}
