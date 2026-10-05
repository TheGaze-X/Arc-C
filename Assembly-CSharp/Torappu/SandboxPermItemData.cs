using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012FD RID: 4861
	[Token(Token = "0x20012FD")]
	public class SandboxPermItemData
	{
		// Token: 0x06007276 RID: 29302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007276")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SandboxPermItemData()
		{
		}

		// Token: 0x04006BB0 RID: 27568
		[Token(Token = "0x4006BB0")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x04006BB1 RID: 27569
		[Token(Token = "0x4006BB1")]
		[FieldOffset(Offset = "0x18")]
		public SandboxPermItemType itemType;

		// Token: 0x04006BB2 RID: 27570
		[Token(Token = "0x4006BB2")]
		[FieldOffset(Offset = "0x20")]
		public string itemName;

		// Token: 0x04006BB3 RID: 27571
		[Token(Token = "0x4006BB3")]
		[FieldOffset(Offset = "0x28")]
		public string itemUsage;

		// Token: 0x04006BB4 RID: 27572
		[Token(Token = "0x4006BB4")]
		[FieldOffset(Offset = "0x30")]
		public string itemDesc;

		// Token: 0x04006BB5 RID: 27573
		[Token(Token = "0x4006BB5")]
		[FieldOffset(Offset = "0x38")]
		public int itemRarity;

		// Token: 0x04006BB6 RID: 27574
		[Token(Token = "0x4006BB6")]
		[FieldOffset(Offset = "0x3C")]
		public int sortId;

		// Token: 0x04006BB7 RID: 27575
		[Token(Token = "0x4006BB7")]
		[FieldOffset(Offset = "0x40")]
		public string obtainApproach;
	}
}
