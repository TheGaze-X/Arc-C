using System;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040F0 RID: 16624
	[Token(Token = "0x20040F0")]
	public class SandboxV2WorkbenchItemModel : SandboxV2AdminMainListItemModel
	{
		// Token: 0x06019B66 RID: 105318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019B66")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public SandboxV2WorkbenchItemModel()
		{
		}

		// Token: 0x040202AB RID: 131755
		[Token(Token = "0x40202AB")]
		[FieldOffset(Offset = "0x30")]
		public string makeId;

		// Token: 0x040202AC RID: 131756
		[Token(Token = "0x40202AC")]
		[FieldOffset(Offset = "0x38")]
		public string groupId;

		// Token: 0x040202AD RID: 131757
		[Token(Token = "0x40202AD")]
		[FieldOffset(Offset = "0x40")]
		public int recipeLevel;

		// Token: 0x040202AE RID: 131758
		[Token(Token = "0x40202AE")]
		[FieldOffset(Offset = "0x48")]
		public string unlockDesc;

		// Token: 0x040202AF RID: 131759
		[Token(Token = "0x40202AF")]
		[FieldOffset(Offset = "0x50")]
		public int outputRatio;

		// Token: 0x040202B0 RID: 131760
		[Token(Token = "0x40202B0")]
		[FieldOffset(Offset = "0x54")]
		public bool isAlchemy;

		// Token: 0x040202B1 RID: 131761
		[Token(Token = "0x40202B1")]
		[FieldOffset(Offset = "0x58")]
		public int tagSortId;

		// Token: 0x040202B2 RID: 131762
		[Token(Token = "0x40202B2")]
		[FieldOffset(Offset = "0x5C")]
		public bool isLocked;
	}
}
