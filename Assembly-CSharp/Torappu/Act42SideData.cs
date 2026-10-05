using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000D47 RID: 3399
	[Token(Token = "0x2000D47")]
	public class Act42SideData
	{
		// Token: 0x06006A1B RID: 27163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006A1B")]
		[Address(RVA = "0x1FF6260", Offset = "0x1FF4E60", VA = "0x181FF6260")]
		public Act42SideData()
		{
		}

		// Token: 0x040045E1 RID: 17889
		[Token(Token = "0x40045E1")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act42SideData.Act42SideTrustorData> trustorData;

		// Token: 0x040045E2 RID: 17890
		[Token(Token = "0x40045E2")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act42SideData.Act42SideTaskData> taskData;

		// Token: 0x040045E3 RID: 17891
		[Token(Token = "0x40045E3")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act42SideData.Act42SideGunData> gunData;

		// Token: 0x040045E4 RID: 17892
		[Token(Token = "0x40045E4")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<string, Act42SideData.Act42SideFileData> fileData;

		// Token: 0x040045E5 RID: 17893
		[Token(Token = "0x40045E5")]
		[FieldOffset(Offset = "0x30")]
		public List<Act42SideData.Act42SideDailyRewardData> dailyRewardList;

		// Token: 0x040045E6 RID: 17894
		[Token(Token = "0x40045E6")]
		[FieldOffset(Offset = "0x38")]
		public Act42SideData.Act42SideConstData constData;

		// Token: 0x040045E7 RID: 17895
		[Token(Token = "0x40045E7")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act42SideData.Act42SideZoneAdditionData> zoneAdditionDataMap;

		// Token: 0x02000D48 RID: 3400
		[Token(Token = "0x2000D48")]
		public class Act42SideTrustorData
		{
			// Token: 0x06006A1C RID: 27164 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A1C")]
			[Address(RVA = "0x1FF6540", Offset = "0x1FF5140", VA = "0x181FF6540")]
			public Act42SideTrustorData()
			{
			}

			// Token: 0x040045E8 RID: 17896
			[Token(Token = "0x40045E8")]
			[FieldOffset(Offset = "0x10")]
			public string trustorId;

			// Token: 0x040045E9 RID: 17897
			[Token(Token = "0x40045E9")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x040045EA RID: 17898
			[Token(Token = "0x40045EA")]
			[FieldOffset(Offset = "0x20")]
			public string trustorName;

			// Token: 0x040045EB RID: 17899
			[Token(Token = "0x40045EB")]
			[FieldOffset(Offset = "0x28")]
			public string trustorIconSmall;

			// Token: 0x040045EC RID: 17900
			[Token(Token = "0x40045EC")]
			[FieldOffset(Offset = "0x30")]
			public string trustorIconLarge;

			// Token: 0x040045ED RID: 17901
			[Token(Token = "0x40045ED")]
			[FieldOffset(Offset = "0x38")]
			public string gunId;

			// Token: 0x040045EE RID: 17902
			[Token(Token = "0x40045EE")]
			[FieldOffset(Offset = "0x40")]
			public List<string> taskList;
		}

		// Token: 0x02000D49 RID: 3401
		[Token(Token = "0x2000D49")]
		public class Act42SideGunData
		{
			// Token: 0x06006A1D RID: 27165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A1D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42SideGunData()
			{
			}

			// Token: 0x040045EF RID: 17903
			[Token(Token = "0x40045EF")]
			[FieldOffset(Offset = "0x10")]
			public string gunId;

			// Token: 0x040045F0 RID: 17904
			[Token(Token = "0x40045F0")]
			[FieldOffset(Offset = "0x18")]
			public string gunName;

			// Token: 0x040045F1 RID: 17905
			[Token(Token = "0x40045F1")]
			[FieldOffset(Offset = "0x20")]
			public string trustorName;

			// Token: 0x040045F2 RID: 17906
			[Token(Token = "0x40045F2")]
			[FieldOffset(Offset = "0x28")]
			public string gunContent;

			// Token: 0x040045F3 RID: 17907
			[Token(Token = "0x40045F3")]
			[FieldOffset(Offset = "0x30")]
			public string gunSmallIcon;

			// Token: 0x040045F4 RID: 17908
			[Token(Token = "0x40045F4")]
			[FieldOffset(Offset = "0x38")]
			public string gunWhiteIcon;

			// Token: 0x040045F5 RID: 17909
			[Token(Token = "0x40045F5")]
			[FieldOffset(Offset = "0x40")]
			public string gunColorIcon;
		}

		// Token: 0x02000D4A RID: 3402
		[Token(Token = "0x2000D4A")]
		public class Act42SideTaskData
		{
			// Token: 0x06006A1E RID: 27166 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A1E")]
			[Address(RVA = "0x1FF64B0", Offset = "0x1FF50B0", VA = "0x181FF64B0")]
			public Act42SideTaskData()
			{
			}

			// Token: 0x040045F6 RID: 17910
			[Token(Token = "0x40045F6")]
			[FieldOffset(Offset = "0x10")]
			public string taskId;

			// Token: 0x040045F7 RID: 17911
			[Token(Token = "0x40045F7")]
			[FieldOffset(Offset = "0x18")]
			public string preposedTaskId;

			// Token: 0x040045F8 RID: 17912
			[Token(Token = "0x40045F8")]
			[FieldOffset(Offset = "0x20")]
			public string trustorId;

			// Token: 0x040045F9 RID: 17913
			[Token(Token = "0x40045F9")]
			[FieldOffset(Offset = "0x28")]
			public string trustorName;

			// Token: 0x040045FA RID: 17914
			[Token(Token = "0x40045FA")]
			[FieldOffset(Offset = "0x30")]
			public int sortId;

			// Token: 0x040045FB RID: 17915
			[Token(Token = "0x40045FB")]
			[FieldOffset(Offset = "0x38")]
			public string taskName;

			// Token: 0x040045FC RID: 17916
			[Token(Token = "0x40045FC")]
			[FieldOffset(Offset = "0x40")]
			public string taskContent;

			// Token: 0x040045FD RID: 17917
			[Token(Token = "0x40045FD")]
			[FieldOffset(Offset = "0x48")]
			public string afterTaskContent;

			// Token: 0x040045FE RID: 17918
			[Token(Token = "0x40045FE")]
			[FieldOffset(Offset = "0x50")]
			public string beforeTaskItemIcon;

			// Token: 0x040045FF RID: 17919
			[Token(Token = "0x40045FF")]
			[FieldOffset(Offset = "0x58")]
			public string afterTaskItemIcon;

			// Token: 0x04004600 RID: 17920
			[Token(Token = "0x4004600")]
			[FieldOffset(Offset = "0x60")]
			public string stageId;

			// Token: 0x04004601 RID: 17921
			[Token(Token = "0x4004601")]
			[FieldOffset(Offset = "0x68")]
			public string taskDesc;

			// Token: 0x04004602 RID: 17922
			[Token(Token = "0x4004602")]
			[FieldOffset(Offset = "0x70")]
			public List<ItemBundle> rewards;
		}

		// Token: 0x02000D4B RID: 3403
		[Token(Token = "0x2000D4B")]
		public class Act42SideFileData
		{
			// Token: 0x06006A1F RID: 27167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A1F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42SideFileData()
			{
			}

			// Token: 0x04004603 RID: 17923
			[Token(Token = "0x4004603")]
			[FieldOffset(Offset = "0x10")]
			public string contentId;

			// Token: 0x04004604 RID: 17924
			[Token(Token = "0x4004604")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;
		}

		// Token: 0x02000D4C RID: 3404
		[Token(Token = "0x2000D4C")]
		public class Act42SideDailyRewardData
		{
			// Token: 0x06006A20 RID: 27168 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A20")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42SideDailyRewardData()
			{
			}

			// Token: 0x04004605 RID: 17925
			[Token(Token = "0x4004605")]
			[FieldOffset(Offset = "0x10")]
			public int completedCnt;

			// Token: 0x04004606 RID: 17926
			[Token(Token = "0x4004606")]
			[FieldOffset(Offset = "0x18")]
			public ItemBundle reward;
		}

		// Token: 0x02000D4D RID: 3405
		[Token(Token = "0x2000D4D")]
		public class Act42SideZoneAdditionData
		{
			// Token: 0x06006A21 RID: 27169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A21")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42SideZoneAdditionData()
			{
			}

			// Token: 0x04004607 RID: 17927
			[Token(Token = "0x4004607")]
			[FieldOffset(Offset = "0x10")]
			public string zoneId;

			// Token: 0x04004608 RID: 17928
			[Token(Token = "0x4004608")]
			[FieldOffset(Offset = "0x18")]
			public string unlockText;
		}

		// Token: 0x02000D4E RID: 3406
		[Token(Token = "0x2000D4E")]
		public class Act42SideConstData
		{
			// Token: 0x06006A22 RID: 27170 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006A22")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Act42SideConstData()
			{
			}

			// Token: 0x04004609 RID: 17929
			[Token(Token = "0x4004609")]
			[FieldOffset(Offset = "0x10")]
			public string coffeeName;

			// Token: 0x0400460A RID: 17930
			[Token(Token = "0x400460A")]
			[FieldOffset(Offset = "0x18")]
			public int dailyCoffee;

			// Token: 0x0400460B RID: 17931
			[Token(Token = "0x400460B")]
			[FieldOffset(Offset = "0x1C")]
			public int coffeeLimit;

			// Token: 0x0400460C RID: 17932
			[Token(Token = "0x400460C")]
			[FieldOffset(Offset = "0x20")]
			public string coffeeContent;

			// Token: 0x0400460D RID: 17933
			[Token(Token = "0x400460D")]
			[FieldOffset(Offset = "0x28")]
			public string minGunTaskDisplay;

			// Token: 0x0400460E RID: 17934
			[Token(Token = "0x400460E")]
			[FieldOffset(Offset = "0x30")]
			public string unlockStageId;

			// Token: 0x0400460F RID: 17935
			[Token(Token = "0x400460F")]
			[FieldOffset(Offset = "0x38")]
			public string toastGunTaskCompleted;

			// Token: 0x04004610 RID: 17936
			[Token(Token = "0x4004610")]
			[FieldOffset(Offset = "0x40")]
			public string toastGunTaskLocked;

			// Token: 0x04004611 RID: 17937
			[Token(Token = "0x4004611")]
			[FieldOffset(Offset = "0x48")]
			public string toastStageBlock;

			// Token: 0x04004612 RID: 17938
			[Token(Token = "0x4004612")]
			[FieldOffset(Offset = "0x50")]
			public string toastEntryLocked;

			// Token: 0x04004613 RID: 17939
			[Token(Token = "0x4004613")]
			[FieldOffset(Offset = "0x58")]
			public string toastFileLocked;

			// Token: 0x04004614 RID: 17940
			[Token(Token = "0x4004614")]
			[FieldOffset(Offset = "0x60")]
			public string toastGunLocked;

			// Token: 0x04004615 RID: 17941
			[Token(Token = "0x4004615")]
			[FieldOffset(Offset = "0x68")]
			public string toastNoCoffee;

			// Token: 0x04004616 RID: 17942
			[Token(Token = "0x4004616")]
			[FieldOffset(Offset = "0x70")]
			public string toastOuterUnlock;
		}
	}
}
