using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006A9 RID: 1705
	[Token(Token = "0x20006A9")]
	public class BuildingSaveDormLockRequest : BuildingRequest
	{
		// Token: 0x060062E5 RID: 25317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingSaveDormLockRequest()
		{
		}

		// Token: 0x04002E92 RID: 11922
		[Token(Token = "0x4002E92")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int[]> lockPos;
	}
}
