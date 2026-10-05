using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C26 RID: 3110
	[Token(Token = "0x2000C26")]
	public class ActArchiveChaosItemData
	{
		// Token: 0x06006905 RID: 26885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006905")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActArchiveChaosItemData()
		{
		}

		// Token: 0x04003FAC RID: 16300
		[Token(Token = "0x4003FAC")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04003FAD RID: 16301
		[Token(Token = "0x4003FAD")]
		[FieldOffset(Offset = "0x18")]
		public bool isHidden;

		// Token: 0x04003FAE RID: 16302
		[Token(Token = "0x4003FAE")]
		[FieldOffset(Offset = "0x20")]
		public string enrollId;

		// Token: 0x04003FAF RID: 16303
		[Token(Token = "0x4003FAF")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;
	}
}
