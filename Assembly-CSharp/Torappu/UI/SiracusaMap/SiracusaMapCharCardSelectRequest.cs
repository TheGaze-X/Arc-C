using System;
using Il2CppDummyDll;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F69 RID: 16233
	[Token(Token = "0x2003F69")]
	public class SiracusaMapCharCardSelectRequest
	{
		// Token: 0x0601930E RID: 103182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601930E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SiracusaMapCharCardSelectRequest()
		{
		}

		// Token: 0x0401F3C5 RID: 127941
		[Token(Token = "0x401F3C5")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0401F3C6 RID: 127942
		[Token(Token = "0x401F3C6")]
		[FieldOffset(Offset = "0x18")]
		public string cardId;
	}
}
