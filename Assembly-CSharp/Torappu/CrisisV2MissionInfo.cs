using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006E4 RID: 1764
	[Token(Token = "0x20006E4")]
	public class CrisisV2MissionInfo
	{
		// Token: 0x06006333 RID: 25395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006333")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2MissionInfo()
		{
		}

		// Token: 0x04002EF6 RID: 12022
		[Token(Token = "0x4002EF6")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04002EF7 RID: 12023
		[Token(Token = "0x4002EF7")]
		[FieldOffset(Offset = "0x18")]
		public CrisisV2MissionType type;
	}
}
