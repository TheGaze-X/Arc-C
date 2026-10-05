using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E3D RID: 3645
	[Token(Token = "0x2000E3D")]
	public class ActMultiV3IdentityData
	{
		// Token: 0x06006B0B RID: 27403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B0B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActMultiV3IdentityData()
		{
		}

		// Token: 0x04004BE6 RID: 19430
		[Token(Token = "0x4004BE6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04004BE7 RID: 19431
		[Token(Token = "0x4004BE7")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004BE8 RID: 19432
		[Token(Token = "0x4004BE8")]
		[FieldOffset(Offset = "0x20")]
		public string picId;

		// Token: 0x04004BE9 RID: 19433
		[Token(Token = "0x4004BE9")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3IdentityType type;

		// Token: 0x04004BEA RID: 19434
		[Token(Token = "0x4004BEA")]
		[FieldOffset(Offset = "0x2C")]
		public int maxNum;

		// Token: 0x04004BEB RID: 19435
		[Token(Token = "0x4004BEB")]
		[FieldOffset(Offset = "0x30")]
		public string color;
	}
}
