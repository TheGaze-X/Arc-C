using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F95 RID: 3989
	[Token(Token = "0x2000F95")]
	public class ClimbTowerSingleTowerData
	{
		// Token: 0x06006CD5 RID: 27861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CD5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSingleTowerData()
		{
		}

		// Token: 0x040054B5 RID: 21685
		[Token(Token = "0x40054B5")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040054B6 RID: 21686
		[Token(Token = "0x40054B6")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x040054B7 RID: 21687
		[Token(Token = "0x40054B7")]
		[FieldOffset(Offset = "0x1C")]
		public int stageNum;

		// Token: 0x040054B8 RID: 21688
		[Token(Token = "0x40054B8")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x040054B9 RID: 21689
		[Token(Token = "0x40054B9")]
		[FieldOffset(Offset = "0x28")]
		public string subName;

		// Token: 0x040054BA RID: 21690
		[Token(Token = "0x40054BA")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x040054BB RID: 21691
		[Token(Token = "0x40054BB")]
		[FieldOffset(Offset = "0x38")]
		public ClimbTowerTowerType towerType;

		// Token: 0x040054BC RID: 21692
		[Token(Token = "0x40054BC")]
		[FieldOffset(Offset = "0x40")]
		public string[] levels;

		// Token: 0x040054BD RID: 21693
		[Token(Token = "0x40054BD")]
		[FieldOffset(Offset = "0x48")]
		public string[] hardLevels;

		// Token: 0x040054BE RID: 21694
		[Token(Token = "0x40054BE")]
		[FieldOffset(Offset = "0x50")]
		public List<ClimbTowerSingleTowerData.ClimbTowerTaskRewardData> taskInfo;

		// Token: 0x040054BF RID: 21695
		[Token(Token = "0x40054BF")]
		[FieldOffset(Offset = "0x58")]
		public string preTowerId;

		// Token: 0x040054C0 RID: 21696
		[Token(Token = "0x40054C0")]
		[FieldOffset(Offset = "0x60")]
		public string medalId;

		// Token: 0x040054C1 RID: 21697
		[Token(Token = "0x40054C1")]
		[FieldOffset(Offset = "0x68")]
		public string hiddenMedalId;

		// Token: 0x040054C2 RID: 21698
		[Token(Token = "0x40054C2")]
		[FieldOffset(Offset = "0x70")]
		public string hardModeMedalId;

		// Token: 0x040054C3 RID: 21699
		[Token(Token = "0x40054C3")]
		[FieldOffset(Offset = "0x78")]
		public string bossId;

		// Token: 0x040054C4 RID: 21700
		[Token(Token = "0x40054C4")]
		[FieldOffset(Offset = "0x80")]
		public string cardId;

		// Token: 0x040054C5 RID: 21701
		[Token(Token = "0x40054C5")]
		[FieldOffset(Offset = "0x88")]
		public List<string> curseCardIds;

		// Token: 0x040054C6 RID: 21702
		[Token(Token = "0x40054C6")]
		[FieldOffset(Offset = "0x90")]
		public string dangerDesc;

		// Token: 0x040054C7 RID: 21703
		[Token(Token = "0x40054C7")]
		[FieldOffset(Offset = "0x98")]
		public string hardModeDesc;

		// Token: 0x02000F96 RID: 3990
		[Token(Token = "0x2000F96")]
		public class ClimbTowerTaskRewardData
		{
			// Token: 0x06006CD6 RID: 27862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CD6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClimbTowerTaskRewardData()
			{
			}

			// Token: 0x040054C8 RID: 21704
			[Token(Token = "0x40054C8")]
			[FieldOffset(Offset = "0x10")]
			public int levelNum;

			// Token: 0x040054C9 RID: 21705
			[Token(Token = "0x40054C9")]
			[FieldOffset(Offset = "0x18")]
			public List<ItemBundle> rewards;
		}
	}
}
