using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C4B RID: 3147
	[Token(Token = "0x2000C4B")]
	public class ActArchiveTotemData
	{
		// Token: 0x0600692F RID: 26927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600692F")]
		[Address(RVA = "0x1FF9070", Offset = "0x1FF7C70", VA = "0x181FF9070")]
		public ActArchiveTotemData()
		{
		}

		// Token: 0x04004027 RID: 16423
		[Token(Token = "0x4004027")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveTotemItemData> totem;
	}
}
