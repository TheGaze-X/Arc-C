using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C1E RID: 3102
	[Token(Token = "0x2000C1E")]
	[Serializable]
	public class ActArchiveAvgData
	{
		// Token: 0x060068FD RID: 26877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60068FD")]
		[Address(RVA = "0x1FF8280", Offset = "0x1FF6E80", VA = "0x181FF8280")]
		public ActArchiveAvgData()
		{
		}

		// Token: 0x04003F98 RID: 16280
		[Token(Token = "0x4003F98")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveAvgItemData> avgs;
	}
}
