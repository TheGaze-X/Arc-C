using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001174 RID: 4468
	[Token(Token = "0x2001174")]
	public class RoguelikeItemData
	{
		// Token: 0x06006F62 RID: 28514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F62")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeItemData()
		{
		}

		// Token: 0x04005FBE RID: 24510
		[Token(Token = "0x4005FBE")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FBF RID: 24511
		[Token(Token = "0x4005FBF")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04005FC0 RID: 24512
		[Token(Token = "0x4005FC0")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04005FC1 RID: 24513
		[Token(Token = "0x4005FC1")]
		[FieldOffset(Offset = "0x28")]
		public string usage;

		// Token: 0x04005FC2 RID: 24514
		[Token(Token = "0x4005FC2")]
		[FieldOffset(Offset = "0x30")]
		public string obtainApproach;

		// Token: 0x04005FC3 RID: 24515
		[Token(Token = "0x4005FC3")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x04005FC4 RID: 24516
		[Token(Token = "0x4005FC4")]
		[FieldOffset(Offset = "0x40")]
		public RoguelikeItemType type;

		// Token: 0x04005FC5 RID: 24517
		[Token(Token = "0x4005FC5")]
		[FieldOffset(Offset = "0x44")]
		public RoguelikeItemRarity rarity;

		// Token: 0x04005FC6 RID: 24518
		[Token(Token = "0x4005FC6")]
		[FieldOffset(Offset = "0x48")]
		public int value;

		// Token: 0x04005FC7 RID: 24519
		[Token(Token = "0x4005FC7")]
		[FieldOffset(Offset = "0x4C")]
		public int sortId;

		// Token: 0x04005FC8 RID: 24520
		[Token(Token = "0x4005FC8")]
		[FieldOffset(Offset = "0x50")]
		public string unlockCond;

		// Token: 0x04005FC9 RID: 24521
		[Token(Token = "0x4005FC9")]
		[FieldOffset(Offset = "0x58")]
		public string unlockCondDesc;

		// Token: 0x04005FCA RID: 24522
		[Token(Token = "0x4005FCA")]
		[FieldOffset(Offset = "0x60")]
		public List<string> unlockCondParams;

		// Token: 0x04005FCB RID: 24523
		[Token(Token = "0x4005FCB")]
		[FieldOffset(Offset = "0x68")]
		public RelicStableUnlockParam stableUnlockCond;
	}
}
