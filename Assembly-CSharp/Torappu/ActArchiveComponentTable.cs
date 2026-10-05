using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020013A2 RID: 5026
	[Token(Token = "0x20013A2")]
	[Serializable]
	public class ActArchiveComponentTable
	{
		// Token: 0x0600737E RID: 29566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600737E")]
		[Address(RVA = "0x21FE890", Offset = "0x21FD490", VA = "0x1821FE890")]
		public ActArchiveComponentTable()
		{
		}

		// Token: 0x04006F89 RID: 28553
		[Token(Token = "0x4006F89")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, ActArchiveComponentData> components;
	}
}
