using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008CB RID: 2251
	[Token(Token = "0x20008CB")]
	public class UpgradeCharLevelMaxRequest
	{
		// Token: 0x0600657D RID: 25981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600657D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UpgradeCharLevelMaxRequest()
		{
		}

		// Token: 0x040032C0 RID: 12992
		[Token(Token = "0x40032C0")]
		[FieldOffset(Offset = "0x10")]
		public int charInsId;

		// Token: 0x040032C1 RID: 12993
		[Token(Token = "0x40032C1")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x040032C2 RID: 12994
		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0x20")]
		public int itemInsId;
	}
}
