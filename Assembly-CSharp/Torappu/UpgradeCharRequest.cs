using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008C8 RID: 2248
	[Token(Token = "0x20008C8")]
	public class UpgradeCharRequest
	{
		// Token: 0x0600657B RID: 25979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UpgradeCharRequest()
		{
		}

		// Token: 0x040032BC RID: 12988
		[Token(Token = "0x40032BC")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x040032BD RID: 12989
		[Token(Token = "0x40032BD")]
		[FieldOffset(Offset = "0x18")]
		public UpgradeCharRequest.ExpMat[] expMats;

		// Token: 0x020008C9 RID: 2249
		[Token(Token = "0x20008C9")]
		public struct ExpMat
		{
			// Token: 0x040032BE RID: 12990
			[Token(Token = "0x40032BE")]
			[FieldOffset(Offset = "0x0")]
			public string id;

			// Token: 0x040032BF RID: 12991
			[Token(Token = "0x40032BF")]
			[FieldOffset(Offset = "0x8")]
			public int count;
		}
	}
}
