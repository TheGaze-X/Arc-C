using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using Torappu.UI.ActivityStage.Extern;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B42 RID: 31554
	[Token(Token = "0x2007B42")]
	public class ActivityFirstUtil : ActivityStageSingleComponent, IHotfixable
	{
		// Token: 0x17006778 RID: 26488
		// (get) Token: 0x0602C2BA RID: 180922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006778")]
		public static string activityId
		{
			[Token(Token = "0x602C2BA")]
			[Address(RVA = "0x2818790", Offset = "0x2817390", VA = "0x182818790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006779 RID: 26489
		// (get) Token: 0x0602C2BB RID: 180923 RVA: 0x000DE4F8 File Offset: 0x000DC6F8
		[Token(Token = "0x17006779")]
		public static ActivityType activityType
		{
			[Token(Token = "0x602C2BB")]
			[Address(RVA = "0x2818880", Offset = "0x2817480", VA = "0x182818880")]
			get
			{
				return ActivityType.DEFAULT;
			}
		}

		// Token: 0x0602C2BC RID: 180924 RVA: 0x000DE510 File Offset: 0x000DC710
		[Token(Token = "0x602C2BC")]
		[Address(RVA = "0x2818100", Offset = "0x2816D00", VA = "0x182818100")]
		public static ActivityBasicInfo AchieveBasicInfo()
		{
			return default(ActivityBasicInfo);
		}

		// Token: 0x0602C2BD RID: 180925 RVA: 0x000DE528 File Offset: 0x000DC728
		[Token(Token = "0x602C2BD")]
		[Address(RVA = "0x2818290", Offset = "0x2816E90", VA = "0x182818290")]
		public static bool CheckStageOpenFlag(ActivityBasicInfo basicInfo)
		{
			return default(bool);
		}

		// Token: 0x1700677A RID: 26490
		// (get) Token: 0x0602C2BE RID: 180926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700677A")]
		public static UIItemCard uiItemCard
		{
			[Token(Token = "0x602C2BE")]
			[Address(RVA = "0x2818AA0", Offset = "0x28176A0", VA = "0x182818AA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700677B RID: 26491
		// (get) Token: 0x0602C2BF RID: 180927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700677B")]
		public static CommonTopMenu commonTopMenu
		{
			[Token(Token = "0x602C2BF")]
			[Address(RVA = "0x2818960", Offset = "0x2817560", VA = "0x182818960")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700677C RID: 26492
		// (get) Token: 0x0602C2C0 RID: 180928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700677C")]
		public static DefaultFirstData activityData
		{
			[Token(Token = "0x602C2C0")]
			[Address(RVA = "0x28185E0", Offset = "0x28171E0", VA = "0x1828185E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C2C1 RID: 180929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C2C1")]
		[Address(RVA = "0x28183A0", Offset = "0x2816FA0", VA = "0x1828183A0")]
		public static MissionData GetMissionData(string missionID, string activityID)
		{
			return null;
		}

		// Token: 0x0602C2C2 RID: 180930 RVA: 0x000DE540 File Offset: 0x000DC740
		[Token(Token = "0x602C2C2")]
		[Address(RVA = "0x28184F0", Offset = "0x28170F0", VA = "0x1828184F0")]
		public static int GetShopCount(string shopId)
		{
			return 0;
		}

		// Token: 0x1700677D RID: 26493
		// (get) Token: 0x0602C2C3 RID: 180931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700677D")]
		public static PlayerActivity.PlayerDefaultActivity playerAct
		{
			[Token(Token = "0x602C2C3")]
			[Address(RVA = "0x28189C0", Offset = "0x28175C0", VA = "0x1828189C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C2C4 RID: 180932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C2C4")]
		[Address(RVA = "0x2818580", Offset = "0x2817180", VA = "0x182818580")]
		public ActivityFirstUtil()
		{
		}

		// Token: 0x04040079 RID: 262265
		[Token(Token = "0x4040079")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x0404007A RID: 262266
		[Token(Token = "0x404007A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_activityType;

		// Token: 0x0404007B RID: 262267
		[Token(Token = "0x404007B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AchieveBasicInfo;

		// Token: 0x0404007C RID: 262268
		[Token(Token = "0x404007C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckStageOpenFlag;

		// Token: 0x0404007D RID: 262269
		[Token(Token = "0x404007D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_uiItemCard;

		// Token: 0x0404007E RID: 262270
		[Token(Token = "0x404007E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_commonTopMenu;

		// Token: 0x0404007F RID: 262271
		[Token(Token = "0x404007F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_activityData;

		// Token: 0x04040080 RID: 262272
		[Token(Token = "0x4040080")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetMissionData;

		// Token: 0x04040081 RID: 262273
		[Token(Token = "0x4040081")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetShopCount;

		// Token: 0x04040082 RID: 262274
		[Token(Token = "0x4040082")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_playerAct;

		// Token: 0x04040083 RID: 262275
		[Token(Token = "0x4040083")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
