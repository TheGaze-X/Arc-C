using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200114B RID: 4427
	[Token(Token = "0x200114B")]
	public class ReturnMissionItemData : IComparable
	{
		// Token: 0x06006F25 RID: 28453 RVA: 0x00032550 File Offset: 0x00030750
		[Token(Token = "0x6006F25")]
		[Address(RVA = "0x210FE30", Offset = "0x210EA30", VA = "0x18210FE30", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x06006F26 RID: 28454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F26")]
		[Address(RVA = "0x210FF00", Offset = "0x210EB00", VA = "0x18210FF00")]
		public ReturnMissionItemData()
		{
		}

		// Token: 0x04005EE0 RID: 24288
		[Token(Token = "0x4005EE0")]
		[FieldOffset(Offset = "0x10")]
		public string missionId;

		// Token: 0x04005EE1 RID: 24289
		[Token(Token = "0x4005EE1")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04005EE2 RID: 24290
		[Token(Token = "0x4005EE2")]
		[FieldOffset(Offset = "0x20")]
		public string uncompleteBgIcon;

		// Token: 0x04005EE3 RID: 24291
		[Token(Token = "0x4005EE3")]
		[FieldOffset(Offset = "0x28")]
		public string completeBgIcon;

		// Token: 0x04005EE4 RID: 24292
		[Token(Token = "0x4005EE4")]
		[FieldOffset(Offset = "0x30")]
		public string desc;

		// Token: 0x04005EE5 RID: 24293
		[Token(Token = "0x4005EE5")]
		[FieldOffset(Offset = "0x38")]
		public ReturnJumpType jumpType;

		// Token: 0x04005EE6 RID: 24294
		[Token(Token = "0x4005EE6")]
		[FieldOffset(Offset = "0x40")]
		public string jumpPlace;

		// Token: 0x04005EE7 RID: 24295
		[Token(Token = "0x4005EE7")]
		[FieldOffset(Offset = "0x48")]
		public List<ItemBundle> rewardList;
	}
}
