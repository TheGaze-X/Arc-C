using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.ActivityStage.Extern
{
	// Token: 0x02006D22 RID: 27938
	[Token(Token = "0x2006D22")]
	public struct ActivityBasicInfo
	{
		// Token: 0x06027D83 RID: 163203 RVA: 0x000CFA20 File Offset: 0x000CDC20
		[Token(Token = "0x6027D83")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06027D84 RID: 163204 RVA: 0x000CFA38 File Offset: 0x000CDC38
		[Token(Token = "0x6027D84")]
		[Address(RVA = "0x22EF320", Offset = "0x22EDF20", VA = "0x1822EF320")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027D85 RID: 163205 RVA: 0x000CFA50 File Offset: 0x000CDC50
		[Token(Token = "0x6027D85")]
		[Address(RVA = "0x22EF260", Offset = "0x22EDE60", VA = "0x1822EF260")]
		public bool IsStageOpen(DateTime curTime)
		{
			return default(bool);
		}

		// Token: 0x06027D86 RID: 163206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027D86")]
		[Address(RVA = "0x22EF430", Offset = "0x22EE030", VA = "0x1822EF430")]
		public static ListDict<string, ActivityBasicInfo> LoadActivityStageInfos([Optional] Func<ActivityBasicInfo, bool> filter)
		{
			return null;
		}

		// Token: 0x06027D87 RID: 163207 RVA: 0x000CFA68 File Offset: 0x000CDC68
		[Token(Token = "0x6027D87")]
		[Address(RVA = "0x22EF030", Offset = "0x22EDC30", VA = "0x1822EF030")]
		public static ActivityBasicInfo CreateInst(ActivityTable.BasicData basicData)
		{
			return default(ActivityBasicInfo);
		}

		// Token: 0x04038795 RID: 231317
		[Token(Token = "0x4038795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ActivityBasicInfo EMPTY;

		// Token: 0x04038796 RID: 231318
		[Token(Token = "0x4038796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string activityId;

		// Token: 0x04038797 RID: 231319
		[Token(Token = "0x4038797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ActivityType activityType;

		// Token: 0x04038798 RID: 231320
		[Token(Token = "0x4038798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DateTime startTime;

		// Token: 0x04038799 RID: 231321
		[Token(Token = "0x4038799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DateTime endTime;

		// Token: 0x0403879A RID: 231322
		[Token(Token = "0x403879A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DateTime rewardEndTime;

		// Token: 0x0403879B RID: 231323
		[Token(Token = "0x403879B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool displayOnHome;

		// Token: 0x0403879C RID: 231324
		[Token(Token = "0x403879C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isMagnify;

		// Token: 0x0403879D RID: 231325
		[Token(Token = "0x403879D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string templateShopId;

		// Token: 0x0403879E RID: 231326
		[Token(Token = "0x403879E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x0403879F RID: 231327
		[Token(Token = "0x403879F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool hasStage;

		// Token: 0x040387A0 RID: 231328
		[Token(Token = "0x40387A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isReplicate;

		// Token: 0x040387A1 RID: 231329
		[Token(Token = "0x40387A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isPageEntry;

		// Token: 0x040387A2 RID: 231330
		[Token(Token = "0x40387A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string medalGroupId;

		// Token: 0x040387A3 RID: 231331
		[Token(Token = "0x40387A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<string> ungroupedMedalIds;

		// Token: 0x040387A4 RID: 231332
		[Token(Token = "0x40387A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ActivityDisplayType displayType;

		// Token: 0x040387A5 RID: 231333
		[Token(Token = "0x40387A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string templateTrapDomainId;

		// Token: 0x040387A6 RID: 231334
		[Token(Token = "0x40387A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<ActivityTable.PicGroup> picGroup;

		// Token: 0x040387A7 RID: 231335
		[Token(Token = "0x40387A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool usePicGroup;
	}
}
