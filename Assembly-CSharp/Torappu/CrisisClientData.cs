using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FAB RID: 4011
	[Token(Token = "0x2000FAB")]
	public class CrisisClientData
	{
		// Token: 0x06006CF4 RID: 27892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006CF4")]
		[Address(RVA = "0x21006D0", Offset = "0x20FF2D0", VA = "0x1821006D0")]
		public CrisisClientData()
		{
		}

		// Token: 0x0400551D RID: 21789
		[Token(Token = "0x400551D")]
		[FieldOffset(Offset = "0x10")]
		public List<CrisisClientData.SeasonInfo> seasonInfo;

		// Token: 0x0400551E RID: 21790
		[Token(Token = "0x400551E")]
		[FieldOffset(Offset = "0x18")]
		public string meta;

		// Token: 0x0400551F RID: 21791
		[Token(Token = "0x400551F")]
		[FieldOffset(Offset = "0x20")]
		public int unlockCoinLv3;

		// Token: 0x04005520 RID: 21792
		[Token(Token = "0x4005520")]
		[FieldOffset(Offset = "0x24")]
		public int hardPointPerm;

		// Token: 0x04005521 RID: 21793
		[Token(Token = "0x4005521")]
		[FieldOffset(Offset = "0x28")]
		public int hardPointTemp;

		// Token: 0x04005522 RID: 21794
		[Token(Token = "0x4005522")]
		[FieldOffset(Offset = "0x2C")]
		public int voiceGrade;

		// Token: 0x04005523 RID: 21795
		[Token(Token = "0x4005523")]
		[FieldOffset(Offset = "0x30")]
		public string crisisRuneCoinUnlockItemTitle;

		// Token: 0x04005524 RID: 21796
		[Token(Token = "0x4005524")]
		[FieldOffset(Offset = "0x38")]
		public string crisisRuneCoinUnlockItemDesc;

		// Token: 0x02000FAC RID: 4012
		[Token(Token = "0x2000FAC")]
		public class SeasonInfo
		{
			// Token: 0x06006CF5 RID: 27893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CF5")]
			[Address(RVA = "0x2114DC0", Offset = "0x21139C0", VA = "0x182114DC0")]
			public SeasonInfo()
			{
			}

			// Token: 0x04005525 RID: 21797
			[Token(Token = "0x4005525")]
			[FieldOffset(Offset = "0x10")]
			public string seasonId;

			// Token: 0x04005526 RID: 21798
			[Token(Token = "0x4005526")]
			[FieldOffset(Offset = "0x18")]
			public long startTs;

			// Token: 0x04005527 RID: 21799
			[Token(Token = "0x4005527")]
			[FieldOffset(Offset = "0x20")]
			public long endTs;

			// Token: 0x04005528 RID: 21800
			[Token(Token = "0x4005528")]
			[FieldOffset(Offset = "0x28")]
			public string name;

			// Token: 0x04005529 RID: 21801
			[Token(Token = "0x4005529")]
			[FieldOffset(Offset = "0x30")]
			public ItemBundle crisisRuneCoinUnlockItem;

			// Token: 0x0400552A RID: 21802
			[Token(Token = "0x400552A")]
			[FieldOffset(Offset = "0x38")]
			public string permBgm;

			// Token: 0x0400552B RID: 21803
			[Token(Token = "0x400552B")]
			[FieldOffset(Offset = "0x40")]
			public string medalGroupId;

			// Token: 0x0400552C RID: 21804
			[Token(Token = "0x400552C")]
			[FieldOffset(Offset = "0x48")]
			public int bgmHardPoint;

			// Token: 0x0400552D RID: 21805
			[Token(Token = "0x400552D")]
			[FieldOffset(Offset = "0x50")]
			public string permBgmHard;
		}

		// Token: 0x02000FAD RID: 4013
		[Token(Token = "0x2000FAD")]
		public class Meta
		{
			// Token: 0x06006CF6 RID: 27894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006CF6")]
			[Address(RVA = "0x2107F80", Offset = "0x2106B80", VA = "0x182107F80")]
			public Meta()
			{
			}

			// Token: 0x0400552E RID: 21806
			[Token(Token = "0x400552E")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, string> stages;

			// Token: 0x0400552F RID: 21807
			[Token(Token = "0x400552F")]
			[FieldOffset(Offset = "0x18")]
			public List<string> icons;
		}
	}
}
