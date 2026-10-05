using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001291 RID: 4753
	[Token(Token = "0x2001291")]
	public class SandboxV2NodeUpgradeData
	{
		// Token: 0x06007209 RID: 29193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007209")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxV2NodeUpgradeData()
		{
		}

		// Token: 0x040068BE RID: 26814
		[Token(Token = "0x40068BE")]
		[FieldOffset(Offset = "0x10")]
		public string nodeUpgradeId;

		// Token: 0x040068BF RID: 26815
		[Token(Token = "0x40068BF")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x040068C0 RID: 26816
		[Token(Token = "0x40068C0")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x040068C1 RID: 26817
		[Token(Token = "0x40068C1")]
		[FieldOffset(Offset = "0x28")]
		public string upgradeDesc;

		// Token: 0x040068C2 RID: 26818
		[Token(Token = "0x40068C2")]
		[FieldOffset(Offset = "0x30")]
		public string upgradeTips;

		// Token: 0x040068C3 RID: 26819
		[Token(Token = "0x40068C3")]
		[FieldOffset(Offset = "0x38")]
		public SandboxPermItemType itemType;

		// Token: 0x040068C4 RID: 26820
		[Token(Token = "0x40068C4")]
		[FieldOffset(Offset = "0x3C")]
		public SandboxV2ItemTrapTag itemTag;

		// Token: 0x040068C5 RID: 26821
		[Token(Token = "0x40068C5")]
		[FieldOffset(Offset = "0x40")]
		public int itemCnt;

		// Token: 0x040068C6 RID: 26822
		[Token(Token = "0x40068C6")]
		[FieldOffset(Offset = "0x44")]
		public int itemRarity;
	}
}
