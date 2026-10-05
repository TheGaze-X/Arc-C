using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006BB RID: 1723
	[Token(Token = "0x20006BB")]
	public class UpgradeSpecializationRequest
	{
		// Token: 0x06006304 RID: 25348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006304")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UpgradeSpecializationRequest()
		{
		}

		// Token: 0x04002EAA RID: 11946
		[Token(Token = "0x4002EAA")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x04002EAB RID: 11947
		[Token(Token = "0x4002EAB")]
		[FieldOffset(Offset = "0x14")]
		public int skillIndex;

		// Token: 0x04002EAC RID: 11948
		[Token(Token = "0x4002EAC")]
		[FieldOffset(Offset = "0x18")]
		public int targetLevel;
	}
}
