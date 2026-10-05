using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C20 RID: 3104
	[Token(Token = "0x2000C20")]
	[Serializable]
	public class ActArchiveBuffData
	{
		// Token: 0x060068FF RID: 26879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FF")]
		[Address(RVA = "0x1FF8310", Offset = "0x1FF6F10", VA = "0x181FF8310")]
		public ActArchiveBuffData()
		{
		}

		// Token: 0x04003F9B RID: 16283
		[Token(Token = "0x4003F9B")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveBuffItemData> buff;
	}
}
