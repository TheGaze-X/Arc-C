using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E51 RID: 20049
	[Token(Token = "0x2004E51")]
	public class Act38SideServerPuzzleInfo
	{
		// Token: 0x0601DED0 RID: 122576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DED0")]
		[Address(RVA = "0x1799800", Offset = "0x1798400", VA = "0x181799800")]
		public Act38SideServerPuzzleInfo()
		{
		}

		// Token: 0x04027B8C RID: 162700
		[Token(Token = "0x4027B8C")]
		[FieldOffset(Offset = "0x10")]
		public long startTime;

		// Token: 0x04027B8D RID: 162701
		[Token(Token = "0x4027B8D")]
		[FieldOffset(Offset = "0x18")]
		public List<string> plateGroupIdList;

		// Token: 0x04027B8E RID: 162702
		[Token(Token = "0x4027B8E")]
		[FieldOffset(Offset = "0x20")]
		public string solvePlateId;

		// Token: 0x04027B8F RID: 162703
		[Token(Token = "0x4027B8F")]
		[FieldOffset(Offset = "0x28")]
		public int slotNum;

		// Token: 0x04027B90 RID: 162704
		[Token(Token = "0x4027B90")]
		[FieldOffset(Offset = "0x2C")]
		public int hintTimes;

		// Token: 0x04027B91 RID: 162705
		[Token(Token = "0x4027B91")]
		[FieldOffset(Offset = "0x30")]
		public List<FireworkData.PlateSlotData> hintPlateList;

		// Token: 0x04027B92 RID: 162706
		[Token(Token = "0x4027B92")]
		[FieldOffset(Offset = "0x38")]
		public ItemBundle rewardItem;
	}
}
