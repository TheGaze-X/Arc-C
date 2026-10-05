using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006B9 RID: 1721
	[Token(Token = "0x20006B9")]
	public class UpgradeSkillRequest
	{
		// Token: 0x06006302 RID: 25346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006302")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UpgradeSkillRequest()
		{
		}

		// Token: 0x04002EA8 RID: 11944
		[Token(Token = "0x4002EA8")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002EA9 RID: 11945
		[Token(Token = "0x4002EA9")]
		[FieldOffset(Offset = "0x14")]
		public int targetLevel;
	}
}
