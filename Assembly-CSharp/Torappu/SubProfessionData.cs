using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013B0 RID: 5040
	[Token(Token = "0x20013B0")]
	public class SubProfessionData
	{
		// Token: 0x0600739C RID: 29596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600739C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SubProfessionData()
		{
		}

		// Token: 0x04007004 RID: 28676
		[Token(Token = "0x4007004")]
		[FieldOffset(Offset = "0x10")]
		public string subProfessionId;

		// Token: 0x04007005 RID: 28677
		[Token(Token = "0x4007005")]
		[FieldOffset(Offset = "0x18")]
		public string subProfessionName;

		// Token: 0x04007006 RID: 28678
		[Token(Token = "0x4007006")]
		[FieldOffset(Offset = "0x20")]
		public int subProfessionCatagory;
	}
}
